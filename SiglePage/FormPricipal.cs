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
        private bool flagPintar = false;
        private Graphics graphcspainel1;
        private float espessuraCeneta;

        public FormPricipal()
        {
            InitializeComponent();
            for(int i=1; i <= 10; i ++)
            {
                cbEspessuraCaneta.Items.Add(i);
            }
            cbEspessuraCaneta.Text = "2";//Texto que aparecerá inicialmente 
            cbEspessuraCaneta.MaxDropDownItems = 5;//Total de itens que serão mostrados
            cbEspessuraCaneta.IntegralHeight = false; // IntegralHeight = false para ser possivel manipular total de itens que serao mostrados

            graphcspainel1 = panel1.CreateGraphics();
            espessuraCeneta = float.Parse(cbEspessuraCaneta.Text);//Converrte o texto para 
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(flagPintar)
            {
                graphcspainel1.DrawEllipse(new Pen(btnCor.BackColor, espessuraCeneta), new RectangleF(e.X, e.Y, espessuraCeneta, espessuraCeneta));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }
    }
}
