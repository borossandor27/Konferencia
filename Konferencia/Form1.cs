using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Konferencia
{
    public partial class Form1 : Form
    {
        Konferencia konferencia = new Konferencia(@"..\..\konferencia.txt");
        int EloadasSzam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formot_Frissit();
        }

        void Formot_Frissit()
        {
            if (konferencia.Eloadasok.Count==EloadasSzam)
            {
                EloadasSzam = 0;
            }
            if (EloadasSzam < 0)
            {
                EloadasSzam = konferencia.Eloadasok.Count - 1;
            }
            string iro = konferencia.Eloadasok[EloadasSzam].Cim.Split()[0];
            pictureBox_iro.Image = Image.FromFile(filename: @"..\..\Kepek\" + iro + ".jpg");
            this.Text = konferencia.Eloadasok[EloadasSzam].Cim;
            tableLayoutPanel_Ertekelesek.Controls.Clear();
            tableLayoutPanel_Ertekelesek.RowStyles.Clear();
            tableLayoutPanel_Ertekelesek.RowCount = konferencia.Eloadasok[EloadasSzam].SorDb;
            tableLayoutPanel_Ertekelesek.ColumnCount = konferencia.Eloadasok[EloadasSzam].HelyDb;
            for (int i = 0; i < konferencia.Eloadasok[EloadasSzam].SorDb; i++)
            {
                for (int j = 0; j < konferencia.Eloadasok[EloadasSzam].HelyDb; j++)
                {
                    Button gomb = new Button();
                    gomb.FlatStyle = FlatStyle.Flat;
                    gomb.FlatAppearance.BorderSize = 0;
                    gomb.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    gomb.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    gomb.BackColor = Color.Transparent;
                    gomb.BackgroundImageLayout = ImageLayout.Stretch;
                    gomb.BackgroundImage = Image.FromFile(filename: @"..\..\Kepek\Pont" + konferencia.Eloadasok[EloadasSzam].Ertekeles[i, j] + ".jpg");
                    gomb.Tag = string.Join(";", konferencia.Eloadasok[EloadasSzam].Ertekeles[i, j], i, j);
                    gomb.Height = 40;
                    gomb.Width = 40;
                    gomb.Click += new EventHandler(button_Ertekeles_Click);
                    tableLayoutPanel_Ertekelesek.Controls.Add(gomb, j, i);
                }
            }

        }

        private void button_jobbra_Click(object sender, EventArgs e)
        {
            EloadasSzam++;
            Formot_Frissit();
        }

        private void button_Balra_Click(object sender, EventArgs e)
        {
            EloadasSzam--;
            Formot_Frissit();
        }
        private void button_Ertekeles_Click(object sender, EventArgs e)
        {
            Button gomb = (Button)sender;
            string[] a = gomb.Tag.ToString().Split(';');
            int sor = int.Parse(a[1]);
            int hely = int.Parse(a[2]);
            switch (a[0])
            {
                case "0":
                    MessageBox.Show("Az adott helyen nem ült senki!");
                    break;
                case "1":
                    konferencia.Eloadasok[EloadasSzam].Ertekeles[sor, hely] = 2;
                    break;
                case "2":
                    konferencia.Eloadasok[EloadasSzam].Ertekeles[sor, hely] = 3;
                    break;
                case "3":
                    konferencia.Eloadasok[EloadasSzam].Ertekeles[sor, hely] = 1;
                    break;
                default:
                    break;
            }
            Formot_Frissit();
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            File.Copy(@"..\..\konferencia.txt", @"..\..\konferencia.bak", true);
            try
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\konferencia.txt"))
                {
                    foreach (Eloadas item in konferencia.Eloadasok)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
