namespace EjerciciosCSharp_2.Capitulo8
{
    partial class Ejercicio3
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
            this.Horalabel = new System.Windows.Forms.Label();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Horalabel
            // 
            this.Horalabel.AutoSize = true;
            this.Horalabel.Location = new System.Drawing.Point(28, 12);
            this.Horalabel.Name = "Horalabel";
            this.Horalabel.Size = new System.Drawing.Size(98, 13);
            this.Horalabel.TabIndex = 2;
            this.Horalabel.Text = "00:00  00/00/0000";
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Location = new System.Drawing.Point(12, 37);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(128, 26);
            this.Iniciarbutton.TabIndex = 3;
            this.Iniciarbutton.Text = "Mostrar Hora y Fecha";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 74);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.Horalabel);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Horalabel;
        private System.Windows.Forms.Button Iniciarbutton;
    }
}