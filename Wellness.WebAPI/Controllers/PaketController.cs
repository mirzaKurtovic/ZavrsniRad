using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaketController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public PaketController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.Paket>> Get([FromQuery]Model.Requests.PaketSearchRequest search)
        {
            var list = _context.Paket.AsQueryable();

            if(search!=null)
            {
                if(!string.IsNullOrEmpty(search.NazivPaketa))
                {
                    list = list.Where(p => p.Naziv.StartsWith(search.NazivPaketa));
                }
                if (search.CijenaVecaOd != null)
                {
                    list = list.Where(p => p.Cijena>=search.CijenaVecaOd);
                }
                if (search.CijenaManjaOd != null)
                {
                    list = list.Where(p => p.Cijena <= search.CijenaManjaOd);
                }
                if (search.Id != null)
                {
                    list = list.Where(p => p.Id == search.Id);
                }
            }
            var list1 = list.ToList();

            return _mapper.Map<List<Model.Paket>>(list1);
        }

        [HttpPost]
        public Model.Paket Insert(Model.Requests.PaketInsertRequest request)
        {
            var paket = _mapper.Map<Database.Paket>(request);


            _context.Paket.Add(paket);
            _context.SaveChanges();
            return _mapper.Map<Model.Paket>(paket);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Paket> GetById(int id)
        {
            var paket = _context.Paket.Where(p => p.Id == id)
                .Include(p=>p.PaketPristupniDani)
                .ToList();


            return _mapper.Map<Model.Paket>(paket);
        }
        [HttpPut("{id}")]
        public Model.Paket Update(int id, Model.Requests.PaketInsertRequest request)
        {
            var paket = _context.Paket.Find(id);
            _mapper.Map(request, paket);

            paket.Id = id;

            _context.SaveChanges();

            return _mapper.Map<Model.Paket>(paket);
        }


    }
}