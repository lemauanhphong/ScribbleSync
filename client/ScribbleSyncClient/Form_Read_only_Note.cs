using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using Markdig.SyntaxHighlighting;
using Markdig.Extensions.Emoji;
using System.Net.Sockets;
using System.Text.Json;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;
namespace ScribbleSyncClient
{
    public partial class Form_Read_only_Note : Form
    {
        int id = 0;
        string shared_token = "";
        public Form_Read_only_Note()
        {
            InitializeComponent();
        }
        public Form_Read_only_Note(List_Note_Item item, int id)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.id = id;
        }
        public Form_Read_only_Note(Form_List_Note form, string shared_token)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.shared_token = shared_token;
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        void share_Click(object sender, EventArgs e)
        {
            Form_Share f = new Form_Share(this.id);
            f.ShowDialog();
        }

        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private string ConvertMarkdownToHtml(string markdown)
        {
            try
            {
                var pipeline = new MarkdownPipelineBuilder()
                    .UseAdvancedExtensions()
                    .UseSyntaxHighlighting()
                    .UseEmojiAndSmiley()
                    .Build();

                string htmlContent = Markdown.ToHtml(markdown, pipeline);
                string cssStyles = @"
    <style>
        body {
            font-family: 'Segoe UI Emoji', 'Segoe UI Symbol', 'Noto Color Emoji',Arial, sans-serif;
            font-size: 18px;
            font-weight: normal;
            font-style: normal;
        }
    </style>";

                return $"{cssStyles}{htmlContent}";
            }
            catch (Exception) { };
            return null;
        }
        private void ContentToHtml(string md)
        {
            string html = ConvertMarkdownToHtml(md);
            if (html != null)
                webView_preview.CoreWebView2.NavigateToString(html);
        }
        private async void Form_Read_only_Note_Load(object sender, EventArgs e)
        {
            await webView_preview.EnsureCoreWebView2Async();
            if (id != 0)
            {
                Request req = new Request { action = "/api/note/" + id.ToString(), token = Connects.token };
                string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
                Response res = JsonSerializer.Deserialize<Response>(msg);
                this.label_noteName.Text = res.name;
                ContentToHtml(res.content);
            }
            else
            {
                Request req = new Request { action = "/api/note/" + shared_token, token = Connects.token };
                string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
                Response res = JsonSerializer.Deserialize<Response>(msg);
                this.label_noteName.Text = res.name;
                ContentToHtml(res.content);
            }
        }
    }
}
