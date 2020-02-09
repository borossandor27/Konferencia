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
            string sorveg = "\n";
            string vissza = this.cim + sorveg;
            vissza += sorDb + ";" + helyDb + sorveg;
            for (int i = 0; i < sorDb; i++)
            {
                for (int j = 0; j < HelyDb; j++)
                {
                    vissza += ertekeles[i, j] + ";";

                }
                vissza = vissza.Substring(0, vissza.Length - 1) + sorveg;
            }
            vissza += sorveg;
            return vissza;
        }
    }
}
