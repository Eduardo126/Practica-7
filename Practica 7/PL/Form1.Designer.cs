
namespace Practica_7
{
    partial class Form1
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
            this.bottonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottonTest
            // 
            this.bottonTest.Location = new System.Drawing.Point(72, 93);
            this.bottonTest.Name = "bottonTest";
            this.bottonTest.Size = new System.Drawing.Size(244, 166);
            this.bottonTest.TabIndex = 0;
            this.bottonTest.Text = "button1";
            this.bottonTest.UseVisualStyleBackColor = true;
            this.bottonTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 410);
            this.Controls.Add(this.bottonTest);
            this.Name = "Form1";
            this.Text = "Semana 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottonTest;
    }
}

