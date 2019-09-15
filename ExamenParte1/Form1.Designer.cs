namespace ExamenParte1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.btnir = new System.Windows.Forms.Button();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsalariofinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas trabajadas:";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(267, 216);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(76, 13);
            this.txt.TabIndex = 1;
            this.txt.Text = "Valor por hora:";
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(355, 307);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(75, 23);
            this.btnir.TabIndex = 2;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(381, 174);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 20);
            this.txthoras.TabIndex = 3;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(381, 216);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario final:";
            // 
            // lblsalariofinal
            // 
            this.lblsalariofinal.AutoSize = true;
            this.lblsalariofinal.Location = new System.Drawing.Point(378, 265);
            this.lblsalariofinal.Name = "lblsalariofinal";
            this.lblsalariofinal.Size = new System.Drawing.Size(27, 13);
            this.lblsalariofinal.TabIndex = 6;
            this.lblsalariofinal.Text = "total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Calcular salario final de un empleado.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsalariofinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsalariofinal;
        private System.Windows.Forms.Label label5;
    }
}

