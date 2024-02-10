using _3TierAdo.BLL.Entities;
using _3TierAdo.BLL.EntityLists;
using _3TierAdo.BLL.EntityManger;
using System.Diagnostics;

namespace _3TierAdo.PLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource bindingSource;
        TitleList titles = TitleManger.GetAllTitle();
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bindingSource = new BindingSource(titles, "");
            this.dataGridView1.DataSource = bindingSource;
            DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();

            dataGridViewComboBoxColumn.HeaderText="Publisher";
            dataGridViewComboBoxColumn.DataSource = PublisherMange.GetAllPuplisher();
            dataGridViewComboBoxColumn.ValueMember = "pub_id";
            dataGridViewComboBoxColumn.DisplayMember= "pub_name";
            dataGridViewComboBoxColumn.DataPropertyName = "pub_id";
            this.dataGridView1.Columns.Add(dataGridViewComboBoxColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in titles)
            {
                Trace.WriteLine(item.State);
            }
            List<Title> AlltitlesUpdates = titles.FindAll(titile => titile.State == BLL.Entities.EntityState.Modified);
            List<Title> AlltitlesAdded = titles.FindAll(titile => titile.State == BLL.Entities.EntityState.created);
            List<Title> AlltitlesDelete = titles.FindAll(titile => titile.State == BLL.Entities.EntityState.Deleted);
            if (TitleManger.EditeAllTitle(AlltitlesUpdates))
                MessageBox.Show("Process  successfully!");

            if (TitleManger.CreateTitle(AlltitlesAdded))
                MessageBox.Show("Process  successfully!");

           if (TitleManger.DeleteTitle(AlltitlesDelete))
             MessageBox.Show("Process  successfully!");
           
        }
    }
}
