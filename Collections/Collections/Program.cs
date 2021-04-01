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
        static Queue<string> pedagio = new Queue<string>();

        private static void Enfileirar(string veiculo)
        {
            var anterior = string.Empty;
            if (pedagio.Any())
            {
               anterior = pedagio.Peek();
            }

            Console.WriteLine($"Entrou na fila: {veiculo} - Veiculos anterior: {anterior} ");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void Desenfileirar()
        {

            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

        static void Main(string[] args)
        {
            Enfileirar("Van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
        }

        public static void StackPilha()
        {
            //Utilizando Pilha

            var teste = new Bastao();
            teste.Colocar("-");
            teste.Colocar("--");
            teste.Colocar("---");
            teste.Retirar();
            teste.Retirar();
            teste.Retirar();
        }

        public static void LinkedList()
        {
            List<string> Frutas = new List<string>() { "Banana", "Perã", "Maçã" };

            LinkedList<string> Dias = new LinkedList<string>();
            //Podemos Adicionar de 4 Formas:
            //1 - Como  primeiro nó
            //2 - Como último nó
            //3 - Antes de um nó conhecido
            //4 - Depois de um nó conhecido
            var d4 =  Dias.AddFirst("Quarta-Feira");

            //Vamos adicionar  segunda ,antes de quarta
            var d2 = Dias.AddBefore(d4, "Segunda-Feira");

            var d3 = Dias.AddAfter(d2, "Terça-Feira");

            var d6 = Dias.AddAfter(d4, "Sexta-feira");

            var d7 = Dias.AddAfter(d6, "Sabado");

            var d5 = Dias.AddBefore(d6, "Quinta-feira");

            var d1 = Dias.AddBefore(d2, "Domingo");

            Dias.Remove("Sabado");

            foreach (var dias in Dias)
            {
                Console.WriteLine(dias);
            }
        }

        public static void Dicionario()
        {
            Alunos n1 = new Alunos(1, "Rafael");
            Alunos n2 = new Alunos(2, "João");
            Alunos n3 = new Alunos(3, "Larissa");

            n1.Matricular(n1);
            n1.Matricular(n2);
            n1.Matricular(n3);

            Alunos retorno = n1.BuscarMatriculado(2);

            Console.WriteLine($"Resultado do retorno: {retorno}");
        }

        public static void Sets()
        {
            //SETS  = Conjuntos
            //Duas propriedades do SET
            //1 - Não permite duplicidade
            //2 - Os elementos não são mantidos em ordem especifica 

            ISet<string> alunos = new  HashSet<string>();
            alunos.Add("Vanessa");
            alunos.Add("Ana");
            alunos.Add("Rafael");

            //Imprimindo
            Console.WriteLine(string.Join(",",alunos));
            Console.WriteLine();

            //Adicionadno mais
            alunos.Add("Kethlyn");
            alunos.Add("Thamires");
            alunos.Add("Vitor");
            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            alunos.Remove("Vitor");
            alunos.Add("Jubileu");
            Console.WriteLine(string.Join(",", alunos));
            Console.WriteLine();

            //Qual a vantagem do SET  sobre a lista ? LOOK-UP!
            //É MAIS RAPIDO QUE UMA LISTAAAA
            //Desempenho HashSet X List: escabilidade x mémoria

            //Ordenando
            List<string> alunosNovo = new List<string>(alunos);
            alunosNovo.Sort();
            Console.WriteLine(string.Join(",", alunosNovo));

            ISet<Alunos> Alunos = new HashSet<Alunos>();

            Alunos.Add(new Alunos(1, "David"));
            Alunos.Add(new Alunos(1, "David"));
            Alunos.Add(new Alunos(1, "David"));
            Alunos.Add(new Alunos(1, "David"));
            Alunos.Add(new Alunos(1, "David"));

            Console.WriteLine(string.Join(",",Alunos.Select(aluno => aluno.Nome)));

            SortedSet<string> nomes = new SortedSet<string>();//Outra maneira bem mais rapida que list

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

    class Bastao
    {
        private readonly Stack<string> steps = new Stack<string>();
        string prato = "";
      

        public Bastao()
        {
            Console.WriteLine(prato += "");
        }

        public void Colocar(string ex)
        {
            steps.Push(prato);
            prato = ex;
            Console.WriteLine(prato);
        }

        public void Retirar()
        {
            if (steps.Any())
            {
                prato = steps.Pop();
                Console.WriteLine(prato);
            }
           
        }
    }

    class Alunos
    {
        private IDictionary<int, Alunos> dicionarioAlunos = new Dictionary<int, Alunos>();

        public Alunos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public void Matricular(Alunos aluno)
        {
            dicionarioAlunos.Add(aluno.Id, aluno);
        }

        public Alunos BuscarMatriculado(int id)
        {
            Alunos aluno = null;
            dicionarioAlunos.TryGetValue(id, out aluno); //vai preencher o aluno caso encontre
            return aluno;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nNome:{Nome}";
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
 