using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLeitura();
        }



        public static void ListaLeitura()
        {
            Curso csharp = new Curso("Marcelos","C# Collections p1");
            csharp.Adicionar(new Aulas("Listas", 20));
            csharp.Adicionar(new Aulas("Array", 15));
            csharp.Adicionar(new Aulas("Dictionary", 30));

            var aulasCopiadas = new List<Aulas>(csharp.Aulas);

            aulasCopiadas.Sort();

            Console.WriteLine("Ordenando: ");
            foreach (var item in aulasCopiadas)
                Console.WriteLine(item);
            

            Console.WriteLine("=========");
            Console.WriteLine("Sem ordenação: ");

            csharp.ImprimirAulas();

            Console.WriteLine("=========");
            Console.WriteLine($"Tempo total de cursos: {csharp.Total}");

            Console.WriteLine("=========");
            Console.WriteLine(csharp);
        }

        public static void ListaObj()
        {
            var aula1 = new Aulas("Aula1", 19);
            var aula2 = new Aulas("Aula2", 25);
            var aula3 = new Aulas("Aula3", 15);

            List<Aulas> Aulas = new List<Aulas>() { aula1, aula2, aula3 };

            Aulas.Sort((first, second) =>
                first.Tempo.CompareTo(second.Tempo)
            );

            Aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }

        public static void Lista()
        {
            string aula1 = "Aula 01";
            string aula2 = "Aula 02";
            string aula3 = "Aula 03";

            //List<string> Aulas = new List<string>()
            //{
            //    aula1,
            //    aula2,
            //    aula3
            //};

            List<string> Aulas = new List<string>();
            Aulas.Add(aula1);
            Aulas.Add(aula2);
            Aulas.Add(aula3);

            Aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }

    }

    class Aulas : IComparable
    {
        public string Aula { get; set; }
        public int Tempo { get; set; }

        public Aulas(string p_aula, int p_tempo)
        {
            Aula = p_aula;
            Tempo = p_tempo;
        }

        public override string ToString()
        {
            return $"{Aula} - {Tempo} minutos";
        }

        public int CompareTo(object obj)
        {
            var aulaObj = obj as Aulas;

            return Tempo.CompareTo(aulaObj.Tempo);
        }
    }

    class Curso
    {
        private List<Aulas> _aulas;
        private string _instrutor;
        private string _nome;
        private int _total;

        public Curso(string instrutor, string nome)
        {
            _aulas = new List<Aulas>();
            _instrutor = instrutor;
            _nome = nome;
        }

        //Protegendo nossa coleção
        public IList<Aulas> Aulas
        {
            get { return new ReadOnlyCollection<Aulas>(_aulas); }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Instrutor
        {

            get { return _instrutor; }
            set { _instrutor = value; }
        }

        public int Total
        {
            get
            {
                //int total = 0;

                //_aulas.ForEach(aula => {
                //    total += aula.Tempo;
                //});

                //return total;

                return _aulas.Sum(a => a.Tempo);
            }
        }

        public void Adicionar(Aulas aulas)
        {
            _aulas.Add(aulas);
        }

        public void ImprimirAulas()
        {
            _aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }

        public override string ToString()
        {
            return $"Nome do curso: {Nome} - Tempo total: {Total}\nAulas:\n {string.Join("\n ",_aulas)}";
        }
    }
}
 