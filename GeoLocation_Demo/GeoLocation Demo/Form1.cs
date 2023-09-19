using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SWDev_Project_Hint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void ReadTextFile(string strPath)
        {
            StreamReader stReader = new StreamReader(strPath, Encoding.GetEncoding("UTF-8"));
            tbContent.Text = stReader.ReadToEnd();
            //tbCurrentLine
            stReader.Close();
        }
		private void btExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void btOK_Click(object sender, EventArgs e)
		{ 
            ReadTextFile(tbInputFile.Text);
		}

		private void btBrowse_Click(object sender, EventArgs e)
		{

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"Documents",
                Title = "Browse for the text file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "data file(*.txt)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
				tbInputFile.Text =  openFileDialog1.FileName;
            }
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void Read1Line(string strData)
		{
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb ;
            Excel.Worksheet ws;
            Excel.Range rng;



            wb = excel.Workbooks.Open("C:\\Users\\User\\OneDrive\\Desktop\\My Works\\การพัฒนาระบบซอฟแวร์ 1\\SWDev-Project-Hint\\Dataset\\DataTest.xlsx");
            ws = wb.Worksheets[1];
            rng = ws.UsedRange;



            string[] data = new string[4];
            foreach (string line in System.IO.File.ReadLines(tbInputFile.Text))
            {
                data[0] = line;

                for (int i = 1; i <= rng.Rows.Count; i++) // Unfinished
                {
        
                    string keyword = ws.Cells[i, 1].Value();
                    Console.WriteLine(i);

                    if (data[0].Contains(keyword))
                    {
                        data[1] = line;
                    }
                    else
                    {
                        data[1] = "??";
                    }
                  
                }
                dataGridView1.Rows.Add(data);
            }

            wb.Close();
            Marshal.ReleaseComObject(wb);

            excel.Quit();
            Marshal.ReleaseComObject(excel);

        }
		private void btAnalyst_Click(object sender, EventArgs e)
		{
			Read1Line(tbInputFile.Text);
		}

        private void tbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInputFile_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
