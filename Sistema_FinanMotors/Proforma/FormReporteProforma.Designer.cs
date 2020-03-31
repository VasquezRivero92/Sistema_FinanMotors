namespace Sistema_FinanMotors
{
    partial class FormReporteProforma
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
            this.crv_proforma = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_proforma
            // 
            this.crv_proforma.ActiveViewIndex = -1;
            this.crv_proforma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_proforma.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_proforma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_proforma.Location = new System.Drawing.Point(0, 0);
            this.crv_proforma.Name = "crv_proforma";
            this.crv_proforma.Size = new System.Drawing.Size(800, 450);
            this.crv_proforma.TabIndex = 0;
            // 
            // FormReporteProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_proforma);
            this.Name = "FormReporteProforma";
            this.Text = "FormReporteProforma";
            this.Load += new System.EventHandler(this.FormReporteProforma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_proforma;
    }
}