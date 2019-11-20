using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SifraController : ControllerBase
    {
        private readonly _160001Context _context;
        public SifraController(_160001Context context)
        {
            this._context = context;
        }

        [HttpPut("{id}")]
        public bool Update(int id, [FromBody]string sifra)
        {
            var osoba = _context.Osoba.Find(id);
            osoba.LozinkaSalt = GenerateSalt();
            osoba.LozinkaHash = GenerateHash(osoba.LozinkaSalt, sifra);
            _context.SaveChanges();
            return true;
        }







        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

    }
}


