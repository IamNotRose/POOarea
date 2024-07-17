using AreaRetangulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaReangulo
{

    class Program
    {

        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcule a area de um retangulo");
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibirDados();
            Console.ReadKey();


        }

    }
}