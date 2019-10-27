using System;

namespace WebApplication1.Models
{
    public abstract class ObjetoEscuelaBase
    {
        // The ID must be called only like ID not UniqueID
        public string Id { get;  set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}