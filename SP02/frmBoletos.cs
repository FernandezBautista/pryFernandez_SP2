using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP02
{
    public partial class frmBoletos : Form
    {
        public frmBoletos()
        {
            InitializeComponent();
        }

        private void frmBoletos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDistancia.Text == "")
            {
                MessageBox.Show("Debe ingresar una distancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int distancia = int.Parse(txtDistancia.Text);
            int dias = (int)nudDias.Value;
            const int PRECIO_POR_KM = 5;
            int distanciaTotal = distancia * 2;
            int precioBase = distanciaTotal * PRECIO_POR_KM;
            bool hayDescuento = (dias >= 7) && (distancia >= 100);
            int precioFinal = hayDescuento ? (precioBase / 2) : precioBase;

            string textoDescuento = "No";
            if (hayDescuento)
            {
                textoDescuento = "Sí";
            }

            string textoParaLista = "Distancia: " + distancia + " km, Días: " + dias + ", Descuento: " + textoDescuento + " - Total: $" + precioFinal;

            lstBoletosTotales.Items.Add(textoParaLista);

            MessageBox.Show(
                "Distancia de ida: " + distancia + " km\n" +
                "Distancia total: " + distanciaTotal + " km\n" +
                "Días de estancia: " + dias + "\n" +
                (hayDescuento ? "Descuento aplicado: 50%\n" : "") +
                "Precio final: $ " + precioFinal,
                "Cálculo de boleto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            nudDias.Value = 1;
        }

        private void lblDistancia_Click(object sender, EventArgs e)
        {

        }

        private void Distancia_Click(object sender, EventArgs e)
        {

        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lstBoletosTotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}