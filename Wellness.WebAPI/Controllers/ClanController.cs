using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public ClanController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.Requests.ClanViewRequest>> Get([FromQuery] ClanSearchRequest request)
        {
            var list = from clan in _context.Clan
                       join osoba in _context.Osoba on clan.OsobaId equals osoba.Id
                       select new Model.Requests.ClanViewRequest
                       {
                           Id = clan.Id,
                           Ime = osoba.Ime,
                           Prezime = osoba.Prezime,
                           OsobaId=osoba.Id,
                           Osoba=_mapper.Map<Model.Osoba>(osoba),
                           QrCodeText=clan.QrCodeText,
                           Qrcode=clan.Qrcode
                       };

            #region filter
            if (request.OsobaId != null)
            {
                list = list.Where(c => c.OsobaId == request.OsobaId);

            }
            if (request.ClanId != null)
            {
                list = list.Where(c => c.Id == request.ClanId);

            }
            if (!string.IsNullOrEmpty(request.QrCodeText))
            {
                list = list.Where(c => c.QrCodeText == request.QrCodeText);
            }
            if (!string.IsNullOrEmpty(request.Ime))
            {
                list = list.Where(c => c.Ime == request.Ime);
            }
            if (!string.IsNullOrEmpty(request.Prezime))
            {
                list = list.Where(c => c.Prezime == request.Prezime);
            }
            if (!string.IsNullOrEmpty(request.KorisnickoIme))
            {
                list = list.Where(c => c.Osoba.KorisnickoIme == request.KorisnickoIme);
            }
            #endregion filter

            return list.ToList();
        }






        [HttpPost]
        public Model.Requests.ClanViewRequest Insert(ClanInsertRequest request)
        {
            var clan = _mapper.Map<Clan>(request);

            _context.Clan.Add(clan);
            _context.SaveChanges();
            return _mapper.Map<Model.Requests.ClanViewRequest>(clan);
        }

        [HttpPut("{id}")]
        public Model.Requests.ClanViewRequest Update(int id, ClanInsertRequest request)
        {
            var clan = _context.Clan.Find(id);
            _mapper.Map(request, clan);
            _context.SaveChanges();

            return _mapper.Map<Model.Requests.ClanViewRequest>(clan);
        }



    }
}