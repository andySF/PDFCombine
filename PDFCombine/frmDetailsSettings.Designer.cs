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
            this.groupBoxWatermark.SuspendLayout();
            this.panelWatermarkPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWatermarkSize)).BeginInit();
            this.panelDetailsPreview.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(198, 428);
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
            this.btnCancel.Location = new System.Drawing.Point(298, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 0;
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
            this.colorPicker.TabIndex = 1;
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
            this.cbWatermarkEnable.TabIndex = 4;
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
            this.txtWatermark.TabIndex = 5;
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
            this.groupBoxWatermark.Location = new System.Drawing.Point(12, 197);
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
            this.numericUpDownWatermarkSize.TabIndex = 12;
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
            this.cbWatermarkLocation.TabIndex = 11;
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
            this.cbWatermarkFont.TabIndex = 6;
            this.cbWatermarkFont.SelectedIndexChanged += new System.EventHandler(this.cbWatermarkFont_SelectedIndexChanged);
            // 
            // cbWritePageNumbers
            // 
            this.cbWritePageNumbers.AutoSize = true;
            this.cbWritePageNumbers.Location = new System.Drawing.Point(151, 136);
            this.cbWritePageNumbers.Name = "cbWritePageNumbers";
            this.cbWritePageNumbers.Size = new System.Drawing.Size(119, 17);
            this.cbWritePageNumbers.TabIndex = 7;
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
            this.cbDetailsFont.TabIndex = 10;
            this.cbDetailsFont.SelectedIndexChanged += new System.EventHandler(this.cbDetailsFont_SelectedIndexChanged);
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
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(380, 168);
            this.groupBoxDetails.TabIndex = 14;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
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
            this.numericUpDownDetailsSize.TabIndex = 15;
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
            // frmDetailsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 463);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxWatermark);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailsSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
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
    }
}