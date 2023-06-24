using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;
namespace ScribbleSyncClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip s = new ContextMenuStrip();

            // add one right click menu item named as hello           
            ToolStripMenuItem hello = new ToolStripMenuItem();
            hello.Text = "Hello";

            // add the clickevent of hello item
            hello.Click += hello_Click;

            // add the item in right click menu
            s.Items.Add(hello);

            // attach the right click menu with form
            this.ContextMenuStrip = s;
        }
        void hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Clicked");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
