using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaketPristupniDaniController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public PaketPristupniDaniController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpPost]
        public Model.PaketPristupniDani Insert(Model.Requests.PaketPristupniDaniInsertRequest request)
        {
            var paketPristupniDani = _mapper.Map<Database.PaketPristupniDani>(request);


            _context.PaketPristupniDani.Add(paketPristupniDani);
            _context.SaveChanges();
            return _mapper.Map<Model.PaketPristupniDani>(paketPristupniDani);
        }
    }
}