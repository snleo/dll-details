using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_fileinfo
{
    public partial class FileInfoForm : Form
    {
        public FileInfoForm()
        {
            InitializeComponent();

            AssemblyName an = new AssemblyName(Assembly.GetExecutingAssembly().FullName);
            tbResult.Text = an.ToString();
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName;
                Analyse();
            }
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            Analyse();
        }

        private void Analyse()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Result for " + tbFile.Text + "\r\n");

            if (tbFile.Text.Contains('.'))
            {
                switch (tbFile.Text.Substring(tbFile.Text.LastIndexOf('.')).ToLower())
                {
                    case ".dll":
                        sb.Append("Description: " + DLLHelper.GetDescritpion(tbFile.Text) + "\r\n");
                        sb.Append("Version: " + DLLHelper.GetVersion(tbFile.Text) + "\r\n");
                        foreach (string s in DLLHelper.GetFullNames(tbFile.Text))
                            sb.Append("Assembly: " + s + "\r\n");
                        break;
                    default:
                        sb.Append("Don't know this type! \r\n");
                        break;
                }
            }
            tbResult.Text = sb.ToString();
        }
    }
}
