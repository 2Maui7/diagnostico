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
            this.Suma = new System.Windows.Forms.Label();
            this.Resta = new System.Windows.Forms.Label();
            this.Divicion = new System.Windows.Forms.Label();
            this.Multiplicacion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Suma
            // 
            this.Suma.AutoSize = true;
            this.Suma.Location = new System.Drawing.Point(295, 184);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(35, 13);
            this.Suma.TabIndex = 4;
            this.Suma.Text = "label5";
            // 
            // Resta
            // 
            this.Resta.AutoSize = true;
            this.Resta.Location = new System.Drawing.Point(374, 184);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(35, 13);
            this.Resta.TabIndex = 5;
            this.Resta.Text = "label6";
            // 
            // Divicion
            // 
            this.Divicion.AutoSize = true;
            this.Divicion.Location = new System.Drawing.Point(540, 184);
            this.Divicion.Name = "Divicion";
            this.Divicion.Size = new System.Drawing.Size(35, 13);
            this.Divicion.TabIndex = 6;
            this.Divicion.Text = "label7";
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.AutoSize = true;
            this.Multiplicacion.Location = new System.Drawing.Point(456, 184);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(35, 13);
            this.Multiplicacion.TabIndex = 7;
            this.Multiplicacion.Text = "label8";
            this.Multiplicacion.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(296, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ingrese el primer Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(296, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ingrese el segundo numero";
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(475, 33);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 20);
            this.Num1.TabIndex = 10;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(475, 88);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 20);
            this.Num2.TabIndex = 11;
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(275, 144);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(75, 23);
            this.btn_Suma.TabIndex = 12;
            this.btn_Suma.Text = "Sumar";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(356, 144);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(75, 23);
            this.btn_Resta.TabIndex = 13;
            this.btn_Resta.Text = "Restar";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(437, 144);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiplicar.TabIndex = 14;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(519, 144);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 15;
            this.btn_div.Text = "Dividir";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Divicion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Suma;
        private System.Windows.Forms.Label Resta;
        private System.Windows.Forms.Label Divicion;
        private System.Windows.Forms.Label Multiplicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_div;
    }
}

