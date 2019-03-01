using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuloJaratok
{
    public class Class1
    {
        class Jarat {

            public Jarat(string jaratSzam, string induloAllomas, string celAllomas, DateTime kiirtIdopont) {
                this.jaratSzam = jaratSzam;
                this.induloAllomas = induloAllomas;
                this.celAllomas = celAllomas;
                this.kiirtIdopont = kiirtIdopont;
            }

            public string jaratSzam { get; set; }
            public string induloAllomas { get; set; }
            public string celAllomas{ get; set; }
            public DateTime kiirtIdopont { get; set; }
            public int keses { get; set; }
        }

        List<Jarat> jaratok = new List<Jarat>();


        public void UjJarat(string jaratSzam, string induloAllomas, string celAllomas, DateTime kiirtIdopont) {
            var j = new Jarat(jaratSzam, induloAllomas, celAllomas, kiirtIdopont);
            jaratok.Add(j);
            Keses(jaratSzam,0);
        }

        public void Keses(string jaratSzam, int keses) {
            for (int i = 0; i < jaratok.Count; i++)
            {
                if (jaratSzam.Equals(jaratok[i].jaratSzam))
                {
                    if (jaratok[i].keses + keses < 0)
                    {
                        throw new NegativKesesException();
                    }
                    jaratok[i].keses += keses;
                }

            }
        }
        

        public DateTime MikorIndul(string jaratSzam) {
            return DateTime.Now;
        }

        List<Jarat> induloJaratok = new List<Jarat>();
        public List<Jarat> JaratokRepuloterrol(string repter) {
            for (int i = 0; i < jaratok.Count; i++)
            {
                if (repter == jaratok[i].induloAllomas)
                {
                    induloJaratok.Add(new Jarat(jaratok[i].jaratSzam, jaratok[i].induloAllomas, jaratok[i].celAllomas, jaratok[i].kiirtIdopont));
                }
            }
            return induloJaratok;
        }

    }
}
