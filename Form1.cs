using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A108223041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string meal = "";
            int meal_price = 0;
            int meal_qu = 0;
            string meal2 = "";
            int meal2_price = 0;
            int meal2_qu = 0;
            string drink = "";
            int drink_price = 0;
            int drink_qu = 0;
            int total = 0;
            total = meal_price * meal_qu + meal2_price * meal2_qu + drink_price * drink_qu;
            if (total > 0)
            {
                MessageBox.Show("您的餐點有:" + "\n" + "主餐:" + meal + meal_qu + "份" + "," + (meal_price * meal_qu).ToString("c") + "\n" + "附餐:" + meal2 + meal2_qu + "份" + "," + (meal2_price * meal2_qu).ToString("c") +
                    "\n" + "飲料:" + drink + drink_qu + "份" + "," + (drink_price * drink_qu).ToString("c") + "\n" + "共需:" + total.ToString() + "元");
            }
            else
            {
                MessageBox.Show("您沒有點任何餐!", "結帳", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                if (checkBox1.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        meal = "牛排";
                        meal_price = 220;
                    }
                    else if (radioButton2.Checked)
                    {
                        meal = "豬排";
                        meal_price = 180;
                    }
                    else if (radioButton3.Checked)
                    {
                        meal = "雞腿排";
                        meal_price = 200;
                    }
                    if (checkBox2.Checked)
                    {
                        if (radioButton4.Checked)
                        {
                            meal2 = "酥皮濃湯";
                            meal2_price = 50;
                        }
                        else if (radioButton5.Checked)
                        {
                            meal2 = "沙拉";
                            meal2_price = 60;
                        }
                        else if (radioButton6.Checked)
                        {
                            meal2 = "蒜香麵包";
                            meal2_price = 40;
                        }
                    }
                    if (checkBox3.Checked)
                    {
                        if (radioButton7.Checked)
                        {
                            drink = "紅茶";
                            drink_price = 20;
                        }
                        else if (radioButton8.Checked)
                        {
                            drink = "奶茶";
                            drink_price = 25;
                        }
                        else if (radioButton9.Checked)
                        {
                            drink = "可樂";
                            drink_price = 30;
                        }
                    }
                    meal_qu = int.Parse(textBox1.Text);
                    meal2_qu = int.Parse(textBox2.Text);
                    drink_qu = int.Parse(textBox3.Text);
                }
            }   catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				pictureBox1.Image = Properties.Resources.牛排;
				MessageBox.Show("牛排，220元");
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				pictureBox1.Image = Properties.Resources.豬排;
				MessageBox.Show("豬排，180元");
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				pictureBox1.Image = Properties.Resources.雞腿排;
				MessageBox.Show("雞腿排，200元");
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				pictureBox2.Image = Properties.Resources.酥皮濃湯;
				MessageBox.Show("酥皮濃湯，50元");
			}
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton5.Checked)
			{
				pictureBox2.Image = Properties.Resources.沙拉;
				MessageBox.Show("沙拉，60元");
			}
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton6.Checked)
			{
				pictureBox2.Image = Properties.Resources.麵包;
				MessageBox.Show("蒜香麵包，40元");
			}
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton7.Checked)
			{
				pictureBox3.Image = Properties.Resources.紅茶;
				MessageBox.Show("紅茶，20元");
			}
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton8.Checked)
			{
				pictureBox3.Image = Properties.Resources.奶茶;
				MessageBox.Show("奶茶，25元");
			}
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton9.Checked)
			{
				pictureBox3.Image = Properties.Resources.可樂;
				MessageBox.Show("可樂，30元");
			}
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Enabled = true;
                pictureBox2.Visible = true;
            }
            else
            {
                groupBox2.Enabled = false;
                pictureBox2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                groupBox1.Enabled = false;
                pictureBox1.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox3.Enabled = true;
                pictureBox3.Visible = true;
            }
            else
            {
                groupBox3.Enabled = false;
                pictureBox3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
