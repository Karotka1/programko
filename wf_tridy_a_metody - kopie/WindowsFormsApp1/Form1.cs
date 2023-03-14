using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        //deklarace objektu třídy operace
        Operace operace = new Operace();
        public Form1()
        {
            InitializeComponent();
        }

        private void BPlus_Click(object sender, EventArgs e)
        {
            try
            {
                //Vytažení godnoty z textbox
                double vstup = Convert.ToDouble(TBVstup.Text);

                operace.cislo1 = vstup;
                TBVstup.Text = "";

                operace.Scitani();

                LVystup.Text = Convert.ToString(operace.vysledek);

                operace.pomocna = operace.vysledek;
            }
            catch (FormatException Err) 
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void BMinus_Click(object sender, EventArgs e)
        {
            try
            {
                //Vytažení godnoty z textbox
                double vstup = Convert.ToDouble(TBVstup.Text);

                operace.cislo1 = vstup;
                TBVstup.Text = "";
                if (operace.cislo1 < 0)
                {
                    operace.cislo1 = operace.cislo1 * (-1);
                }
                operace.Odcitani();

                LVystup.Text = Convert.ToString(operace.vysledek);
                operace.pomocna = operace.vysledek;
            }
            catch (FormatException Err) 
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void BKrat_Click(object sender, EventArgs e)
        {
            try
            {
                double vstup = Convert.ToDouble(TBVstup.Text);
                TBVstup.Text = "";
                if (operace.pomocna != 0)
                {
                    operace.cislo2 = vstup;
                    operace.cislo1 = operace.pomocna;
                    operace.Nasobeni();
                    LVystup.Text = Convert.ToString(operace.vysledek);
                    operace.pomocna = operace.vysledek;
                }
                else
                {
                    operace.cislo1 = vstup;
                    operace.pomocna = vstup;
                }
            }
            catch (FormatException Err) 
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void BDeleno_Click(object sender, EventArgs e)
        {
            try
            {
                //Zapisuje do proměnné vstup hodnoty z TBVstup
                double vstup = Convert.ToDouble(TBVstup.Text);

                if (operace.pomocna != 0)
                {
                    operace.cislo2 = vstup;
                    if (operace.cislo2 != 0)
                    {
                        operace.cislo1 = operace.pomocna;
                        operace.Deleni();
                        LVystup.Text = Convert.ToString(operace.vysledek);
                        operace.pomocna = operace.vysledek;
                    }
                    else
                    {

                        //throw new Exception();
                    }
                }
                else
                {
                    operace.cislo1 = vstup;
                    operace.pomocna = vstup;
                }

                TBVstup.Text = "";
            }
            catch (FormatException Err) 
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TBVstup.Text = "";
            LVystup.Text = "";
            operace.vysledek = 0;
            operace.cislo1 = 0;
            operace.cislo2 = 0;
            operace.pomocna = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LVystup.Text = "";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 1;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 2;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 3;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 4;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 5;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 6;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 7;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 8;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 9;
        }

        private void B0_Click(object sender, EventArgs e)
        {
            TBVstup.Text += 0;
        }
    }
}
        
    
    class Operace
    {
        public double cislo1, cislo2, pomocna, vysledek;

        public void Scitani()
        {
            vysledek = cislo1 + vysledek;
        }
        public void Odcitani()
        {
            if (pomocna == 0)
            {
                cislo1 = cislo1 * -1;
            }

            vysledek = vysledek - cislo1;
        }
        public void Nasobeni()
        {
            vysledek = cislo1 * cislo2;
        }
        public void Deleni()
        {
            vysledek = cislo1 / cislo2;
        }

    }

