using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._3._1__HelloForm_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text=="Admin" && txtSifre.Text=="123")
            {
                MessageBox.Show("Hoş geldiniz!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalıdır.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
