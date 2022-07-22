using System;

namespace app.Src
{
    public class Animal
    {
        string Name { get; set; }
        string Tipo { get; set; }

        public Animal(string name, string tipo)
        {
            Name = name;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Nome: {Name} || Tipo: {Tipo}";
        }
    }

    public class Pessoa
    {
        public string Name { get; set; }
        int Age { get; set; }
        string Hometown { get; set; }

        public Pessoa(string name, int age, string hometown)
        {
            Name = name;
            Age = age;
            Hometown = hometown;
        }

        public override string ToString()
        {
            return $"Nome: {Name} || Idade: {Age} || Natalidade: {Hometown}";
        }
    }  

    public class Livro
    {
        public string Title { get; set; }
        string Autor { get; set; }
        int NmbrPages { get; set; }

        public Livro(string title, string autor, int nmbrPages)
        {
            Title = title;
            Autor = autor;
            NmbrPages = nmbrPages;
        }

        public override string ToString()
        {
            return $"Título: {Title} || Autor: {Autor} || Páginas: {NmbrPages}";
        }
    }  
}