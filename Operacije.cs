using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Operacije
    {
        public string LevaStrana { get; set; }
        public string DesnaStrana { get; set; }
        public OperacijeEnum Op { get; set; }
        public Operacije Unutrasnja { get; set; }
        public Operacije()
        {
            LevaStrana = string.Empty;
            DesnaStrana = string.Empty;
        }

    }
}
