using Modelos;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var avion=new Avion();

var azafata1=new Tcp(111,"Florencia","Diaz");
var azafata2=new Tcp(222,"Carla","Barcos");

avion.Abordar(azafata1);
avion.Abordar(azafata2);

var piloto=new Piloto(333,"Laura","Alonso");
avion.Abordar(piloto);

avion.Reporte();

