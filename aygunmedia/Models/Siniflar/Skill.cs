using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aygunmedia.Models.Siniflar
{
    public class Skill
    {
        public int Id { get; set; } // Yetenek için benzersiz ID
        public string yetenekAd { get; set; } // Yetenek adı
        public int yuzde { get; set; } // Yetenek yüzdesi
    }
}