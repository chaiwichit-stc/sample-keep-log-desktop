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

namespace SampleKeepLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeepLog_Click(object sender, EventArgs e)
        {

            // Check data
            if (txtData.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input data!");
                return;
            }

            // choose folder
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // keep log
            using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName,true,Encoding.UTF8))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string dataToKeep = txtData.Text;
                writer.WriteLine(timestamp + ": "+ dataToKeep);
            }

            
            MessageBox.Show("Keep log completed");
           

        }

    }
}
