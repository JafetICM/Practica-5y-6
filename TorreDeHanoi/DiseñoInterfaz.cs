namespace TorreHanoi
{
    partial class Interfaz
    {
        private void InitializeComponent()
        {
            this.txtNumDiscos = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            
            // 
            // txtNumDiscos
            // 
            this.txtNumDiscos.Location = new System.Drawing.Point(12, 12);
            this.txtNumDiscos.Name = "txtNumDiscos";
            this.txtNumDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtNumDiscos.TabIndex = 0;
            this.txtNumDiscos.Text = "3"; // Valor predeterminado de 3 discos

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 38);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumDiscos);
            this.Name = "Interfaz";
            this.Text = "Torres de Hanói";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
