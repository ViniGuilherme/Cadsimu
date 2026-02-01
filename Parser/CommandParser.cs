using CadSimuLike.Core;
using CadSimuLike.Components;
using System;
using System.Linq;

namespace CadSimuLike.Parser
{
    public class CommandParser
    {
        private readonly Diagram _diagram;
        private readonly NumberingService _numbering;

        public CommandParser(Diagram diagram, NumberingService numbering)
        {
            _diagram = diagram;
            _numbering = numbering;
        }
    
        public void Execute(string command)
        {
            var parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts[0] == "CONTATOR")
            {
                var c = new Contactor
                {
                    Tag = _numbering.Next("KM")
                };
                _diagram.AddComponent(c);
                Console.WriteLine($"Criado: {c.Tag}");
            }

            else if (parts[0] == "BOTÃO")
            {
                var type = parts[1];
                var b = new PushButton(type)
                {
                    Tag = _numbering.Next("S")
                };
                _diagram.AddComponent(b);
                Console.WriteLine($"Criado: {b.Tag}");  
            }

            else if (parts[0] == "LIGAR")
            {
                var from = parts[1];
                var to = parts[3];
                _diagram.Connect(from, to);
                Console.WriteLine($"Ligação: {from} -> {to}");
            }

            else
            {
                Console.WriteLine("Comando desconhecido.");
            }
        }
    }
}