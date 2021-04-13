using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_formatter
{
    public partial class Form1 : Form
    {
        private String command = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateSQLCommand_Click(object sender, EventArgs e)
        {
            //Separates each line
            String[] command_fields =
            textBoxFields.Text.Split(new Char[] { '\n', '\r' }, 
            StringSplitOptions.RemoveEmptyEntries); ;

            //Foreach line adds to command
            foreach(String field in command_fields)
            {
                command += field + ", ";
            }

            textBoxFields.AppendText(Environment.NewLine);
            textBoxFields.AppendText(Environment.NewLine);
            textBoxFields.AppendText(command);
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only reads text and spreadsheet (excel) files");

            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    String file_extension = Path.GetExtension(openFileDialog.FileName);

                    switch(file_extension)
                    {
                        case ".txt":
                            read_txt_file(openFileDialog.FileName);
                            break;

                        /*default:
                            MessageBox.Show("Invalid file extension!");
                            break;*/
                    }
                }
            }
        }

        private void read_txt_file(String filename) 
        {
            foreach(String field in File.ReadLines(filename))
            {
                command += field + ", ";
            }

            textBoxFields.AppendText(command);
        }

        private void buttonDeleteTextBox_Click(object sender, EventArgs e)
        {
            textBoxFields.Text = null;
        }
    }
}
