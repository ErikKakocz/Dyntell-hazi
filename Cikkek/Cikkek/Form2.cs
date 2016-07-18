using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cikkek
{
    public partial class Form2 : Form
    {
        public Item ItemToReturn { get; set; }
        private BindingList<String> ME= new BindingList<String>();

        public Form2()
        {
            InitializeComponent();
            Text = "Cikk hozzáadása";
            ME.Add("Darab");
            ME.Add("Pár");
            ME.Add("Csomag");
            ME.Add("Méter");
            MEBindingSource.DataSource = ME;
            ItemToReturn = new Item();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ItemBindingSource.DataSource = ItemToReturn;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
