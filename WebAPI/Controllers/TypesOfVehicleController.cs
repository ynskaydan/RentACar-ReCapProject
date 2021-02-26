using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesOfVehicleController : Controller
    {
        ITypeOfVehicleService _typeOfVehicleService;

        public TypesOfVehicleController(ITypeOfVehicleService typeOfVehicleService)
        {
            _typeOfVehicleService = typeOfVehicleService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _typeOfVehicleService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("add")]
        public IActionResult Add(TypeOfVehicle typeOfVehicle)
        {
            var result = _typeOfVehicleService.Add(typeOfVehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(TypeOfVehicle typeOfVehicle)
        {
            var result = _typeOfVehicleService.Update(typeOfVehicle);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int codid)
        {
            TypeOfVehicle deletedTypeOfVehicle = _typeOfVehicleService.GetById(codid).Data;
            var result = _typeOfVehicleService.Delete(deletedTypeOfVehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
