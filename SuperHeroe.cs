using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre{ get; set; }
        public string IdentidadSecretra { get; set; }   
        public string Ciudad { get; set; }
        public bool PuedeVolar {  get; set; }   
        public SuperPoder SuperPoder { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Super Heroe");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecretra}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {PuedeVolar}");
            Console.WriteLine($"Super Poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripcion: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
        }
        public SuperHeroe()
        {
            SuperPoder = new SuperPoder();
        }
    }
}
