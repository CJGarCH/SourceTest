using System;
using System.Linq;

namespace ListCar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           List<Cars> lst = new List<Cars>() 
           { 
               new Cars() {Model = 2022, Brand = "Ch", Color = "Red"},
               new Cars() {Model = 2010, Brand = "Ren", Color = "Gree"},
               new Cars() {Model = 2017, Brand = "Seat", Color = "Blue"},
               new Cars() {Model = 2021, Brand = "Toy", Color = "Pink"},

           };

            List<string> lstOrdenadoSoloNombres = (
             from d in lst
             where d.Model >= 2017
             select  ("Brand: " + d.Brand + " Color:" + d.Color + " Model: " + d.Model) ).ToList();

            


            foreach(var Model in lstOrdenadoSoloNombres)
            {
                Console.WriteLine(Model);
            }

            

       

        }
       
    }
}

/*
 List<Cerveza> cervezas = new List<Cerveza> ()
new Cerveza () { Alcohol=7, Cantidad-1e, Nombre= "Pale Ale", Marca="Minerva"}
new Cerveza () { Alcohol-8, cantidad=5, Nombre="Ticús", Marca="Colima "},
new Cerveza (){ Alcohol-7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
 */

/*
  List<Cerveza> cervezas = new List<Cerveza> () 
            {
                new Cerveza () { Alcohol=7, Marca="Minerva",  Cantidad=10, Nombre= "Pale Ale"},
                new Cerveza () { Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
                new Cerveza (){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
            //    new Cerveza () {Alcohol = 8, Cantidad = 1, Nombre}
            };
 */

/*
 var cervezasOrdenadas = from d in cervezas
                                    orderby d.Marca
                                    select d;
            foreach (var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine($"{cerveza.Nombre}{cerveza.Marca}");
            }
*/