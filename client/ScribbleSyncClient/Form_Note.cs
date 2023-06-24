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
using System.Windows.Forms;
namespace ScribbleSyncClient
{
    public partial class Form_Note : Form
    {
        int id = 0;
        Data curdt = new Data();
        public Form_Note()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public Form_Control FormControlCalling = null;
        private Timer timer1;
        public Form_Note(Form_Control control, string name, string content, int id)
        {
            InitializeComponent();
            FormControlCalling = control;
            CheckForIllegalCrossThreadCalls = false;
            textBox_noteName.Text = name;
            richTextBox_input.Text = content;
            curdt.name = name;
            curdt.content = content;
            this.id = id;
            timer1 = new Timer();
            timer1.Interval = 10000; // 10 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        public Form_Note(List_Note_Item item, int id)
        {
            InitializeComponent();
            this.id = id;

            Request req = new Request { action = "/api/note/" + id.ToString(), token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            textBox_noteName.Text = res.name;
            richTextBox_input.Text = res.content;
            curdt.name = res.name;
            curdt.content = res.content;
            timer1 = new Timer();
            timer1.Interval = 10000; // 10 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Perform your desired actions or update your form
            Refresh();
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
        
        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        void share_Click(object sender, EventArgs e)
        {
            Form_Share f = new Form_Share(this.id);
            f.ShowDialog();
        }

        void publish_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked == false)
            {
                //MessageBox.Show("false");
                //curdt.share_token = true;
                Request req = new Request
                {
                    action = "/api/note/edit/" + id.ToString(),
                    data = new Data { share_token = true },
                    token = Connects.token
                };
                string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
                Response res = JsonSerializer.Deserialize<Response>(msg);

                if (res.statuscode != 200)
                {
                    MessageBox.Show(res.message);
                    return;
                }
                req = new Request
                {
                    action = "/api/note/get_share_token/" + id.ToString(),
                    token = Connects.token
                };
                msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));

                res = JsonSerializer.Deserialize<Response>(msg);
                if (res.statuscode != 200)
                {
                    MessageBox.Show(res.message);
                    return;
                }
                textBox_sharetoken.Text = "Public shared token: " + res.share_token;
                textBox_sharetoken.Visible = true;
                ((ToolStripMenuItem)sender).Checked = true;
            }
            else
            {
                //MessageBox.Show("false");
                //curdt.share_token = false;
                Request req = new Request
                {
                    action = "/api/note/edit/" + id.ToString(),
                    data = new Data { share_token = false },
                    token = Connects.token
                };

                string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
                Response res = JsonSerializer.Deserialize<Response>(msg);

                if (res.statuscode != 200)
                {
                    MessageBox.Show(res.message);
                    return;
                }
                textBox_sharetoken.Visible = false;
                ((ToolStripMenuItem)sender).Checked = false;
            }

        }
        private async void Form_Note_Load(object sender, EventArgs e)
        {
            textBox_sharetoken.Visible = false;
            await webView_preview.EnsureCoreWebView2Async();
            ContentToHtml();
            ContextMenuStrip s = new ContextMenuStrip();
            //Share
            ToolStripMenuItem share = new ToolStripMenuItem();
            share.Text = "Share";
            share.Click += share_Click;
            s.Items.Add(share);

            //Share_token
            ToolStripMenuItem publish = new ToolStripMenuItem();
            publish.Text = "Publish Note";
            publish.Click += publish_Click;
            s.Items.Add(publish);

            this.ContextMenuStrip = s;
        }

        
        public void Refresh()
        {
            //curdt.content = richTextBox_input.Text;
            //curdt.name = textBox_noteName.Text;
            Request req = new Request
            {
                action = "/api/note/edit/" + id.ToString(), 
                data = new Data { name = textBox_noteName.Text, content = richTextBox_input.Text },
                token = Connects.token };
            //MessageBox.Show(curdt.share_token.ToString());
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
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

        private void ContentToHtml()
        {
            string md = richTextBox_input.Text;
            string html = ConvertMarkdownToHtml(md);
            if (html != null)
                webView_preview.CoreWebView2.NavigateToString(html);
        }
        private void richTextBox_input_TextChanged(object sender, EventArgs e)
        {
            //Refresh();
            ContentToHtml();
        }

        private void richTextBox_input_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control)
            {

                switch (e.KeyCode)
                {
                    case Keys.B:
                        e.SuppressKeyPress = true;
                        richTextBox_input.SelectedText = $"**{richTextBox_input.SelectedText}**";
                        break;
                    case Keys.I:
                        e.SuppressKeyPress = true;
                        richTextBox_input.SelectedText = $"*{richTextBox_input.SelectedText}*";
                        break;
                    default:
                        break;
                }

            }
        }

        private void textBox_noteName_Enter(object sender, EventArgs e)
        {
            textBox_noteName.BackColor = Color.White;
        }

        private void textBox_noteName_Leave(object sender, EventArgs e)
        {
            textBox_noteName.BackColor = Color.AliceBlue;
            Refresh();
        }

        private void textBox_noteName_MouseEnter(object sender, EventArgs e)
        {
            textBox_noteName.BackColor = Color.White;
        }

        private void textBox_noteName_MouseHover(object sender, EventArgs e)
        {
            textBox_noteName.BackColor = Color.White;
        }

        private void textBox_noteName_TextChanged(object sender, EventArgs e)
        {   

        }
        private void textBox_noteName_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    textBox_noteName_Leave(sender,e);
                    break;
                default:
                    break;
            }
        }

        private void Form_Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormControlCalling != null)
                FormControlCalling.Show();
            timer1.Stop();
        }


    }
}
