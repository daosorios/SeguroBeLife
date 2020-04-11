using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroBeLife
{
    class Plan
    {  
        public String IdPlan       { get; set; }
        public String Nombre       { get; set; }
        public float  PrimaBase    { get; set; }
        public String PolizaActual { get; set; }

        public Plan()
        {
            this.Init();
        }

        void Init()
        {
            IdPlan       = String.Empty;
            Nombre       = String.Empty;
            PrimaBase    =            0;
            PolizaActual = String.Empty;
        }
    }
}
