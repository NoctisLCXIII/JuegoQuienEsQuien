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
    public partial class Form1 : Form
    {
        string lenguaje = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
        int puntos = 10000;
        string nombre;
        int edad;
        Data data;
        int k = 1;
        Boolean hayElegido = false;
       
        List<string> nombres = new List<string>() { " ", "Ana", "Julián", "Gema", "Patricia", "Silvia", "Sara", "Andrea", "Aitor", "Darío", "Nerea", "María", "Rafa", "Paloma", "Alicia", "Esther", "José", "Paula", "Laura", "Victoria", "Alba" };
        public Form1()
        {


            InitializeComponent();
            btnFinish.Enabled = false;
            CaragarFondoFuturama();
            data = new Data(this);
            data.Activate();
            data.ShowDialog();
            lblPlayer.Text += " " + nombre;

        }


        public void ejecutaMetodo()
        {

            if (String.IsNullOrWhiteSpace(data.tbName.Text))
            {
                MessageBox.Show(Properties.Resources.msgValor);
            }
            else if ((String.IsNullOrWhiteSpace(data.tbAge.Text)))
            {
                MessageBox.Show(Properties.Resources.msgValor);
            }
            else
            {
                nombre = data.tbName.Text;
                edad = int.Parse(data.tbAge.Text);
                data.Dispose();
            }
        }

        private void CaragarFondoFuturama()
        {
            for (int j = 0; j < this.pnlImages.RowCount; j++)
            {
                for (int h = 0; h < this.pnlImages.ColumnCount; h++)
                {
                    Avatar.avatar_juego av = new Avatar.avatar_juego();
                    av.setImage(Properties.Resources.futurama);
                    av.getLabel().SendToBack();
                    av.Parent = pnlImages;
                    pnlImages.Controls.Add(av);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void cargarImagenes()

        {
            pnlImages.Controls.Clear();

            for (int j = 0; j < this.pnlImages.RowCount; j++)
            {
                for (int h = 0; h < this.pnlImages.ColumnCount; h++)
                {
                    Avatar.avatar_juego av = new Avatar.avatar_juego();
                    string ruta = "img" + k;
                    Bitmap img = (Bitmap)QuienEsQuien.Properties.Resources.ResourceManager.GetObject(ruta);
                    av.setImage(img);
                    av.setName(nombres[k]);


                    pnlImages.Controls.Add(av);
                    av.getPictureBox().Click += new EventHandler(this.clickEnFoto);
                    k++;
                }
            }
            k = 1;


        }

        private void clickEnFoto(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Avatar.avatar_juego uc = (Avatar.avatar_juego)pb.Parent;

            if (uc.getActive() == true)
            {
                uc.setActive(false);
            }
            else
            {
                uc.setActive(true);

            }


        }


        private void mnNewGame_Click(object sender, EventArgs e)
        {
            cargarImagenes();

        }

        private void mnVersion_Click(object sender, EventArgs e)
        {
            lenguaje = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            version version = new version(lenguaje);

            version.Show();
        }





        private void pbSelec_Click(object sender, EventArgs e)
        {
            int b = 0;
            Avatar.avatar_juego avatarElegido = new Avatar.avatar_juego();
            foreach (var control in pnlImages.Controls.Cast<Control>().ToArray())
            {
                if (control is Avatar.avatar_juego)
                {
                    if (((Avatar.avatar_juego)control).getActive() == true)
                    {
                        b = b + 1;
                        if (b > 1)
                        {
                            MessageBox.Show(Properties.Resources.msgElegir1,Properties.Resources.msgHeadElegir1);
                            break;
                        }
                        else
                        if (b == 1)
                        {
                            hayElegido = true;
                            btnFinish.Enabled = true;
                            avatarElegido = ((Avatar.avatar_juego)control);
                        }


                    }
                }

            }
            if (b == 1)
            {
                pbSelec.Image = null;
                avatarElegido.Parent = panel1;
                panel1.Size = new Size(100, 131);
                avatarElegido.Dock = DockStyle.Fill;
                avatarElegido.BringToFront();
                cargarImagenes();
            }
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
            Controls.Clear();
            InitializeComponent();
            CaragarFondoFuturama();

        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            Controls.Clear();
            InitializeComponent();
            CaragarFondoFuturama();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(QuienEsQuien.Properties.Resources.msgExit,
                         QuienEsQuien.Properties.Resources.msgHeadExit,
                          MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Dispose();
             
            }
        }

    

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (hayElegido == false)
            {
                MessageBox.Show(Properties.Resources.msgElegirJugador, Properties.Resources.msgHeadElegir1);
            } else { 
            foreach (var control in pnlImages.Controls.Cast<Control>().ToArray())
            {
                if (control is Avatar.avatar_juego)
                {
                    if (((Avatar.avatar_juego)control).getActive() == true)
                    {
                        DialogResult dr = MessageBox.Show(QuienEsQuien.Properties.Resources.msgDescartar + ((Avatar.avatar_juego)control).getNameAvatar() + "?",
                        QuienEsQuien.Properties.Resources.headDescartar,
                         MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            control.Dispose();
                            puntos = int.Parse(lblPointsNumber.Text) - 500;

                            lblPointsNumber.Text = Convert.ToString(puntos);
                        }

                    }
                }
            }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Points formPunt = new Points(lenguaje);
            formPunt.Show();
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("HistorialPartidas.txt"))
            {
                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter("HistorialPartidas.txt"))
                {

                }
            }
            else
            {
                using (System.IO.StreamWriter sw = File.AppendText("HistorialPartidas.txt"))
                {
                    sw.WriteLine("Nombre: " + nombre);
                    sw.WriteLine("Edad: " + edad);
                    sw.WriteLine("Puntuación: " + puntos);
                    sw.WriteLine("-----------------------");
                }
                
            }
            this.Dispose();
        }
    }


}
