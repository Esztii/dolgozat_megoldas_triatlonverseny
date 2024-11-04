using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_megoldas_triatlonverseny
{
    internal class Verseny
    {
        //Nagy Máté;1996;4;f;18-19;00:12:47;00:00:34;00:31:40;00:00:26;00:17:42
        public string Nev { get; set; }
        public int Szuletesev { get; set; }
        public string Rajtszam { get; set; }
        public bool Nem { get; set; }
        public string Kategoria { get; set; }
        public Dictionary<string, TimeSpan> VersenyIdok { get; set; }

        public override string ToString() =>
            $"[{Rajtszam}] {Nev} ({(Nem ? "férfi" : "nő")}, {Kategoria})";

        public double OsszIdoSec => (int)VersenyIdok.Values.Sum(x => x.TotalSeconds);
        public Verseny(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            Szuletesev = int.Parse(s[1]);
            Rajtszam = s[2];
            Nem = s [3] == "f";
            Kategoria = s [4];

            VersenyIdok = new()
            {
                { "úszás", TimeSpan.Parse(s[5])},
                { "I. depó", TimeSpan.Parse(s[5])},
                { "kerékpár", TimeSpan.Parse(s[5])},
                { "II. depó", TimeSpan.Parse(s[5])},
                { "futás", TimeSpan.Parse(s[5])},

            };
        }
    }
}
