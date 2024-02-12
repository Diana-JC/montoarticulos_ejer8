namespace montoarticulos_ejer8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            double montoTotal = 0;
            double descuento = 0;
            double itbis = 0;
          


            if (double.TryParse(txtMontoTotal.Text, out montoTotal))
            {
                if (montoTotal >= 1000 && montoTotal <= 5000)
                {
                    descuento = 0;
                }
                else if (montoTotal > 5001 && montoTotal <= 10000)
                {
                    descuento = montoTotal * 0.03;
                }
                else if (montoTotal > 10000 && montoTotal <= 15000)
                {
                    descuento = montoTotal * 0.05;
                }
                else if (montoTotal > 15000 && montoTotal <= 20000)
                {
                    descuento = montoTotal * 0.08;
                }
                else if (montoTotal > 20000)
                {
                    descuento = montoTotal * 0.10;
                }
                else
                {
                    descuento = 0;
                    MessageBox.Show("No Aplica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                itbis = montoTotal * 0.12;
                montoTotal = montoTotal - descuento + itbis;

                txt_Descuento.Text = "Descuento: $" + descuento.ToString("N2");
                txt_Itbis.Text = "ITBIS: $" + itbis.ToString("N2");
                txtMontoTotal.Text = "Monto Neto: $" + montoTotal.ToString("N2");
            }
        }




        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtMontoTotal.Clear();
            txt_Descuento.Clear();
            txt_Itbis.Clear();
        }
    }
}

