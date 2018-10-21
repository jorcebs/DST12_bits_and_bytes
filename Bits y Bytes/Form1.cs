using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bits_y_Bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 1;
            g.DrawLine(myPen, 12, 235, 526, 235);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int dirección = (num & 14) >> 1; //bits 1-3
            int tanque = (num & 48) >> 4; //bits 4-5
            bool sensor2 = Convert.ToBoolean((num & 64) >> 6); //bit 6
            bool sensor1 = Convert.ToBoolean((num & 128) >> 7); //bit 7
            int día = (num & 7936) >> 8; //bits 8-12
            int mes = (num & 122880) >> 13; //bits 13-16
            int año = (num & 16646144) >> 17; //bits 17-23
            
            revisaSensores(sensor1, sensor2);
            revisaTanque(tanque);
            revisaDirección(dirección);
            escribeFecha(día, mes, año + 1900);
        }

        private void revisaSensores(bool sensor1, bool sensor2)
        {
            pctS1.Image = (sensor1) ? Bits_y_Bytes.Properties.Resources.on : Bits_y_Bytes.Properties.Resources.off;
            pctS2.Image = (sensor2) ? Bits_y_Bytes.Properties.Resources.on : Bits_y_Bytes.Properties.Resources.off;
        }

        private void revisaTanque(int tanque)
        {
            switch (tanque)
            {
                case 0:
                    lblTanque.Text = "Vacío";
                    break;
                case 1:
                    lblTanque.Text = "Nivel medio";
                    break;
                case 2:
                    lblTanque.Text = "Lleno";
                    break;
                case 3:
                    lblTanque.Text = "En llenado";
                    break;
            }
        }

        private void revisaDirección(int dirección)
        {
            switch (dirección)
            {
                case 0:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D0;
                    break;
                case 1:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D1;
                    break;
                case 2:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D2;
                    break;
                case 3:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D3;
                    break;
                case 4:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D4;
                    break;
                case 5:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D5;
                    break;
                case 6:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D6;
                    break;
                case 7:
                    pctDirección.Image = Bits_y_Bytes.Properties.Resources.D7;
                    break;
            }
        }

        private void escribeFecha(int día, int mes, int año)
        {
            lblFecha.Text = "Fecha de lectura: " + día.ToString() + "/" + mes.ToString() + "/" + año.ToString();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            int día = getDía(txtFecha.Text);
            int mes = getMes(txtFecha.Text) << 5;
            int año = (getAño(txtFecha.Text) - 1900) << 9;
            txtFechaAjustada.Text = (día | mes | año).ToString();
        }

        private int getDía(string fecha)
        {
            return Convert.ToInt32(txtFecha.Text.ElementAt(0).ToString() + txtFecha.Text.ElementAt(1).ToString());
        }

        private int getMes(string fecha)
        {
            return Convert.ToInt32(txtFecha.Text.ElementAt(3).ToString() + txtFecha.Text.ElementAt(4).ToString());
        }

        private int getAño(string fecha)
        {
            return Convert.ToInt32(txtFecha.Text.ElementAt(6).ToString() + txtFecha.Text.ElementAt(7).ToString() + txtFecha.Text.ElementAt(8).ToString() + txtFecha.Text.ElementAt(9).ToString());
        }
    }
}