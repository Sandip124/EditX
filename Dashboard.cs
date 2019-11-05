using EditX.Helper;
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
    public partial class Dashboard : Form
    {
        private static string WORKSPACE = "workspace_panel";
        public Dashboard(string canvas_name,int width, int height)
        {
            InitializeComponent();
            this.canvas_name = canvas_name;
            this.canvas_width = width;
            this.canvas_height = height;
        }

        private string canvas_name { get; set; } ="";
        private int canvas_width { get; set; } = 0;
        private int canvas_height { get; set; } = 0;

        private void createArtboard(string canvas_name,int canvas_width, int canvas_height)
        {
            Panel canvas = new Panel();
            this.SuspendLayout();
            canvas.Name = canvas_name;
            canvas.Width = canvas_width;
            canvas.Height = canvas_height;
            canvas.BackColor = Color.White;
            canvas.Location = new Point(0, 0);
            
            addCanvasToWorkSpace(canvas);
            this.ResumeLayout();
        }

        private void addCanvasToWorkSpace(Panel canvas)
        {
            Panel workspace = ControlHelper.findPanel(this, WORKSPACE);
            workspace.Controls.Clear();
            workspace.Controls.Add(canvas);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            createArtboard(canvas_name,canvas_width, canvas_height);

        }
    }
}
