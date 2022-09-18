using System;
using System.Collections.Generic;
namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1=new Auto();
            auto1.Patente="XXX123";
            auto1.Marca="Peugeot";

            var desperfecto1=new Desperfecto();
            desperfecto1.Descripcion="No funcionan las luces";
            desperfecto1.Repuestos=new List<Autoparte>(); 

            var repuesto1=new Autoparte();
            repuesto1.Descripcion="lampara";

            var repuesto2=new Autoparte();
            repuesto2.Descripcion="cable";

            var repuesto3=new Autoparte();
            repuesto3.Descripcion="cinta";

            desperfecto1.Repuestos.Add(repuesto1);
            
            desperfecto1.Repuestos.Add(repuesto2);
            
            desperfecto1.Repuestos.Add(repuesto3);

            var repuesto4=new Autoparte();
            repuesto4.Descripcion="Parlante";

            var desperfecto2=new Desperfecto();
            desperfecto2.Descripcion="No funciona stereo";
            desperfecto2.Repuestos=new List<Autoparte>();
            desperfecto2.Repuestos.Add(repuesto2);
            desperfecto2.Repuestos.Add(repuesto3);
            desperfecto2.Repuestos.Add(repuesto4);


        }
    }

    public class Auto {
        public string Patente {get;set;}
        public string Marca {get;set;}

        public List<Desperfecto> Desperfectos {get;set;}

    }

    public class Desperfecto{
        public string Descripcion {get;set;}
        //autopartes
        public List<Autoparte> Repuestos {get;set;}
        public int Horas {get;set;}
    }

    public class Autoparte{
        public int Costo {get;set;}
        public string Descripcion {get;set;}
    }
}
