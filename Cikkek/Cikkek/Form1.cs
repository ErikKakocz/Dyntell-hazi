using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cikkek
{
    public partial class Form1 : Form
    {
        public BindingList<Item> _items = new BindingList<Item>();
        public BindingList<Item> _searchedItems;
        private bool isSaved;
        private bool Cancellation = false;

        public Form1()
        {
            InitializeComponent();
            isSaved = true;


        }

        private void save()
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.AddExtension = true;
                save.DefaultExt = ".csv";
                save.Filter = "Minden fájl|*.*|csv fájlok|*.csv";
                var res = save.ShowDialog();
                if (res == DialogResult.OK)
                {
                    using (CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(new StreamWriter(new FileStream(save.FileName, FileMode.Create), Encoding.GetEncoding(1252))))
                    {
                        Item header = new Item();
                        header.Cikknev = "Cikknev";
                        header.Cikkszam = "Cikkszam";
                        header.Vonalkod = "Vonalkod";
                        header.MennyisegiEgyseg = "MennyisegiEgyseg";
                        writer.Configuration.Delimiter = ";";
                        writer.WriteRecords(_items);
                        isSaved = true;
                    }

                }

            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool canDo = true;
            if (!isSaved)
                canDo = notSavedConfirmation();
            if (canDo)
            {
                using (OpenFileDialog load = new OpenFileDialog())
                {
                    load.Filter = "Minden fájl|*.*|csv fájlok|*.csv";
                    _items = new BindingList<Item>();
                    ItemBindingSource.DataSource = _items;
                    ItemBindingSource.CancelEdit();
                    load.CheckFileExists = true;
                    var res = load.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        backgroundLoader.RunWorkerAsync(load.FileName);

                    }
                }
                isSaved = true;

            }

      }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            ItemBindingSource.DataSource = _items;
            disableCancel();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var txt = SearchBox.Text;
            search(txt);
        }

        private void search(string txt)
        {
            if (txt.Equals(""))
                ItemBindingSource.DataSource = _items;
            _searchedItems = new BindingList<Item>();
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Cikknev.ToString().ToLower().Contains(txt.ToLower()) ||
                    _items[i].Cikkszam.ToString().ToLower().Contains(txt.ToLower()) ||
                    _items[i].Vonalkod.ToString().ToLower().Contains(txt.ToLower()) ||
                    _items[i].MennyisegiEgyseg.ToString().ToLower().Contains(txt.ToLower()))
                {
                    _searchedItems.Add(_items[i]);
                }

            }
            ItemBindingSource.DataSource = _searchedItems;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ItemBindingSource.CancelEdit();
            using (Form2 form = new Form2())
            {
                var res=form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _items.Add(form.ItemToReturn);
                    isSaved = false;
                }


            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Item itemToEdit=new Item();
            int itemIndex=-1;
            if (dataGridView1.SelectedRows.Count > 0)
                itemIndex = dataGridView1.SelectedRows[0].Index;
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Selected = true;
                itemIndex = dataGridView1.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Nincs elem kiválasztva!", "Hiba!",MessageBoxButtons.OK);
                return;
            }

            itemToEdit.Cikknev = _items[itemIndex].Cikknev;
            itemToEdit.Cikkszam = _items[itemIndex].Cikkszam;
            itemToEdit.Vonalkod = _items[itemIndex].Vonalkod;
            itemToEdit.MennyisegiEgyseg = _items[itemIndex].MennyisegiEgyseg;


            using (Form2 form = new Form2())
            {
                form.Text = "Cikk szerkesztése";
                form.ItemToReturn = itemToEdit;
                var res=form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _items[itemIndex] = form.ItemToReturn;
                    isSaved = false;
                }
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool canDo = true;
            if (!isSaved)
                canDo=notSavedConfirmation();
            if(canDo)
            {
                _items = new BindingList<Item>();
                ItemBindingSource.DataSource = _items;
                isSaved = true;
            }
        }

        private bool notSavedConfirmation() {
            using (Form3 form = new Form3())
            {
                var res = form.ShowDialog();
                if (res == DialogResult.Ignore)
                {
                    return true;
                }
                else if (res == DialogResult.OK)
                {
                    save();
                    return true;
                }
            }

            return false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void backgroundLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            enableCancel();

            string filename = (string)e.Argument;
                int rowCount = 0;
                using (CsvHelper.CsvReader reader = new CsvHelper.CsvReader(new StreamReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1252))))
                {

                    reader.Configuration.Delimiter = ";";
                    while (reader.Read())
                        rowCount++;


                }
                Debug.WriteLine("betöltendő: " + rowCount);
                using (CsvHelper.CsvReader reader = new CsvHelper.CsvReader(new StreamReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1252))))
                {
                    int readSoFar = 0;
                    reader.Configuration.Delimiter = ";";
                    while (reader.Read())
                    {
                        Invoke(new Action(() =>
                        {
                            _items.Add(reader.GetRecord<Item>());
                            
                            
                        }));
                        readSoFar++;
                        backgroundLoader.ReportProgress((int)Math.Round(((double)readSoFar * 100 )/ rowCount));
                        if (Cancellation)
                            break;
                }

                }
                
        }

        private void backgroundLoader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadinStatusBar.Value = e.ProgressPercentage;
        }

        private void backgroundLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            disableCancel();
        }

        private void disableCancel()
        {
            Invoke(new Action(() =>
            {
                CancelButton.Enabled = false;
                CancelButton.Hide();
            }));
            
        }

        private void enableCancel()
        {
            Invoke(new Action(() =>
            {
                CancelButton.Enabled = true;
                CancelButton.Show();
            }));
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancellation = true;
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                var txt = SearchBox.Text;
                search(txt);
            }
        }
    }
}
