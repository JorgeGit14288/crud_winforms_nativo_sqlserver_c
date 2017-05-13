namespace Tutorial
{
    partial class visorReporte
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
            this.crvPersona = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPersona
            // 
            this.crvPersona.ActiveViewIndex = -1;
            this.crvPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPersona.CachedPageNumberPerDoc = 10;
            this.crvPersona.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPersona.Location = new System.Drawing.Point(0, 0);
            this.crvPersona.Name = "crvPersona";
            this.crvPersona.Size = new System.Drawing.Size(415, 313);
            this.crvPersona.TabIndex = 0;
            // 
            // visorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 313);
            this.Controls.Add(this.crvPersona);
            this.Name = "visorReporte";
            this.Text = "visorReporte";
            this.Load += new System.EventHandler(this.visorReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPersona;
    }
}