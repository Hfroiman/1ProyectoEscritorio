
namespace Calculadora
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
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.btnsumar = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(36, 44);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(56, 13);
            this.lbln1.TabIndex = 0;
            this.lbln1.Text = "Numero 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Location = new System.Drawing.Point(36, 93);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(56, 13);
            this.lbln2.TabIndex = 1;
            this.lbln2.Text = "Numero 2:";
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(39, 126);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(154, 30);
            this.btnsumar.TabIndex = 2;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(98, 41);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(109, 20);
            this.txtn1.TabIndex = 3;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(98, 93);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(109, 20);
            this.txtn2.TabIndex = 4;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(36, 169);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 247);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lblresultado;
    }
}

