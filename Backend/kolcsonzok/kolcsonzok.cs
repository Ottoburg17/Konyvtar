using System;
using System.Collections.Generic;

namespace kolcsonzok
{
    
    public class Kolcsonzes
    {
        public int Id { get; set; }
        public string? Iro { get; set; }
        public string? Mufaj { get; set; }
        public string? Cim { get; set; }
    }

    
    public class Kolcsonzo
    {
        public int Id { get; set; }
        public string? Nev { get; set; }
        public DateTime? SzulIdo { get; set; }
        public List<Kolcsonzes> Kolcsonzesek { get; set; }
    }
}
