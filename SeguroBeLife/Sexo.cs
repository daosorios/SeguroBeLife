using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroBeLife
{
    class Sexo
    {
        public int    IdSexo      { get; set; }
        public string Descripcion { get; set; }

        public Sexo()
        {
            this.Init();
        }

        void Init()
        {
            IdSexo      =            0;
            Descripcion = String.Empty;
        }
    }
}
