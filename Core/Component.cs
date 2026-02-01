using System.Collections.Generic;

namespace CadSimuLike.Core
{
    public abstract class Component
    {
        public string Tag { get; set; } = string.Empty;
        public string Type { get; }

        public List<Terminal> Terminals { get; } = new();

        protected Component(string type)
        {
            Type = type;
        }

    }
}