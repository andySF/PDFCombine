using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace PDFCombine
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
     
            try
            {
                Assembly creditAssm = Assembly.GetExecutingAssembly();
                using (Stream creditStream = creditAssm.GetManifestResourceStream("PDFCombine.info.rtf"))
                {
                    richTextBoxInfo.LoadFile(creditStream, RichTextBoxStreamType.RichText);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error accessing resources!");
            }

        }

        private void richTextBoxInfo_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
