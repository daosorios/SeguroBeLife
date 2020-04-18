using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
    class Tarificador
    {
        private DateTime Fnacimiento { get; set; }
        private int Edad { get; set; }
        private int Sexo { get; set; }
        private int EstadoCivil { get; set; }
        private int Valorbase { get; set; }
        private Double UF { get; set; }
        private Double Recargo { get; set; }
        private Double Seguro { get; set; }

        public Tarificador()
        {
            this.Init();
        }

        public void Init()
        {
            Fnacimiento = DateTime.Today;
            Edad = 0;
            Sexo = 0;
            EstadoCivil = 0;
            Valorbase = 0;
            UF = 1;
            Recargo = 0;
            Seguro = 0;
        }

        public int edad //Validacion_de_edad
        {
            get
            {
                return this.Edad;
            }
            set
            {
                if (value >= 18 && value <= 100)
                {
                    this.Edad = value;
                }
                else if (value >= 0 && value < 18)
                {
                    throw new ArgumentOutOfRangeException("La persona es menor de edad");
                }
                else if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La edad es menor a 0");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("La edad es un numero demaciado alto");
                }
            }
        }

        public int valorbase
        {
            get
            {
                return this.Valorbase;
            }
            set
            {
                if (value > 0 && value <= 20)
                {
                    this.Valorbase = value;
                }
                else if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("El valor base es igual a 0");
                }
                else if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("El valor base es negativo");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("El valor base es mayor a 20");
                }
            }
        }

        public double Clarec(int Edad, int sexo, int EstadoCivil)//Calculo de recargo
        {
            Recargo = 0;

            //Edad
            if (Edad >= 18 && Edad <= 25)
            {
                Recargo = +3.6;
            }
            else if (Edad > 25 && Edad <= 45)
            {
                Recargo = +2.4;
            }
            else if (Edad < 45)
            {
                Recargo = +6.0;
            }

            //SEXO
            else if (sexo == 1)
            {
                Recargo = +2.4;
            }
            else if (sexo == 2)
            {
                Recargo = +1.2;
            }

            //EstadoCivil
            else if (EstadoCivil == 1)
            {
                Recargo = +4.8;
            }
            else if (EstadoCivil == 2)
            {
                Recargo = +2.4;
            }
            else
            {
                Recargo = +3.6;
            }

            return Recargo;
        }
        public double seguro(int UF, double Recargo)//Calculo de seguro multiplicando el recargo por las uf
        {
            this.Seguro = UF * Recargo;
            return Seguro;
        }

        public int calcularEdad(DateTime Fnacimiento, DateTime fechaHoy)//Calcular la edad

        {
            fechaHoy = DateTime.Today;
            Edad = fechaHoy.Year - Fnacimiento.Year;

            if (fechaHoy.Month < Fnacimiento.Month || (fechaHoy.Month == Fnacimiento.Month && fechaHoy.Day < Fnacimiento.Day))
            {
                Edad--;
            }
            return Edad;
        }
    }
}
