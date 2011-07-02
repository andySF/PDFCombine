using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace PDFCombine
{
    public partial class frmMain : Form
    {
        PDFUtils pdf = new PDFUtils();
        ListViewItem item;
        List<String> caleFisierePDF = new List<string>();
        string totalFilesForImport = string.Empty;
        String unsupportedPDF = "supported";
        String supportedPDF = "unsupported";
        String imageFile = "image";
        String combineButtonText = "Combine This Files";
        int totalOutputPages = 0;
        CanelOperationCallerEnum CanelOperationCaller;
        public frmMain()
        {
            InitializeComponent();
            
  
            lblProgress.Text = String.Empty;

            //setting UI for the first time
            btnClear.Visible = false;
            
            btnCancelOperation.Visible = false;
            
            btnCombinePDFs.Visible = false;
            
            lblProgress.Visible = false;
            lblProgress.Text = String.Empty;
            
            lblTotalSize.Visible = false;
            lblTotalSize.Text = String.Empty;

            btnMoveItemDown.Enabled = false;
            btnMoveItemUp.Enabled = false;
            btnRemoveFromList.Enabled = false;

            cbWriteDetails.Enabled = false;
            cbOpenFile.Enabled = false;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region IMPORT FILES 
        //delegate for accessing lvPDFs from backgroundworker
        private delegate void AddItemCallback(object o);
        private void AddItem(object o)
        {
            if (lvPDFs.InvokeRequired)
            {
                AddItemCallback d = new AddItemCallback(AddItem);
                this.Invoke(d, new object[] { o });
            }
            else
            {
                ListViewItem itm; itm = (ListViewItem)o;

                if (itm.Tag.ToString() == supportedPDF)
                    lvPDFs.Items.Add((ListViewItem)o).ImageIndex=0;
                else if (itm.Tag.ToString() == unsupportedPDF)
                    lvPDFs.Items.Add((ListViewItem)o).ImageIndex = 1;
                else if (itm.Tag.ToString() == imageFile)
                    lvPDFs.Items.Add((ListViewItem)o).ImageIndex = 2;

               
            }
        }

        //delegate for accessing lvPDFs from backgroundworker
        private delegate void SetLblTotalSizeTextCallback(object o);
        private void SetLblTotalSizeText(object o)
        {
            if (lblTotalSize.InvokeRequired)
            {
                SetLblTotalSizeTextCallback d = new SetLblTotalSizeTextCallback(SetLblTotalSizeText);
                this.Invoke(d, new object[] { o });
            }
            else
            {
                lblTotalSize.Text = o.ToString();
            }
        }

        public void AddItemToList(String[] path)
        {
            if (!backgroundWorkerAddItemsToList.IsBusy)
            {
                backgroundWorkerAddItemsToList.RunWorkerAsync(path);
                btnSelectPDFs.Enabled = false;
                btnCombinePDFs.Visible = false;
                lblProgress.Visible = true;
                btnClear.Enabled = false;
                btnRemoveFromList.Enabled = false;
                btnMoveItemDown.Enabled = false;
                btnMoveItemUp.Enabled = false;
                lvPDFs.AllowDrop = false;
                lblProgress.Text = "Preparing...";
                btnCancelOperation.Visible = true;
                CanelOperationCaller = CanelOperationCallerEnum.Import;
            }

        }

        private void backgroundWorkerAddItemsToList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancelOperation.Enabled = true;
            lblProgress.Visible = false;
            lblProgress.Text = String.Empty;
            btnSelectPDFs.Enabled = true;
            btnCancelOperation.Visible = false;
            CanelOperationCaller = CanelOperationCallerEnum.Nobody;
            lvPDFs.AllowDrop = true;
            

            if (lvPDFs.Items.Count != 0)
            {
                btnCombinePDFs.Visible = true;
                btnCombinePDFs.Enabled = true;
                btnCombinePDFs.Text = combineButtonText;

                totalFilesForImport = String.Empty;
                btnClear.Enabled = true;
                btnRemoveFromList.Enabled = true;
                btnMoveItemDown.Enabled = true;
                btnMoveItemUp.Enabled = true;
            }
            if (lvPDFs.Items.Count == 1)
            {
                btnCombinePDFs.Enabled = false;
                btnCombinePDFs.Text = "Add more files";
            }
        }

        private void backgroundWorkerAddItemsToList_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = e.ProgressPercentage.ToString() + " / "+totalFilesForImport +" Files imported so far! Please wait for this operation to finish or press cancel to abort!";
        }

        private void backgroundWorkerAddItemsToList_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] paths = e.Argument as string[];
            int files = 1;
            totalFilesForImport = paths.Length.ToString();
            foreach (String path in paths)
            {
                if ((backgroundWorkerAddItemsToList.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    bool isFile = File.Exists(path);
                    bool isPDF = false;
                    bool isImage = false;
                    String extension = Path.GetExtension(path);
                    if (extension.ToLower() == ".pdf")
                        isPDF = true;
                    if ((extension.ToLower() == ".jpg")||extension.ToLower()==".png")
                        isImage = true;
                    if (isFile)
                    {
                        if (isImage)
                        {
                            //set current pdf
                            //pdf.ReadThisPDF(path);
                            //check if file is compatible with PDFSharp

                            //int pages = pdf.PdfPageCount;
                           
                                String[] col = new String[4];
                                //path
                                col[0] = path;
                                //pages
                                col[1] = "1";
                                totalOutputPages = totalOutputPages + 1;
                                //size
                                col[2] = pdf.GetPdfFileSize(path);
                                col[3] = "image";
                                item = new ListViewItem(col);
                                item.Tag = imageFile;

                                AddItem(item);
                                SetLblTotalSizeText("Aproximative output size= " + pdf.FormatSize(pdf.AproximativeOutputSize));
                                //lvPDFs.Refresh();
                                //add a complete verified version of file to list

                                caleFisierePDF.Add(path);
                        }
                        if (isPDF)
                        {
                            //set current pdf
                            pdf.ReadThisPDF(path);
                            //check if file is compatible with PDFSharp

                            int pages = pdf.PdfPageCount;
                            if (pages != 0)
                            {
                                String[] col = new String[4];
                                //path
                                col[0] = path;
                                //pages
                                col[1] = pages.ToString();
                                totalOutputPages = totalOutputPages + pages;
                                //size
                                col[2] = pdf.GetPdfFileSize(path);
                                col[3] = pdf.PdfSecurityLevel;
                                item = new ListViewItem(col);
                                item.Tag = supportedPDF;

                                AddItem(item);
                                SetLblTotalSizeText("Aproximative output size= " + pdf.FormatSize(pdf.AproximativeOutputSize));
                                //lvPDFs.Refresh();
                                //add a complete verified version of file to list
                                
                                caleFisierePDF.Add(path);
                            }
                            if (pages == 0)
                            {

                                String[] col = new String[4];
                                //path
                                col[0] = "File \"" + Path.GetFileName(path) + "\" is not supported by this program";
                                //pages
                                col[1] = "-";
                                //size
                                col[2] = "-";
                                col[3] = pdf.PdfSecurityLevel;
                                item = new ListViewItem(col);
                                item.Tag = unsupportedPDF;
                                AddItem(item);
                                SetLblTotalSizeText("Aproximative output size= " + pdf.FormatSize(pdf.AproximativeOutputSize));
                                //lvPDFs.Refresh();
                            }
                        }//isPDF

                    }//if isFile
                }

                backgroundWorkerAddItemsToList.ReportProgress((files++));
            }
        }

        #endregion

        #region COMBINE FILES

        private void btnCombinePDFs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "\"Combined PDF\"|*.PDF";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                pdf.caleFisierePDF = caleFisierePDF;
                pdf.writeDetails = cbWriteDetails.Checked;
                pdf.caleOutput = saveFile.FileName;

                btnCombinePDFs.Visible = false;
                lblProgress.Visible = true;
                btnCancelOperation.Visible = true;
                CanelOperationCaller = CanelOperationCallerEnum.Combine;

                backgroundWorkerCombine.RunWorkerAsync();

                if (cbOpenFile.Checked)
                {
                    Process.Start(saveFile.FileName);
                }
            }
        }

        private void backgroundWorkerCombine_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                    pdf.CombinePDFs(sender);
                    if ((sender as System.ComponentModel.BackgroundWorker).CancellationPending == true)
                    {
                        e.Cancel = true;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocured", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorkerCombine_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = "Added page " + e.ProgressPercentage.ToString()+" from "+totalOutputPages.ToString();
        }

        private void backgroundWorkerCombine_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                btnCancelOperation.Enabled = true;
                MessageBox.Show("Operation has been canceled","CANCELED",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            //fă funcții pt prepareGuiForOperation și altele
            ClearList();

            //lvPDFs.Items.Clear();
            //caleFisierePDF.Clear();
            //pdf.AproximativeOutputSize = 0;
            //totalOutputPages = 0;
            //lblTotalSize.Text = String.Empty;
            //btnMoveItemUp.Enabled = false;
            //btnMoveItemDown.Enabled = false;
            //btnRemoveFromList.Enabled = false;
            //btnCombinePDFs.Visible = false;
            btnCombinePDFs.Visible = true;
            pdf.writeDetails = cbWriteDetails.Checked;
            pdf.caleOutput = String.Empty;
            lblProgress.Visible = false;
            btnCancelOperation.Visible = false;
            CanelOperationCaller = CanelOperationCallerEnum.Nobody;

        }

        #endregion

        enum CanelOperationCallerEnum
        {
            Import,
            Combine,
            Nobody
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            switch (CanelOperationCaller)
            {
                case CanelOperationCallerEnum.Import:
                    lblProgress.Text = "Canceling import...";
                    btnCancelOperation.Enabled = false;
                    backgroundWorkerAddItemsToList.CancelAsync();
                    break;
                case CanelOperationCallerEnum.Combine:
                    btnCancelOperation.Enabled = false;
                    lblProgress.Text = "Canceling ...";
                    backgroundWorkerCombine.CancelAsync();
                    break;
                case CanelOperationCallerEnum.Nobody:
                    //Like null
                    break;
                default:
                    //nothing
                    break;
            }
        }
    
        private void btnSelectPDFs_Click(object sender, EventArgs e)
        {
            if (openPdfDialog.ShowDialog() == DialogResult.OK)
            {
                AddItemToList(openPdfDialog.FileNames);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void ClearList()
        {
            lvPDFs.Items.Clear();
            caleFisierePDF.Clear();
            pdf.AproximativeOutputSize = 0;
            totalOutputPages = 0;
            lblTotalSize.Text = String.Empty;
            btnMoveItemUp.Enabled = false;
            btnMoveItemDown.Enabled = false;
            btnRemoveFromList.Enabled = false;
            btnCombinePDFs.Visible = false;
        }

        #region  DRAG AND DROP METHODS

        private void lvPDFs_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //Begins a drag-and-drop operation in the ListView control.
            lvPDFs.DoDragDrop(lvPDFs.SelectedItems, DragDropEffects.Move);
        }

        private void lvPDFs_DragEnter(object sender, DragEventArgs e)
        {
            int len = e.Data.GetFormats().Length - 1;
            int i;
            for (i = 0; i <= len; i++)
            {
                if (e.Data.GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
                {
                    //The data from the drag source is moved to the target.	
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void lvPDFs_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Return if the items are not selected in the ListView control.
                if (lvPDFs.SelectedItems.Count == 0)
                {
                    return;
                }
                //Returns the location of the mouse pointer in the ListView control.
                Point cp = lvPDFs.PointToClient(new Point(e.X, e.Y));
                //Obtain the item that is located at the specified location of the mouse pointer.
                ListViewItem dragToItem = lvPDFs.GetItemAt(cp.X, cp.Y);
                if (dragToItem == null)
                {
                    return;
                }
                //Obtain the index of the item at the mouse pointer.
                int dragIndex = dragToItem.Index;
                ListViewItem[] sel = new ListViewItem[lvPDFs.SelectedItems.Count];
                for (int i = 0; i <= lvPDFs.SelectedItems.Count - 1; i++)
                {
                    sel[i] = lvPDFs.SelectedItems[i];
                }
                for (int i = 0; i < sel.GetLength(0); i++)
                {
                    //Obtain the ListViewItem to be dragged to the target location.
                    ListViewItem dragItem = sel[i];
                    int itemIndex = dragIndex;
                    if (itemIndex == dragItem.Index)
                    {
                        return;
                    }
                    if (dragItem.Index < itemIndex)
                        itemIndex++;
                    else
                        itemIndex = dragIndex + i;
                    //Insert the item at the mouse pointer.
                    ListViewItem insertItem = (ListViewItem)dragItem.Clone();
                    lvPDFs.Items.Insert(itemIndex, insertItem);
                    //Removes the item from the initial location while 
                    //the item is moved to the new location.
                    lvPDFs.Items.Remove(dragItem);
                    lvPDFs.Items[itemIndex].Selected = true;
                }

            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                AddItemToList(files);
            }
        }

        private void lvPDFs_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                e.Effect = DragDropEffects.Link;
                Point pt = lvPDFs.PointToClient(new Point(e.X, e.Y));
                ListViewItem itemUnder = lvPDFs.GetItemAt(pt.X, pt.Y);
            }
        }

        #endregion DRAG AND DROP METHODS

        #region ORDER MOETHODS
        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPDFs.SelectedItems)
            {
                lvPDFs.Items.Remove(item);
            }
        }

        //Based on microsoft example
        private void btnMoveItemUp_Click(object sender, EventArgs e)
        {
            if (lvPDFs.SelectedItems.Count == 0)
                return;
            
            if (lvPDFs.SelectedItems[0].Index == 0)
                return;
            ListViewItem dragToItem = lvPDFs.Items[lvPDFs.SelectedItems[0].Index-1];
            if (dragToItem == null)
            {
                return;
            }
            int dragIndex = dragToItem.Index;
            ListViewItem[] sel = new ListViewItem[lvPDFs.SelectedItems.Count];
            for (int i = 0; i <= lvPDFs.SelectedItems.Count - 1; i++)
            {
                sel[i] = lvPDFs.SelectedItems[i];
            }
            for (int i = 0; i < sel.GetLength(0); i++)
            {
                ListViewItem dragItem = sel[i];
                int itemIndex = dragIndex;
                if (itemIndex == dragItem.Index)
                {
                    return;
                }
                if (dragItem.Index < itemIndex)
                    itemIndex++;
                else
                    itemIndex = dragIndex + i;
                ListViewItem insertItem = (ListViewItem)dragItem.Clone();
                lvPDFs.Items.Insert(itemIndex, insertItem);
                lvPDFs.Items.Remove(dragItem);
                lvPDFs.Focus();
                lvPDFs.Items[itemIndex].Selected = true;
            }
        }

        private void btnMoveItemDown_Click(object sender, EventArgs e)
        {
            if (lvPDFs.SelectedItems.Count == 0)
            {
                return;
            }
            //if (lvPDFs.SelectedItems[lvPDFs.SelectedItems.Count-1].Index+lvPDFs.SelectedItems.Count-1 == lvPDFs.Items.Count)
            if(lvPDFs.Items[lvPDFs.SelectedItems[lvPDFs.SelectedItems.Count-1].Index].Index == lvPDFs.Items[lvPDFs.Items.Count-1].Index)
                return;
            ListViewItem dragToItem = lvPDFs.Items[lvPDFs.SelectedItems[lvPDFs.SelectedItems.Count-1].Index + 1];
            if (dragToItem == null)
            {
                return;
            }
            int dragIndex = dragToItem.Index;
            ListViewItem[] sel = new ListViewItem[lvPDFs.SelectedItems.Count];
            for (int i = 0; i <= lvPDFs.SelectedItems.Count - 1; i++)
            {
                sel[i] = lvPDFs.SelectedItems[i];
            }
            for (int i = 0; i < sel.GetLength(0); i++)
            {
                ListViewItem dragItem = sel[i];
                int itemIndex = dragIndex;
                if (itemIndex == dragItem.Index)
                {
                    return;
                }
                if (dragItem.Index < itemIndex)
                    itemIndex++;
                else
                    itemIndex = dragIndex + i;
                ListViewItem insertItem = (ListViewItem)dragItem.Clone();
                lvPDFs.Items.Insert(itemIndex, insertItem);
                lvPDFs.Items.Remove(dragItem);
                lvPDFs.Focus();
                lvPDFs.Items[itemIndex-1].Selected = true;
            }
        }
        #endregion ORDER MOETHODS







    }
}
