namespace PDFCombine
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openPdfDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbWriteDetails = new System.Windows.Forms.CheckBox();
            this.cbOpenFile = new System.Windows.Forms.CheckBox();
            this.imageListPdf = new System.Windows.Forms.ImageList(this.components);
            this.lvPDFs = new System.Windows.Forms.ListView();
            this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPages = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSize = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorkerAddItemsToList = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.backgroundWorkerCombine = new System.ComponentModel.BackgroundWorker();
            this.btnRemoveErrors = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnMoveItemUp = new System.Windows.Forms.Button();
            this.btnMoveItemDown = new System.Windows.Forms.Button();
            this.btnRemoveFromList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCombinePDFs = new System.Windows.Forms.Button();
            this.btnSelectPDFs = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openPdfDialog
            // 
            this.openPdfDialog.Filter = "Supported Files|*.PDF;*.JPG;*.PNG|PDF files|*.PDF|JPEG Images|*.jpg|PNG Images|*." +
                "png";
            this.openPdfDialog.Multiselect = true;
            // 
            // cbWriteDetails
            // 
            this.cbWriteDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWriteDetails.AutoSize = true;
            this.cbWriteDetails.Location = new System.Drawing.Point(41, 475);
            this.cbWriteDetails.Name = "cbWriteDetails";
            this.cbWriteDetails.Size = new System.Drawing.Size(124, 17);
            this.cbWriteDetails.TabIndex = 3;
            this.cbWriteDetails.Text = "Write Page Numbers";
            this.cbWriteDetails.UseVisualStyleBackColor = true;
            this.cbWriteDetails.CheckedChanged += new System.EventHandler(this.cbWriteDetails_CheckedChanged);
            // 
            // cbOpenFile
            // 
            this.cbOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOpenFile.AutoSize = true;
            this.cbOpenFile.Location = new System.Drawing.Point(41, 498);
            this.cbOpenFile.Name = "cbOpenFile";
            this.cbOpenFile.Size = new System.Drawing.Size(117, 17);
            this.cbOpenFile.TabIndex = 4;
            this.cbOpenFile.Text = "Open after creation";
            this.cbOpenFile.UseVisualStyleBackColor = true;
            // 
            // imageListPdf
            // 
            this.imageListPdf.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPdf.ImageStream")));
            this.imageListPdf.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPdf.Images.SetKeyName(0, "file-pdf.png");
            this.imageListPdf.Images.SetKeyName(1, "error_delete.png");
            this.imageListPdf.Images.SetKeyName(2, "image.png");
            // 
            // lvPDFs
            // 
            this.lvPDFs.AllowDrop = true;
            this.lvPDFs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPDFs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPath,
            this.columnHeaderPages,
            this.columnHeaderSize,
            this.columnHeaderStatus});
            this.lvPDFs.FullRowSelect = true;
            this.lvPDFs.GridLines = true;
            this.lvPDFs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPDFs.LargeImageList = this.imageListPdf;
            this.lvPDFs.Location = new System.Drawing.Point(41, 63);
            this.lvPDFs.Name = "lvPDFs";
            this.lvPDFs.Size = new System.Drawing.Size(913, 406);
            this.lvPDFs.SmallImageList = this.imageListPdf;
            this.lvPDFs.TabIndex = 5;
            this.lvPDFs.UseCompatibleStateImageBehavior = false;
            this.lvPDFs.View = System.Windows.Forms.View.Details;
            this.lvPDFs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPDFs_MouseDoubleClick);
            this.lvPDFs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvPDFs_DragDrop);
            this.lvPDFs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvPDFs_DragEnter);
            this.lvPDFs.DragLeave += new System.EventHandler(this.lvPDFs_DragLeave);
            this.lvPDFs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvPDFs_ItemDrag);
            this.lvPDFs.DragOver += new System.Windows.Forms.DragEventHandler(this.lvPDFs_DragOver);
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 501;
            // 
            // columnHeaderPages
            // 
            this.columnHeaderPages.Text = "Pages";
            this.columnHeaderPages.Width = 125;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 110;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 151;
            // 
            // backgroundWorkerAddItemsToList
            // 
            this.backgroundWorkerAddItemsToList.WorkerReportsProgress = true;
            this.backgroundWorkerAddItemsToList.WorkerSupportsCancellation = true;
            this.backgroundWorkerAddItemsToList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAddItemsToList_DoWork);
            this.backgroundWorkerAddItemsToList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAddItemsToList_RunWorkerCompleted);
            this.backgroundWorkerAddItemsToList.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerAddItemsToList_ProgressChanged);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.Black;
            this.lblProgress.Location = new System.Drawing.Point(40, 559);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 16);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "label1";
            // 
            // backgroundWorkerCombine
            // 
            this.backgroundWorkerCombine.WorkerReportsProgress = true;
            this.backgroundWorkerCombine.WorkerSupportsCancellation = true;
            this.backgroundWorkerCombine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCombine_DoWork);
            this.backgroundWorkerCombine.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCombine_RunWorkerCompleted);
            this.backgroundWorkerCombine.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCombine_ProgressChanged);
            // 
            // btnRemoveErrors
            // 
            this.btnRemoveErrors.Image = global::PDFCombine.Properties.Resources.error_delete;
            this.btnRemoveErrors.Location = new System.Drawing.Point(8, 439);
            this.btnRemoveErrors.Name = "btnRemoveErrors";
            this.btnRemoveErrors.Size = new System.Drawing.Size(27, 30);
            this.btnRemoveErrors.TabIndex = 12;
            this.toolTipInfo.SetToolTip(this.btnRemoveErrors, "Remove not supported files");
            this.btnRemoveErrors.UseVisualStyleBackColor = true;
            this.btnRemoveErrors.Click += new System.EventHandler(this.btnRemoveErrors_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelOperation.Image = global::PDFCombine.Properties.Resources.cancel;
            this.btnCancelOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOperation.Location = new System.Drawing.Point(41, 525);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(117, 31);
            this.btnCancelOperation.TabIndex = 10;
            this.btnCancelOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipInfo.SetToolTip(this.btnCancelOperation, "Cancel");
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnMoveItemUp
            // 
            this.btnMoveItemUp.Image = global::PDFCombine.Properties.Resources.arrow_up;
            this.btnMoveItemUp.Location = new System.Drawing.Point(12, 118);
            this.btnMoveItemUp.Name = "btnMoveItemUp";
            this.btnMoveItemUp.Size = new System.Drawing.Size(23, 23);
            this.btnMoveItemUp.TabIndex = 9;
            this.toolTipInfo.SetToolTip(this.btnMoveItemUp, "Move selectet files up in the list");
            this.btnMoveItemUp.UseVisualStyleBackColor = true;
            this.btnMoveItemUp.Click += new System.EventHandler(this.btnMoveItemUp_Click);
            // 
            // btnMoveItemDown
            // 
            this.btnMoveItemDown.Image = global::PDFCombine.Properties.Resources.arrow_down;
            this.btnMoveItemDown.Location = new System.Drawing.Point(12, 147);
            this.btnMoveItemDown.Name = "btnMoveItemDown";
            this.btnMoveItemDown.Size = new System.Drawing.Size(23, 23);
            this.btnMoveItemDown.TabIndex = 8;
            this.toolTipInfo.SetToolTip(this.btnMoveItemDown, "Move selectet files down in the list");
            this.btnMoveItemDown.UseVisualStyleBackColor = true;
            this.btnMoveItemDown.Click += new System.EventHandler(this.btnMoveItemDown_Click);
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Image = global::PDFCombine.Properties.Resources.delete;
            this.btnRemoveFromList.Location = new System.Drawing.Point(12, 89);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveFromList.TabIndex = 7;
            this.toolTipInfo.SetToolTip(this.btnRemoveFromList, "Remove selected files");
            this.btnRemoveFromList.UseVisualStyleBackColor = true;
            this.btnRemoveFromList.Click += new System.EventHandler(this.btnRemoveFromList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::PDFCombine.Properties.Resources.bin_empty;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(845, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear list";
            this.toolTipInfo.SetToolTip(this.btnClear, "Clear list");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCombinePDFs
            // 
            this.btnCombinePDFs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombinePDFs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombinePDFs.Image = global::PDFCombine.Properties.Resources.File_Pdf_64;
            this.btnCombinePDFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombinePDFs.Location = new System.Drawing.Point(626, 529);
            this.btnCombinePDFs.Name = "btnCombinePDFs";
            this.btnCombinePDFs.Size = new System.Drawing.Size(328, 63);
            this.btnCombinePDFs.TabIndex = 0;
            this.btnCombinePDFs.Text = "Combine this files";
            this.toolTipInfo.SetToolTip(this.btnCombinePDFs, "Combine files");
            this.btnCombinePDFs.UseVisualStyleBackColor = true;
            this.btnCombinePDFs.Click += new System.EventHandler(this.btnCombinePDFs_Click);
            // 
            // btnSelectPDFs
            // 
            this.btnSelectPDFs.Image = global::PDFCombine.Properties.Resources.file_pdf;
            this.btnSelectPDFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPDFs.Location = new System.Drawing.Point(41, 16);
            this.btnSelectPDFs.Name = "btnSelectPDFs";
            this.btnSelectPDFs.Size = new System.Drawing.Size(192, 31);
            this.btnSelectPDFs.TabIndex = 0;
            this.btnSelectPDFs.Text = "Select Files";
            this.toolTipInfo.SetToolTip(this.btnSelectPDFs, "Select the files you want to combine");
            this.btnSelectPDFs.UseVisualStyleBackColor = true;
            this.btnSelectPDFs.Click += new System.EventHandler(this.btnSelectPDFs_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(780, 472);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 16);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "label1";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(171, 472);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(62, 23);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 604);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRemoveErrors);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnMoveItemUp);
            this.Controls.Add(this.btnMoveItemDown);
            this.Controls.Add(this.btnRemoveFromList);
            this.Controls.Add(this.lvPDFs);
            this.Controls.Add(this.cbOpenFile);
            this.Controls.Add(this.cbWriteDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCombinePDFs);
            this.Controls.Add(this.btnSelectPDFs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 500);
            this.Name = "frmMain";
            this.Text = "PDF Combine";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPDFs;
        private System.Windows.Forms.OpenFileDialog openPdfDialog;
        private System.Windows.Forms.Button btnCombinePDFs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbWriteDetails;
        private System.Windows.Forms.CheckBox cbOpenFile;
        private System.Windows.Forms.ImageList imageListPdf;
        private System.Windows.Forms.ListView lvPDFs;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderPages;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.Button btnRemoveFromList;
        private System.Windows.Forms.Button btnMoveItemDown;
        private System.Windows.Forms.Button btnMoveItemUp;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddItemsToList;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCombine;
        private System.Windows.Forms.Button btnRemoveErrors;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSettings;
    }
}

