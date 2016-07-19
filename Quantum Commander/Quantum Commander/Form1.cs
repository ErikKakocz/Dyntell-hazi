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

namespace Quantum_Commander
{
    public partial class Form1 : Form
    {
        public BindingList<FileSystemElement> _tabOneElements = new BindingList<FileSystemElement>();
        public BindingList<FileSystemElement> _tabTwoElements = new BindingList<FileSystemElement>();
        public String currentDirTabOne;
        public String currentDirTabTwo;
        String[] _roots;

        public Form1()
        {
            InitializeComponent();
        }

        private void load()
        {
            _roots = Directory.GetLogicalDrives();
            currentDirTabOne = _roots[0];
            currentDirTabTwo = _roots[0];
            String[] dirs = Directory.GetDirectories(_roots[0]);
            String[] files = Directory.GetFiles(_roots[0]);
            foreach (String str in dirs)
            {
                Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.ElementName = str.Substring(str.LastIndexOf('\\')+1);
                element.Extension = "DIR";
                _tabOneElements.Add(element);
                _tabTwoElements.Add(element);
            }
            foreach (String str in files)
            {
                Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.Extension = str.Substring(str.LastIndexOf('.') + 1);
                
                element.ElementName = str.Substring(str.LastIndexOf('\\') + 1);
                _tabOneElements.Add(element);
                _tabTwoElements.Add(element);
            }

        }            

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tabOneBinding.DataSource = _tabOneElements;
            tabTwoBinding.DataSource = _tabTwoElements;
            tabOneBinding.CancelEdit();
            tabTwoBinding.CancelEdit();
            load();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String dirToOpen;
            if (dataGridView1.CurrentRow.Cells[1].Value.Equals("DIR"))
            {
                dirToOpen = currentDirTabOne+'\\'+(String)dataGridView1.CurrentRow.Cells[0].Value;


            }

                
        }
    }
}
