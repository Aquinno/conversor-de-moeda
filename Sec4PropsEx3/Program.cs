using Sec4PropsEx3;
using System;
using System.Globalization;

namespace Projeto {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("-=--=--=--=--=--=--=-");
            Console.WriteLine("VERIFICADOR DE ALUNO");
            Console.WriteLine("-=--=--=--=--=--=--=-");

            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal());

            Console.WriteLine("SITUAÇÃO: " + a.Situacao());
        }
    }
}
