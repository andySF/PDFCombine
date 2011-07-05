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
        
        public Dictionary<int,string> caleFisierePDF { get; set; }
        public bool writeDetails { get; set; }
        public String caleOutput { get; set; }

        
        public void CombinePDFs(object sender)
        {
            try
            {
                PdfDocument outputDocument = new PdfDocument();
                XFont font = new XFont("Verdana", 10, XFontStyle.Bold);
                XStringFormat format = new XStringFormat();
                format.Alignment = XStringAlignment.Center;
                format.LineAlignment = XLineAlignment.Far;
                

                XGraphics gfx;
                XRect box;
                PdfDocument fisierPDF;
                int pgnr = 0;

                foreach (String caleFisierPDF in caleFisierePDF.Values)
                {

                    bool isPDF = false;
                    String extension = Path.GetExtension(caleFisierPDF);
                    if (extension.ToLower() == ".pdf")
                        isPDF = true;

                    if (isPDF)
                    {
                        fisierPDF = PdfReader.Open(caleFisierPDF, PdfDocumentOpenMode.Import);

                        //int curPageNr=0;
                        foreach (PdfPage _page in fisierPDF.Pages)
                        {
                            if ((sender as System.ComponentModel.BackgroundWorker).CancellationPending == true)
                            {
                                return;
                            }
                            else
                            {
                                pgnr++;
                                //PdfPage page = fisierPDF.Pages[curPageNr];
                                //curPageNr++;
                                PdfPage page = _page;
                                page = outputDocument.AddPage(page);
                                if (writeDetails)
                                {
                                    gfx = XGraphics.FromPdfPage(page);
                                    box = page.MediaBox.ToXRect();
                                    box.Inflate(0, -10);
                                    gfx.DrawString(String.Format("{0} • {1}", caleFisierPDF, pgnr),
                                      font, XBrushes.Red, box, format);
                                }
                                (sender as System.ComponentModel.BackgroundWorker).ReportProgress(pgnr);
                            }
                        }
                    }

                    if (!isPDF)
                    {
                        PdfPage page = outputDocument.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        XImage xImage;
                        Bitmap bitmap = new Bitmap(caleFisierPDF);

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
                        bitmap.Dispose();
                        pgnr++;
                        (sender as System.ComponentModel.BackgroundWorker).ReportProgress(pgnr);
                    }
                }
                outputDocument.Save(caleOutput);
                outputDocument.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int PdfPageCount { get; set; }

        public String PdfInfo { get; set; }

        public void ReadThisPDF(String caleFisierPDF)
        {
            try
            {
                PdfInfo = "Ready";
                PdfDocument fisierPDF = new PdfDocument();
                fisierPDF = PdfReader.Open(caleFisierPDF, PdfDocumentOpenMode.Import);
                PdfPageCount = fisierPDF.PageCount;
            }
            catch(Exception ex)
            {
                PdfPageCount= 0;
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
            //Corners of the image
            PointF[] rotationPoints = { new PointF(0, 0),
                                        new PointF(inputImg.Width, 0),
                                        new PointF(0, inputImg.Height),
                                        new PointF(inputImg.Width, inputImg.Height)};

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
