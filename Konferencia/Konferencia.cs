using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Konferencia
{
    class Konferencia
    {
        List<Eloadas> eloadasok = new List<Eloadas>();

        internal List<Eloadas> Eloadasok { get => eloadasok; }

        public Konferencia(string filenev)
        {
            using (StreamReader sr = new StreamReader(filenev))
            {
                while (!sr.EndOfStream)
                {
                    string cim = sr.ReadLine();
                    string[] sor = sr.ReadLine().Split(';');
                    int sorDb = int.Parse(sor[0]);
                    int helyDb = int.Parse(sor[1]);
                    int[,] ertekeles = new int[sorDb, helyDb];
                    for (int i = 0; i < sorDb; i++)
                    {
                        sor = sr.ReadLine().Split(';');
                        int j = 0;
                        foreach (string item in sor)
                        {
                            ertekeles[i, j++] = int.Parse(item);
                        }
                    }
                    sr.ReadLine();
                    Eloadasok.Add(new Eloadas(cim, sorDb, helyDb, ertekeles));
                }
            }
        }
    }
}
