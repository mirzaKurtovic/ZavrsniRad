using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public ActionResult<List<Model.PaketPristupniDani>> Get([FromQuery]Model.Requests.PaketPristupniDaniInsertRequest searchRequest)
        {
            var list = _context.PaketPristupniDani.Where(p=>p.PaketId==searchRequest.PaketId)
                .Include(p=>p.PristupniDani)
                .ToList();

            return _mapper.Map<List<Model.PaketPristupniDani>>(list);
        }
        [HttpDelete("{id}")]
        public bool Update(int id)
        {
            var p = _context.PaketPristupniDani.Where(pp => pp.Id == id).FirstOrDefault();
            if (p == null) return false;
            _context.Remove(p);
            _context.SaveChanges();
            return true;
        }
    }
}