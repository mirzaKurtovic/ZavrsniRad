using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PristupDanimaController : ControllerBase
    {


        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public PristupDanimaController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }


        // GET: api/PristupDanima
        [HttpGet]
        public ActionResult<List<Model.PristupDanima>> Get([FromQuery]PristupDanimaSearchRequest request)
        {
            //treba implementirat search ako ga ikako bude...
            var PristupDanima = _context.PristupDanima.ToList();

           
            
            return _mapper.Map<List<Wellness.Model.PristupDanima>>(PristupDanima);
        }

        
    }
}
