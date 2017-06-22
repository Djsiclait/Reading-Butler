namespace Cliente_Estudiante
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.conectar_client_estudiante = new System.Windows.Forms.Button();
            this.nombre_usuario_cliente_estudiante = new System.Windows.Forms.Label();
            this.password_cliente_estudiante = new System.Windows.Forms.Label();
            this.nombre_usuario_texto_cliente_estudiante = new System.Windows.Forms.TextBox();
            this.password_texto_cliente_estudiante = new System.Windows.Forms.TextBox();
            this.login_tooltip_cliente_estudiante = new System.Windows.Forms.ToolTip(this.components);
            this.enlace_registro_cliente_estudiante = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(13, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(120, 120);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // conectar_client_estudiante
            // 
            this.conectar_client_estudiante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conectar_client_estudiante.Location = new System.Drawing.Point(185, 110);
            this.conectar_client_estudiante.Name = "conectar_client_estudiante";
            this.conectar_client_estudiante.Size = new System.Drawing.Size(75, 23);
            this.conectar_client_estudiante.TabIndex = 1;
            this.conectar_client_estudiante.Text = "Conectar";
            this.conectar_client_estudiante.UseVisualStyleBackColor = true;
            this.conectar_client_estudiante.Click += new System.EventHandler(this.conectar_client_estudiante_Click);
            // 
            // nombre_usuario_cliente_estudiante
            // 
            this.nombre_usuario_cliente_estudiante.AutoSize = true;
            this.nombre_usuario_cliente_estudiante.Location = new System.Drawing.Point(139, 13);
            this.nombre_usuario_cliente_estudiante.Name = "nombre_usuario_cliente_estudiante";
            this.nombre_usuario_cliente_estudiante.Size = new System.Drawing.Size(98, 13);
            this.nombre_usuario_cliente_estudiante.TabIndex = 2;
            this.nombre_usuario_cliente_estudiante.Text = "Nombre de Usuario";
            this.nombre_usuario_cliente_estudiante.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_cliente_estudiante
            // 
            this.password_cliente_estudiante.AutoSize = true;
            this.password_cliente_estudiante.Location = new System.Drawing.Point(140, 62);
            this.password_cliente_estudiante.Name = "password_cliente_estudiante";
            this.password_cliente_estudiante.Size = new System.Drawing.Size(61, 13);
            this.password_cliente_estudiante.TabIndex = 3;
            this.password_cliente_estudiante.Text = "Contraseña";
            this.password_cliente_estudiante.Click += new System.EventHandler(this.label2_Click);
            // 
            // nombre_usuario_texto_cliente_estudiante
            // 
            this.nombre_usuario_texto_cliente_estudiante.Location = new System.Drawing.Point(140, 30);
            this.nombre_usuario_texto_cliente_estudiante.Name = "nombre_usuario_texto_cliente_estudiante";
            this.nombre_usuario_texto_cliente_estudiante.Size = new System.Drawing.Size(175, 20);
            this.nombre_usuario_texto_cliente_estudiante.TabIndex = 4;
            this.login_tooltip_cliente_estudiante.SetToolTip(this.nombre_usuario_texto_cliente_estudiante, "ej: johnSmith1234");
            this.nombre_usuario_texto_cliente_estudiante.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_texto_cliente_estudiante
            // 
            this.password_texto_cliente_estudiante.Location = new System.Drawing.Point(140, 79);
            this.password_texto_cliente_estudiante.Name = "password_texto_cliente_estudiante";
            this.password_texto_cliente_estudiante.Size = new System.Drawing.Size(175, 20);
            this.password_texto_cliente_estudiante.TabIndex = 5;
            // 
            // login_tooltip_cliente_estudiante
            // 
            this.login_tooltip_cliente_estudiante.AutomaticDelay = 1000;
            this.login_tooltip_cliente_estudiante.Popup += new System.Windows.Forms.PopupEventHandler(this.nombre_tooltip_cliente_estudiante_Popup);
            // 
            // enlace_registro_cliente_estudiante
            // 
            this.enlace_registro_cliente_estudiante.AutoSize = true;
            this.enlace_registro_cliente_estudiante.Location = new System.Drawing.Point(117, 142);
            this.enlace_registro_cliente_estudiante.Name = "enlace_registro_cliente_estudiante";
            this.enlace_registro_cliente_estudiante.Size = new System.Drawing.Size(84, 13);
            this.enlace_registro_cliente_estudiante.TabIndex = 6;
            this.enlace_registro_cliente_estudiante.TabStop = true;
            this.enlace_registro_cliente_estudiante.Text = "Registrarse Aqui";
            this.enlace_registro_cliente_estudiante.VisitedLinkColor = System.Drawing.Color.Blue;
            this.enlace_registro_cliente_estudiante.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlace_registro_cliente_estudiante_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 164);
            this.Controls.Add(this.enlace_registro_cliente_estudiante);
            this.Controls.Add(this.password_texto_cliente_estudiante);
            this.Controls.Add(this.nombre_usuario_texto_cliente_estudiante);
            this.Controls.Add(this.password_cliente_estudiante);
            this.Controls.Add(this.nombre_usuario_cliente_estudiante);
            this.Controls.Add(this.conectar_client_estudiante);
            this.Controls.Add(this.Logo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 203);
            this.MinimumSize = new System.Drawing.Size(343, 203);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reading Butler - Login";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button conectar_client_estudiante;
        private System.Windows.Forms.Label nombre_usuario_cliente_estudiante;
        private System.Windows.Forms.Label password_cliente_estudiante;
        private System.Windows.Forms.TextBox nombre_usuario_texto_cliente_estudiante;
        private System.Windows.Forms.TextBox password_texto_cliente_estudiante;
        private System.Windows.Forms.ToolTip login_tooltip_cliente_estudiante;
        private System.Windows.Forms.LinkLabel enlace_registro_cliente_estudiante;
    }
}

