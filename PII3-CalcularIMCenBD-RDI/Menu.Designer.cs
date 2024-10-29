namespace PII3_CalcularIMCenBD_RDI
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.btnCalcularM = new System.Windows.Forms.Button();
            this.btnHistorialM = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbxNombreM = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.tbxUsuarioM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEdadM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularM
            // 
            this.btnCalcularM.Location = new System.Drawing.Point(97, 352);
            this.btnCalcularM.Name = "btnCalcularM";
            this.btnCalcularM.Size = new System.Drawing.Size(93, 48);
            this.btnCalcularM.TabIndex = 67;
            this.btnCalcularM.Text = "Calcular IMC";
            this.btnCalcularM.UseVisualStyleBackColor = true;
            this.btnCalcularM.Click += new System.EventHandler(this.btnCalcularM_Click);
            // 
            // btnHistorialM
            // 
            this.btnHistorialM.Location = new System.Drawing.Point(253, 352);
            this.btnHistorialM.Name = "btnHistorialM";
            this.btnHistorialM.Size = new System.Drawing.Size(104, 48);
            this.btnHistorialM.TabIndex = 66;
            this.btnHistorialM.Text = "Historial IMC";
            this.btnHistorialM.UseVisualStyleBackColor = true;
            this.btnHistorialM.Click += new System.EventHandler(this.btnHistorialM_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(644, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 48);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbxNombreM
            // 
            this.tbxNombreM.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreM.Location = new System.Drawing.Point(284, 64);
            this.tbxNombreM.Name = "tbxNombreM";
            this.tbxNombreM.Size = new System.Drawing.Size(230, 28);
            this.tbxNombreM.TabIndex = 63;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(192, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(75, 20);
            this.txtUsuario.TabIndex = 61;
            this.txtUsuario.Text = "Nombre:";
            // 
            // tbxUsuarioM
            // 
            this.tbxUsuarioM.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuarioM.Location = new System.Drawing.Point(614, 94);
            this.tbxUsuarioM.Name = "tbxUsuarioM";
            this.tbxUsuarioM.Size = new System.Drawing.Size(74, 28);
            this.tbxUsuarioM.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Usuario:";
            // 
            // tbxEdadM
            // 
            this.tbxEdadM.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEdadM.Location = new System.Drawing.Point(619, 155);
            this.tbxEdadM.Name = "tbxEdadM";
            this.tbxEdadM.Size = new System.Drawing.Size(42, 28);
            this.tbxEdadM.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Edad:";
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.Location = new System.Drawing.Point(463, 352);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(104, 48);
            this.btnActualizarM.TabIndex = 72;
            this.btnActualizarM.Text = "Actualizar Datos";
            this.btnActualizarM.UseVisualStyleBackColor = true;
            this.btnActualizarM.Click += new System.EventHandler(this.btnActualizarM_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(-2, 6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(253, 30);
            this.txtLogin.TabIndex = 91;
            this.txtLogin.Text = "Calcular el IMC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.tbxEdadM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUsuarioM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularM);
            this.Controls.Add(this.btnHistorialM);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbxNombreM);
            this.Controls.Add(this.txtUsuario);
            this.Name = "fMenu";
            this.Text = "indice de Masa Corporal : Menu Principal";
            this.Load += new System.EventHandler(this.fMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularM;
        private System.Windows.Forms.Button btnHistorialM;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.Label txtLogin;
        public System.Windows.Forms.TextBox tbxNombreM;
        public System.Windows.Forms.Label txtUsuario;
        public System.Windows.Forms.TextBox tbxUsuarioM;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxEdadM;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}