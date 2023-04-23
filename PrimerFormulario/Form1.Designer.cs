
namespace PrimerFormulario
{
    partial class Formulario
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDatospersonales = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.chbHombre = new System.Windows.Forms.CheckBox();
            this.chbMujer = new System.Windows.Forms.CheckBox();
            this.chbotro = new System.Windows.Forms.CheckBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbthijos = new System.Windows.Forms.RadioButton();
            this.lblcanthijos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nudcanthijos = new System.Windows.Forms.NumericUpDown();
            this.btMostrarDatos = new System.Windows.Forms.Button();
            this.cbxestadocivil = new System.Windows.Forms.ComboBox();
            this.lblEstadocivil = new System.Windows.Forms.Label();
            this.gbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudcanthijos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(18, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblDatospersonales
            // 
            this.lblDatospersonales.AutoSize = true;
            this.lblDatospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatospersonales.Location = new System.Drawing.Point(30, 9);
            this.lblDatospersonales.Name = "lblDatospersonales";
            this.lblDatospersonales.Size = new System.Drawing.Size(219, 29);
            this.lblDatospersonales.TabIndex = 2;
            this.lblDatospersonales.Text = "Datos Personales";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(74, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(96, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(19, 85);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "Nombre: ";
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechanacimiento.Location = new System.Drawing.Point(19, 118);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(209, 16);
            this.lblfechanacimiento.TabIndex = 8;
            this.lblfechanacimiento.Text = "Seleccionar fecha de nacimiento: ";
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Location = new System.Drawing.Point(22, 147);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(194, 20);
            this.dtpFechanacimiento.TabIndex = 9;
            // 
            // chbHombre
            // 
            this.chbHombre.AutoSize = true;
            this.chbHombre.Checked = true;
            this.chbHombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHombre.Location = new System.Drawing.Point(16, 29);
            this.chbHombre.Name = "chbHombre";
            this.chbHombre.Size = new System.Drawing.Size(63, 17);
            this.chbHombre.TabIndex = 10;
            this.chbHombre.Text = "Hombre";
            this.chbHombre.UseVisualStyleBackColor = true;
            // 
            // chbMujer
            // 
            this.chbMujer.AutoSize = true;
            this.chbMujer.Location = new System.Drawing.Point(102, 29);
            this.chbMujer.Name = "chbMujer";
            this.chbMujer.Size = new System.Drawing.Size(52, 17);
            this.chbMujer.TabIndex = 11;
            this.chbMujer.Text = "Mujer";
            this.chbMujer.UseVisualStyleBackColor = true;
            // 
            // chbotro
            // 
            this.chbotro.AutoSize = true;
            this.chbotro.Location = new System.Drawing.Point(182, 29);
            this.chbotro.Name = "chbotro";
            this.chbotro.Size = new System.Drawing.Size(46, 17);
            this.chbotro.TabIndex = 12;
            this.chbotro.Text = "Otro";
            this.chbotro.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.chbotro);
            this.gbGenero.Controls.Add(this.chbHombre);
            this.gbGenero.Controls.Add(this.chbMujer);
            this.gbGenero.Location = new System.Drawing.Point(21, 191);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(292, 70);
            this.gbGenero.TabIndex = 13;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // rbthijos
            // 
            this.rbthijos.AutoSize = true;
            this.rbthijos.Location = new System.Drawing.Point(99, 318);
            this.rbthijos.Name = "rbthijos";
            this.rbthijos.Size = new System.Drawing.Size(34, 17);
            this.rbthijos.TabIndex = 14;
            this.rbthijos.Text = "Si";
            this.rbthijos.UseVisualStyleBackColor = true;
            // 
            // lblcanthijos
            // 
            this.lblcanthijos.AutoSize = true;
            this.lblcanthijos.Location = new System.Drawing.Point(24, 350);
            this.lblcanthijos.Name = "lblcanthijos";
            this.lblcanthijos.Size = new System.Drawing.Size(163, 13);
            this.lblcanthijos.TabIndex = 15;
            this.lblcanthijos.Text = "Seleccionar la cantidad de hijos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tenes hijos ?";
            // 
            // Nudcanthijos
            // 
            this.Nudcanthijos.Location = new System.Drawing.Point(193, 350);
            this.Nudcanthijos.Name = "Nudcanthijos";
            this.Nudcanthijos.Size = new System.Drawing.Size(120, 20);
            this.Nudcanthijos.TabIndex = 17;
            // 
            // btMostrarDatos
            // 
            this.btMostrarDatos.Location = new System.Drawing.Point(26, 394);
            this.btMostrarDatos.Name = "btMostrarDatos";
            this.btMostrarDatos.Size = new System.Drawing.Size(107, 27);
            this.btMostrarDatos.TabIndex = 18;
            this.btMostrarDatos.Text = "Mostrar datos";
            this.btMostrarDatos.UseVisualStyleBackColor = true;
            this.btMostrarDatos.Click += new System.EventHandler(this.btMostrarDatos_Click);
            // 
            // cbxestadocivil
            // 
            this.cbxestadocivil.FormattingEnabled = true;
            this.cbxestadocivil.Location = new System.Drawing.Point(99, 278);
            this.cbxestadocivil.Name = "cbxestadocivil";
            this.cbxestadocivil.Size = new System.Drawing.Size(82, 21);
            this.cbxestadocivil.TabIndex = 19;
            // 
            // lblEstadocivil
            // 
            this.lblEstadocivil.AutoSize = true;
            this.lblEstadocivil.Location = new System.Drawing.Point(24, 278);
            this.lblEstadocivil.Name = "lblEstadocivil";
            this.lblEstadocivil.Size = new System.Drawing.Size(67, 13);
            this.lblEstadocivil.TabIndex = 20;
            this.lblEstadocivil.Text = "Estado civil: ";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 447);
            this.Controls.Add(this.lblEstadocivil);
            this.Controls.Add(this.cbxestadocivil);
            this.Controls.Add(this.btMostrarDatos);
            this.Controls.Add(this.Nudcanthijos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcanthijos);
            this.Controls.Add(this.rbthijos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.dtpFechanacimiento);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDatospersonales);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(372, 486);
            this.MinimumSize = new System.Drawing.Size(372, 486);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudcanthijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDatospersonales;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.CheckBox chbHombre;
        private System.Windows.Forms.CheckBox chbMujer;
        private System.Windows.Forms.CheckBox chbotro;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbthijos;
        private System.Windows.Forms.Label lblcanthijos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nudcanthijos;
        private System.Windows.Forms.Button btMostrarDatos;
        private System.Windows.Forms.ComboBox cbxestadocivil;
        private System.Windows.Forms.Label lblEstadocivil;
    }
}

