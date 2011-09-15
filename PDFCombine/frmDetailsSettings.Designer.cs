namespace PDFCombine
{
    partial class frmDetailsSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsSettings));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.Panel();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.cbWriteFileName = new System.Windows.Forms.CheckBox();
            this.cbWatermarkEnable = new System.Windows.Forms.CheckBox();
            this.txtWatermark = new System.Windows.Forms.TextBox();
            this.groupBoxWatermark = new System.Windows.Forms.GroupBox();
            this.panelWatermarkPreview = new System.Windows.Forms.Panel();
            this.lblWatermarkFontPreview = new System.Windows.Forms.Label();
            this.numericUpDownWatermarkSize = new System.Windows.Forms.NumericUpDown();
            this.cbWatermarkLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWatermarkFont = new System.Windows.Forms.ComboBox();
            this.cbWritePageNumbers = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDetailsFont = new System.Windows.Forms.ComboBox();
            this.lblFontDetailsFontPreview = new System.Windows.Forms.Label();
            this.panelDetailsPreview = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.numericUpDownDetailsSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageInPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlDocumentProperties = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelSecurityOptions = new System.Windows.Forms.Panel();
            this.checkBoxPermitPrinting = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitFillingForms = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitFullQualityPrinting = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitDocumentAssembly = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitContentCopyingforAccesibility = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitAnnotations = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitModifyDocument = new System.Windows.Forms.CheckBox();
            this.checkBoxPermitExtractContent = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOwnerPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxWatermark.SuspendLayout();
            this.panelWatermarkPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatermarkSize)).BeginInit();
            this.panelDetailsPreview.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsSize)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.tabPageInPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlDocumentProperties.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelSecurityOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(209, 455);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(309, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Location = new System.Drawing.Point(73, 21);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(28, 13);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Location = new System.Drawing.Point(8, 20);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(58, 13);
            this.lblTextColor.TabIndex = 2;
            this.lblTextColor.Text = "Text Color:";
            // 
            // cbWriteFileName
            // 
            this.cbWriteFileName.AutoSize = true;
            this.cbWriteFileName.Location = new System.Drawing.Point(49, 136);
            this.cbWriteFileName.Name = "cbWriteFileName";
            this.cbWriteFileName.Size = new System.Drawing.Size(96, 17);
            this.cbWriteFileName.TabIndex = 3;
            this.cbWriteFileName.Text = "Write file name";
            this.cbWriteFileName.UseVisualStyleBackColor = true;
            // 
            // cbWatermarkEnable
            // 
            this.cbWatermarkEnable.AutoSize = true;
            this.cbWatermarkEnable.Location = new System.Drawing.Point(7, 19);
            this.cbWatermarkEnable.Name = "cbWatermarkEnable";
            this.cbWatermarkEnable.Size = new System.Drawing.Size(59, 17);
            this.cbWatermarkEnable.TabIndex = 0;
            this.cbWatermarkEnable.Text = "Enable";
            this.cbWatermarkEnable.UseVisualStyleBackColor = true;
            this.cbWatermarkEnable.CheckedChanged += new System.EventHandler(this.cbWatermarkEnable_CheckedChanged);
            // 
            // txtWatermark
            // 
            this.txtWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWatermark.Location = new System.Drawing.Point(7, 42);
            this.txtWatermark.Name = "txtWatermark";
            this.txtWatermark.Size = new System.Drawing.Size(367, 26);
            this.txtWatermark.TabIndex = 1;
            this.txtWatermark.TextChanged += new System.EventHandler(this.txtWatermark_TextChanged);
            // 
            // groupBoxWatermark
            // 
            this.groupBoxWatermark.Controls.Add(this.panelWatermarkPreview);
            this.groupBoxWatermark.Controls.Add(this.numericUpDownWatermarkSize);
            this.groupBoxWatermark.Controls.Add(this.cbWatermarkLocation);
            this.groupBoxWatermark.Controls.Add(this.label4);
            this.groupBoxWatermark.Controls.Add(this.label2);
            this.groupBoxWatermark.Controls.Add(this.label1);
            this.groupBoxWatermark.Controls.Add(this.cbWatermarkFont);
            this.groupBoxWatermark.Controls.Add(this.cbWatermarkEnable);
            this.groupBoxWatermark.Controls.Add(this.txtWatermark);
            this.groupBoxWatermark.Location = new System.Drawing.Point(9, 180);
            this.groupBoxWatermark.Name = "groupBoxWatermark";
            this.groupBoxWatermark.Size = new System.Drawing.Size(380, 207);
            this.groupBoxWatermark.TabIndex = 6;
            this.groupBoxWatermark.TabStop = false;
            this.groupBoxWatermark.Text = "Watermark";
            // 
            // panelWatermarkPreview
            // 
            this.panelWatermarkPreview.BackColor = System.Drawing.Color.White;
            this.panelWatermarkPreview.Controls.Add(this.lblWatermarkFontPreview);
            this.panelWatermarkPreview.Location = new System.Drawing.Point(7, 154);
            this.panelWatermarkPreview.Name = "panelWatermarkPreview";
            this.panelWatermarkPreview.Size = new System.Drawing.Size(367, 33);
            this.panelWatermarkPreview.TabIndex = 14;
            // 
            // lblWatermarkFontPreview
            // 
            this.lblWatermarkFontPreview.AutoSize = true;
            this.lblWatermarkFontPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatermarkFontPreview.Location = new System.Drawing.Point(4, 6);
            this.lblWatermarkFontPreview.Name = "lblWatermarkFontPreview";
            this.lblWatermarkFontPreview.Size = new System.Drawing.Size(156, 20);
            this.lblWatermarkFontPreview.TabIndex = 12;
            this.lblWatermarkFontPreview.Text = "Please Select a Font";
            // 
            // numericUpDownWatermarkSize
            // 
            this.numericUpDownWatermarkSize.Location = new System.Drawing.Point(69, 101);
            this.numericUpDownWatermarkSize.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownWatermarkSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownWatermarkSize.Name = "numericUpDownWatermarkSize";
            this.numericUpDownWatermarkSize.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownWatermarkSize.TabIndex = 3;
            this.numericUpDownWatermarkSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cbWatermarkLocation
            // 
            this.cbWatermarkLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWatermarkLocation.FormattingEnabled = true;
            this.cbWatermarkLocation.Items.AddRange(new object[] {
            "TOP",
            "CENTER",
            "BOTTOM"});
            this.cbWatermarkLocation.Location = new System.Drawing.Point(69, 127);
            this.cbWatermarkLocation.Name = "cbWatermarkLocation";
            this.cbWatermarkLocation.Size = new System.Drawing.Size(116, 21);
            this.cbWatermarkLocation.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Font:";
            // 
            // cbWatermarkFont
            // 
            this.cbWatermarkFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWatermarkFont.FormattingEnabled = true;
            this.cbWatermarkFont.Location = new System.Drawing.Point(69, 74);
            this.cbWatermarkFont.Name = "cbWatermarkFont";
            this.cbWatermarkFont.Size = new System.Drawing.Size(305, 21);
            this.cbWatermarkFont.TabIndex = 2;
            this.cbWatermarkFont.SelectedIndexChanged += new System.EventHandler(this.cbWatermarkFont_SelectedIndexChanged);
            // 
            // cbWritePageNumbers
            // 
            this.cbWritePageNumbers.AutoSize = true;
            this.cbWritePageNumbers.Location = new System.Drawing.Point(151, 136);
            this.cbWritePageNumbers.Name = "cbWritePageNumbers";
            this.cbWritePageNumbers.Size = new System.Drawing.Size(119, 17);
            this.cbWritePageNumbers.TabIndex = 4;
            this.cbWritePageNumbers.Text = "Write Page Number";
            this.cbWritePageNumbers.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Font:";
            // 
            // cbDetailsFont
            // 
            this.cbDetailsFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetailsFont.FormattingEnabled = true;
            this.cbDetailsFont.Location = new System.Drawing.Point(49, 44);
            this.cbDetailsFont.Name = "cbDetailsFont";
            this.cbDetailsFont.Size = new System.Drawing.Size(325, 21);
            this.cbDetailsFont.TabIndex = 1;
            this.cbDetailsFont.SelectedIndexChanged += new System.EventHandler(this.cbDetailsFont_SelectedIndexChanged);
            // 
            // lblFontDetailsFontPreview
            // 
            this.lblFontDetailsFontPreview.AutoSize = true;
            this.lblFontDetailsFontPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontDetailsFontPreview.Location = new System.Drawing.Point(4, 6);
            this.lblFontDetailsFontPreview.Name = "lblFontDetailsFontPreview";
            this.lblFontDetailsFontPreview.Size = new System.Drawing.Size(156, 20);
            this.lblFontDetailsFontPreview.TabIndex = 0;
            this.lblFontDetailsFontPreview.Text = "Please Select a Font";
            // 
            // panelDetailsPreview
            // 
            this.panelDetailsPreview.BackColor = System.Drawing.Color.White;
            this.panelDetailsPreview.Controls.Add(this.lblFontDetailsFontPreview);
            this.panelDetailsPreview.Location = new System.Drawing.Point(49, 97);
            this.panelDetailsPreview.Name = "panelDetailsPreview";
            this.panelDetailsPreview.Size = new System.Drawing.Size(325, 33);
            this.panelDetailsPreview.TabIndex = 13;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.numericUpDownDetailsSize);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.colorPicker);
            this.groupBoxDetails.Controls.Add(this.panelDetailsPreview);
            this.groupBoxDetails.Controls.Add(this.lblTextColor);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.cbWriteFileName);
            this.groupBoxDetails.Controls.Add(this.cbDetailsFont);
            this.groupBoxDetails.Controls.Add(this.cbWritePageNumbers);
            this.groupBoxDetails.Location = new System.Drawing.Point(9, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(380, 168);
            this.groupBoxDetails.TabIndex = 14;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Footer Details";
            // 
            // numericUpDownDetailsSize
            // 
            this.numericUpDownDetailsSize.Location = new System.Drawing.Point(52, 71);
            this.numericUpDownDetailsSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDetailsSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDetailsSize.Name = "numericUpDownDetailsSize";
            this.numericUpDownDetailsSize.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownDetailsSize.TabIndex = 2;
            this.numericUpDownDetailsSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size:";
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageInPage);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlSettings.Location = new System.Drawing.Point(5, 5);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(410, 440);
            this.tabControlSettings.TabIndex = 15;
            // 
            // tabPageInPage
            // 
            this.tabPageInPage.Controls.Add(this.groupBoxDetails);
            this.tabPageInPage.Controls.Add(this.groupBoxWatermark);
            this.tabPageInPage.Controls.Add(this.label12);
            this.tabPageInPage.Location = new System.Drawing.Point(4, 22);
            this.tabPageInPage.Name = "tabPageInPage";
            this.tabPageInPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInPage.Size = new System.Drawing.Size(402, 414);
            this.tabPageInPage.TabIndex = 0;
            this.tabPageInPage.Text = "On Page Details";
            this.tabPageInPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlDocumentProperties);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Document Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlDocumentProperties
            // 
            this.tabControlDocumentProperties.Controls.Add(this.tabPage1);
            this.tabControlDocumentProperties.Controls.Add(this.tabPage3);
            this.tabControlDocumentProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDocumentProperties.Location = new System.Drawing.Point(3, 3);
            this.tabControlDocumentProperties.Name = "tabControlDocumentProperties";
            this.tabControlDocumentProperties.SelectedIndex = 0;
            this.tabControlDocumentProperties.Size = new System.Drawing.Size(396, 408);
            this.tabControlDocumentProperties.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtKeywords);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtAuthor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(70, 95);
            this.txtKeywords.Multiline = true;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(292, 90);
            this.txtKeywords.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Keywords:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(70, 69);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(292, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(70, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(292, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(70, 43);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(292, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelSecurityOptions);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtUserPassword);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtOwnerPassword);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(388, 382);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Security";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelSecurityOptions
            // 
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitPrinting);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitFillingForms);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitFullQualityPrinting);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitDocumentAssembly);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitContentCopyingforAccesibility);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitAnnotations);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitModifyDocument);
            this.panelSecurityOptions.Controls.Add(this.checkBoxPermitExtractContent);
            this.panelSecurityOptions.Location = new System.Drawing.Point(9, 194);
            this.panelSecurityOptions.Name = "panelSecurityOptions";
            this.panelSecurityOptions.Size = new System.Drawing.Size(367, 185);
            this.panelSecurityOptions.TabIndex = 11;
            // 
            // checkBoxPermitPrinting
            // 
            this.checkBoxPermitPrinting.AutoSize = true;
            this.checkBoxPermitPrinting.Location = new System.Drawing.Point(12, 2);
            this.checkBoxPermitPrinting.Name = "checkBoxPermitPrinting";
            this.checkBoxPermitPrinting.Size = new System.Drawing.Size(93, 17);
            this.checkBoxPermitPrinting.TabIndex = 0;
            this.checkBoxPermitPrinting.Text = "Permit Printing";
            this.checkBoxPermitPrinting.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitFillingForms
            // 
            this.checkBoxPermitFillingForms.AutoSize = true;
            this.checkBoxPermitFillingForms.Location = new System.Drawing.Point(12, 163);
            this.checkBoxPermitFillingForms.Name = "checkBoxPermitFillingForms";
            this.checkBoxPermitFillingForms.Size = new System.Drawing.Size(115, 17);
            this.checkBoxPermitFillingForms.TabIndex = 7;
            this.checkBoxPermitFillingForms.Text = "Permit Filling Forms";
            this.checkBoxPermitFillingForms.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitFullQualityPrinting
            // 
            this.checkBoxPermitFullQualityPrinting.AutoSize = true;
            this.checkBoxPermitFullQualityPrinting.Location = new System.Drawing.Point(12, 140);
            this.checkBoxPermitFullQualityPrinting.Name = "checkBoxPermitFullQualityPrinting";
            this.checkBoxPermitFullQualityPrinting.Size = new System.Drawing.Size(147, 17);
            this.checkBoxPermitFullQualityPrinting.TabIndex = 6;
            this.checkBoxPermitFullQualityPrinting.Text = "Permit Full Quality Printing";
            this.checkBoxPermitFullQualityPrinting.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitDocumentAssembly
            // 
            this.checkBoxPermitDocumentAssembly.AutoSize = true;
            this.checkBoxPermitDocumentAssembly.Location = new System.Drawing.Point(12, 25);
            this.checkBoxPermitDocumentAssembly.Name = "checkBoxPermitDocumentAssembly";
            this.checkBoxPermitDocumentAssembly.Size = new System.Drawing.Size(154, 17);
            this.checkBoxPermitDocumentAssembly.TabIndex = 1;
            this.checkBoxPermitDocumentAssembly.Text = "Permit Document Assembly";
            this.checkBoxPermitDocumentAssembly.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitContentCopyingforAccesibility
            // 
            this.checkBoxPermitContentCopyingforAccesibility.AutoSize = true;
            this.checkBoxPermitContentCopyingforAccesibility.Location = new System.Drawing.Point(12, 48);
            this.checkBoxPermitContentCopyingforAccesibility.Name = "checkBoxPermitContentCopyingforAccesibility";
            this.checkBoxPermitContentCopyingforAccesibility.Size = new System.Drawing.Size(206, 17);
            this.checkBoxPermitContentCopyingforAccesibility.TabIndex = 2;
            this.checkBoxPermitContentCopyingforAccesibility.Text = "Permit Content Copying for Accesibility";
            this.checkBoxPermitContentCopyingforAccesibility.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitAnnotations
            // 
            this.checkBoxPermitAnnotations.AutoSize = true;
            this.checkBoxPermitAnnotations.Location = new System.Drawing.Point(12, 71);
            this.checkBoxPermitAnnotations.Name = "checkBoxPermitAnnotations";
            this.checkBoxPermitAnnotations.Size = new System.Drawing.Size(114, 17);
            this.checkBoxPermitAnnotations.TabIndex = 3;
            this.checkBoxPermitAnnotations.Text = "Permit Annotations";
            this.checkBoxPermitAnnotations.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitModifyDocument
            // 
            this.checkBoxPermitModifyDocument.AutoSize = true;
            this.checkBoxPermitModifyDocument.Location = new System.Drawing.Point(12, 117);
            this.checkBoxPermitModifyDocument.Name = "checkBoxPermitModifyDocument";
            this.checkBoxPermitModifyDocument.Size = new System.Drawing.Size(141, 17);
            this.checkBoxPermitModifyDocument.TabIndex = 5;
            this.checkBoxPermitModifyDocument.Text = "Permit Modify Document";
            this.checkBoxPermitModifyDocument.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermitExtractContent
            // 
            this.checkBoxPermitExtractContent.AutoSize = true;
            this.checkBoxPermitExtractContent.Location = new System.Drawing.Point(12, 94);
            this.checkBoxPermitExtractContent.Name = "checkBoxPermitExtractContent";
            this.checkBoxPermitExtractContent.Size = new System.Drawing.Size(131, 17);
            this.checkBoxPermitExtractContent.TabIndex = 4;
            this.checkBoxPermitExtractContent.Text = "Permit Extract Content";
            this.checkBoxPermitExtractContent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtInfo);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 120);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDFCombine.Properties.Resources.tip;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(73, 1);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(287, 118);
            this.txtInfo.TabIndex = 8;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "User Password:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(104, 44);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(272, 20);
            this.txtUserPassword.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Owner Password:";
            // 
            // txtOwnerPassword
            // 
            this.txtOwnerPassword.Location = new System.Drawing.Point(104, 18);
            this.txtOwnerPassword.Name = "txtOwnerPassword";
            this.txtOwnerPassword.Size = new System.Drawing.Size(272, 20);
            this.txtOwnerPassword.TabIndex = 0;
            this.txtOwnerPassword.TextChanged += new System.EventHandler(this.txtOwnerPassword_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "*This options are available only if [Write Page Details] is checked";
            // 
            // frmDetailsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 495);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailsSettings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDFCombine settings";
            this.groupBoxWatermark.ResumeLayout(false);
            this.groupBoxWatermark.PerformLayout();
            this.panelWatermarkPreview.ResumeLayout(false);
            this.panelWatermarkPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatermarkSize)).EndInit();
            this.panelDetailsPreview.ResumeLayout(false);
            this.panelDetailsPreview.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsSize)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageInPage.ResumeLayout(false);
            this.tabPageInPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControlDocumentProperties.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelSecurityOptions.ResumeLayout(false);
            this.panelSecurityOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel colorPicker;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.CheckBox cbWriteFileName;
        private System.Windows.Forms.CheckBox cbWatermarkEnable;
        private System.Windows.Forms.TextBox txtWatermark;
        private System.Windows.Forms.GroupBox groupBoxWatermark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWatermarkFont;
        private System.Windows.Forms.CheckBox cbWritePageNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDetailsFont;
        private System.Windows.Forms.NumericUpDown numericUpDownWatermarkSize;
        private System.Windows.Forms.ComboBox cbWatermarkLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFontDetailsFontPreview;
        private System.Windows.Forms.Panel panelDetailsPreview;
        private System.Windows.Forms.Panel panelWatermarkPreview;
        private System.Windows.Forms.Label lblWatermarkFontPreview;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailsSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageInPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControlDocumentProperties;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOwnerPassword;
        private System.Windows.Forms.CheckBox checkBoxPermitPrinting;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxPermitExtractContent;
        private System.Windows.Forms.CheckBox checkBoxPermitAnnotations;
        private System.Windows.Forms.CheckBox checkBoxPermitContentCopyingforAccesibility;
        private System.Windows.Forms.CheckBox checkBoxPermitDocumentAssembly;
        private System.Windows.Forms.CheckBox checkBoxPermitModifyDocument;
        private System.Windows.Forms.CheckBox checkBoxPermitFullQualityPrinting;
        private System.Windows.Forms.CheckBox checkBoxPermitFillingForms;
        private System.Windows.Forms.Panel panelSecurityOptions;
        private System.Windows.Forms.Label label12;
    }
}