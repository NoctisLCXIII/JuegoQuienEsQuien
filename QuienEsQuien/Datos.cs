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
    public partial class Data : Form
    {
        Form1 f1;
        public Data(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            f1.ejecutaMetodo();
        }
    }
    }

