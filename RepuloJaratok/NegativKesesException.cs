using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuloJaratok
{
    class NegativKesesException : Exception
    {
        public NegativKesesException()
            : base("Nem van ilyen késés e!")
        {

        }
    }
}
