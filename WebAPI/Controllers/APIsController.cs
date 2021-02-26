using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIsController<T> : ControllerBase
    {
        IEntityService<T> _entityService;

        public APIsController(IEntityService<T> entityService)
        {
            _entityService = entityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _entityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("add")]
        public IActionResult Add(T entity)
        {
            var result = _entityService.Add(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(T entity)
        {
            var result = _entityService.Update(entity);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            T deletedEntity = _entityService.GetById(id).Data;
            var result = _entityService.Delete(deletedEntity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

}


