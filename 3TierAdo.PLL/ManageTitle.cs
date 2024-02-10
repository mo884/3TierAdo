using _3TierAdo.BLL.Entities;
using _3TierAdo.BLL.EntityLists;
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

namespace _3TierAdo.PLL
{
    public partial class ManageTitle : Form
    {
        public ManageTitle()
        {
            InitializeComponent();
        }
        BindingSource bindingSource;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        TitleList titles = TitleManger.GetAllTitle();

        private void ManageTitle_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource(titles, "");
            this.listBox1.DataSource = bindingSource;
            this.listBox1.DisplayMember = "title";
            this.listBox1.ValueMember = "title_id";
         
            this.textBox4.DataBindings.Add("Text", bindingSource, "price");
            this.textBox7.DataBindings.Add("Text", bindingSource, "title");
            this.textBox3.DataBindings.Add("Text", bindingSource, "advance");
            this.textBox2.DataBindings.Add("Text", bindingSource, "royalty");
            this.textBox1.DataBindings.Add("Text", bindingSource, "ytd_sales");
            this.comboBox1.DataSource = PublisherMange.GetAllPuplisher();
            this.comboBox1.ValueMember ="pub_id";
            this.comboBox1.DisplayMember ="pub_name";
            this.comboBox1.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

            //Title title = TitleManger.GetTitleByID(listBox1.SelectedValue.ToString());
            
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            //List<Title> AlltitlesUpdates = new List<Title>();
            //AlltitlesUpdates.Add(new Title() { title_id=listBox1.SelectedValue.ToString(), title= this.textBox7.Text, pub_id=comboBox1.SelectedValue.ToString(),price=decimal.Parse(textBox4.Text) });
            //if (listBox1.SelectedItems.Count>0)
            //{
            //    if (TitleManger.EditeAllTitle(AlltitlesUpdates))
            //        MessageBox.Show("Process  successfully!");

            //}
        }
    }
}
