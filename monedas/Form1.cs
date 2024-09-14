using System;
using System.Windows.Forms;

namespace CalculadoraDeCambio
{
    public partial class Form1 : Form
    {
        // Inicialización directa de los controles
        private System.Windows.Forms.TextBox txtCantidadAPagar = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.TextBox txtCantidadPagada = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label lblResultado = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button btnCalcular = new System.Windows.Forms.Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object? sender, EventArgs e)  // Asegúrate de que el `sender` pueda ser nulo si usas el flag de nullabilidad
        {
            try
            {
                // Leer las cantidades ingresadas
                decimal cantidadAPagar = Convert.ToDecimal(txtCantidadAPagar.Text);
                decimal cantidadPagada = Convert.ToDecimal(txtCantidadPagada.Text);

                // Instanciar la clase CalculadoraDeCambio y obtener el resultado
                CalculadoraDeCambio calculadora = new CalculadoraDeCambio();
                string resultado = calculadora.CalcularCambio(cantidadAPagar, cantidadPagada);

                // Mostrar el resultado en los Labels
                lblResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
