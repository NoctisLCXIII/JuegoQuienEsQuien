namespace QuienEsQuien
{
    partial class version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(version));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.gbLicencia = new System.Windows.Forms.GroupBox();
            this.rtbLicencia = new System.Windows.Forms.RichTextBox();
            this.btnOkVersion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbLicencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNameProgram, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Name = "label3";
            // 
            // lblNameProgram
            // 
            resources.ApplyResources(this.lblNameProgram, "lblNameProgram");
            this.lblNameProgram.Name = "lblNameProgram";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.lblAuthor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthorName, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.Name = "lblAuthor";
            // 
            // lblAuthorName
            // 
            resources.ApplyResources(this.lblAuthorName, "lblAuthorName");
            this.lblAuthorName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAuthorName.Name = "lblAuthorName";
            // 
            // gbLicencia
            // 
            resources.ApplyResources(this.gbLicencia, "gbLicencia");
            this.gbLicencia.Controls.Add(this.rtbLicencia);
            this.gbLicencia.Name = "gbLicencia";
            this.gbLicencia.TabStop = false;
            // 
            // rtbLicencia
            // 
            resources.ApplyResources(this.rtbLicencia, "rtbLicencia");
            this.rtbLicencia.Name = "rtbLicencia";
            // 
            // btnOkVersion
            // 
            resources.ApplyResources(this.btnOkVersion, "btnOkVersion");
            this.btnOkVersion.Name = "btnOkVersion";
            this.btnOkVersion.UseVisualStyleBackColor = true;
            this.btnOkVersion.Click += new System.EventHandler(this.btnOkVersion_Click);
            // 
            // version
            // 
            this.AcceptButton = this.btnOkVersion;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOkVersion);
            this.Controls.Add(this.gbLicencia);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "version";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbLicencia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNameProgram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.GroupBox gbLicencia;
        private System.Windows.Forms.RichTextBox rtbLicencia;
        private System.Windows.Forms.Button btnOkVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}