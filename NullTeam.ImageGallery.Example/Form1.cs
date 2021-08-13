using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullTeam.ImageGallery.Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image img1 = Image.FromFile(@"..\..\..\ExampleImages\img1.jpg");
            Image img2 = Image.FromFile(@"..\..\..\ExampleImages\img2.jpg");
            Image img3 = Image.FromFile(@"..\..\..\ExampleImages\img3.jpg");
            
            //Adicionar imagens pelo codigo
            imageGallery1.AddImages(img1, img2, img3);
        }

        private void btnSetLimiteImagens_Click(object sender, EventArgs e)
        {
            imageGallery1.LimiteImagens = Convert.ToUInt32(numericLimiteImagens.Value);
        }

        private void checkAdicao_CheckedChanged(object sender, EventArgs e)
        {
            imageGallery1.PermitirAdicao = checkAdicao.Checked;
        }

        private void checkRemocao_CheckedChanged(object sender, EventArgs e)
        {
            imageGallery1.PermitirRemocao = checkRemocao.Checked;
        }

        private void checkContador_CheckedChanged(object sender, EventArgs e)
        {
            imageGallery1.MostrarContador = checkContador.Checked;
        }
    }
}
