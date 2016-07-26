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
            
            String[] dirs = Directory.GetDirectories(_roots[0]);
            String[] files = Directory.GetFiles(_roots[0]);
            foreach (String str in dirs)
            {
                //Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.ElementName = str.Substring(str.LastIndexOf('\\')+1);
                element.Extension = "DIR";
                _tabOneElements.Add(element);
                _tabTwoElements.Add(element);
            }
            foreach (String str in files)
            {
                //Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.Extension = str.Substring(str.LastIndexOf('.') + 1);
                
                element.ElementName = str.Substring(str.LastIndexOf('\\') + 1);
                _tabOneElements.Add(element);
                _tabTwoElements.Add(element);
            }

        }

        public bool isRootDir(String dir)
        {
            foreach (String directory in _roots)
                if (directory.Equals(dir))
                    return true;
            return false;
        }

        private void load(String currentDir,int tab)
        {
            String[] dirs;
            String[] files;
            try
            {
                dirs = Directory.GetDirectories(currentDir);
            }
            catch (Exception e) {
                dirs = new String[0];
            }
            try
            {
                files = Directory.GetFiles(currentDir);
            }
            catch (Exception e)
            {
                files = new String[0];
            }
            if (tab == 0)
                _tabOneElements.Clear();
            else
                _tabTwoElements.Clear();
            if (!isRootDir(currentDir))
            {
                FileSystemElement back= new FileSystemElement();
                back.ElementName = "..";
                back.Extension = null;
                if (tab == 0)
                    _tabOneElements.Add(back);
                else
                    _tabTwoElements.Add(back);
            }
            if(dirs.Length>0)
            foreach (String str in dirs)
            {
                //Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.ElementName = str.Substring(str.LastIndexOf('\\') + 1);
                element.Extension = "DIR";
                if(tab==0)
                    _tabOneElements.Add(element);
                else
                    _tabTwoElements.Add(element);
            }
            if(files.Length>0)
            foreach (String str in files)
            {

                //Debug.WriteLine(str);
                FileSystemElement element = new FileSystemElement();
                element.Extension = str.Substring(str.LastIndexOf('.') + 1);

                element.ElementName = str.Substring(str.LastIndexOf('\\') + 1);
                if (tab == 0)
                    _tabOneElements.Add(element);
                else
                    _tabTwoElements.Add(element);
            }
            setDirTextBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tabOneBinding.DataSource = _tabOneElements;
            tabTwoBinding.DataSource = _tabTwoElements;
            tabOneBinding.CancelEdit();
            tabTwoBinding.CancelEdit();
            _roots = Directory.GetLogicalDrives();
            currentDirTabOne = _roots[0];
            currentDirTabTwo = _roots[0];
            setDirTextBoxes();
            load();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Cells[0].Value.Equals(".."))
            {
                Debug.WriteLine("HereWeAre: " + dataGridView1.CurrentRow.Cells[0].Value);
                currentDirTabOne = currentDirTabOne.Substring(0, currentDirTabOne.LastIndexOf("\\"));
                if (currentDirTabOne.Equals("C:"))
                    currentDirTabOne = currentDirTabOne + '\\';
                Debug.WriteLine("currentdir: "+currentDirTabOne);
                
                load(currentDirTabOne, 0);
            }
            else if (dataGridView1.CurrentRow.Cells[1].Value.Equals("DIR"))
            {
                Debug.WriteLine("HereWeAre: " + dataGridView1.CurrentRow.Cells[0].Value);
                if (isRootDir(currentDirTabOne))
                    currentDirTabOne = currentDirTabOne + (String)dataGridView1.CurrentRow.Cells[0].Value;
                else
                    currentDirTabOne = currentDirTabOne + '\\' + (String)dataGridView1.CurrentRow.Cells[0].Value;
                Debug.WriteLine("currentdir: " + currentDirTabOne);
                
                load(currentDirTabOne, 0);

            }

                
        }

        private void setDirTextBoxes()
        {
            currentDirTabOneTextBox.Text = currentDirTabOne;
            currentDirTabTwoTextBox.Text = currentDirTabTwo;
        }
    }
}
