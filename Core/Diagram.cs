using System.Collections.Generic;

namespace CadSimuLike.Core
{
    public class Diagram
    {
        public List<Component> Components { get; } = new();
        public List<Connection> Connections { get; } = new();

        public void AddComponent(Component component)
        {
            Components.Add(component);
        }

        public void Connect(string from, string to)
        {
            Connections.Add(new Connection(from, to));
        }
    }
}