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
    public partial class ChooseTemplate : Form
    {
        private static readonly char SPLITTER = '*';
        public ChooseTemplate()
        {
            InitializeComponent();
        }

        private string canvas_name { get; set; } = "";
        private int canvas_width { get; set; } = 0;
        private int canvas_height { get; set; } = 0;

        private void Choose_Template_Load(object sender, EventArgs e)
        {
            //load templates
        }

        private void mobile_Click(object sender, EventArgs e)
        {
            var dimension = getDimension(mobile.Tag.ToString());
            this.canvas_width = dimension[0];
            this.canvas_height = dimension[1];
            this.canvas_name = mobile.Tag.ToString();
        }

        private void tablet_Click(object sender, EventArgs e)
        {
            var dimension = getDimension(tablet.Tag.ToString());
            this.canvas_width = dimension[0];
            this.canvas_height = dimension[1];
            this.canvas_name = mobile.Tag.ToString();
        }

        private void web_Click(object sender, EventArgs e)
        {
            var dimension = getDimension(web.Tag.ToString());
            this.canvas_width = dimension[0];
            this.canvas_height = dimension[1];
            this.canvas_name = mobile.Tag.ToString();
        }

        private int[] getDimension(string tag)
        {
            var dimension = new int[2];
            dimension[0] = Convert.ToInt32(tag.Split(SPLITTER)[0]);
            dimension[1] = Convert.ToInt32(tag.Split(SPLITTER)[1]);
            return dimension;
        }

        private void createArtBoardWithDimension(string canvas_name, int canvas_width, int canvas_height)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(canvas_name,canvas_width,canvas_height);
            dashboard.Show();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(width_textbox.Text) && !string.IsNullOrEmpty(height_textbox.Text))
            {
                this.canvas_width = Convert.ToInt32(width_textbox.Text);
                this.canvas_height = Convert.ToInt32(height_textbox.Text);
                this.canvas_name = width_textbox.Text +"*"+ height_textbox.Text;
            }
            createArtBoardWithDimension(this.canvas_name, this.canvas_width, this.canvas_height);
        }
    }
}
