using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace PDFCombine
{
    class CheckUpdate
    {


        //checkUpdateThread = new System.Threading.Thread(CheckForUpdate);
        //    checkUpdateThread.SetApartmentState(System.Threading.ApartmentState.STA);
        //    checkUpdateThread.Start();

           /// <summary>
        /// Get version from server
        /// </summary>
        /// <returns>Version as Int</returns>
        private static string GetAvailableVersion()
        {

            String url = "http://www.olteteanu.com/appupdatesfiles/pdfcombine/PDFCombine";
            String onlineVersionWithoutPunctuation;
            String onlineVersion = String.Empty;

            try
            {
                WebClient client = new WebClient();
                onlineVersionWithoutPunctuation= client.DownloadString(url);
                foreach (Char c in onlineVersionWithoutPunctuation)
                {
                    onlineVersion += c + ".";
                }
                return onlineVersion.Remove(onlineVersion.Length-1);
            }
            catch 
            {
               return String.Empty;
            }
        }

        public static bool IsUpdateAvailable()
        {
            try
            {
                Version onlineVersion = new Version(GetAvailableVersion());
                if (onlineVersion > System.Reflection.Assembly.GetExecutingAssembly().GetName().Version)
                    return true;
                else
                    return false;
            }
            catch
            {
               return false;
            }

        }

        public static string GetUrlForDownload()
        {
            String url = "http://www.olteteanu.com/appupdatesfiles/pdfcombine/PDFCombineURL";
            try
            {
                WebClient client = new WebClient();
                return client.DownloadString(url);
            }
            catch 
            {
                return string.Empty;
            }
        }

    }
}
