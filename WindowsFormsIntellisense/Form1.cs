using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsIntellisense
{
    //                                                                          ,     \    /      ,
    //                                                                         / \    )\__/(     / \   
    //                                                                        /   \  (_\  /_)   /   \                
    //                                                     __________________/_____\__\@  @/___/_____\_________________
    //                                                     |                          |\../|                          |
    //                                                     |                           \VV/                           |
    //                                                     |                     Here Be Dragons                      |
    //                                                     |                                                          |
    //                                                     |                    Be aware of magic!                    |
    //                                                     |                                                          |
    //                                                     |__________________________________________________________|
    //                                                                   |    /\ /      \\       \ /\    |
    //                                                                   |  /   V        ))       V   \  |
    //                                                                   |/     `       //        '     \|
    //                                                                   `              V                '                

    public partial class Form1 : Form
    {
        List<string> dictionary = new List<string>();
        string passed = "";
        BindingList<string> bs = new BindingList<string>();
        StringBuilder currentSelection = new StringBuilder();
        bool ascending = true;
        public Form1()
        {
            InitializeComponent();
            foreach (var font in FontFamily.Families)
                toolStripComboBox1.Items.Add(font.Name);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadTxt = new OpenFileDialog();
            loadTxt.Filter = "txt files (*.txt)| *.txt";
            if (loadTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bool add = false;
                    
                   
                    foreach (string line in File.ReadAllLines(loadTxt.FileName))
                    {
                        //if (!dictionary.Contains(line))
                        //{
                        //    dictionary.Add(line);
                        //    add = true;
                        //}
                        foreach (string word in line.Split(' '))
                        {
                            if (!dictionary.Contains(word) && word.All(Char.IsLetter) && word.Length > 0)
                            {
                                dictionary.Add(word);
                                add = true;
                            }
                        }
                    
                    
                    }
                        
                    
                    if (add)
                    {
                        dictionary.Sort();

                        bs = new BindingList<string>();
                        foreach (var s in dictionary)
                            bs.Add(s);
                        listBox2.DataSource = bs;

                        listBox1.DataSource = null;
                        listBox1.DataSource = dictionary;
                        //listBox2.DataSource = null;
                        //listBox2.DataSource = dictionary;    
                    }
                    //currentSelection.Clear();
                    //foreach (string line in File.ReadAllLines(loadTxt.FileName))
                    //    //foreach (string word in line.Split(' '))
                    //    //{
                    //    //    dictionary.Add(word);
                    //    //    //if (!dictionary.Contains(word) && word.All(Char.IsLetter))
                    //    //    //{
                    //    //    //    dictionary.Add(word);
                    //    //    //}
                    //    //}
                    //dictionary.Add(line);                        

                    //dictionary.Sort();
                    //foreach(string s in dictionary)
                    //    bs.Add(s);
                    //listBox2.DataSource = bs;                    
                    //listBox1.DataSource = dictionary;
                }
                catch
                {
                    MessageBox.Show("Incorrect file");
                }
            }
        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(char.IsLetter((char)e.KeyValue))
            {
                var point = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
                point.Y += 25;
                if (listBox1.Visible == false && dictionary.Count != 0)
                    listBox1.Visible = true;
                listBox1.Location = point;

                currentSelection.Append(char.ToLower((char)e.KeyValue));
                
                if(dictionary.Count != 0)
                {
                    
                    List<string> temp = new List<string>(dictionary.Where(s => s.ToLower().StartsWith(currentSelection.ToString())));
                    //string a = ((List<string>)listBox1.DataSource)[listBox1.SelectedIndex];
                    listBox1.DataSource = temp;

                    if (listBox1.Items.Count > 0)
                    {
                        //int selected = temp.IndexOf(a);
                        //listBox1.SelectedIndex = (selected == -1) ? 0 : selected;    
                        //listBox1.SelectedIndex = 0;

                    }
                    else
                    {
                        listBox1.Visible = false;
                        currentSelection.Clear();
                    }
                }
                
            }
            
            else{
                if (e.KeyCode == Keys.Tab && listBox1.Visible == true)
                {
                    richTextBox1.AppendText(listBox1.SelectedItem.ToString().Substring(currentSelection.Length));
                    listBox1.Visible = false;
                    currentSelection.Clear();
                }

                else if (e.KeyCode == Keys.Up && listBox1.SelectedIndex > 0)
                    listBox1.SelectedIndex--;
                else if (e.KeyCode == Keys.Up && listBox1.SelectedIndex == 0)
                    return;

                else if (e.KeyCode == Keys.Down && listBox1.SelectedIndex < (listBox1.Items.Count - 1))
                    listBox1.SelectedIndex++;
                else if (e.KeyCode == Keys.Down && listBox1.SelectedIndex == (listBox1.Items.Count - 1))
                    return;
                else if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Alt)
                    return;

                else
                {
                    currentSelection.Clear();
                    listBox1.Visible = false;
                }
                    
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTxt = new SaveFileDialog();
            saveTxt.Filter = "txt files (*.txt)| *.txt";
            if (saveTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    File.WriteAllLines(saveTxt.FileName, dictionary);                    
                }
                catch
                {
                    MessageBox.Show("Incorrect file");
                }
            }
        }  

        private void sort_Click(object sender, EventArgs e)
        {
            if (dictionary == null) return;
            if(ascending)
            {               
                bs = new BindingList<string>();
                for (int i = dictionary.Count - 1; i >= 0; i--)
                    bs.Add(dictionary[i]);

                ascending = false;
            }
            else
            {

                bs = new BindingList<string>();
                for (int i = 0; i < dictionary.Count; i++)
                    bs.Add(dictionary[i]);
                
                ascending = true;
            }
            listBox2.DataSource = bs;

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog(this);
            if (form2.DialogResult == DialogResult.OK)
            {
                int index = 0;
                while (index < dictionary.Count && string.Compare(form2.result, dictionary[index]) > 0)
                {
                    index++;
                }
                dictionary.Insert(index, form2.result);
                bs.Insert(index, form2.result);
                listBox2.DataSource = bs;
                listBox1.DataSource = null;                
                listBox1.DataSource = dictionary;

                //dictionary.Add(form2.result);
                //dictionary.Sort();
                //bs = new BindingList<string>(dictionary);
                //ascending = true;
                //listBox2.DataSource = bs;
                ////listBox1.DataSource = null;                
                //listBox1.DataSource = dictionary;
                ////listBox2.DataSource = null;
                //// listBox2.DataSource = dictionary;
            }
        }

        private void listBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //int where = listBox2.SelectedIndex;
                //var items = listBox2.SelectedItems;
                //int count = items.Count;
                //foreach (var item in listBox2.SelectedItems)
                //{
                //    dictionary.Remove(item.ToString());
                //    ((BindingList<string>)listBox2.DataSource).Remove(item.ToString());

                //}
                for (int i = 0; i < listBox2.SelectedItems.Count; i++)//items.Count; i++)
                {

                    dictionary.Remove(listBox2.SelectedItems[i].ToString());
                    //((BindingList<string>)listBox2.DataSource).Remove(listBox2.SelectedItems[i].ToString());
                }
                bs = new BindingList<string>();
                for (int i = 0; i < dictionary.Count; i++)
                    bs.Add(dictionary[i]);
                listBox2.DataSource = bs;
                //if (listBox2.SelectedIndex < bs.Count) ;


                //listBox2.SelectedIndex = (where < bs.Count) ? where : 0;
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            bool add = false;
            if (files.Length == 0) return;
            foreach (var file in files)
            {
                if (file.Substring(file.Length - 3) == "txt")
                {
                    foreach (string line in File.ReadAllLines(file))
                    {
                        //if (!dictionary.Contains(line))
                        //{
                        //    dictionary.Add(line);
                        //    add = true;
                        //}
                        foreach (string word in line.Split(' '))
                        {
                            if (!dictionary.Contains(word) && word.All(Char.IsLetter) && word.Length >0 )
                            {
                                dictionary.Add(word);
                                add = true;
                            }
                        }
                           
                        
                    }
                }
            }
            if(add)
            {
                dictionary.Sort();
                
                bs = new BindingList<string>();
                foreach (var s in dictionary)
                    bs.Add(s);
                listBox2.DataSource = bs;

                listBox1.DataSource = null;             
                listBox1.DataSource = dictionary;
                //listBox2.DataSource = null;
                //listBox2.DataSource = dictionary;    
            }


        }

        private void toolStripBold_Click(object sender, EventArgs e)
        {
            
            
            if (toolStripBold.Checked)
                //Make the selected Bold
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);
            else
                //Make the selected unBold
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Bold);
           
        }

        private void toolStripItalic_Click(object sender, EventArgs e)
        {
            
            if (toolStripItalic.Checked)
                //Make the selected Italic
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);
            else
                //Make the selected unItalic
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Italic);
            
        }

        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
           
            
            if (toolStripUnderline.Checked)
                //Make the selected Underlined
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline);
            else
                //Make the selected notUnderlined
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Underline);
            
        }

        private void toolStripTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cd.Color;
            }
        }

        private void toolStripBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = richTextBox1.GetCharIndexFromPosition(e.Location);
                int start = index;
                int end = index;
                var contextMenu = new ContextMenuStrip();
                
                if (index >= 0 && index < richTextBox1.Text.Length)
                {
                    while (start - 1 >= 0 && (richTextBox1.Text[start - 1] != ' ' && richTextBox1.Text[start - 1] != '\n'))
                        start--;
                    while (end + 1 < richTextBox1.Text.Length && (richTextBox1.Text[end + 1] != ' ' && richTextBox1.Text[end + 1] != '\n'))                
                        end++;
                    passed = richTextBox1.Text.Substring(start, end - start + 1);

                }                

                if (dictionary.Contains(passed))
                {
                    contextMenu.Items.Add("Remove " + passed);
                    contextMenu.ItemClicked += DeleteFromDict;
                }
                else
                {
                    contextMenu.Items.Add("Add " + passed);
                    contextMenu.ItemClicked += AddToDict;
                }

                             
                richTextBox1.ContextMenuStrip = contextMenu;
            }
        }

        private void AddToDict(object sender, EventArgs e)
        {
            
            var form2 = new Form2(passed);
            form2.ShowDialog(this);
            if (form2.DialogResult == DialogResult.OK)
            {
                if (!dictionary.Contains(form2.result))
                {
                    dictionary.Add(form2.result);
                    dictionary.Sort();
                    ascending = true;
                    bs = new BindingList<string>();
                    foreach (var s in dictionary)
                        bs.Add(s);
                    listBox2.DataSource = bs;
                    listBox1.DataSource = null;
                    //listBox2.DataSource = null;
                    listBox1.DataSource = dictionary;
                    //listBox2.DataSource = dictionary;
                }
            }
        }

        private void DeleteFromDict(object sender, EventArgs e)
        {
            if (dictionary.Remove(passed))
            {
                bs.Remove(passed);
                listBox2.DataSource = bs;
                listBox1.DataSource = null;
                //listBox2.DataSource = null;
                listBox1.DataSource = dictionary;
                //listBox2.DataSource = dictionary;
            }
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var Font = FontFamily.Families[toolStripComboBox1.SelectedIndex];
            richTextBox1.Font = new Font(toolStripComboBox1.SelectedItem as string, 12, richTextBox1.Font.Style);
            richTextBox1.Focus();
            return;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
