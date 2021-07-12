
namespace FactoryForms {
    partial class frmJoke {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJoke));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbHorseImage = new System.Windows.Forms.PictureBox();
            this.tmrFade_In = new System.Windows.Forms.Timer(this.components);
            this.tmrFade_Out = new System.Windows.Forms.Timer(this.components);
            this.lblMessage01 = new System.Windows.Forms.Label();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorseImage)).BeginInit();
            this.pnlButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.pbHorseImage);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(486, 278);
            this.pnlTop.TabIndex = 0;
            // 
            // pbHorseImage
            // 
            this.pbHorseImage.BackColor = System.Drawing.Color.Transparent;
            this.pbHorseImage.BackgroundImage = global::FactoryForms.Properties.Resources.Horse;
            this.pbHorseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHorseImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHorseImage.Location = new System.Drawing.Point(0, 0);
            this.pbHorseImage.Name = "pbHorseImage";
            this.pbHorseImage.Size = new System.Drawing.Size(486, 278);
            this.pbHorseImage.TabIndex = 0;
            this.pbHorseImage.TabStop = false;
            // 
            // tmrFade_In
            // 
            this.tmrFade_In.Interval = 70;
            this.tmrFade_In.Tick += new System.EventHandler(this.tmrFade_In_Tick);
            // 
            // tmrFade_Out
            // 
            this.tmrFade_Out.Interval = 70;
            this.tmrFade_Out.Tick += new System.EventHandler(this.tmrFade_Out_Tick);
            // 
            // lblMessage01
            // 
            this.lblMessage01.AutoSize = true;
            this.lblMessage01.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage01.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMessage01.Location = new System.Drawing.Point(53, 24);
            this.lblMessage01.Name = "lblMessage01";
            this.lblMessage01.Size = new System.Drawing.Size(392, 66);
            this.lblMessage01.TabIndex = 0;
            this.lblMessage01.Text = "Si llegaste hasta aca...\r\nRelajate con este caballito.";
            this.lblMessage01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlButtom.Controls.Add(this.lblMessage01);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtom.Location = new System.Drawing.Point(0, 278);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(486, 115);
            this.pnlButtom.TabIndex = 1;
            // 
            // frmJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(486, 393);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJoke_FormClosing);
            this.Load += new System.EventHandler(this.frmJoke_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHorseImage)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbHorseImage;
        private System.Windows.Forms.Timer tmrFade_In;
        private System.Windows.Forms.Timer tmrFade_Out;
        private System.Windows.Forms.Label lblMessage01;
        private System.Windows.Forms.Panel pnlButtom;
    }
}