// See https://aka.ms/new-console-template for more information
using CadSimuLike.Core;
using CadSimuLike.Parser;
using System;

namespace CadSimuLike
{
    class Program
    {
        static void Main()
        {
            var diagram = new Diagram();
            var numbering = new NumberingService();
            var parser = new CommandParser(diagram, numbering);

            Console.WriteLine("Digite comandos (ENTER vazio para sair):");

            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                    break;

                parser.Execute(line);
            }

            Console.WriteLine("Diagrama final.");

            foreach (var c in diagram.Components)
                Console.WriteLine($"{c.Tag} ({c.Type})");

            Console.WriteLine("\nConexões.");
            foreach (var l in diagram.Connections)
                Console.WriteLine($"from: {l.From}, to: {l.To}");
            
        }
    }
}
