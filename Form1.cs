using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            panel1.Visible = false;
            labeltop.Visible = false;
            labelofdrink.Visible = false;
            pictureBoxOfDrink.Visible = false;
            pictureBoxOfEnergy.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Финиш";
            labelofdrink.Text = "Ура";
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = false;
            labelofenergy.Visible = false;
            labelofinf.Visible = false;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = false;
            pictureBoxOfEnergy.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labeltop.Text = "Чекпоинт 1\nМЦК Лужники";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = false;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
            pictureBoxOfToilet.Location = new Point(33, 357);
            labeloftoilet.Location = new Point(110, 357);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = true;
            labeloftoilet.Visible = true;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = true;
            pictureBoxOfToilet.Visible = true;
            labeltop.Text = "Чекпоинт 2\nНоводевичей Монастырь";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
            labelofmedicine.Text = "Мед пункт";
            labeloftoilet.Text = "Туалет";
            pictureBoxOfToilet.Location = new Point(33, 357);
            labeloftoilet.Location = new Point(110, 357);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
            labeltop.Text = "Чекпоинт 3\nМетро Киевская";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = true;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = true;
            labeltop.Text = "Чекпоинт 4\nМИД";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
            labelofmedicine.Text = "Мед пункт";
            labeloftoilet.Text = "Туалет";
            pictureBoxOfToilet.Location = new Point(33, 286);
            labeloftoilet.Location = new Point(110, 286);


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = true;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = true;
            pictureBoxOfToilet.Visible = false;
            labeltop.Text = "Чекпоинт 5\nПарк Горького";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
            labelofmedicine.Text = "Мед пункт";
            pictureBoxOfToilet.Location = new Point(33, 357);
            labeloftoilet.Location = new Point(110, 357);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = true;
            labeloftoilet.Visible = true;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = true;
            pictureBoxOfToilet.Visible = true;
            labeltop.Text = "Чекпоинт 7\nМетро Воробьёвы Горы";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
            labelofmedicine.Text = "Мед пункт";
            labeloftoilet.Text = "Туалет";
            pictureBoxOfToilet.Location = new Point(33, 357);
            labeloftoilet.Location = new Point(110, 357);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = true;
            labeloftoilet.Visible = true;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = true;
            pictureBoxOfToilet.Visible = true;
            labeltop.Text = "Чекпоинт 8\nСтадион лужники";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
            labelofmedicine.Text = "Мед пункт";
            labeloftoilet.Text = "Туалет";
            pictureBoxOfToilet.Location = new Point(33, 357);
            labeloftoilet.Location = new Point(110, 357);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = true;
            labelofenergy.Visible = true;
            labelofinf.Visible = true;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = true;
            pictureBoxOfEnergy.Visible = true;
            pictureBoxOfInformation.Visible = true;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
            labeltop.Text = "Чекпоинт 6\nЗдание РАН";
            labelofdrink.Text = "Питьевые напитки";
            labelofenergy.Text = "Энергетические батончики";
            labelofinf.Text = "Стенд информации";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт гонки\nТрасса Samba Full Marathon";
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = false;
            labelofenergy.Visible = false;
            labelofinf.Visible = false;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = false;
            pictureBoxOfEnergy.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт гонки\nТрасса Capoeria 5km fun run";
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = false;
            labelofenergy.Visible = false;
            labelofinf.Visible = false;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = false;
            pictureBoxOfEnergy.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт гонки\nТрасса Jongo Half Marathon";
            panel1.Visible = true;
            labeltop.Visible = true;
            labelofdrink.Visible = false;
            labelofenergy.Visible = false;
            labelofinf.Visible = false;
            labelofmedicine.Visible = false;
            labeloftoilet.Visible = false;
            pictureBoxOfDrink.Visible = false;
            pictureBoxOfEnergy.Visible = false;
            pictureBoxOfInformation.Visible = false;
            pictureBoxOfMedical.Visible = false;
            pictureBoxOfToilet.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
