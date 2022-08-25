using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace CaptureApp
{
    public partial class Form1 : Form
    {
        private ProxyServer proxyServer = new ProxyServer();
        private String url = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
        }

        public async Task OnRequest(object sender, SessionEventArgs e)
        {
            await Task.Run(() =>
            {
                var method = e.HttpClient.Request.Method.ToUpper();
                if (method == "GET")
                {
                    var matchStr = textBox_matchStr.Text;
                    var requestUrl = e.HttpClient.Request.Url;
                    Console.WriteLine(requestUrl);
                    if (requestUrl.Contains(matchStr))
                    {
                        stopProxyServer();
                        textBox_result.Text = requestUrl;
                        url = requestUrl;
                    }

                }
            });

        }

        private void startProxyServer()
        {
            textBox_matchStr.Enabled = false;
            textBox_port.Enabled = false;
            checkBox_autoexit.Enabled = false;
            button_stop.Enabled = true;
            textBox_result.Text = "";
            //proxyServer.CertificateManager.TrustRootCertificate(true);
            proxyServer.BeforeRequest += OnRequest;
            int port = 0;
            try
            {
                port = int.Parse(textBox_port.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("端口输入错误");
                return;
            }
            if (port < 0 || port > 65535)
            {
                MessageBox.Show("端口范围错误");
                return;
            }
            var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Any, port, true) { };

            proxyServer.AddEndPoint(explicitEndPoint);
            proxyServer.Start();
            proxyServer.SetAsSystemHttpsProxy(explicitEndPoint);

        }
        private void stopProxyServer()
        {
            textBox_matchStr.Enabled = true;
            textBox_port.Enabled = true;
            checkBox_autoexit.Enabled = true;
            button_start.Enabled = true;
            proxyServer.BeforeRequest -= OnRequest;
            if (proxyServer.ProxyRunning)
            {
                proxyServer.Stop();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopProxyServer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_status.Text = proxyServer.ProxyRunning ? "运行中" : "未开始";
            if (checkBox_autoexit.Checked)
            {
                if (url != "")
                    try
                    {
                        Clipboard.SetText(url);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误");
                    }

            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            startProxyServer();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            stopProxyServer();
        }

        private void checkBox_autoexit_CheckedChanged(object sender, EventArgs e)
        {
            url = "";
        }
    }
}
