using Business.Abstracts;
using Business.DTO.Requests;
using Business.DTO.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest model)
        {
            CreatedBrandResponse response = _brandService.Add(model);
            return Ok(response); //Created("",response); --> 201 değeri döner kayıt başarılı ve eklendi bilgisini verir.
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_brandService.GetList());
        }
    }
}
