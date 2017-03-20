namespace QuienEsQuien
{
    partial class Points
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Points));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeadPoints = new System.Windows.Forms.Label();
            this.rtbPoints = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lblHeadPoints);
            this.panel1.Name = "panel1";
            // 
            // lblHeadPoints
            // 
            resources.ApplyResources(this.lblHeadPoints, "lblHeadPoints");
            this.lblHeadPoints.BackColor = System.Drawing.Color.YellowGreen;
            this.lblHeadPoints.Name = "lblHeadPoints";
            // 
            // rtbPoints
            // 
            resources.ApplyResources(this.rtbPoints, "rtbPoints");
            this.rtbPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPoints.Name = "rtbPoints";
            this.rtbPoints.ReadOnly = true;
            // 
            // Points
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbPoints);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Points";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeadPoints;
        private System.Windows.Forms.RichTextBox rtbPoints;
    }
}