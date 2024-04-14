using Microsoft.AspNetCore.Mvc;
using kolcsonzok;
using System.Collections.Generic;

namespace kolcsonzok.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KolcsonzokController : ControllerBase
    {
        private readonly DataService _db;

        public KolcsonzokController(DataService db)
        {
            _db = db;
        }

        [HttpGet(Name = "GetKolcsonzok")]
        public IEnumerable<Kolcsonzo> Get()
        {
            return _db.Kolcsonzesek.ToArray();
        }

        [HttpPost]
        public Kolcsonzo Post(Kolcsonzo kolcsonzo)
        {
            _db.Kolcsonzesek.Add(kolcsonzo);
            _db.SaveChanges();
            return kolcsonzo;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Kolcsonzo kolcsonzo)
        {
            var existingKolcsonzo = _db.Kolcsonzesek.Find(id);
            if (existingKolcsonzo == null)
            {
                return NotFound();
            }

            existingKolcsonzo.Nev = kolcsonzo.Nev;
            existingKolcsonzo.SzulIdo = kolcsonzo.SzulIdo;
            existingKolcsonzo.Kolcsonzesek = kolcsonzo.Kolcsonzesek;

            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var kolcsonzo = _db.Kolcsonzesek.Find(id);
            if (kolcsonzo == null)
            {
                return NotFound();
            }

            _db.Kolcsonzesek.Remove(kolcsonzo);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
