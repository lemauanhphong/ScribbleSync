using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace ScribbleSyncClient
{
    public partial class Shared_User_Item : UserControl
    {
        string username;
        Color orgColor = SystemColors.Info;
        public Shared_User_Item()
        {
            InitializeComponent();
        }
        public Shared_User_Item(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void Shared_User_Item_Load(object sender, EventArgs e)
        {
            pictureBox_avatar.Image = Properties.Resources.Avatar;
            label_name.Text = username;
            Refresh();
        }

        public void Refresh()
        {
            Request req = new Request { action = "/api/profile/avatar/"+username, token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));

            Response res = JsonSerializer.Deserialize<Response>(msg);
            //MessageBox.Show(msg);
            if (res.avatar != null && res.avatar != "")
            {
                byte[] imageBytes = Convert.FromBase64String(res.avatar);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox_avatar.Image = image;
                }
            }
        }
        private void Shared_User_Item_MouseEnter(object sender, EventArgs e)
        {
            orgColor = this.BackColor;
            this.BackColor = Color.Gold;
        }

        private void Shared_User_Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = orgColor;
        }
    }
}
