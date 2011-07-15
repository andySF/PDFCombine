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

            colorPicker.BackColor = PDFCombine.Properties.Settings.Default.Details_TextColor;
            cbDetailsFont.Text = PDFCombine.Properties.Settings.Default.Details_Font;
            cbWriteFileName.Checked = PDFCombine.Properties.Settings.Default.Details_WriteFileName;
            cbWritePageNumbers.Checked = PDFCombine.Properties.Settings.Default.Details_WritePageNumber;
            numericUpDownDetailsSize.Value = PDFCombine.Properties.Settings.Default.Details_Size;

            cbWatermarkEnable.Checked = PDFCombine.Properties.Settings.Default.Watermark_Enabled;
            WatermarkUI(cbWatermarkEnable.Checked);
            txtWatermark.Text = PDFCombine.Properties.Settings.Default.Watermark_Text;
            cbWatermarkFont.Text = PDFCombine.Properties.Settings.Default.Watermark_Font;
            numericUpDownWatermarkSize.Value = PDFCombine.Properties.Settings.Default.Watermark_size;
            cbWatermarkLocation.Text = PDFCombine.Properties.Settings.Default.Watermark_Location;
            WatermarkUI(cbWatermarkEnable.Checked);
        }

        private void WatermarkUI(bool enabled)
        {
            if (enabled)
            {
                txtWatermark.Enabled = true;
                cbWatermarkFont.Enabled = true;
                cbWatermarkFont.Enabled = true;
                numericUpDownWatermarkSize.Enabled = true;
                cbWatermarkLocation.Enabled = true;
                panelWatermarkPreview.Enabled = true;
            }
            if (!enabled)
            {
                txtWatermark.Enabled = false;
                cbWatermarkFont.Enabled = false;
                cbWatermarkFont.Enabled = false;
                numericUpDownWatermarkSize.Enabled = false;
                cbWatermarkLocation.Enabled = false;
                panelWatermarkPreview.Enabled = false;
            }
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
                colorPicker.BackColor = cdlg.Color;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PDFCombine.Properties.Settings.Default.Details_TextColor = colorPicker.BackColor;
            PDFCombine.Properties.Settings.Default.Details_Font = cbDetailsFont.Text;
            PDFCombine.Properties.Settings.Default.Details_WriteFileName = cbWriteFileName.Checked;
            PDFCombine.Properties.Settings.Default.Details_WritePageNumber = cbWritePageNumbers.Checked;
            PDFCombine.Properties.Settings.Default.Details_Size = numericUpDownDetailsSize.Value;

            PDFCombine.Properties.Settings.Default.Watermark_Enabled = cbWatermarkEnable.Checked;
            PDFCombine.Properties.Settings.Default.Watermark_Text = txtWatermark.Text;
            PDFCombine.Properties.Settings.Default.Watermark_Font = cbWatermarkFont.Text;
            PDFCombine.Properties.Settings.Default.Watermark_size = numericUpDownWatermarkSize.Value;
            PDFCombine.Properties.Settings.Default.Watermark_Location = cbWatermarkLocation.Text;

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

        private void cbWatermarkEnable_CheckedChanged(object sender, EventArgs e)
        {
            WatermarkUI(cbWatermarkEnable.Checked);
        }

        private void cbWatermarkFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewWatermarkChanges();
        }

        private void numericUpDownWatermarkSize_ValueChanged(object sender, EventArgs e)
        {
            PreviewWatermarkChanges();
        }

        private void txtWatermark_TextChanged(object sender, EventArgs e)
        {
            PreviewWatermarkChanges();
        }

        private void PreviewWatermarkChanges()
        {
            if (IsStyleSupported(cbWatermarkFont.Text, FontStyle.Regular))
            {
                lblWatermarkFontPreview.Font = new Font(cbWatermarkFont.Text, 12, FontStyle.Regular);
            }
            else if (IsStyleSupported(cbWatermarkFont.Text, FontStyle.Bold))
            {
                lblWatermarkFontPreview.Font = new Font(cbWatermarkFont.Text, 12, FontStyle.Bold);
            }

            lblWatermarkFontPreview.Text = txtWatermark.Text;
        }

     

    }
}
