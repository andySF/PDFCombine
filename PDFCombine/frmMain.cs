using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace PDFCombine
{
    public partial class frmMain : Form
    {
        FileUtils Files = new FileUtils();
        ListViewItem item;
        List<String> caleFisierePDF = new List<string>();
        string totalFilesForImport = string.Empty;
        String unsupportedPDF = "unsupported";
        String supportedPDF = "supported";
        String imageFile = "image";
        String combineButtonText = "Combine This Files";
        int totalOutputPages = 0;
        int noOfCurrentInvalidFiles = 0;
        int noOfTotalErrorFiles = 0;
        int totalFilesInList = 0;
        Thread checkUpdateThread;

        CanelOperationCallerEnum CanelOperationCaller;

        public frmMain()
        {
            InitializeComponent();
            SetUiToApplicationStartDefault();

            checkUpdateThread = new System.Threading.Thread(CheckForUpdate);
            checkUpdateThread.SetApartmentState(System.Threading.ApartmentState.STA);
            checkUpdateThread.Start();

            this.Text ="PDFCombine "+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " - http://www.olteteanu.com";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void CheckForUpdate()
        {
            if (CheckUpdate.IsUpdateAvailable())
            {
                if(MessageBox.Show("A new version of PDFCombine is available.\nDo you want to download the last version?", "A New Version is available", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                    Process.Start(CheckUpdate.GetUrlForDownload());
            }
        }

        #region IMPORT FILES 
        //delegate for accessing lvPDFs from backgroundworker
        private delegate void AddItemCallback(ListViewItem itm,String path);
        private void AddItem(ListViewItem itm, String path)
        {
            if (lvPDFs.InvokeRequired)
            {
                AddItemCallback d = new AddItemCallback(AddItem);
                this.Invoke(d, new object[] { itm,path });
            }
            else
            {
                //ListViewItem itm; itm = (ListViewItem)o;

                if (itm.Tag.ToString() == supportedPDF)
                    lvPDFs.Items.Add(itm).ImageIndex=0;
                else if (itm.Tag.ToString() == unsupportedPDF)
                {
                    lvPDFs.Items.Add(itm).ImageIndex = 1;
                    noOfCurrentInvalidFiles++;
                }
                else if (itm.Tag.ToString() == imageFile)
                    lvPDFs.Items.Add(itm).ImageIndex = 2;

                lvPDFs.Items[lvPDFs.Items.Count - 1].EnsureVisible();
               
            }
        }

        //delegate for accessing lvPDFs from backgroundworker
        private delegate void SetInfoCallback(String info);
        private void SetInfo(String info)
        {
            if (lvPDFs.InvokeRequired)
            {
                SetInfoCallback d = new SetInfoCallback(SetInfo);
                this.Invoke(d, new object[] {info });
            }
            else
            {
                lblInfo.Text = info;

            }
        }

        public void AddItemToList(String[] path)
        {
            if (!backgroundWorkerAddItemsToList.IsBusy)
            {
                SetUiForOperationInProgress(CanelOperationCallerEnum.Import);
                //setting outside the ui methods the buttonremoveerror
                btnRemoveErrors.Enabled = false;
                backgroundWorkerAddItemsToList.RunWorkerAsync(path);
            }
        }

        private void backgroundWorkerAddItemsToList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRemoveErrors.Enabled = true;
            if (noOfCurrentInvalidFiles != 0)
            {
                noOfTotalErrorFiles += noOfCurrentInvalidFiles;
                noOfCurrentInvalidFiles = 0;
            }
            SetUiBasedOnItemsInList();
            if (noOfCurrentInvalidFiles != 0)
            {
                MessageBox.Show(noOfCurrentInvalidFiles.ToString() + " Files was not imported", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
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
                    if ((extension.ToLower() == ".jpg") || extension.ToLower() == ".png" || extension.ToLower() == ".tif" || extension.ToLower() == ".tiff")
                        isImage = true;
                    if (isFile)
                    {
                        String[] col = new String[4];
                        if (isImage)
                        {
                            //set current pdf
                            //pdf.ReadThisPDF(path);
                            //check if file is compatible with PDFSharp

                            //int pages = pdf.PdfPageCount;
                           
                                //path
                                col[0] = path;
                                //pages
                                col[1] = "1";
                                totalOutputPages = totalOutputPages + 1;
                                //size
                                col[2] = Files.GetFileSize(path);
                                col[3] = "Ready";
                                item = new ListViewItem(col);
                                item.Tag = imageFile;
                                //lvPDFs.Refresh();
                                //add a complete verified version of file to list
                                item.ToolTipText = "Double Click to open " + Path.GetFileName(path) + " in your default image viewer!";
                                AddItem(item, path);
                        }
                        if (isPDF)
                        {
                            //set current pdf
                            Files.ReadThisPDF(path);
                            //check if file is compatible with PDFSharp

                            int pages = Files.PdfPageCount;
                            if (pages != 0)
                            {
                                //path
                                col[0] = path;
                                //pages
                                col[1] = pages.ToString();
                                totalOutputPages = totalOutputPages + pages;
                                //size
                                col[2] = Files.GetFileSize(path);
                                col[3] = Files.PdfInfo;
                                item = new ListViewItem(col);
                                item.Tag = supportedPDF;

                            }
                            if (pages == 0)
                            {

                                //path
                                col[0] = "File \"" + Path.GetFileName(path) + "\" is not supported by this program";
                                //pages
                                col[1] = "-";
                                //size
                                col[2] = "-";
                                col[3] = Files.PdfInfo;
                                item = new ListViewItem(col);
                                item.Tag = unsupportedPDF;
                            }
                            item.ToolTipText = "Double Click to open " + Path.GetFileName(path) + " in your default pdf reader!";
                            AddItem(item, path);
                        }//isPDF
                        
                        //lvPDFs.Refresh();
                        //add a complete verified version of file to list
                    }//if isFile
                }
                totalFilesInList++;
                SetInfo("TOTAL: " + totalFilesInList.ToString() + " files.");

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

                foreach (ListViewItem itm in lvPDFs.Items)
                {
                    String path = itm.SubItems[0].Text;
                    if ((itm.Tag.ToString() == supportedPDF)|itm.Tag.ToString()==imageFile)
                        if (File.Exists(path))
                            caleFisierePDF.Add(path);
                            
                }

                Files.caleFisierePDF = caleFisierePDF;

                Files.writeDetails = cbWriteDetails.Checked;

                //verifica daca fisierul este accesibil
                Files.caleOutput = saveFile.FileName;

                SetUiForOperationInProgress(CanelOperationCallerEnum.Combine);
                
                //disable btnremoveerrors while combining
                btnRemoveErrors.Enabled = false;
                backgroundWorkerCombine.RunWorkerAsync();

            }
        }

        private void backgroundWorkerCombine_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                    Files.CombinePDFs(sender);
                    if ((sender as System.ComponentModel.BackgroundWorker).CancellationPending == true)
                    {
                        e.Cancel = true;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void backgroundWorkerCombine_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = "Added page " + e.ProgressPercentage.ToString()+" from "+totalOutputPages.ToString();
        }

        private void backgroundWorkerCombine_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //enable btnremoveerrors 
            btnRemoveErrors.Enabled = true;

            if (e.Cancelled)
            {
                btnCancelOperation.Enabled = true;
                MessageBox.Show("Operation has been canceled", "CANCELED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                SetUiToApplicationStartDefault();

            if(!e.Cancelled)
            {
                var textForOpenningFile = String.Empty;
                if(cbOpenFile.Checked)
                    textForOpenningFile = "\n\nAfter your press ok the file will be opened with your default application";

                if (MessageBox.Show("Your file has been saved to:\n\n"+Files.caleOutput+textForOpenningFile, "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    if (cbOpenFile.Checked)
                    {
                        Process.Start(Files.caleOutput);
                    }
                }
            }
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
            SetUiForCancelOperation(CanelOperationCaller);
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
            SetUiToApplicationStartDefault();
        }
        #region UI

        private void SetUiWhileCombiningFiles()
        {

            btnCombinePDFs.Visible = false;
            btnSelectPDFs.Visible = false;
            btnClear.Visible = false;
            btnRemoveFromList.Visible = false;
            btnMoveItemDown.Visible = false;
            btnMoveItemUp.Visible = false;
            

            lblProgress.Visible = true;
            btnCancelOperation.Visible = true;
            CanelOperationCaller = CanelOperationCallerEnum.Combine;

        }

        private void SetUiForCancelOperation(CanelOperationCallerEnum CanelOperationCaller)
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

        private void SetUiForOperationInProgress(CanelOperationCallerEnum _CanelOperationCaller)
        {
            btnSettings.Enabled = false;
            btnSelectPDFs.Enabled = false;
            btnCombinePDFs.Visible = false;

            cbOpenFile.Enabled = false;
            cbWriteDetails.Enabled = false;

            lblProgress.Visible = true;
            lblProgress.Text = "Preparing...";

            lblInfo.Visible = true;
            lblInfo.Text = String.Empty;

            btnClear.Visible = false;

            btnRemoveFromList.Enabled = false;
            btnMoveItemDown.Enabled = false;
            btnMoveItemUp.Enabled = false;

            lvPDFs.AllowDrop = false;

            btnCancelOperation.Visible = true;
            btnCancelOperation.Enabled = true;

            CanelOperationCaller = _CanelOperationCaller;
            if (_CanelOperationCaller == CanelOperationCallerEnum.Import)
                btnCancelOperation.Text = "Cancel Import";
            if (_CanelOperationCaller == CanelOperationCallerEnum.Combine)
                btnCancelOperation.Text = "Cancel Combine";

        }

        private void SetUiBasedOnItemsInList()
        {

            lblInfo.Text = "TOTAL: " + totalFilesInList.ToString() + " files.";

            btnClear.Visible = true;

            lblProgress.Visible = false;
            lblProgress.Text = String.Empty;

            btnSelectPDFs.Enabled = true;
            btnCancelOperation.Visible = false;
            lvPDFs.AllowDrop = true;

            cbWriteDetails.Enabled = true;
            cbOpenFile.Enabled = true;

            btnSettings.Enabled = true;
            //if (cbWriteDetails.Checked)
            //    btnSettings.Visible = true;
            //if (!cbWriteDetails.Checked)
            //    btnSettings.Visible = false;

            if (noOfTotalErrorFiles != 0)
                btnRemoveErrors.Visible = true;
            if (noOfTotalErrorFiles == 0)
                btnRemoveErrors.Visible = false;

            if (lvPDFs.Items.Count != 0 && lvPDFs.Items.Count > 1)
            {
                btnCombinePDFs.Visible = true;
                btnCombinePDFs.Enabled = true;
                btnCombinePDFs.Text = combineButtonText;

                totalFilesForImport = String.Empty;

                btnRemoveFromList.Enabled = true;
                btnMoveItemDown.Enabled = true;
                btnMoveItemUp.Enabled = true;


            }
            if (lvPDFs.Items.Count == 1)
            {
                if (lvPDFs.Items[0].Tag.ToString() == imageFile)
                {
                    btnCombinePDFs.Visible = true;
                    btnCombinePDFs.Enabled = true;
                    btnCombinePDFs.Text = "Create PDF from image";

                    totalFilesForImport = String.Empty;

                    btnRemoveFromList.Enabled = true;
                    btnMoveItemDown.Enabled = false;
                    btnMoveItemUp.Enabled = false;


                }
                else
                {

                    btnRemoveFromList.Enabled = true;
                    btnCombinePDFs.Visible = true;
                    btnCombinePDFs.Enabled = false;
                    btnCombinePDFs.Text = "Add more files";
                }
            }
            if (lvPDFs.Items.Count == 0)
            {
                SetUiToApplicationStartDefault();
            }
        }

        private void SetUiToApplicationStartDefault()
        {

            lvPDFs.Items.Clear();
            lvPDFs.AllowDrop = true;
            caleFisierePDF.Clear();
            Files.AproximativeOutputSize = 0;
            totalOutputPages = 0;
            noOfTotalErrorFiles = 0;
            totalFilesInList = 0;

            btnSelectPDFs.Visible = true;
            btnSelectPDFs.Enabled = true;
            
            //setting UI for the first time
            btnClear.Visible = false;

            btnCancelOperation.Visible = false;

            btnCombinePDFs.Visible = false;

            lblProgress.Visible = false;
            lblProgress.Text = String.Empty;

            lblInfo.Visible = false;
            lblInfo.Text = String.Empty;

            btnMoveItemDown.Enabled = false;
            btnMoveItemUp.Enabled = false;
            btnRemoveFromList.Enabled = false;

           
                btnRemoveErrors.Visible = false;

            cbWriteDetails.Enabled = false;
            btnSettings.Enabled = true;

            cbOpenFile.Enabled = false;


            CanelOperationCaller = CanelOperationCallerEnum.Nobody;
        }

        #endregion UI

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



                    //String dragValue = caleFisierePDF[dragIndex];
                    //String itemValue = caleFisierePDF[itemIndex];
                    //caleFisierePDF[itemIndex] = dragValue;
                    //caleFisierePDF[dragIndex] = itemValue;

                    //Insert the item at the mouse pointer.
                    ListViewItem insertItem = (ListViewItem)dragItem.Clone();
                    lvPDFs.Items.Insert(itemIndex, insertItem);
                    lvPDFs.Items[itemIndex].Selected = true;

                    //Removes the item from the initial location while 
                    //the item is moved to the new location.
                    lvPDFs.Items.Remove(dragItem);
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
                //Point pt = lvPDFs.PointToClient(new Point(e.X, e.Y));
                //ListViewItem currentItemUnder = lvPDFs.GetItemAt(pt.X, pt.Y);
            
                e.Effect = DragDropEffects.Link;
            }
        }

        private void lvPDFs_DragLeave(object sender, EventArgs e)
        {
            
            
        }


        #endregion DRAG AND DROP METHODS

        #region ORDER MOETHODS
        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPDFs.SelectedItems)
            {
                lvPDFs.Items.Remove(item);
                
            }
            totalFilesInList = lvPDFs.Items.Count;
            SetUiBasedOnItemsInList();
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
            if (lvPDFs.Items[lvPDFs.SelectedItems[lvPDFs.SelectedItems.Count - 1].Index].Index == lvPDFs.Items[lvPDFs.Items.Count - 1].Index)
                return;
            ListViewItem dragToItem = lvPDFs.Items[lvPDFs.SelectedItems[lvPDFs.SelectedItems.Count - 1].Index + 1];
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
                int currentItem = dragItem.Index;


                int itemIndex = dragIndex;
                itemIndex++;




                ListViewItem insertItem = (ListViewItem)dragItem.Clone();

                lvPDFs.Items.Insert(itemIndex, insertItem);


                lvPDFs.Items.Remove(dragItem);
                lvPDFs.Focus();
                lvPDFs.Items[itemIndex - 1].Selected = true;
            }
        }
        #endregion ORDER MOETHODS

        private void lvPDFs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvPDFs.SelectedItems.Count != 0)
            {
                
                Process.Start(lvPDFs.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void btnRemoveErrors_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvPDFs.Items)
            {
                if (itm.Tag.ToString() == unsupportedPDF)
                {
                    itm.Remove();
                }
                totalFilesInList = lvPDFs.Items.Count;
                
            }
            noOfCurrentInvalidFiles = 0;
            noOfTotalErrorFiles = 0;
            SetUiBasedOnItemsInList();
        }

        private void cbWriteDetails_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbWriteDetails.Checked)
            //    btnSettings.Visible=true;
            //if (!cbWriteDetails.Checked)
            //    btnSettings.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmDetailsSettings fds = new frmDetailsSettings();
            fds.ShowDialog();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo fi = new frmInfo();
            fi.ShowDialog();
        }

      


 









    }
}
