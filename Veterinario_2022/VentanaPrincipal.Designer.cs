namespace Veterinario_2022
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.insertaUsuario = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoBuscador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insertaMascota = new System.Windows.Forms.Button();
            this.colorMascota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tipoMascota = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNombreMascota = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAnimalMascota = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxColorMascota = new System.Windows.Forms.TextBox();
            this.botonBuscarUsuario = new System.Windows.Forms.Button();
            this.botonBuscarPorNombre = new System.Windows.Forms.Button();
            this.botonBuscarPorAnimal = new System.Windows.Forms.Button();
            this.botonBuscarPorColor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.botonBuscarPorColor);
            this.tabPage2.Controls.Add(this.botonBuscarPorAnimal);
            this.tabPage2.Controls.Add(this.botonBuscarPorNombre);
            this.tabPage2.Controls.Add(this.botonBuscarUsuario);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBoxColorMascota);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBoxAnimalMascota);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxNombreMascota);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxNombreUsuario);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textoBuscador);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.insertaMascota);
            this.tabPage3.Controls.Add(this.colorMascota);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.nombreMascota);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tipoMascota);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.insertaUsuario);
            this.tabPage3.Controls.Add(this.textBoxEmail);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBoxPass);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxApellido);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxNombre);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxDNI);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(856, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Añadir US/M";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 100);
            this.label6.TabIndex = 47;
            this.label6.Text = "AÑADIR NUEVO USUARIO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertaUsuario
            // 
            this.insertaUsuario.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaUsuario.Location = new System.Drawing.Point(105, 355);
            this.insertaUsuario.Name = "insertaUsuario";
            this.insertaUsuario.Size = new System.Drawing.Size(193, 73);
            this.insertaUsuario.TabIndex = 46;
            this.insertaUsuario.Text = "Inserta Usuario";
            this.insertaUsuario.UseVisualStyleBackColor = true;
            this.insertaUsuario.Click += new System.EventHandler(this.insertaUsuario_Click_1);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(137, 303);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(183, 22);
            this.textBoxEmail.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(137, 255);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(183, 22);
            this.textBoxPass.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Password";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(137, 210);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(183, 22);
            this.textBoxApellido.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(137, 166);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 22);
            this.textBoxNombre.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(137, 123);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(183, 22);
            this.textBoxDNI.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "DNI";
            // 
            // textoBuscador
            // 
            this.textoBuscador.AutoSize = true;
            this.textoBuscador.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBuscador.Location = new System.Drawing.Point(130, 18);
            this.textoBuscador.Name = "textoBuscador";
            this.textoBuscador.Size = new System.Drawing.Size(241, 60);
            this.textoBuscador.TabIndex = 0;
            this.textoBuscador.Text = "BUSCADOR";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 100);
            this.label7.TabIndex = 59;
            this.label7.Text = "AÑADIR NUEVA MASCOTA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertaMascota
            // 
            this.insertaMascota.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaMascota.Location = new System.Drawing.Point(566, 387);
            this.insertaMascota.Name = "insertaMascota";
            this.insertaMascota.Size = new System.Drawing.Size(180, 88);
            this.insertaMascota.TabIndex = 58;
            this.insertaMascota.Text = "Inserta Mascota";
            this.insertaMascota.UseVisualStyleBackColor = true;
            this.insertaMascota.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorMascota
            // 
            this.colorMascota.Location = new System.Drawing.Point(478, 301);
            this.colorMascota.Name = "colorMascota";
            this.colorMascota.Size = new System.Drawing.Size(183, 22);
            this.colorMascota.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(358, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Color";
            // 
            // nombreMascota
            // 
            this.nombreMascota.Location = new System.Drawing.Point(478, 253);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(183, 22);
            this.nombreMascota.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nombre";
            // 
            // tipoMascota
            // 
            this.tipoMascota.Location = new System.Drawing.Point(478, 208);
            this.tipoMascota.Name = "tipoMascota";
            this.tipoMascota.Size = new System.Drawing.Size(183, 22);
            this.tipoMascota.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Tipo Animal";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Usuarios";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(110, 196);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombreUsuario.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(482, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mascotas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nombre";
            // 
            // textBoxNombreMascota
            // 
            this.textBoxNombreMascota.Location = new System.Drawing.Point(398, 138);
            this.textBoxNombreMascota.Name = "textBoxNombreMascota";
            this.textBoxNombreMascota.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombreMascota.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Animal";
            // 
            // textBoxAnimalMascota
            // 
            this.textBoxAnimalMascota.Location = new System.Drawing.Point(398, 222);
            this.textBoxAnimalMascota.Name = "textBoxAnimalMascota";
            this.textBoxAnimalMascota.Size = new System.Drawing.Size(100, 22);
            this.textBoxAnimalMascota.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(316, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Color";
            // 
            // textBoxColorMascota
            // 
            this.textBoxColorMascota.Location = new System.Drawing.Point(398, 307);
            this.textBoxColorMascota.Name = "textBoxColorMascota";
            this.textBoxColorMascota.Size = new System.Drawing.Size(100, 22);
            this.textBoxColorMascota.TabIndex = 9;
            // 
            // botonBuscarUsuario
            // 
            this.botonBuscarUsuario.Location = new System.Drawing.Point(110, 261);
            this.botonBuscarUsuario.Name = "botonBuscarUsuario";
            this.botonBuscarUsuario.Size = new System.Drawing.Size(100, 68);
            this.botonBuscarUsuario.TabIndex = 11;
            this.botonBuscarUsuario.Text = "Buscar Usuario";
            this.botonBuscarUsuario.UseVisualStyleBackColor = true;
            this.botonBuscarUsuario.Click += new System.EventHandler(this.botonBuscarUsuario_Click);
            // 
            // botonBuscarPorNombre
            // 
            this.botonBuscarPorNombre.Location = new System.Drawing.Point(565, 118);
            this.botonBuscarPorNombre.Name = "botonBuscarPorNombre";
            this.botonBuscarPorNombre.Size = new System.Drawing.Size(100, 62);
            this.botonBuscarPorNombre.TabIndex = 12;
            this.botonBuscarPorNombre.Text = "Buscar Por Nombre";
            this.botonBuscarPorNombre.UseVisualStyleBackColor = true;
            this.botonBuscarPorNombre.Click += new System.EventHandler(this.botonBuscarPorNombre_Click);
            // 
            // botonBuscarPorAnimal
            // 
            this.botonBuscarPorAnimal.Location = new System.Drawing.Point(565, 205);
            this.botonBuscarPorAnimal.Name = "botonBuscarPorAnimal";
            this.botonBuscarPorAnimal.Size = new System.Drawing.Size(100, 62);
            this.botonBuscarPorAnimal.TabIndex = 13;
            this.botonBuscarPorAnimal.Text = "Buscar Por Animal";
            this.botonBuscarPorAnimal.UseVisualStyleBackColor = true;
            this.botonBuscarPorAnimal.Click += new System.EventHandler(this.botonBuscarPorAnimal_Click);
            // 
            // botonBuscarPorColor
            // 
            this.botonBuscarPorColor.Location = new System.Drawing.Point(565, 290);
            this.botonBuscarPorColor.Name = "botonBuscarPorColor";
            this.botonBuscarPorColor.Size = new System.Drawing.Size(100, 62);
            this.botonBuscarPorColor.TabIndex = 14;
            this.botonBuscarPorColor.Text = "Buscar Por Color";
            this.botonBuscarPorColor.UseVisualStyleBackColor = true;
            this.botonBuscarPorColor.Click += new System.EventHandler(this.botonBuscarPorColor_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 536);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertaUsuario;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textoBuscador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertaMascota;
        private System.Windows.Forms.TextBox colorMascota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nombreMascota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tipoMascota;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxNombreMascota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonBuscarPorColor;
        private System.Windows.Forms.Button botonBuscarPorAnimal;
        private System.Windows.Forms.Button botonBuscarPorNombre;
        private System.Windows.Forms.Button botonBuscarUsuario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxColorMascota;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAnimalMascota;
    }
}

