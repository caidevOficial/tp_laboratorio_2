
namespace TP_01_FacundoFalcone
{
    partial class FormCalculadora
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.grpLogo = new System.Windows.Forms.GroupBox();
            this.grpOperadores = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.grpConvert = new System.Windows.Forms.GroupBox();
            this.grpLogoEsferas = new System.Windows.Forms.GroupBox();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblVersionApp = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.playerControlIcons = new System.Windows.Forms.ImageList(this.components);
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.grpOperadores.SuspendLayout();
            this.grpConvert.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogo
            // 
            this.grpLogo.BackColor = System.Drawing.Color.Transparent;
            this.grpLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpLogo.BackgroundImage")));
            this.grpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpLogo.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpLogo.Location = new System.Drawing.Point(14, 12);
            this.grpLogo.Name = "grpLogo";
            this.grpLogo.Size = new System.Drawing.Size(250, 85);
            this.grpLogo.TabIndex = 0;
            this.grpLogo.TabStop = false;
            this.grpLogo.Text = "Logo";
            // 
            // grpOperadores
            // 
            this.grpOperadores.BackColor = System.Drawing.Color.Transparent;
            this.grpOperadores.Controls.Add(this.btnCerrar);
            this.grpOperadores.Controls.Add(this.btnLimpiar);
            this.grpOperadores.Controls.Add(this.btnOperar);
            this.grpOperadores.Controls.Add(this.cmbOperador);
            this.grpOperadores.Controls.Add(this.txtNumero2);
            this.grpOperadores.Controls.Add(this.txtNumero1);
            this.grpOperadores.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpOperadores.Location = new System.Drawing.Point(15, 169);
            this.grpOperadores.Name = "grpOperadores";
            this.grpOperadores.Size = new System.Drawing.Size(605, 154);
            this.grpOperadores.TabIndex = 0;
            this.grpOperadores.TabStop = false;
            this.grpOperadores.Text = "Main Buttons";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(233, 105);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(134, 42);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLimpiar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(465, 104);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(134, 42);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOperar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnOperar.Image = ((System.Drawing.Image)(resources.GetObject("btnOperar.Image")));
            this.btnOperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperar.Location = new System.Drawing.Point(6, 104);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOperar.Size = new System.Drawing.Size(134, 42);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOperador.BackColor = System.Drawing.Color.DarkBlue;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "-",
            "*",
            "/",
            "+"});
            this.cmbOperador.Location = new System.Drawing.Point(246, 30);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(110, 63);
            this.cmbOperador.Sorted = true;
            this.cmbOperador.TabIndex = 1;
            this.cmbOperador.Text = "-";
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.DarkBlue;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNumero2.Location = new System.Drawing.Point(502, 30);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(97, 62);
            this.txtNumero2.TabIndex = 2;
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.Color.DarkBlue;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNumero1.Location = new System.Drawing.Point(6, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(97, 62);
            this.txtNumero1.TabIndex = 0;
            // 
            // grpConvert
            // 
            this.grpConvert.BackColor = System.Drawing.Color.Transparent;
            this.grpConvert.Controls.Add(this.grpLogoEsferas);
            this.grpConvert.Controls.Add(this.btnConvertirABinario);
            this.grpConvert.Controls.Add(this.btnConvertirADecimal);
            this.grpConvert.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpConvert.Location = new System.Drawing.Point(15, 326);
            this.grpConvert.Name = "grpConvert";
            this.grpConvert.Size = new System.Drawing.Size(605, 119);
            this.grpConvert.TabIndex = 0;
            this.grpConvert.TabStop = false;
            this.grpConvert.Text = "Convert Buttons";
            // 
            // grpLogoEsferas
            // 
            this.grpLogoEsferas.BackColor = System.Drawing.Color.Transparent;
            this.grpLogoEsferas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpLogoEsferas.BackgroundImage")));
            this.grpLogoEsferas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpLogoEsferas.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpLogoEsferas.Location = new System.Drawing.Point(225, 19);
            this.grpLogoEsferas.Name = "grpLogoEsferas";
            this.grpLogoEsferas.Size = new System.Drawing.Size(158, 94);
            this.grpLogoEsferas.TabIndex = 0;
            this.grpLogoEsferas.TabStop = false;
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConvertirABinario.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirABinario.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnConvertirABinario.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertirABinario.Image")));
            this.btnConvertirABinario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertirABinario.Location = new System.Drawing.Point(7, 19);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(196, 94);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = false;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.BackColor = System.Drawing.Color.OrangeRed;
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirADecimal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnConvertirADecimal.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertirADecimal.Image")));
            this.btnConvertirADecimal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(403, 19);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(196, 94);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = false;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.BackColor = System.Drawing.Color.Transparent;
            this.grpResultado.Controls.Add(this.lblResultado);
            this.grpResultado.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpResultado.Location = new System.Drawing.Point(270, 12);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(350, 85);
            this.grpResultado.TabIndex = 0;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Display";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.OrangeRed;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResultado.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResultado.Location = new System.Drawing.Point(6, 28);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(330, 37);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Become a Hero!";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersionApp
            // 
            this.lblVersionApp.BackColor = System.Drawing.Color.OrangeRed;
            this.lblVersionApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionApp.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVersionApp.Image = ((System.Drawing.Image)(resources.GetObject("lblVersionApp.Image")));
            this.lblVersionApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVersionApp.Location = new System.Drawing.Point(432, 444);
            this.lblVersionApp.Name = "lblVersionApp";
            this.lblVersionApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersionApp.Size = new System.Drawing.Size(161, 30);
            this.lblVersionApp.TabIndex = 8;
            this.lblVersionApp.Text = "Version: 2.5.0.2";
            this.lblVersionApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.AutoSize = true;
            this.btnPlayPause.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ImageKey = "pause_icon.png";
            this.btnPlayPause.ImageList = this.playerControlIcons;
            this.btnPlayPause.Location = new System.Drawing.Point(16, 14);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(40, 40);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // playerControlIcons
            // 
            this.playerControlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playerControlIcons.ImageStream")));
            this.playerControlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.playerControlIcons.Images.SetKeyName(0, "pause_icon.png");
            this.playerControlIcons.Images.SetKeyName(1, "play_icon.png");
            // 
            // grpPlayer
            // 
            this.grpPlayer.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayer.Controls.Add(this.btnPlayPause);
            this.grpPlayer.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpPlayer.Location = new System.Drawing.Point(15, 103);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(73, 63);
            this.grpPlayer.TabIndex = 9;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Mini Player";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 475);
            this.Controls.Add(this.grpPlayer);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpConvert);
            this.Controls.Add(this.grpOperadores);
            this.Controls.Add(this.grpLogo);
            this.Controls.Add(this.lblVersionApp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Facu Falcone - 2°D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.grpOperadores.ResumeLayout(false);
            this.grpOperadores.PerformLayout();
            this.grpConvert.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogo;
        private System.Windows.Forms.GroupBox grpOperadores;
        private System.Windows.Forms.GroupBox grpConvert;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblVersionApp;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.ImageList playerControlIcons;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.GroupBox grpLogoEsferas;
    }
}

