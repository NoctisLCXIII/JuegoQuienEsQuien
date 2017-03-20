using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienEsQuien
{
    public partial class Points : Form
    {
        public Points(string lenguaje)
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lenguaje);
            using (StreamReader sr = File.OpenText("HistorialPartidas.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    rtbPoints.Text += s + "\n";
                }
            }
        }


    }
}
