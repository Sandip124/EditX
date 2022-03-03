using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void newProject_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard chooseTemplate = new Dashboard();
            chooseTemplate.Show();
        }


        private bool mouseDown;
        private Point lastLocation;
        private void navBar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navBar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void navBar_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
