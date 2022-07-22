using System;
using System.Collections.Generic;
using app.Src;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Animais --");
            CList();

            Console.WriteLine("\n\n-- Pessoas --");
            CQueue();

            Console.WriteLine("\n\n-- Livros --");
            CStack();

            Console.WriteLine("\n\n-- Dicionário --");
            CDictionary();
        }

        static void CList()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal("Flamingo", "Voador"));
            animals.Add(new Animal("Macaco", "Terrestre"));
            animals.Add(new Animal("Baleia", "Marinho"));
            animals.Add(new Animal("Golfinho", "Marinho"));

            animals.Insert(2, new Animal("Leão", "Terrestre"));

            animals.RemoveAt(animals.Count - 1);
            animals.RemoveAt(1);

            foreach(var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void CQueue()
        {
            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Gustavo", 18, "Recife"));
            pessoas.Enqueue(new Pessoa("Francine", 16, "Mauá"));
            pessoas.Enqueue(new Pessoa("Victor", 20, "São Miguel"));
            pessoas.Enqueue(new Pessoa("Nilton", 51, "Embú"));
            pessoas.Enqueue(new Pessoa("Lívia", 43, "São Miguel"));

            Console.WriteLine($"Primeiro(a) da fila: {pessoas.Dequeue().Name}");
            Console.WriteLine($"{pessoas.Peek().Name} foi removido(a).");

            pessoas.Peek();

            Console.WriteLine($"Restam {pessoas.Count} pessoas na fila");

            foreach (var item in pessoas)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void CStack()
        {
            Stack<Livro> livros = new();

            livros.Push(new Livro("As Cronicas de Nárnia","C.S.Lewis", 327));
            livros.Push(new Livro("O Pequeno Príncipe", " Antoine de Saint-Exupéry", 132));
            livros.Push(new Livro("Romanos", "Paulo", 42));

            Console.WriteLine($"O primeiro livro da pilha é {livros.Peek().Title}");
            Console.WriteLine($"{livros.Peek().Title} foi removido da pilha");

            livros.Pop();

            Console.WriteLine($"Quantidade de livros na pilha: {livros.Count}");

            foreach (var item in livros)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void CDictionary()
        {
            Dictionary<String, String> dic = new();

            dic.Add("Persistência","É quando persistimos no nosso alvo/objetivo mesmo diante dos obstáculos e dificuldades.");
            dic.Add("Mentalidade de Crescimento","Quando acreditamos que nossas qualidades podem sempre ser cultivadas, o que nos leva a usar críticas, dificuldades e desafios como o ponto de partida para o desenvolvimento.");
            dic.Add("Responsabilidade Pessoal","Assumir a responsabilidade pelas próprias ações, trabalhar duro, manter os compromissos, e não dar desculpas.");
            dic.Add("Orientação ao Futuro","Significa criar um roteiro para o seu futuro, compreender como as ações de hoje impactam seus objetivos e verificar seu progresso com frequência.");
            dic.Add("Comunicação", "Saber transmitir a mensagem, ser claro e objetivo");
            dic.Add("Orientação ao Detalhe", "Prestar atenção nas poucas coisas, nas mínimas e pequenas coisas que parecem irrelevantes, mas, que podem trazer graves consequências");
            dic.Add("Proatividade", "Significa assumir a liderança em seu emprego sem nenhum impulso de seu gerente ou de outras pessoas, antecipando situações e tomando as ações preventivas que forem necessárias.");
            dic.Add("Trabalho em Equipe", "Pode ser definido como a capacidade dos membros da equipe de trabalharem juntos, comunicarem-se efetivamente, anteciparem-se e atenderem às demandas uns dos outros, e inspirar confiança, resultando em uma ação coletiva coordenada.");

            foreach(KeyValuePair<String, String> kvp in dic)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine("========================");
                Console.WriteLine(kvp.Value + "\n");

            }
        }
    }
}
