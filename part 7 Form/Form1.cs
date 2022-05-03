using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_7_Form
{
    public partial class Lists : Form
    {
        
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();


        public Lists()
        {
            InitializeComponent();
        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
          
        }

        private void lstHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Numbers sorted");
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Heroes sorted");
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: New numbers list");
            btnRemoveNumber.Enabled = true;
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: New heroes list");

        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            numbers.RemoveAt((Int32)lstNumbers.SelectedIndex);

            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Number removed");
            if (lstNumbers.SelectedItem == null)
                btnRemoveNumber.Enabled = false;
            
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {

        }
    }
}
