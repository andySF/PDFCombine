using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;

namespace PDFCombine
{
    public partial class frmDetailsSettings : Form
    {
        BackgroundWorker readFonts;
        public frmDetailsSettings()
        {
            InitializeComponent();

            //loading fonts message
            cbDetailsFont.Items.Add("Loading Fonts...");
            cbDetailsFont.SelectedIndex = 0;
            cbWatermarkFont.Items.Add("Loading Fonts...");
            cbWatermarkFont.SelectedIndex = 0;

            readFonts = new BackgroundWorker();
            readFonts.DoWork += new DoWorkEventHandler(readFonts_DoWork);
            readFonts.RunWorkerCompleted += new RunWorkerCompletedEventHandler(readFonts_RunWorkerCompleted);
            readFonts.RunWorkerAsync();

            CheckSecurityOptions();

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

            txtOwnerPassword.Text = PDFCombine.Properties.Settings.Default.ownerPassword;
            txtUserPassword.Text = PDFCombine.Properties.Settings.Default.userPassword;

            checkBoxPermitAnnotations.Checked = PDFCombine.Properties.Settings.Default.permitAnnotations;
            checkBoxPermitContentCopyingforAccesibility.Checked = PDFCombine.Properties.Settings.Default.permitAccessibilityExtractContent;
            checkBoxPermitDocumentAssembly.Checked = PDFCombine.Properties.Settings.Default.permitAssembleDocument;
            checkBoxPermitExtractContent.Checked = PDFCombine.Properties.Settings.Default.permitExtractContent;
            checkBoxPermitFullQualityPrinting.Checked = PDFCombine.Properties.Settings.Default.permitFullQualityPrint;
            checkBoxPermitModifyDocument.Checked = PDFCombine.Properties.Settings.Default.permitModifyDocument;
            checkBoxPermitPrinting.Checked = PDFCombine.Properties.Settings.Default.permitPrint;
            checkBoxPermitFillingForms.Checked = PDFCombine.Properties.Settings.Default.PermitFormsFill;

            txtTitle.Text = PDFCombine.Properties.Settings.Default.documentTitle;
            txtAuthor.Text = PDFCombine.Properties.Settings.Default.documentAuthor;
            txtSubject.Text = PDFCombine.Properties.Settings.Default.documentSubject;
            txtKeywords.Text = PDFCombine.Properties.Settings.Default.documentKeywords;

        }

        #region fonts methods

        private delegate void AddFontCallback(String itm);
        private void AddFont(String itm)
        {
            if (cbDetailsFont.InvokeRequired || cbWatermarkFont.InvokeRequired)
            {
                AddFontCallback d = new AddFontCallback(AddFont);
                this.Invoke(d, new object[] { itm });
            }
            else
            {
                cbDetailsFont.Items.Add(itm);
                cbWatermarkFont.Items.Add(itm);
            }
        }
        void readFonts_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //cleaning loading message
            cbWatermarkFont.Items.RemoveAt(0);
            cbDetailsFont.Items.RemoveAt(0);
            cbWatermarkFont.SelectedIndex = 0;
            cbDetailsFont.SelectedIndex = 0;
        }

        void readFonts_DoWork(object sender, DoWorkEventArgs e)
        {
            //Thread.Sleep(5000); //time consuming task...
            InstalledFontCollection fonts = new InstalledFontCollection();
            for (int i = 0; i < fonts.Families.Length; i++)
            {
                AddFont(fonts.Families[i].Name);
            }
        }

        private bool IsStyleSupported(String familyName, FontStyle style)
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

            PDFCombine.Properties.Settings.Default.ownerPassword =txtOwnerPassword.Text;
            PDFCombine.Properties.Settings.Default.userPassword = txtUserPassword.Text;

            PDFCombine.Properties.Settings.Default.permitAnnotations = checkBoxPermitAnnotations.Checked;
            PDFCombine.Properties.Settings.Default.permitAccessibilityExtractContent = checkBoxPermitContentCopyingforAccesibility.Checked;
            PDFCombine.Properties.Settings.Default.permitAssembleDocument = checkBoxPermitDocumentAssembly.Checked;
            PDFCombine.Properties.Settings.Default.permitExtractContent = checkBoxPermitExtractContent.Checked;
            PDFCombine.Properties.Settings.Default.permitFullQualityPrint = checkBoxPermitFullQualityPrinting.Checked;
            PDFCombine.Properties.Settings.Default.permitModifyDocument = checkBoxPermitModifyDocument.Checked;
            PDFCombine.Properties.Settings.Default.permitPrint = checkBoxPermitPrinting.Checked;
            PDFCombine.Properties.Settings.Default.PermitFormsFill = checkBoxPermitFillingForms.Checked;

            PDFCombine.Properties.Settings.Default.documentTitle = txtTitle.Text;
            PDFCombine.Properties.Settings.Default.documentAuthor = txtAuthor.Text;
            PDFCombine.Properties.Settings.Default.documentSubject = txtSubject.Text;
            PDFCombine.Properties.Settings.Default.documentKeywords = txtKeywords.Text;

            PDFCombine.Properties.Settings.Default.Save();
        }

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

        private void txtOwnerPassword_TextChanged(object sender, EventArgs e)
        {
            CheckSecurityOptions();
        }

        private void CheckSecurityOptions()
        {
            if (txtOwnerPassword.Text != String.Empty)
                panelSecurityOptions.Enabled = true;
            else
                panelSecurityOptions.Enabled = false;
        }
     

    }
}
