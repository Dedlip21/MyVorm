using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm_RolanMaslennikov
{
    public partial class cinema : Form
    {
        public cinema()
        {
            this.Size = new System.Drawing.Size(500, 300);
            this.BackColor = Color.LightBlue;
            Button room_btn = new Button
            {
                Text = "saali valimine ja pileti ostmine",
                Location = new System.Drawing.Point(200, 100),
                Size = new Size(100, 40)

            };
            room_btn.BackColor = Color.White;
            room_btn.Click += Room_btn_Click;
            this.Controls.Add(room_btn);
            Label lbl = new Label()
            {
                Text = "Tere tulemast kinnos",
                Location = new System.Drawing.Point(200, 30),
                Size = new Size(200, 80),
                Font = new Font("Arial", 14)
                
            };
            this.Controls.Add(lbl);

        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            room room = new room("Cinema", "Valige saali suurus", "Väike", "Keskmine", "Suur");
            room.StartPosition = FormStartPosition.CenterScreen;
            room.ShowDialog();
        }
    }
}