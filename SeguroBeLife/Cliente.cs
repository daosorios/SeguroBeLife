using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BD
/*
 [RutCliente] Nvarchar(10) NOT NULL,
 [Nombres] Nvarchar(20) NOT NULL,
 [Apellidos] Nvarchar(20) NOT NULL,
 [FechaNacimiento] Datetime NOT NULL,
 [IdSexo] Int NOT NULL,
 [IdEstadoCivil] Int NOT NULL
 */

namespace SeguroBeLife
{
    class Cliente
    {
        public String RutCliente { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

        public Cliente()
        {
            this.Init();
        }

        void Init()
        {
            RutCliente      =   String.Empty;
            Nombres         =   String.Empty;
            Apellidos       =   String.Empty;
            FechaNacimiento = DateTime.Today;
            IdSexo          =              0;
            IdEstadoCivil   =              0;
        }
    }
}