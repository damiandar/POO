using System;

namespace Clase1v2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto();
            auto1.Anio = 2015;
            auto1.Combustible = "nafta";
            auto1.Marca = "Peugeot";
            auto1.Modelo = "208";
            auto1.Frenar();
            auto1.Acelerar();
            auto1.MotorInterno = new Motor();
            auto1.MotorInterno.Cilindrada = 1500;
            auto1.MotorInterno.Potencia = 85;

            var auto2 = new Auto();
            auto2.Marca = "Fiat";

            var motordeauto2 = new Motor();
            motordeauto2.Cilindrada = 1000;

            auto2.MotorInterno = motordeauto2;

            var auto3 = new Auto(2021);
            auto3.Anio = 2021;
            Console.WriteLine(auto3.Anio);

            var auto4 = new Auto(2017, "diesel", "Ford");
            Console.WriteLine(auto4.Marca);
            
        }
    }

    class Auto {

        #region Constructores
        public Auto() { 
            //implementacion
            //sirve para inicializar
        }

        public Auto(int anio) {
            Anio = anio;
        }
        public Auto(int anio,string combustible,string marca)
        {
            Anio = anio;
            Combustible = combustible;
            Marca = marca;

        }
        #endregion

        #region Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        //campos
        private string _combustible;
        //propiedad sirve para dar acceso a los campos, que por definicion son privados
        public string Combustible {
            get { return _combustible; }
            set { _combustible = value; }
        }
        #endregion

        #region Metodos
        public void Acelerar() { }

        public void Frenar() { }
        #endregion

        //motor

        public Motor MotorInterno { get; set; }

        //tren delantero
    }

    class Motor { 
        public int Cilindrada { get; set; }
        public int Potencia { get; set; }
        public int CantCilindros { get; set; }

        public string Combustible { get; set; }

    }


}
