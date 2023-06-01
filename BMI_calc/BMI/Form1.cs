using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.BMI_калькулятор
{
    public partial class Form1 : Form
    {
        float hei;
        float wei;
        float imt;

        public Form1()
        {
            InitializeComponent();
            pictureBoxOverWeight.Visible = false;
            pictureBoxUnderWeight.Visible = false;
            pictureBoxHealthy.Visible = false;
            pictureBoxObese.Visible = false;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            hei = float.Parse(textBoxHeight.Text); 
            wei = float.Parse(textBoxWeight.Text);
            hei = hei / 100; //перевод роста в метры
            imt = wei / (hei * hei);
            label1BMI.Text = imt.ToString("N"); //с пом. N сокращаем число до 2 знаков
            trackBarBMI.Value = (int)imt;

            labelves.Visible = true;
            if (imt < 18.5)
            {
                labelves.Text = "Недостаточный вес";
                pictureBoxOverWeight.Visible = false;
                pictureBoxObese.Visible = false;
                pictureBoxHealthy.Visible = false;
                pictureBoxUnderWeight.Visible = true;

            }

            if ((imt > 18.5) & (imt < 24.9))
            {
                labelves.Text = "Здоровый вес";
                pictureBoxOverWeight.Visible = false;
                pictureBoxObese.Visible = false;
                pictureBoxUnderWeight.Visible = false;
                pictureBoxHealthy.Visible = true;
            }
 
            if ((imt > 24.9) & (imt < 29.9))
            {
                labelves.Text = "Избыточный вес";
                pictureBoxObese.Visible = false;
                pictureBoxUnderWeight.Visible = false;
                pictureBoxHealthy.Visible = false;
                pictureBoxOverWeight.Visible = true;
            }
            if (imt > 30)
            {
                labelves.Text = "Ожирение вес";
                pictureBoxOverWeight.Visible = false;
                pictureBoxUnderWeight.Visible = false;
                pictureBoxHealthy.Visible = false;
                pictureBoxObese.Visible = true;
            }
        }

        private void pictureBoxWoman_Click(object sender, EventArgs e)
        {
            pictureBoxWoman.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxWoman.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxMan.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMan_Click(object sender, EventArgs e)
        {
            pictureBoxMan.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxMan.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxWoman.BorderStyle = BorderStyle.None;
        }

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            textBoxHeight.Clear();
            textBoxWeight.Clear();
            label1BMI.Text = " ";
            labelves.Text = " ";
            pictureBoxOverWeight.Visible = false;
            pictureBoxUnderWeight.Visible = false;
            pictureBoxHealthy.Visible = false;
            pictureBoxObese.Visible = false;
            pictureBoxMan.BorderStyle = BorderStyle.None;
            pictureBoxWoman.BorderStyle = BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
