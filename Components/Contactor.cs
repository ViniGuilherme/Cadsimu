using CadSimuLike.Core;

namespace CadSimuLike.Components
{
    public class Contactor : Component
    {
        public Contactor() : base("Contactor")
        {
            Terminals.Add(new Terminal("A1"));
            Terminals.Add(new Terminal("A2"));
        }
    }
}