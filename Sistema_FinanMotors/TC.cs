using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FinanMotors
{
    class TC
    {
        public static string sUrl = "https://e-consulta.sunat.gob.pe/cl-at-ittipcam/tcS01Alias";
        public static string TC_C, TC_V;

        public static void tipo_cambio()
        {
            try
            {
                Encoding objEncoding = Encoding.GetEncoding("ISO-8859-1");
                WebProxy objWebProxy = new WebProxy();
                CookieCollection objCookies = new CookieCollection();

                //USANDO GET
                HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(sUrl);
                getRequest.Proxy = objWebProxy;
                getRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
                getRequest.ProtocolVersion = HttpVersion.Version11;
                getRequest.UserAgent = ".NET Framework 4.0";
                getRequest.Method = "GET";

                getRequest.CookieContainer = new CookieContainer();
                getRequest.CookieContainer.Add(objCookies);
                string sGetResponse = string.Empty;

                using (HttpWebResponse getResponse = (HttpWebResponse)getRequest.GetResponse())
                {
                    objCookies = getResponse.Cookies;

                    using (StreamReader srGetResponse = new StreamReader(getResponse.GetResponseStream(), objEncoding))
                    {
                        sGetResponse = srGetResponse.ReadToEnd();
                    }
                }
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(sGetResponse);
                HtmlNodeCollection NodesTr = document.DocumentNode.SelectNodes("//table[@class='class=\"form-table\"']//tr");
                if (NodesTr != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Día", typeof(String));
                    dt.Columns.Add("Compra", typeof(String));
                    dt.Columns.Add("Venta", typeof(String));

                    int iNumFila = 0;
                    foreach (HtmlNode Node in NodesTr)
                    {
                        if (iNumFila > 0)
                        {
                            int iNumColumna = 0;
                            DataRow dr = dt.NewRow();
                            foreach (HtmlNode subNode in Node.Elements("td"))
                            {

                                if (iNumColumna == 0) dr = dt.NewRow();

                                string sValue = subNode.InnerHtml.ToString().Trim();
                                sValue = System.Text.RegularExpressions.Regex.Replace(sValue, "<.*?>", " ");
                                dr[iNumColumna] = sValue;

                                iNumColumna++;

                                if (iNumColumna == 3)
                                {
                                    dt.Rows.Add(dr);
                                    iNumColumna = 0;
                                }
                            }
                        }
                        iNumFila++;
                    }
                    dt.AcceptChanges();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow lastRow = dt.Rows[dt.Rows.Count - 1];

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataRow currentRow = dt.Rows[i];
                            if (currentRow == lastRow)
                            {
                                TC_C = dt.Rows[i]["Compra"].ToString();
                                TC_V = dt.Rows[i]["Venta"].ToString();
                            }
                        }

                    }
                    //string val = (string)rows[0].Cells["Venta"].Value; 
                    //Console.WriteLine(dgvHtml.SelectedRows[0].Cells["Venta"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
