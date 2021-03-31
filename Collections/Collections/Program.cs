using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Aula Intro";
            string aulaModelando = "Aula Modelando";
            string aulaSets = "Aula Sets";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);
        }

        public static void MudarTamanhoArray(string[] array)
        {
            Array.Resize(ref array, 2);
        }

        public static void TrocarOrdem(string[] array)
        {
            Array.Reverse(array);
        }

        public static void Buscar(string[] array, string palavra)
        {
            Console.WriteLine($"Indice de busca: {Array.IndexOf(array,palavra)}");
        }

        public static void Imprimir(string[] array)
        {
            foreach (var aula in array)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
 