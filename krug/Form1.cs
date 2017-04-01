using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krug
{
    public partial class Form1 : Form
    {
        private int visina = 25;
        public int duzina = 25;
        private int precnik = 10;
        private char[,] matrica;
        private int r = 0;
        private bool unapred = true;
        private int testic = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        public void asdf()
        {
           
            for (int u = 0; u <= 360; u++)
            {
                int x = (int)(r *Math.Sin(Math.PI * u / 180.0));
                int y = (int) (r*Math.Cos(Math.PI*u/180.0));
                matrica[x+visina/2, y+duzina/2] = 'X';
            }
            printMatra();
                
            matra();
            if(unapred && r < precnik)
                r++;
            else if (r > 0)
            {
                r--;
                unapred = false;
            }
               
            else
            {
                r++;
                unapred = true;
            }

        }

        public void matra()
        {
            matrica = new char[visina,duzina];
            for (int i = 0; i<visina; i++)
                for (int j = 0; j < duzina; j++)
                    matrica[i, j] = '.';
        }

        public void printMatra()
        {
            tb.Text = "";
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < duzina; j++)
                    tb.Text += matrica[i, j]+" ";
                tb.Text += "\r\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            matra();
            asdf();
        }
    }
}
