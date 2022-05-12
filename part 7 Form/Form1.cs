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
        int removedNmbrs = 0;


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
            NumberUpdate();
            lblStatus.Text = ("Status: Numbers sorted");
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            HeroUpdate();
            lblStatus.Text = ("Status: Heroes sorted");
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            NumberUpdate();
            lblStatus.Text = ("Status: New numbers list");

        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            HeroUpdate();
            lblStatus.Text = ("Status: New heroes list");

        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex < 0)
                lblStatus.Text = ("Status: No item selected");
            else
            {
                numbers.RemoveAt((Int32)lstNumbers.SelectedIndex);
                NumberUpdate();
                lblStatus.Text = ("Status: Number removed");
            }




        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {


            if (heroes.Remove(txtRemoveHero.Text))
            {
                HeroUpdate();
                lblStatus.Text = ("Status: Hero(es) removed");
            }
            else
                lblStatus.Text = ("Hero name not found");
        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {

            if (lstNumbers.SelectedIndex < 0)
                lblStatus.Text = ("Status: No index selected");
            else
            while (numbers.Remove((Int32)lstNumbers.SelectedItem))
                {
                    removedNmbrs = removedNmbrs + 1;
                    lblStatus.Text = ($"Status: {removedNmbrs} number(s) have been removed");
                }

            removedNmbrs = 0;
            NumberUpdate();
        }
        private void NumberUpdate()
        {
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
        }
        private void HeroUpdate()
        {
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnAddHeroes_Click(object sender, EventArgs e)
        {
            heroes.Add(txtAddHeroes.Text);
            HeroUpdate();
            lblStatus.Text = ("Status: Hero added");
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            NumberUpdate();
            lblStatus.Text = ("Status: Decsending numbers sorted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heroes = heroes.ConvertAll(low => low.ToUpperInvariant());
            lblStatus.Text = ("Status: Heroes to upper");
            HeroUpdate();
        }

        private void heroesToLower_Click(object sender, EventArgs e)
        {
            heroes = heroes.ConvertAll(low => low.ToLowerInvariant());
            lblStatus.Text = ("Status: Heroes to lower");
            HeroUpdate();
        }
    }

}
