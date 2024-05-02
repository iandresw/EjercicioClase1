// See https://aka.ms/new-console-template for more information
using EjercicioClase;

Console.WriteLine("Ejercicio 1");

SuperHeroe superHeroe = new SuperHeroe();

superHeroe.Nombre = "Super Man";
superHeroe.IdentidadSecretra = "Clack Kent";
superHeroe.Ciudad = "Metropolis";
superHeroe.PuedeVolar = true;
superHeroe.SuperPoder.Nombre = "Super Fuerza";
superHeroe.SuperPoder.Descripcion = "Capacidad de levntar Obejtos muy pesados";
superHeroe.SuperPoder.Nivel = 9;
superHeroe.Imprimir();




superHeroe.Nombre = "Hombre Arania";
superHeroe.IdentidadSecretra = "Peter Parker";
superHeroe.Ciudad = "New York";
superHeroe.PuedeVolar = false;
superHeroe.SuperPoder.Nombre = "Lanza Telas de Arania";
superHeroe.SuperPoder.Descripcion = "Libiano y se pouede lanzar lejos";
superHeroe.SuperPoder.Nivel = 7;
superHeroe.Imprimir();

superHeroe.Nombre = "Iro Man";
superHeroe.IdentidadSecretra = "Tony Stark";
superHeroe.Ciudad = "New York";
superHeroe.PuedeVolar = false;
superHeroe.SuperPoder.Nombre = "Tecnologia Avanzada";
superHeroe.SuperPoder.Descripcion = "Utiliza Armadura Poderosa";
superHeroe.SuperPoder.Nivel = 9;
superHeroe.Imprimir();