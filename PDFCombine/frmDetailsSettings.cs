using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PDFCombine
{
    public partial class frmDetailsSettings : Form
    {
        public frmDetailsSettings()
        {
            InitializeComponent();

            GetInstalledFonts();

            colorPicker.BackColor = PDFCombine.Properties.Settings.Default.TextColor;
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
                colorPicker.BackColor = cdlg.Color;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PDFCombine.Properties.Settings.Default.TextColor = colorPicker.BackColor;
            PDFCombine.Properties.Settings.Default.Save();
        }

        #region fonts methods
        private void GetInstalledFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            for (int i = 0; i < fonts.Families.Length; i++)
            {
                cbDetailsFont.Items.Add(fonts.Families[i].Name);
                cbWatermarkFont.Items.Add(fonts.Families[i].Name);
            }
        }

        private bool IsStyleSupported( String familyName,  FontStyle style)
        {
            try
            {
                Font f = new Font(familyName, 10, style);
                f.Dispose();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        #endregion 

        private void cbDetailsFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (IsStyleSupported(cbDetailsFont.Text, FontStyle.Regular))
            {
                lblFontDetailsFontPreview.Font = new Font(cbDetailsFont.Text, 10, FontStyle.Regular);
            }
            else if (IsStyleSupported(cbDetailsFont.Text, FontStyle.Bold))
            {
                lblFontDetailsFontPreview.Font = new Font(cbDetailsFont.Text, 10, FontStyle.Bold);
            }

            lblFontDetailsFontPreview.Text = cbDetailsFont.Text;

        }

    }
}
