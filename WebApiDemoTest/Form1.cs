using Elasticsearch.Net;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApiDemoTest
{
    public partial class Form1 : Form
    {
        string userAgent = "";
        string uri = "";
        string data = "";
        string contentType = "";
        public Form1()
        {
            InitializeComponent();
            tb_Uri.Text = "https://localhost/premInquiry";
            tb_UserAgent.Text = "demo";
            tb_data.Text = "{\"_key\":\"index\",\"_value\":{\"CASE_SN\":\"\",\"CASE_TYPE\":\"01\"}}";
            cb_ContentType.Text = "application/json";
        }
        private void bt_webclient_Click(object sender, EventArgs e)
        {
            Setting();
            WebClient webClient = new WebClient();
            try
            {
                webClient.Headers[HttpRequestHeader.ContentType] = contentType;
                webClient.Headers[HttpRequestHeader.UserAgent] = userAgent;
                webClient.Encoding = Encoding.UTF8;
                string response = webClient.UploadString(uri, data);
                Console.WriteLine(response);
                MessageBox.Show(response);     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bt_RestClient_Click(object sender, EventArgs e)
        {
            Setting();
            try
            {
                var client = new RestClient(uri);
                var request = new RestRequest(Method.POST);
                request.AddHeader("user-Agent", "");
                if (!String.IsNullOrEmpty(userAgent))
                    request.AddHeader("user-Agent", userAgent);
                request.AddHeader("content-type", contentType);
                request.AddParameter(contentType, data, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content.ToString());
                MessageBox.Show(response.Content);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void bt_HttpWebRequest_Click(object sender, EventArgs e)
        {
            Setting();

            HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
            string result = null;
            request.Method = "POST";    // 方法
            if (!String.IsNullOrEmpty(userAgent))
                request.UserAgent = userAgent;
            request.KeepAlive = true; //是否保持連線
            request.ContentType = contentType;
            byte[] bs = Encoding.ASCII.GetBytes(data);

            try
            {
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }

                using (WebResponse response = request.GetResponse())
                {
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    result = sr.ReadToEnd();
                    sr.Close();
                }
                Console.WriteLine(result);
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void bt_HttpClient_Click(object sender, EventArgs e)
        {
            Setting();
            try
            {
                HttpClient client = new HttpClient() { BaseAddress = new Uri(uri) };
                HttpContent contentPost = new StringContent(data, Encoding.UTF8, contentType);
                if (!String.IsNullOrEmpty(userAgent))
                    client.DefaultRequestHeaders.Add("User-Agent", userAgent);
                
                // 發出 post 並取得結果
                HttpResponseMessage response = client.PostAsync(uri, contentPost).GetAwaiter().GetResult();
                
                // 將回應結果內容取出並轉為 string 再透過 linqpad 輸出
                var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Console.WriteLine(result);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Setting()
        {
            userAgent = tb_UserAgent.Text;
            uri = tb_Uri.Text;
            data = tb_data.Text;
            contentType = cb_ContentType.Text;
        }
    }
}
