namespace WebApiDemoTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Uri = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.bt_webclient = new System.Windows.Forms.Button();
            this.bt_RestClient = new System.Windows.Forms.Button();
            this.bt_HttpWebRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UserAgent = new System.Windows.Forms.TextBox();
            this.bt_HttpClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ContentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uri";
            // 
            // tb_Uri
            // 
            this.tb_Uri.Location = new System.Drawing.Point(91, 13);
            this.tb_Uri.Name = "tb_Uri";
            this.tb_Uri.Size = new System.Drawing.Size(697, 25);
            this.tb_Uri.TabIndex = 1;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 108);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(776, 381);
            this.tb_data.TabIndex = 2;
            // 
            // bt_webclient
            // 
            this.bt_webclient.Location = new System.Drawing.Point(12, 495);
            this.bt_webclient.Name = "bt_webclient";
            this.bt_webclient.Size = new System.Drawing.Size(141, 23);
            this.bt_webclient.TabIndex = 3;
            this.bt_webclient.Text = "Use WebClient";
            this.bt_webclient.UseVisualStyleBackColor = true;
            this.bt_webclient.Click += new System.EventHandler(this.bt_webclient_Click);
            // 
            // bt_RestClient
            // 
            this.bt_RestClient.Location = new System.Drawing.Point(183, 495);
            this.bt_RestClient.Name = "bt_RestClient";
            this.bt_RestClient.Size = new System.Drawing.Size(150, 23);
            this.bt_RestClient.TabIndex = 4;
            this.bt_RestClient.Text = "Use RestClient";
            this.bt_RestClient.UseVisualStyleBackColor = true;
            this.bt_RestClient.Click += new System.EventHandler(this.bt_RestClient_Click);
            // 
            // bt_HttpWebRequest
            // 
            this.bt_HttpWebRequest.Location = new System.Drawing.Point(368, 495);
            this.bt_HttpWebRequest.Name = "bt_HttpWebRequest";
            this.bt_HttpWebRequest.Size = new System.Drawing.Size(195, 23);
            this.bt_HttpWebRequest.TabIndex = 5;
            this.bt_HttpWebRequest.Text = "Use HttpWebRequest";
            this.bt_HttpWebRequest.UseVisualStyleBackColor = true;
            this.bt_HttpWebRequest.Click += new System.EventHandler(this.bt_HttpWebRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "User-Agent";
            // 
            // tb_UserAgent
            // 
            this.tb_UserAgent.Location = new System.Drawing.Point(91, 45);
            this.tb_UserAgent.Name = "tb_UserAgent";
            this.tb_UserAgent.Size = new System.Drawing.Size(697, 25);
            this.tb_UserAgent.TabIndex = 7;
            // 
            // bt_HttpClient
            // 
            this.bt_HttpClient.Location = new System.Drawing.Point(598, 495);
            this.bt_HttpClient.Name = "bt_HttpClient";
            this.bt_HttpClient.Size = new System.Drawing.Size(120, 23);
            this.bt_HttpClient.TabIndex = 8;
            this.bt_HttpClient.Text = "Use HttpClient";
            this.bt_HttpClient.UseVisualStyleBackColor = true;
            this.bt_HttpClient.Click += new System.EventHandler(this.bt_HttpClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "content-type";
            // 
            // cb_ContentType
            // 
            this.cb_ContentType.FormattingEnabled = true;
            this.cb_ContentType.Items.AddRange(new object[] {
            "application/json",
            "application/xhtml+xml",
            "application/xml",
            "application/atom+xml",
            "application/pdf",
            "application/msword",
            "application/octet-stream",
            "application/x-www-form-urlencoded ",
            "text/html",
            "text/plain",
            "text/xml",
            "image/gif",
            "image/jpeg",
            "image/png"});
            this.cb_ContentType.Location = new System.Drawing.Point(91, 77);
            this.cb_ContentType.Name = "cb_ContentType";
            this.cb_ContentType.Size = new System.Drawing.Size(697, 23);
            this.cb_ContentType.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.cb_ContentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_HttpClient);
            this.Controls.Add(this.tb_UserAgent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_HttpWebRequest);
            this.Controls.Add(this.bt_RestClient);
            this.Controls.Add(this.bt_webclient);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_Uri);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebApiDemoTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Uri;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button bt_webclient;
        private System.Windows.Forms.Button bt_RestClient;
        private System.Windows.Forms.Button bt_HttpWebRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UserAgent;
        private System.Windows.Forms.Button bt_HttpClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ContentType;
    }
}

