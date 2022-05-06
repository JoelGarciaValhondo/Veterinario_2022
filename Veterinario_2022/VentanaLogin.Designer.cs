namespace Veterinario_2022
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.textoNombreUsuario = new System.Windows.Forms.TextBox();
            this.textoPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.textoInicioSesion = new System.Windows.Forms.Label();
            this.textoApellidoUsuario = new System.Windows.Forms.TextBox();
            this.apellidoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.nombreUsuario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuario.Location = new System.Drawing.Point(62, 110);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(163, 23);
            this.nombreUsuario.TabIndex = 0;
            this.nombreUsuario.Text = "Nombre:";
            this.nombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombreUsuario.Click += new System.EventHandler(this.nombreUsuario_Click);
            // 
            // textoNombreUsuario
            // 
            this.textoNombreUsuario.Location = new System.Drawing.Point(66, 149);
            this.textoNombreUsuario.Name = "textoNombreUsuario";
            this.textoNombreUsuario.Size = new System.Drawing.Size(163, 20);
            this.textoNombreUsuario.TabIndex = 1;
            // 
            // textoPassword
            // 
            this.textoPassword.Location = new System.Drawing.Point(66, 290);
            this.textoPassword.Name = "textoPassword";
            this.textoPassword.Size = new System.Drawing.Size(163, 20);
            this.textoPassword.TabIndex = 3;
            this.textoPassword.TextChanged += new System.EventHandler(this.textoPassword_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(66, 251);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(163, 23);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.BlueViolet;
            this.login.Location = new System.Drawing.Point(108, 342);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(227, 82);
            this.login.TabIndex = 4;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textoInicioSesion
            // 
            this.textoInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.textoInicioSesion.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoInicioSesion.Location = new System.Drawing.Point(27, 52);
            this.textoInicioSesion.Name = "textoInicioSesion";
            this.textoInicioSesion.Size = new System.Drawing.Size(233, 32);
            this.textoInicioSesion.TabIndex = 5;
            this.textoInicioSesion.Text = "Inicio de Sesión";
            this.textoInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoApellidoUsuario
            // 
            this.textoApellidoUsuario.Location = new System.Drawing.Point(66, 218);
            this.textoApellidoUsuario.Name = "textoApellidoUsuario";
            this.textoApellidoUsuario.Size = new System.Drawing.Size(163, 20);
            this.textoApellidoUsuario.TabIndex = 7;
            // 
            // apellidoUsuario
            // 
            this.apellidoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.apellidoUsuario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoUsuario.ForeColor = System.Drawing.Color.Black;
            this.apellidoUsuario.Location = new System.Drawing.Point(66, 182);
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.Size = new System.Drawing.Size(163, 23);
            this.apellidoUsuario.TabIndex = 6;
            this.apellidoUsuario.Text = "Apellido:";
            this.apellidoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(373, 448);
            this.Controls.Add(this.textoApellidoUsuario);
            this.Controls.Add(this.apellidoUsuario);
            this.Controls.Add(this.textoInicioSesion);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textoPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textoNombreUsuario);
            this.Controls.Add(this.nombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "VentanaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.TextBox textoNombreUsuario;
        private System.Windows.Forms.TextBox textoPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label textoInicioSesion;
        private System.Windows.Forms.TextBox textoApellidoUsuario;
        private System.Windows.Forms.Label apellidoUsuario;
    }
}