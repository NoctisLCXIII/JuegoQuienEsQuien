using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienEsQuien
{
    public partial class version : Form
    {
        public version(string lenguaje)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lenguaje);
            Controls.Clear();
            InitializeComponent();
            Console.WriteLine(lenguaje);
        }

        private void btnOkVersion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
