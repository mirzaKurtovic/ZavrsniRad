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
    public class TrenerSpecijalizacijaController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public TrenerSpecijalizacijaController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }


        // GET: api/TrenerSpecijalizacija
        [HttpGet]
        public ActionResult<List<Model.TrenerSpecijalizacija>> Get([FromQuery]Model.Requests.TrenerSpecijalizacijaSearchRequest request)
        {
            var query = _context.TrenerSpecijalizacija
                .Include(p=>p.Trener)
                .ThenInclude(p=>p.Radnik)
                .ThenInclude(p => p.Osoba)
                .Include(p=>p.TipTreninga)
                .AsQueryable();


            if (request != null)
            {
                if (request.TrenerId != null)
                {
                    query = query.Where(p => p.TrenerId == request.TrenerId);
                }
                if (request.TipTreningaId != null)
                {
                    query = query.Where(p => p.TipTreningaId == request.TipTreningaId);
                }
            }



            var list = query.ToList();
            return _mapper.Map<List<Model.TrenerSpecijalizacija>>(list);
        }

        //// GET: api/TrenerSpecijalizacija/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/TrenerSpecijalizacija
        [HttpPost]
        public ActionResult<Model.TrenerSpecijalizacija> Post([FromBody] Model.Requests.TrenerSpecijalizacijaInsertRequest request)
        {
            //var trenerSpecijalizacija = _context.TrenerSpecijalizacija.Where(t => t.TrenerId == request.TrenerId && t.TipTreningaId == request.TipTreningaId).FirstOrDefault();
            Database.TrenerSpecijalizacija trenerSpecijalizacija = new TrenerSpecijalizacija()
            {

                TipTreningaId = request.TipTreningaId,
                TrenerId = request.TrenerId
            };
            _context.TrenerSpecijalizacija.Add(trenerSpecijalizacija);
            _context.SaveChanges();


            return _mapper.Map<Model.TrenerSpecijalizacija>(trenerSpecijalizacija);
        }

        //// PUT: api/TrenerSpecijalizacija/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var trenerSpecijalizacija = _context.TrenerSpecijalizacija.Where(t => t.Id==id).FirstOrDefault();

            _context.TrenerSpecijalizacija.Remove(trenerSpecijalizacija);
            _context.SaveChanges();
            return true;
        }
    }
}
