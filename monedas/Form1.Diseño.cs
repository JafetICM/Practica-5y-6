namespace CalculadoraDeCambio
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.txtCantidadAPagar = new System.Windows.Forms.TextBox();
            this.txtCantidadPagada = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            
            // 
            // txtCantidadAPagar
            // 
            this.txtCantidadAPagar.Location = new System.Drawing.Point(12, 12);
            this.txtCantidadAPagar.Name = "txtCantidadAPagar";
            this.txtCantidadAPagar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAPagar.TabIndex = 0;
            // 
            // txtCantidadPagada
            // 
            this.txtCantidadPagada.Location = new System.Drawing.Point(12, 38);
            this.txtCantidadPagada.Name = "txtCantidadPagada";
            this.txtCantidadPagada.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPagada.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 91);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCantidadPagada);
            this.Controls.Add(this.txtCantidadAPagar);
            this.Name = "Form1";
            this.Text = "Calculadora de Cambio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
