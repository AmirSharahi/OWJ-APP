using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OWJ_APP
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        private bool _nameMatchSuccess;
        private string _verificator{ get; set; }
        private int gheymat = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //in coda baadan virayesh mishe
            var GheymatLST = new List<int>() { 120000, 6940000, 65840000, 6416516, 316516, 651651 };
            var itemsLST = new List<string>();

            foreach (var item in docs_cb.Items)
            {
                itemsLST.Add(Convert.ToString(item));
            }

            for (int i = 0; i < itemsLST.Count; i++)
            {
                if (docs_cb.SelectedItem == itemsLST[i])
                {
                    gheymat += GheymatLST[i];
                }    
            }

            price_tb.Text = Convert.ToString(gheymat);
            //ta inja

            if (docs_cb.SelectedItem != null && radioButton4.Checked && !radioButton2.Checked)
                docsList.Items.Add(docs_cb.SelectedItem + " - " + "Normal" + " - " + _verificator);

            else if (docs_cb.SelectedItem != null && radioButton2.Checked && radioButton4.Checked)
                docsList.Items.Add(docs_cb.SelectedItem + " - " + "FORCE" + " - " + _verificator);

            else if (docs_cb.SelectedItem != null && radioButton2.Checked)
                docsList.Items.Add(docs_cb.SelectedItem + " - " + "FORCE");

            else if (docs_cb.SelectedItem != null && !radioButton2.Checked)
                docsList.Items.Add(docs_cb.SelectedItem + " - " + "Normal");

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            docs_cb.SelectedItem = null;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var validId = Regex.IsMatch(id_tb.Text, @"^([0-9]*)$");
            var validTelOffice = Regex.IsMatch(tel_tb.Text, @"^([0][2][1][0-9]*)$");
            var validName = Regex.IsMatch(name_tb.Text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
            var validEmail = Regex.IsMatch(email_tb.Text, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
            var validPhone = Regex.IsMatch(phone_tb.Text, @"^([0][9][0-9]*)$");
            var validPrice = Regex.IsMatch(forcePrice.Text, "^([0-9]*)$");
            var validList = new List<bool>() { validId, validTelOffice, validName, validEmail, validPhone, validPrice };
            var inputList = new List<TextBox>() { id_tb, tel_tb, name_tb, email_tb, phone_tb, forcePrice };
            for (int i = 0; i < validList.Count; i++)
            {
                if (!validList[i])
                {
                    inputList[i].Clear();
                }
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.AddRange(
            //    new object[]
            //    {
            //        "Title",
            //        "Priority",
            //        "Verification",
            //        "Verificator",
            //        "Price",
            //    });
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
            name_tb.MaxLength = 40;
        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {
            id_tb.MaxLength = 10;
        }

        private void phone_tb_TextChanged(object sender, EventArgs e)
        {
            phone_tb.MaxLength = 11;
        }

        private void tel_tb_TextChanged(object sender, EventArgs e)
        {
            tel_tb.MaxLength = 11;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                forcePrice.Enabled = true;
            else
            {
                forcePrice.Enabled = false;
                forcePrice.Text = null;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                verificator_gp.Enabled = true;
            else
            {
                verificator_gp.Enabled = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                _verificator = "office";
            else
                _verificator = "costumer";
        }

        private void docs_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docs_cb.SelectedItem == null)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
        }

        private void forcePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_tb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
