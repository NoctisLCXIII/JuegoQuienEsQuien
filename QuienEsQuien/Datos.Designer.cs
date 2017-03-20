namespace QuienEsQuien
{
    partial class Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.lblAgePlayer = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataPlayer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblNamePlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAgePlayer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbAge, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblNamePlayer
            // 
            resources.ApplyResources(this.lblNamePlayer, "lblNamePlayer");
            this.lblNamePlayer.Name = "lblNamePlayer";
            // 
            // lblAgePlayer
            // 
            resources.ApplyResources(this.lblAgePlayer, "lblAgePlayer");
            this.lblAgePlayer.Name = "lblAgePlayer";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbAge
            // 
            resources.ApplyResources(this.tbAge, "tbAge");
            this.tbAge.Name = "tbAge";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lblDataPlayer);
            this.panel1.Name = "panel1";
            // 
            // lblDataPlayer
            // 
            resources.ApplyResources(this.lblDataPlayer, "lblDataPlayer");
            this.lblDataPlayer.Name = "lblDataPlayer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStart);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Data
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Data";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label lblAgePlayer;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataPlayer;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnStart;
    }
}