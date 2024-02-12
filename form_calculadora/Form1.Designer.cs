namespace form_calculadora
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Valorr1 = new System.Windows.Forms.TextBox();
            this.txt_Valorr2 = new System.Windows.Forms.TextBox();
            this.txt_Sumas = new System.Windows.Forms.TextBox();
            this.txt_Restas = new System.Windows.Forms.TextBox();
            this.txt_Multiplicaciones = new System.Windows.Forms.TextBox();
            this.txt_Divisiones = new System.Windows.Forms.TextBox();
            this.btn_Calcularr = new System.Windows.Forms.Button();
            this.btn_Limpiarr = new System.Windows.Forms.Button();
            this.btn_Salirr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Calculadora";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Valor 1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Suma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Resta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(386, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Multiplicacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(386, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Division";
            // 
            // txt_Valorr1
            // 
            this.txt_Valorr1.Location = new System.Drawing.Point(214, 142);
            this.txt_Valorr1.Name = "txt_Valorr1";
            this.txt_Valorr1.Size = new System.Drawing.Size(100, 20);
            this.txt_Valorr1.TabIndex = 7;
            // 
            // txt_Valorr2
            // 
            this.txt_Valorr2.Location = new System.Drawing.Point(214, 189);
            this.txt_Valorr2.Name = "txt_Valorr2";
            this.txt_Valorr2.Size = new System.Drawing.Size(100, 20);
            this.txt_Valorr2.TabIndex = 8;
            // 
            // txt_Sumas
            // 
            this.txt_Sumas.Location = new System.Drawing.Point(214, 297);
            this.txt_Sumas.Name = "txt_Sumas";
            this.txt_Sumas.Size = new System.Drawing.Size(100, 20);
            this.txt_Sumas.TabIndex = 9;
            // 
            // txt_Restas
            // 
            this.txt_Restas.Location = new System.Drawing.Point(214, 347);
            this.txt_Restas.Name = "txt_Restas";
            this.txt_Restas.Size = new System.Drawing.Size(100, 20);
            this.txt_Restas.TabIndex = 10;
            // 
            // txt_Multiplicaciones
            // 
            this.txt_Multiplicaciones.Location = new System.Drawing.Point(526, 295);
            this.txt_Multiplicaciones.Name = "txt_Multiplicaciones";
            this.txt_Multiplicaciones.Size = new System.Drawing.Size(111, 20);
            this.txt_Multiplicaciones.TabIndex = 11;
            // 
            // txt_Divisiones
            // 
            this.txt_Divisiones.Location = new System.Drawing.Point(526, 345);
            this.txt_Divisiones.Name = "txt_Divisiones";
            this.txt_Divisiones.Size = new System.Drawing.Size(111, 20);
            this.txt_Divisiones.TabIndex = 12;
            // 
            // btn_Calcularr
            // 
            this.btn_Calcularr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Calcularr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcularr.Location = new System.Drawing.Point(88, 439);
            this.btn_Calcularr.Name = "btn_Calcularr";
            this.btn_Calcularr.Size = new System.Drawing.Size(131, 54);
            this.btn_Calcularr.TabIndex = 13;
            this.btn_Calcularr.Text = "Calcular";
            this.btn_Calcularr.UseVisualStyleBackColor = false;
            this.btn_Calcularr.Click += new System.EventHandler(this.btn_Calcularr_Click_1);
            // 
            // btn_Limpiarr
            // 
            this.btn_Limpiarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Limpiarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiarr.Location = new System.Drawing.Point(292, 439);
            this.btn_Limpiarr.Name = "btn_Limpiarr";
            this.btn_Limpiarr.Size = new System.Drawing.Size(131, 54);
            this.btn_Limpiarr.TabIndex = 14;
            this.btn_Limpiarr.Text = "Limpiar";
            this.btn_Limpiarr.UseVisualStyleBackColor = false;
            this.btn_Limpiarr.Click += new System.EventHandler(this.btn_Limpiarr_Click);
            // 
            // btn_Salirr
            // 
            this.btn_Salirr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Salirr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salirr.Location = new System.Drawing.Point(487, 439);
            this.btn_Salirr.Name = "btn_Salirr";
            this.btn_Salirr.Size = new System.Drawing.Size(131, 54);
            this.btn_Salirr.TabIndex = 15;
            this.btn_Salirr.Text = "Salir";
            this.btn_Salirr.UseVisualStyleBackColor = false;
            this.btn_Salirr.Click += new System.EventHandler(this.btn_Salirr_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(821, 578);
            this.Controls.Add(this.btn_Salirr);
            this.Controls.Add(this.btn_Limpiarr);
            this.Controls.Add(this.btn_Calcularr);
            this.Controls.Add(this.txt_Divisiones);
            this.Controls.Add(this.txt_Multiplicaciones);
            this.Controls.Add(this.txt_Restas);
            this.Controls.Add(this.txt_Sumas);
            this.Controls.Add(this.txt_Valorr2);
            this.Controls.Add(this.txt_Valorr1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.TextBox txt_Suma;
        private System.Windows.Forms.TextBox txt_Resta;
        private System.Windows.Forms.TextBox txt_Division;
        private System.Windows.Forms.TextBox txt_Multiplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Valorr1;
        private System.Windows.Forms.TextBox txt_Valorr2;
        private System.Windows.Forms.TextBox txt_Sumas;
        private System.Windows.Forms.TextBox txt_Restas;
        private System.Windows.Forms.TextBox txt_Multiplicaciones;
        private System.Windows.Forms.TextBox txt_Divisiones;
        private System.Windows.Forms.Button btn_Calcularr;
        private System.Windows.Forms.Button btn_Limpiarr;
        private System.Windows.Forms.Button btn_Salirr;
    }
}

