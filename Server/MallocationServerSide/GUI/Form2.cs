using BLL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DAL;
namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ShowDetails();
           
        }

        ShopsBLL Shops_BLL = new ShopsBLL();
        audiencesBLL Malls_BLL = new audiencesBLL();

        private void ShowDetails()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Malls_BLL.GetAll().Select(a => a.AudienceName).ToArray());
        }

        public void ShowTable(AudiencesDTO audiences)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            AudiencesDTO audience_Tbl_dal = new AudiencesDTO();
            audience_Tbl_dal = Malls_BLL.GetAll().Find(a => a.AudienceName == comboBox1.SelectedItem.ToString());
            ShopsBLL.Add(new shops_tbl() { ShopName = textBox1.Text, IdFromAudience = audience_Tbl_dal.AudienceID });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
