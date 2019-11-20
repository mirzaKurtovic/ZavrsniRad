using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Services
{
    public class TreningService:ITreningService
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public TreningService(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public List<Model.Trening> Get(TreningSearchRequest request)
        {

            var query = _context.Trening
                .Include(t => t.TipTreninga)
                .Include(t => t.Trener)
                .ThenInclude(t => t.Radnik)
                .ThenInclude(t => t.Osoba)
                .OrderBy(t => t.Odrzan)
                .AsQueryable();
            if (request != null)
            {
                //sa ovim if-om provjeravamo ima li treninga sa zeljenim terminom..
                if (request.TrenerID != null && request.VrijemePocetak != null && request.VrijemeKraj != null && request.DatumTreninga != null)
                {
                    query = query.Where(q => q.TrenerId == request.TrenerID);

                    query = query.Where(q => q.DatumTreninga.ToShortDateString() == request.DatumTreninga.ToShortDateString());
                    query = query.Where(q => 
                           (request.VrijemeKraj >= q.VrijemeKraj && request.VrijemeKraj >= q.VrijemeKraj)//POCETAK UNUTAR
                        || (request.VrijemePocetak >= q.VrijemePocetak && request.VrijemePocetak >= q.VrijemePocetak)//POCETAK UNUTAR
                        || (request.VrijemePocetak <= q.VrijemePocetak && request.VrijemeKraj >= q.VrijemeKraj)//pocetak prije treninga kraj je poslije   OKOLO
                        || (request.VrijemePocetak >= q.VrijemePocetak && request.VrijemeKraj <= q.VrijemeKraj)); //pocetak unutar i kraj unutar treninnn UNUTAR



                    //(q.VrijemePocetak <= request.VrijemePocetak && q.VrijemeKraj >= request.VrijemePocetak)// pocetak prije treningaj, kraj je unutar treninga
                    //    || (request.VrijemeKraj >= q.VrijemePocetak && request.VrijemeKraj <= q.VrijemeKraj)//kraj je unutar treninga

                }
                else
                {
                    if (request.TipTreningaID != 0)
                    {
                        query = query.Where(q => q.TipTreningaId == request.TipTreningaID);
                    }
                    if (request.DatumTreninga.ToShortDateString() != DateTime.MinValue.ToShortDateString())
                    {
                        query = query.Where(q => q.DatumTreninga.ToShortDateString() == request.DatumTreninga.ToShortDateString());
                    }
                    if (request.TrenerID != null)
                    {
                        query = query.Where(q => q.TrenerId == request.TrenerID);
                    }
                    if (request.MaksimalnoPristunihManjeOd != 0)
                    {
                        query = query.Where(q => q.MaksimalnoPrisutnih < request.MaksimalnoPristunihManjeOd);
                    }
                    if (request.MaksimalnoPristunihVeceOd != 0)
                    {
                        query = query.Where(q => q.MaksimalnoPrisutnih > request.MaksimalnoPristunihVeceOd);
                    }
                    if (request.Odrzan==true)
                    {
                        query = query.Where(q => q.Odrzan==request.Odrzan);
                    }
                    if (request.Odrzan == false)
                    {
                        query = query.Where(q => q.Odrzan == false || q.Odrzan == null);
                    }
                }
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Trening>>(list);
        }

        public Model.Trening GetById(int id)
        {
            var trening = _context.Trening
                .Where(t => t.Id == id)
                 .Include(t => t.TipTreninga)
                .Include(t => t.Trener)
                .ThenInclude(t => t.Radnik)
                .ThenInclude(t => t.Osoba)
                .FirstOrDefault();

            return _mapper.Map<Model.Trening>(trening);
        }

        public Model.Trening Insert(TreningInsertRequest request)
        {
            var trening = _mapper.Map<Trening>(request);

            _context.Trening.Add(trening);
            _context.SaveChanges();
            return _mapper.Map<Model.Trening>(trening);
        }

        public void Update(int id, TreningInsertRequest request)
        {
            var trening = _context.Trening.Find(id);
            _mapper.Map(request, trening);
            _context.SaveChanges();

        }


    }
}
