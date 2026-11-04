using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Tier
    {
        private string lebensraum;
        private string ernaehrung;

        public int Gesundheit { get; set; }

        public Tier(string lebensraum, string ernaehrung, int gesundheit)
        {
            this.lebensraum = lebensraum;
            this.ernaehrung = ernaehrung;
            Gesundheit = gesundheit;
        }

        public string GetLebensraum()
        {
            return lebensraum;
        }

        public string GetErnaehrung()
        {
            return ernaehrung;
        }
    }
}
