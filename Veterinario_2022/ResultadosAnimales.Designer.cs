namespace Veterinario_2022
{
    partial class ResultadosAnimales
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
            this.resultadoAnimales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultadoAnimales
            // 
            this.resultadoAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoAnimales.Location = new System.Drawing.Point(13, 13);
            this.resultadoAnimales.Name = "resultadoAnimales";
            this.resultadoAnimales.Size = new System.Drawing.Size(426, 340);
            this.resultadoAnimales.TabIndex = 0;
            this.resultadoAnimales.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultadosAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 362);
            this.Controls.Add(this.resultadoAnimales);
            this.Name = "ResultadosAnimales";
            this.Text = "RespuestasAnimales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resultadoAnimales;
    }
}