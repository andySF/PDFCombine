using System;
using System.Collections.Generic;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PDFCombine
{
    class FileUtils
    {
        
        public List<String> caleFisierePDF { get; set; }
        public bool writeDetails { get; set; }
        public String caleOutput { get; set; }
        

        int dpi = 100;
        

        public void CombinePDFs(object sender)
        {
            PdfDocument outputDocument = new PdfDocument();
            XGraphics gfx;
            XRect box;
            XRect boxShadow;
            PdfDocument fisierPDF;
            try
            {
                var details_font=PDFCombine.Properties.Settings.Default.Details_Font;
                var details_size = (float)PDFCombine.Properties.Settings.Default.Details_Size;
                var write_watermark = PDFCombine.Properties.Settings.Default.Watermark_Enabled;

                XFont font = new XFont(details_font, details_size, XFontStyle.Bold);

                XStringFormat format = new XStringFormat();
                format.Alignment = XStringAlignment.Center;
                format.LineAlignment = XLineAlignment.Far;
                

                int pgnr = 1;

                foreach (String caleFisierPDF in caleFisierePDF)
                {
                    
                    bool isPDF = false;
                    bool isImage=false;
                    String extension = Path.GetExtension(caleFisierPDF);
                    if (extension.ToLower() == ".pdf")
                        isPDF = true;
                    else if ((extension.ToLower() == ".jpg") || (extension.ToLower() == ".png") || (extension.ToLower() == ".tif") || (extension.ToLower() == ".tiff"))
                        isImage = true;



                    FileInfo f = new FileInfo(caleFisierPDF);
                    SolidBrush textBrush = new SolidBrush(PDFCombine.Properties.Settings.Default.Details_TextColor);
                    SolidBrush textBrush2 = new SolidBrush(Color.White);
                    SolidBrush watermarkBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
                    SolidBrush watermarkBrushShadow = new SolidBrush(Color.FromArgb(100, 255, 255, 255));

                    var details_writePageNr = PDFCombine.Properties.Settings.Default.Details_WritePageNumber;
                    var details_writeFileName = PDFCombine.Properties.Settings.Default.Details_WriteFileName;
                    var fName = String.Empty;
                    var _pgnr = String.Empty;
                    if (details_writeFileName)
                        fName = f.Name;
                    if (details_writePageNr)
                        _pgnr = pgnr.ToString();


                    if (isPDF)
                    {
                        fisierPDF = PdfReader.Open(caleFisierPDF, PdfDocumentOpenMode.Import);

                        //int curPageNr=0;
                        foreach (PdfPage _page in fisierPDF.Pages)
                        {
                            if ((sender as System.ComponentModel.BackgroundWorker).CancellationPending == true)
                            {
                                outputDocument.Close();
                                outputDocument.Dispose();
                                return;
                            }
                            else
                            {
                                _pgnr = pgnr++.ToString();
                                
                                //PdfPage page = fisierPDF.Pages[curPageNr];
                                //curPageNr++;
                                PdfPage page = _page;
                                page = outputDocument.AddPage(page);
                                if (writeDetails)
                                {
                                          //write details
                                    gfx = XGraphics.FromPdfPage(page);
                                    box = page.MediaBox.ToXRect();
                                    box.Inflate(0, -10);
                                    boxShadow = box;
                                    boxShadow.X = boxShadow.X + 1f; boxShadow.Y = boxShadow.Y + 1f;
                                    
                                    gfx.DrawString(String.Format("{0} • {1}", fName, _pgnr),
                                     font, textBrush2, boxShadow, format);
                                    gfx.DrawString(String.Format("{0} • {1}", fName, _pgnr),
                                      font, textBrush, box, format);
                                    if (write_watermark)
                                    {
                                        var watermark_text = PDFCombine.Properties.Settings.Default.Watermark_Text;
                                        var watermark_font = PDFCombine.Properties.Settings.Default.Watermark_Font;
                                        var watermark_size = (float)PDFCombine.Properties.Settings.Default.Watermark_size;
                                        var watermark_location = PDFCombine.Properties.Settings.Default.Watermark_Location;

                                        XFont fontWatermark = new XFont(watermark_font, watermark_size, XFontStyle.Bold);
                                       
                                        Point p = new Point();
                                        if (watermark_location == "CENTER")
                                        { p.X = (int)page.Width / 2; p.Y = (int)page.Height / 2; }
                                        if (watermark_location == "TOP")
                                        { p.X = (int)page.Width / 2; p.Y = (int)watermark_size + 20; }
                                        if (watermark_location == "BOTTOM")
                                        { p.X = (int)page.Width / 2; p.Y = (int)page.Height - 20; }

                                        gfx.DrawString(watermark_text, fontWatermark, watermarkBrushShadow, p.X+2,p.Y+2, format);
                                        gfx.DrawString(watermark_text, fontWatermark, watermarkBrush, p, format);
                                        //gfx.DrawString
                                    }
                                    gfx.Dispose();
                                }
                                
                                (sender as System.ComponentModel.BackgroundWorker).ReportProgress(pgnr);
                            }
                        }
                        //fisierPDF.Close();
                        //fisierPDF.Dispose();

                    }

                    if (isImage)
                    {
                        PdfPage page = outputDocument.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        XImage xImage;
                        Bitmap bitmap = new Bitmap(caleFisierPDF);
                        if ((sender as System.ComponentModel.BackgroundWorker).CancellationPending == true)
                        {
                            bitmap.Dispose();
                            outputDocument.Close();
                            outputDocument.Dispose();
                            GC.Collect();
                            return;
                        }
                        pgnr++;


                        //if image is landscape and bigger than page make it portrait
                        if ((bitmap.Width > bitmap.Height)&& ( bitmap.Width > gfx.PageSize.Width))
                        {
                            bitmap = RotateImage(bitmap, 90);

                        }
                        //if image is bigger than page resize it proportionaly to fit the page
                        if ((bitmap.Width > gfx.PageSize.Width) && (bitmap.Height > gfx.PageSize.Height))
                        {
                            Size imageSize = new Size((int)gfx.PageSize.Width, (int)gfx.PageSize.Height);
                            bitmap = ResizeImage(bitmap, bitmap.Width, imageSize.Height, false);
                        }
                        
                        //if image is smaller than page or has been rotated and resized add it to page
                        xImage = XImage.FromGdiPlusImage(bitmap);
                        gfx.DrawImage(xImage, 0, 0,xImage.PixelWidth, xImage.PixelHeight);
                        if (writeDetails)
                        {
                            //write details
                            box = page.MediaBox.ToXRect();
                            box.Inflate(0, -10);
                            boxShadow = box;
                            boxShadow.X = boxShadow.X + 1f; boxShadow.Y = boxShadow.Y + 1f;

                            
                            gfx.DrawString(String.Format("{0} • {1}", fName, _pgnr),
                              font, textBrush2, boxShadow, format);
                            gfx.DrawString(String.Format("{0} • {1}", fName, _pgnr),
                              font, textBrush, box, format);

                            if (write_watermark)
                            {
                                var watermark_text = PDFCombine.Properties.Settings.Default.Watermark_Text;
                                var watermark_font = PDFCombine.Properties.Settings.Default.Watermark_Font;
                                var watermark_size = (float)PDFCombine.Properties.Settings.Default.Watermark_size;
                                var watermark_location = PDFCombine.Properties.Settings.Default.Watermark_Location;

                                XFont fontWatermark = new XFont(watermark_font, watermark_size, XFontStyle.Bold);
                                Point p = new Point();
                                if (watermark_location == "CENTER")
                                { p.X = (int)page.Width / 2; p.Y = (int)page.Height / 2; }
                                if (watermark_location == "TOP")
                                { p.X = (int)page.Width / 2; p.Y =(int)watermark_size+20;}
                                if (watermark_location == "BOTTOM")
                                { p.X = (int)page.Width / 2; p.Y = (int)page.Height - 20; }

                                gfx.DrawString(watermark_text, fontWatermark, watermarkBrush, p, format);
                                //gfx.DrawString
                            }
                        }
                        gfx.Dispose();
                        xImage.Dispose();
                        bitmap.Dispose();
                        (sender as System.ComponentModel.BackgroundWorker).ReportProgress(pgnr);
                    }
                }
                outputDocument.Save(caleOutput);
                outputDocument.Close();
                outputDocument.Dispose();
                
                
            }

            catch (Exception ex)
            {
                outputDocument.Close();
                outputDocument.Dispose();
                throw new Exception(ex.Message);
            }
        }

        //
        private void WriteDetails()
        {

        }

        public int PdfPageCount { get; set; }

        public String PdfInfo { get; set; }

        public void ReadThisPDF(String caleFisierPDF)
        {
            PdfDocument fisierPDF = new PdfDocument();
            try
            {
                PdfInfo = "Ready";
                fisierPDF = PdfReader.Open(caleFisierPDF, PdfDocumentOpenMode.Import);
                PdfPageCount = fisierPDF.PageCount;
                fisierPDF.Dispose();
            }
            catch (Exception ex)
            {
                fisierPDF.Dispose();
                PdfPageCount = 0;
                PdfInfo = ex.Message;

            }
        }

        public double AproximativeOutputSize { get; set; }

        public string GetFileSize(String caleFisierPDF)
        {
            FileInfo file = new FileInfo(caleFisierPDF);
            double byteCount = file.Length;
            AproximativeOutputSize = AproximativeOutputSize + byteCount;
            
            return FormatSize(byteCount);
        }

        public string FormatSize(Double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";
            return size;
        }

        private Bitmap RotateImage(Bitmap inputImg, double degreeAngle)
        {
            inputImg.SetResolution(dpi, dpi);
            //Corners of the image
            PointF[] rotationPoints = { new PointF(0, 0),
                                        new PointF(inputImg.Width, 0),
                                        new PointF(0, inputImg.Height),
                                        new PointF(inputImg.Width, inputImg.Height) };

            //Rotate the corners
            PointMath.RotatePoints(rotationPoints, new PointF(inputImg.Width / 2.0f, inputImg.Height / 2.0f), degreeAngle);

            //Get the new bounds given from the rotation of the corners
            //(avoid clipping of the image)
            Rectangle bounds = PointMath.GetBounds(rotationPoints);

            //An empy bitmap to draw the rotated image
            Bitmap rotatedBitmap = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(rotatedBitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //Transformation matrix
                Matrix m = new Matrix();
                m.RotateAt((float)degreeAngle, new PointF(inputImg.Width / 2.0f, inputImg.Height / 2.0f));
                m.Translate(-bounds.Left, -bounds.Top, MatrixOrder.Append); //shift to compensate for the rotation

                g.Transform = m;
                g.DrawImage(inputImg, 0, 0);
            }
            return rotatedBitmap;
        }

        public Bitmap ResizeImage(Bitmap OriginalFile, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            System.Drawing.Image FullsizeImage = OriginalFile;

            // Prevent using images internal thumbnail
            //FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            //FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight= FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
               NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
        }

            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            FullsizeImage.Dispose();

            // Save resized picture
            return (Bitmap)NewImage;
        }
    }

    public static class PointMath
    {
        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public static PointF RotatePoint(PointF pnt, double degreeAngle)
        {
            return RotatePoint(pnt, new PointF(0, 0), degreeAngle);
        }

        public static PointF RotatePoint(PointF pnt, PointF origin, double degreeAngle)
        {
            double radAngle = DegreeToRadian(degreeAngle);

            PointF newPoint = new PointF();

            double deltaX = pnt.X - origin.X;
            double deltaY = pnt.Y - origin.Y;

            newPoint.X = (float)(origin.X + (Math.Cos(radAngle) * deltaX - Math.Sin(radAngle) * deltaY));
            newPoint.Y = (float)(origin.Y + (Math.Sin(radAngle) * deltaX + Math.Cos(radAngle) * deltaY));

            return newPoint;
        }

        public static void RotatePoints(PointF[] pnts, double degreeAngle)
        {
            for (int i = 0; i < pnts.Length; i++)
            {
                pnts[i] = RotatePoint(pnts[i], degreeAngle);
            }
        }

        public static void RotatePoints(PointF[] pnts, PointF origin, double degreeAngle)
        {
            for (int i = 0; i < pnts.Length; i++)
            {
                pnts[i] = RotatePoint(pnts[i], origin, degreeAngle);
            }
        }

        public static Rectangle GetBounds(PointF[] pnts)
        {
            RectangleF boundsF = GetBoundsF(pnts);
            return new Rectangle((int)Math.Round(boundsF.Left),
                                 (int)Math.Round(boundsF.Top),
                                 (int)Math.Round(boundsF.Width),
                                 (int)Math.Round(boundsF.Height));
        }

        public static RectangleF GetBoundsF(PointF[] pnts)
        {
            float left = pnts[0].X;
            float right = pnts[0].X;
            float top = pnts[0].Y;
            float bottom = pnts[0].Y;

            for (int i = 1; i < pnts.Length; i++)
            {
                if (pnts[i].X < left)
                    left = pnts[i].X;
                else if (pnts[i].X > right)
                    right = pnts[i].X;

                if (pnts[i].Y < top)
                    top = pnts[i].Y;
                else if (pnts[i].Y > bottom)
                    bottom = pnts[i].Y;
            }

            return new RectangleF(left,
                                  top,
                                 (float)Math.Abs(right - left),
                                 (float)Math.Abs(bottom - top));
        }
    }
}
