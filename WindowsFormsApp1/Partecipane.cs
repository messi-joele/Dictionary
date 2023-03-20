using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Partecipane
    {

        public Partecipane (string nome)
        {
            Nome = nome;
        }   

        public string Nome { get; set; }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public bool Equals(Partecipane p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Nome == p.Nome);
        }
    }
}
