
namespace TestesWindowsForms.Frm
{
    partial class FrmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.stripPrincipal = new System.Windows.Forms.ToolStrip();
            this.barBtnMostrar = new System.Windows.Forms.ToolStripButton();
            this.barBtnApagar = new System.Windows.Forms.ToolStripButton();
            this.lstPrincipal = new System.Windows.Forms.ListBox();
            this.stripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripPrincipal
            // 
            this.stripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barBtnMostrar,
            this.barBtnApagar});
            this.stripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.stripPrincipal.Name = "stripPrincipal";
            this.stripPrincipal.Size = new System.Drawing.Size(411, 25);
            this.stripPrincipal.TabIndex = 0;
            this.stripPrincipal.Text = "toolStrip1";
            // 
            // barBtnMostrar
            // 
            this.barBtnMostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("barBtnMostrar.Image")));
            this.barBtnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnMostrar.Name = "barBtnMostrar";
            this.barBtnMostrar.Size = new System.Drawing.Size(23, 22);
            this.barBtnMostrar.Text = "toolStripButton1";
            this.barBtnMostrar.Click += new System.EventHandler(this.barBtnMostrar_Click);
            // 
            // barBtnApagar
            // 
            this.barBtnApagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnApagar.Image = ((System.Drawing.Image)(resources.GetObject("barBtnApagar.Image")));
            this.barBtnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnApagar.Name = "barBtnApagar";
            this.barBtnApagar.Size = new System.Drawing.Size(23, 22);
            this.barBtnApagar.Text = "toolStripButton2";
            this.barBtnApagar.Click += new System.EventHandler(this.barBtnApagar_Click);
            // 
            // lstPrincipal
            // 
            this.lstPrincipal.FormattingEnabled = true;
            this.lstPrincipal.Location = new System.Drawing.Point(12, 57);
            this.lstPrincipal.Name = "lstPrincipal";
            this.lstPrincipal.Size = new System.Drawing.Size(387, 303);
            this.lstPrincipal.TabIndex = 1;
            this.lstPrincipal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPrincipal_MouseDoubleClick);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 373);
            this.Controls.Add(this.lstPrincipal);
            this.Controls.Add(this.stripPrincipal);
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.stripPrincipal.ResumeLayout(false);
            this.stripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip stripPrincipal;
        private System.Windows.Forms.ToolStripButton barBtnMostrar;
        private System.Windows.Forms.ToolStripButton barBtnApagar;
        private System.Windows.Forms.ListBox lstPrincipal;
    }
}