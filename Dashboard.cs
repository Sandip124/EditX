using EditX.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditX
{
    public partial class Dashboard : Form
    {
        private static string WORKSPACE = "workspace_panel";

        int positionX = 0;
        int positionY = 0;
        float zoom = 1;

        private enum Tool
        {
            POINTER,
            RECTANGLE,
            TEXT,
            ARTBOARD,
        };

        private Tool currentTool;

        private enum Panels
        {
            WORKSPACE_PANEL,
            TOOLBAR_PANEL,
            ACTIONBAR_PANEL,
            NAVIGATIONBAR_PANEL
        }

        public Dashboard(string canvas_name, int width, int height)
        {
            InitializeComponent();
            this.canvas_name = canvas_name;
            this.canvas_width = width;
            this.canvas_height = height;

            Graphics g = this.CreateGraphics();

            // Fit width
            centerArtBoard();

        }

        private void centerArtBoard()
        {
            var position = getFitLocation(this.canvas_width, this.canvas_height, workspace_panel.Width, workspace_panel.Height);
            updateLocation(position);
        }

        private Point getFitLocation(int canvasWidth, int canvasHeight, int workSpaceWidth, int workspaceHeight)
        {
            int posX = (int)((workSpaceWidth / 2) - (canvasWidth / 2));
            int posY = (int)((workspaceHeight / 2) - (canvasHeight / 2));
            return new Point(posX, posY);
        }

        private string canvas_name { get; set; } = "";
        private int canvas_width { get; set; } = 0;
        private int canvas_height { get; set; } = 0;


        private void createArtboard(string canvas_name, int canvas_width, int canvas_height)
        {
            Panel canvas = new Panel();
            this.SuspendLayout();
            canvas.Name = canvas_name;
            canvas.Width = canvas_width;
            canvas.Height = canvas_height;
            canvas.BackColor = Color.White;
            canvas.Location = new Point(positionX, positionY);
            canvas.MouseDown += new MouseEventHandler(CanvasMouseDown);
            canvas.MouseUp += new MouseEventHandler(CanvasMouseUp);
            canvas.MouseMove += new MouseEventHandler(CanvasMouseMove);

            addCanvasToWorkSpace(canvas);
            this.ResumeLayout();
        }

        #region mouse Events For canvas

        private bool mouseDownAction;
        private Point lastLocation;
        private void CanvasMouseDown(object sender, MouseEventArgs e)
        {
            mouseDownAction = true;
            lastLocation = e.Location;
        }

        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownAction && Control.ModifierKeys == Keys.Alt)
            {
                var canvas = ControlHelper.findPanel(this, canvas_name);
                canvas.Location = new Point(
                    (canvas.Location.X - lastLocation.X) + e.X, (canvas.Location.Y - lastLocation.Y) + e.Y);
                updateLocation(canvas.Location);
                canvas.Update();
            }
        }

        private void CanvasMouseUp(object sender, MouseEventArgs e)
        {
            mouseDownAction = false;
        }
        #endregion

        private void addCanvasToWorkSpace(Panel canvas)
        {
            Panel workspace = ControlHelper.findPanel(this, WORKSPACE);
            workspace.Controls.Clear();
            //workspace.AutoScroll =true;
            workspace.Controls.Add(canvas);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            createArtboard(canvas_name, canvas_width, canvas_height);
        }

        private void updateLocation(Point location)
        {
            positionX = location.X;
            positionY = location.Y;

            this.posX.Text = positionX.ToString();
            this.posY.Text = positionY.ToString();
            controls_panel.Refresh();
        }

        private void Dashboard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D0)
            {
                //center the canvas in screen
                centerArtBoard();
                updateCanvas();
            }
        }

        private void updateCanvas()
        {
            var canvas = ControlHelper.findPanel(this, canvas_name);
            canvas.Location = new Point(positionX, positionY);
            canvas.Update();
            controls_panel.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseTemplate chooseTemplate = new ChooseTemplate();
            chooseTemplate.Show();
        }

        bool onMouseWheel = false;
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            onMouseWheel = true;
            if (onMouseWheel && Control.ModifierKeys == Keys.Shift)
            {
                float oldzoom = zoom;

                if (e.Delta > 0)
                {
                    zoom += 0.1F;
                }

                else if (e.Delta < 0)
                {
                    zoom = Math.Max(zoom - 0.1F, 0.01F);
                }

                MouseEventArgs mouse = e as MouseEventArgs;
                Point mousePosNow = mouse.Location;

                int x = mousePosNow.X - workspace_panel.Location.X;    // Where location of the mouse in the pictureframe
                int y = mousePosNow.Y - workspace_panel.Location.Y;

                int oldimagex = (int)(x / oldzoom);  // Where in the IMAGE is it now
                int oldimagey = (int)(y / oldzoom);

                int newimagex = (int)(x / zoom);     // Where in the IMAGE will it be when the new zoom i made
                int newimagey = (int)(y / zoom);

                positionX = newimagex - oldimagex + positionX;  // Where to move image to keep focus on one point
                positionY = newimagey - oldimagey + positionY;

                workspace_panel.Refresh();  // calls imageBox_Paint
                updateCanvas();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            setCurrentTool(Tool.POINTER);
            this.Cursor = Cursors.Default;
            if (currentTool == Tool.POINTER)
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            setCurrentTool(Tool.RECTANGLE);
            this.Cursor = Cursors.Default;
            if (currentTool == Tool.RECTANGLE)
            {
                this.Cursor = Cursors.Cross;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            setCurrentTool(Tool.TEXT);
            this.Cursor = Cursors.Default;
            if (currentTool == Tool.TEXT)
            {
                this.Cursor = Cursors.IBeam;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            setCurrentTool(Tool.ARTBOARD);
            this.Cursor = Cursors.Default;
            if (currentTool == Tool.ARTBOARD)
            {
                this.Cursor = Cursors.Arrow;            
            }
        }


        private void setCurrentTool(Tool tool)
        {
            this.currentTool = tool;
        }
    }

}
