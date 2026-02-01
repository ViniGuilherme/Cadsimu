using CadSimuLike.Core;

namespace CadSimuLike.Components
{
    public class PushButton : Component
    {
        public PushButton(string type) : base("PushButton")
        {
            Terminals.Add(new Terminal("1")); 
            Terminals.Add(new Terminal("2")); 
        }
    
    }   
}