using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konferencia
{
    class Eloadas
    {
        string cim;
        int sorDb;
        int helyDb;
        int[,] ertekeles;

        public string Cim { get => cim; }
        public int SorDb { get => sorDb; }
        public int HelyDb { get => helyDb; }
        public int[,] Ertekeles { get => ertekeles;  }

        public Eloadas(string cim, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.cim = cim;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }

        public override string ToString()
        {
            string vissza = this.cim;
            vissza += sorDb + ";" + helyDb;
            vissza += string.Join(";", ertekeles);
            vissza += "\n";
            return vissza;
        }
    }
}
