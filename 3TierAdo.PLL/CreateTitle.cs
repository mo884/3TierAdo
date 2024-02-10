using _3TierAdo.BLL.Entities;
using _3TierAdo.BLL.EntityManger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3TierAdo.PLL
{
    public partial class CreateTitle : Form
    {
        public CreateTitle()
        {
            InitializeComponent();
        }

        private void CreateTitle_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = PublisherMange.GetAllPuplisher();
            this.comboBox1.ValueMember ="pub_id";
            this.comboBox1.DisplayMember ="pub_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titleId = textBox3.Text;
            string titleName = textBox7.Text;
            string publisherId = comboBox1.SelectedValue.ToString();
            decimal price = decimal.Parse(textBox2.Text);
            decimal advance = decimal.Parse(textBox5.Text);
            int royalty = int.Parse(textBox6.Text);
            int ytdSales = int.Parse(textBox1.Text);
            string notes = textBox8.Text;

            Title updatedTitle = new Title
            {
                title_id = titleId,
                title = titleName,
                pub_id = publisherId,
                price = price,
                advance = advance,
                royalty = royalty,
                ytd_sales = ytdSales,
                notes = notes
            };
            if (TitleManger.CreateTitle(updatedTitle))
                this.Close();
        }
    }
}
