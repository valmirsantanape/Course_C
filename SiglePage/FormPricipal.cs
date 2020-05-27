using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiglePage
{
    public partial class FormPricipal : Form
    {
        public FormPricipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ColorDialog = new ColorDialog();
            var corEscolhida = ColorDialog.ShowDialog();
            if(corEscolhida == DialogResult.OK)
            {
                btnCor.BackColor = ColorDialog.Color;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
