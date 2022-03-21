using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._3._2__BMI_
{
    public partial class FormVKI : Form
    {
        public FormVKI()
        {
            InitializeComponent(); // Kontrolleri ve onların özelliklerini oluşturan metot.

            // RadioButtonları unchecked yapalım.
            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;
        }

        double bmi, agirlik, boy;



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!radioButtonKadin.Checked && !radioButtonErkek.Checked)
                {
                    MessageBox.Show("Lütfen cinsiyet seçimi yapınız.");
                }
                else
                {
                    agirlik = Convert.ToDouble(txtAgirlik.Text);
                    boy = Convert.ToDouble(txtBoy.Text);
                    if (boy < 0 || agirlik < 0)
                    {
                        throw new Exception("Ağırlık ve boy negatif olamaz.");
                    }
                    /* İşlemler
                     * VKI = Kilo / Boy^2
                     * Erkek ise 1.1 ile, Kadın ise 1.07 ile çarpılsın */
                    bmi = (agirlik / Math.Pow(boy, 2)) * 100;

                    /* Turnery If ileyapalım:
                     * radioButtonErkek seçili ise sonucu 1.1 ile çarpsın, değilse 1.07 ile çarpsın. */
                    bmi *= radioButtonErkek.Checked ? 1.1 : 1.07;
                }



                MessageBox.Show("VKİ: " + bmi.ToString("0.00"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA! - " + ex.Message);
            }
        }
    }
}
