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

namespace datagridview
{
    public partial class Form1 : Form
    {
        string fileName = "";
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void SaveTwoFiles(string filePath)
        {
            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                if(dataGridView1.Rows[row].Cells[1].Value != null)
                {
                     if (dataGridView1.Rows[row].Cells[1].Value.ToString() == "Male")
                     {
                        using (StreamWriter sw1 = new StreamWriter(filePath + @"\movies_male.txt"))
                        {
                           string lines = "";


                           for (int col = 0; col < dataGridView1.ColumnCount; col++)
                           {
                              if (dataGridView1.Rows[row].Cells[col].Value != null)
                              {
                                  lines += dataGridView1.Rows[row].Cells[col].Value.ToString() + ", ";
                                    
                              }
                           }
                           sw1.WriteLine(lines);


                        }
                    }
                    else
                    {
                        if (dataGridView1.Rows[row].Cells[1].Value.ToString() == "Female")
                        {
                            using (StreamWriter sw2 = new StreamWriter(filePath + @"\movies_female.txt"))
                            {
                                string lines = "";
                                for (int col = 0; col < dataGridView1.ColumnCount; col++)
                                {
                                    if (dataGridView1.Rows[row].Cells[col].Value != null)
                                    {
                                        lines += dataGridView1.Rows[row].Cells[col].Value.ToString() + ", ";
                                    }

                                }
                                sw2.WriteLine(lines);
                            }
                        }
                    }
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            fileName = textBoxFileName.Text;
            if (textBoxFileName.Text == null || textBoxFileName.Text == "")
            {
                string message = "Filling out file name is mandatory!";
                string caption = "Please fill out file name!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                
                if (fileName == "movies")
                {
                    SaveTwoFiles(filePath);
                   
                }
                else
                {
                    filePath = filePath + @"\" + fileName + ".txt";
                    SaveFile(filePath);
                }

            }
        }
        
        public void SaveFile(string filePath)
        {

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (var i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + "  ");
                }
                writer.WriteLine();

                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    string lines = "";
                    for (int col = 0; col < dataGridView1.ColumnCount; col++)
                    {
                        if (dataGridView1.Rows[row].Cells[col].Value != null)
                        {
                            lines += dataGridView1.Rows[row].Cells[col].Value.ToString() + ", ";
                        }
                    }
                    writer.WriteLine(lines);
                }
            }
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelFolder.Show();
                labelFolder.Text = folderBrowserDialog1.SelectedPath;
                filePath = folderBrowserDialog1.SelectedPath;
            }
            Console.WriteLine(result);
        }
    }
}
