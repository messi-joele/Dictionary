using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Importo
    {
        public int soldo;
        public Importo(int soldo)
        {
            Soldo = soldo;
            
        }

       

        public int Soldo
        {
            get { return soldo; }
            set { soldo = value; }
        }
        public override int GetHashCode() => (soldo).GetHashCode();
        public bool Equals(Importo p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.soldo == p.soldo);
        }
    }

}
