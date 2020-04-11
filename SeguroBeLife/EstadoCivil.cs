using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroBeLife
{
    class EstadoCivil
    {
        public int    IdEstadoCivil { get; set; }
        public string Descripcion   { get; set; }

        public EstadoCivil()
        {
            this.Init();
        }

        void Init()
        {
            IdEstadoCivil =            0;
            Descripcion   = String.Empty;
        }
    }
    
}
