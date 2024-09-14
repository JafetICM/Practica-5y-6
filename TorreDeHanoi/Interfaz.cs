using System;
using System.Windows.Forms;

namespace TorreHanoi
{
    public partial class Interfaz : Form
    {
        // Inicialización directa de los controles
        private System.Windows.Forms.TextBox txtNumDiscos = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label lblResultado = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button btnCalcular = new System.Windows.Forms.Button();

        public Interfaz()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número de discos ingresado
                int numDiscos = int.Parse(txtNumDiscos.Text);

                // Instanciar la clase TorresDeHanoi y obtener el resultado
                TorreHanoi hanoi = new TorreHanoi();
                string resultado = hanoi.ResolverTorresDeHanoi(numDiscos, 'A', 'C', 'B');

                // Mostrar el resultado en el Label
                lblResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
