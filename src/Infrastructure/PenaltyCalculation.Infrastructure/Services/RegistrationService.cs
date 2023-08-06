using AutoMapper;
using Microsoft.EntityFrameworkCore.Internal;
using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.Interfaces.IServices;
using PenaltyCalculation.Application.Interfaces.IUnitOfWork;
using PenaltyCalculation.Application.ViewModels;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Infrastructure.Services
{
    public class RegistrationService : GenericService<Registration>, IRegistrationService
    {
        private readonly IRegistrationRepository _registrationRepository;
        private readonly INationalHolidayRepository _nationalHolidayRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;



        public RegistrationService(IGenericRepository<Registration> repository, IUnitOfWork unitOfWork, IRegistrationRepository registrationRepository, INationalHolidayRepository nationalHolidayRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _registrationRepository = registrationRepository;
            _unitOfWork = unitOfWork;
            _nationalHolidayRepository = nationalHolidayRepository;
            _mapper = mapper;
        }

        public async Task<CalculateViewModel> Calculation(CalculateViewModel model)
        {
            //RegistrationViewModel registration = new RegistrationViewModel();
            int penalty = 0;
            int businessDay = 0;
            var holiday = _nationalHolidayRepository.Where(x => x.CountryId == model.CountryId).Select(x => x.Date).ToList();
            for (var date = model.CheckedOut; date <= model.Returned; date= date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday && holiday.Any(x => x.Date.Day != date.Day) && holiday.Any(x=>x.Date.Month!=date.Month))
                {
                    businessDay++;
                }
                
            }

            if (businessDay > 3)
            {
                penalty = businessDay * 5;

                model.Price = penalty;
                model.QueryPenalty = true;
                await _registrationRepository.AddAsync(_mapper.Map<Registration>(model));
                await _unitOfWork.CommitAsync();
                return model;
            }
            else
            {
                model.QueryPenalty = false;
                await _registrationRepository.AddAsync(_mapper.Map<Registration>(model));
                await _unitOfWork.CommitAsync();
                return model;
            }

           
           
        }

    }

}












