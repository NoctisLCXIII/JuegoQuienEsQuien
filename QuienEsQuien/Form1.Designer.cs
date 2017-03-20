namespace QuienEsQuien
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnlPoints = new System.Windows.Forms.TableLayoutPanel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointsNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSelec = new System.Windows.Forms.PictureBox();
            this.lblElection = new System.Windows.Forms.Label();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlImages = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnMain.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPoints.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.BackColor = System.Drawing.Color.SeaShell;
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivo,
            this.mnAyuda,
            this.idiomaToolStripMenuItem});
            resources.ApplyResources(this.mnMain, "mnMain");
            this.mnMain.Name = "mnMain";
            // 
            // mnArchivo
            // 
            this.mnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNewGame,
            this.salirToolStripMenuItem});
            this.mnArchivo.Name = "mnArchivo";
            resources.ApplyResources(this.mnArchivo, "mnArchivo");
            // 
            // mnNewGame
            // 
            this.mnNewGame.Name = "mnNewGame";
            resources.ApplyResources(this.mnNewGame, "mnNewGame");
            this.mnNewGame.Click += new System.EventHandler(this.mnNewGame_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnAyuda
            // 
            this.mnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnVersion});
            this.mnAyuda.Name = "mnAyuda";
            resources.ApplyResources(this.mnAyuda, "mnAyuda");
            // 
            // mnVersion
            // 
            this.mnVersion.Name = "mnVersion";
            resources.ApplyResources(this.mnVersion, "mnVersion");
            this.mnVersion.Click += new System.EventHandler(this.mnVersion_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglésToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            resources.ApplyResources(this.idiomaToolStripMenuItem, "idiomaToolStripMenuItem");
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            resources.ApplyResources(this.españolToolStripMenuItem, "españolToolStripMenuItem");
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            resources.ApplyResources(this.inglésToolStripMenuItem, "inglésToolStripMenuItem");
            this.inglésToolStripMenuItem.Click += new System.EventHandler(this.inglésToolStripMenuItem_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlBoard.Controls.Add(this.panel2);
            this.pnlBoard.Controls.Add(this.pnlPoints);
            this.pnlBoard.Controls.Add(this.pnlImages);
            resources.ApplyResources(this.pnlBoard, "pnlBoard");
            this.pnlBoard.Name = "pnlBoard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPlayer);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblPlayer
            // 
            resources.ApplyResources(this.lblPlayer, "lblPlayer");
            this.lblPlayer.Name = "lblPlayer";
            // 
            // pnlPoints
            // 
            resources.ApplyResources(this.pnlPoints, "pnlPoints");
            this.pnlPoints.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlPoints.Controls.Add(this.lblPoints, 0, 0);
            this.pnlPoints.Controls.Add(this.lblPointsNumber, 0, 1);
            this.pnlPoints.Controls.Add(this.panel1, 0, 3);
            this.pnlPoints.Controls.Add(this.lblElection, 0, 2);
            this.pnlPoints.Controls.Add(this.pbDelete, 0, 4);
            this.pnlPoints.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.pnlPoints.Name = "pnlPoints";
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.ForeColor = System.Drawing.Color.Chocolate;
            this.lblPoints.Name = "lblPoints";
            // 
            // lblPointsNumber
            // 
            resources.ApplyResources(this.lblPointsNumber, "lblPointsNumber");
            this.lblPointsNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblPointsNumber.Name = "lblPointsNumber";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pbSelec);
            this.panel1.Name = "panel1";
            // 
            // pbSelec
            // 
            resources.ApplyResources(this.pbSelec, "pbSelec");
            this.pbSelec.Image = global::QuienEsQuien.Properties.Resources.tick;
            this.pbSelec.Name = "pbSelec";
            this.pbSelec.TabStop = false;
            this.pbSelec.Click += new System.EventHandler(this.pbSelec_Click);
            // 
            // lblElection
            // 
            resources.ApplyResources(this.lblElection, "lblElection");
            this.lblElection.Name = "lblElection";
            // 
            // pbDelete
            // 
            resources.ApplyResources(this.pbDelete, "pbDelete");
            this.pbDelete.Image = global::QuienEsQuien.Properties.Resources.delete;
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btnFinish);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnFinish
            // 
            resources.ApplyResources(this.btnFinish, "btnFinish");
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlImages
            // 
            resources.ApplyResources(this.pnlImages, "pnlImages");
            this.pnlImages.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlImages.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlImages.Name = "pnlImages";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.pnlBoard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPoints.ResumeLayout(false);
            this.pnlPoints.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnNewGame;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnVersion;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.TableLayoutPanel pnlPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointsNumber;
        private System.Windows.Forms.TableLayoutPanel pnlImages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSelec;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.Label lblElection;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPlayer;
    }
}

