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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.Panel();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.cbWriteFileName = new System.Windows.Forms.CheckBox();
            this.cbEnableWatermark = new System.Windows.Forms.CheckBox();
            this.txtWatermark = new System.Windows.Forms.TextBox();
            this.groupBoxWatermark = new System.Windows.Forms.GroupBox();
            this.cbWatermarkFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWritePageNumbers = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDetailsFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownWatermarkSize = new System.Windows.Forms.NumericUpDown();
            this.lblFontDetailsFontPreview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxWatermark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatermarkSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(238, 514);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Location = new System.Drawing.Point(11, 20);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(13, 13);
            this.colorPicker.TabIndex = 1;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Location = new System.Drawing.Point(30, 20);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(55, 13);
            this.lblTextColor.TabIndex = 2;
            this.lblTextColor.Text = "Text Color";
            // 
            // cbWriteFileName
            // 
            this.cbWriteFileName.AutoSize = true;
            this.cbWriteFileName.Location = new System.Drawing.Point(45, 145);
            this.cbWriteFileName.Name = "cbWriteFileName";
            this.cbWriteFileName.Size = new System.Drawing.Size(101, 17);
            this.cbWriteFileName.TabIndex = 3;
            this.cbWriteFileName.Text = "Write file names";
            this.cbWriteFileName.UseVisualStyleBackColor = true;
            // 
            // cbEnableWatermark
            // 
            this.cbEnableWatermark.AutoSize = true;
            this.cbEnableWatermark.Location = new System.Drawing.Point(7, 19);
            this.cbEnableWatermark.Name = "cbEnableWatermark";
            this.cbEnableWatermark.Size = new System.Drawing.Size(59, 17);
            this.cbEnableWatermark.TabIndex = 4;
            this.cbEnableWatermark.Text = "Enable";
            this.cbEnableWatermark.UseVisualStyleBackColor = true;
            // 
            // txtWatermark
            // 
            this.txtWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWatermark.Location = new System.Drawing.Point(7, 42);
            this.txtWatermark.Name = "txtWatermark";
            this.txtWatermark.Size = new System.Drawing.Size(367, 26);
            this.txtWatermark.TabIndex = 5;
            // 
            // groupBoxWatermark
            // 
            this.groupBoxWatermark.Controls.Add(this.numericUpDownWatermarkSize);
            this.groupBoxWatermark.Controls.Add(this.comboBox3);
            this.groupBoxWatermark.Controls.Add(this.label4);
            this.groupBoxWatermark.Controls.Add(this.label2);
            this.groupBoxWatermark.Controls.Add(this.label1);
            this.groupBoxWatermark.Controls.Add(this.cbWatermarkFont);
            this.groupBoxWatermark.Controls.Add(this.cbEnableWatermark);
            this.groupBoxWatermark.Controls.Add(this.txtWatermark);
            this.groupBoxWatermark.Location = new System.Drawing.Point(11, 258);
            this.groupBoxWatermark.Name = "groupBoxWatermark";
            this.groupBoxWatermark.Size = new System.Drawing.Size(380, 250);
            this.groupBoxWatermark.TabIndex = 6;
            this.groupBoxWatermark.TabStop = false;
            this.groupBoxWatermark.Text = "Watermark Details";
            // 
            // cbWatermarkFont
            // 
            this.cbWatermarkFont.FormattingEnabled = true;
            this.cbWatermarkFont.Location = new System.Drawing.Point(69, 74);
            this.cbWatermarkFont.Name = "cbWatermarkFont";
            this.cbWatermarkFont.Size = new System.Drawing.Size(305, 21);
            this.cbWatermarkFont.TabIndex = 6;
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
            // cbWritePageNumbers
            // 
            this.cbWritePageNumbers.AutoSize = true;
            this.cbWritePageNumbers.Location = new System.Drawing.Point(152, 145);
            this.cbWritePageNumbers.Name = "cbWritePageNumbers";
            this.cbWritePageNumbers.Size = new System.Drawing.Size(124, 17);
            this.cbWritePageNumbers.TabIndex = 7;
            this.cbWritePageNumbers.Text = "Write Page Numbers";
            this.cbWritePageNumbers.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Font:";
            // 
            // cbDetailsFont
            // 
            this.cbDetailsFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetailsFont.FormattingEnabled = true;
            this.cbDetailsFont.Location = new System.Drawing.Point(45, 36);
            this.cbDetailsFont.Name = "cbDetailsFont";
            this.cbDetailsFont.Size = new System.Drawing.Size(285, 21);
            this.cbDetailsFont.TabIndex = 10;
            this.cbDetailsFont.SelectedIndexChanged += new System.EventHandler(this.cbDetailsFont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "TOP",
            "CENTER",
            "BOTTOM",
            "DIAGONAL"});
            this.comboBox3.Location = new System.Drawing.Point(69, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location:";
            // 
            // numericUpDownWatermarkSize
            // 
            this.numericUpDownWatermarkSize.Location = new System.Drawing.Point(69, 102);
            this.numericUpDownWatermarkSize.Maximum = new decimal(new int[] {
            50,
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
            this.numericUpDownWatermarkSize.TabIndex = 12;
            this.numericUpDownWatermarkSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblFontDetailsFontPreview
            // 
            this.lblFontDetailsFontPreview.AutoSize = true;
            this.lblFontDetailsFontPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontDetailsFontPreview.Location = new System.Drawing.Point(4, 6);
            this.lblFontDetailsFontPreview.Name = "lblFontDetailsFontPreview";
            this.lblFontDetailsFontPreview.Size = new System.Drawing.Size(156, 20);
            this.lblFontDetailsFontPreview.TabIndex = 12;
            this.lblFontDetailsFontPreview.Text = "Please Select a Font";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblFontDetailsFontPreview);
            this.panel1.Location = new System.Drawing.Point(45, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 33);
            this.panel1.TabIndex = 13;
            // 
            // frmDetailsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDetailsFont);
            this.Controls.Add(this.cbWritePageNumbers);
            this.Controls.Add(this.groupBoxWatermark);
            this.Controls.Add(this.cbWriteFileName);
            this.Controls.Add(this.lblTextColor);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetailsSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Write Details Settings";
            this.groupBoxWatermark.ResumeLayout(false);
            this.groupBoxWatermark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatermarkSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel colorPicker;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.CheckBox cbWriteFileName;
        private System.Windows.Forms.CheckBox cbEnableWatermark;
        private System.Windows.Forms.TextBox txtWatermark;
        private System.Windows.Forms.GroupBox groupBoxWatermark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWatermarkFont;
        private System.Windows.Forms.CheckBox cbWritePageNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDetailsFont;
        private System.Windows.Forms.NumericUpDown numericUpDownWatermarkSize;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFontDetailsFontPreview;
        private System.Windows.Forms.Panel panel1;
    }
}