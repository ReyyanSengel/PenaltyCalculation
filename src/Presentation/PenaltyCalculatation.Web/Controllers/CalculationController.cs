using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PenaltyCalculation.Application.Interfaces.IServices;
using PenaltyCalculation.Application.ViewModels;

namespace PenaltyCalculatation.Web.Controllers
{
    public class CalculationController : Controller
    {
        private readonly IRegistrationService _service;
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CalculationController(IRegistrationService service, ICountryService countryService, IMapper mapper)
        {
            _service = service;
            _countryService = countryService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> Calculate()
        {
            await FillSelectListemItem();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CalculateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.Calculation(model);
                return RedirectToAction(nameof(Result), result);
            }
           
            return View();

        }

        [HttpGet]
        public  IActionResult Result(RegistrationViewModel model)
        {
            return  View(model);
        }




        private async Task FillSelectListemItem()
        {
            var countries = _countryService.GetAll();
            var countriesDto = _mapper.Map<List<CountryViewModel>>(countries);
            ViewBag.Countries = new SelectList(countriesDto, "Id", "Name");

        }
    }
}
