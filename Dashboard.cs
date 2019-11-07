﻿using EditX.Helper;
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

        public Dashboard(string canvas_name, int width, int height)
        {
            InitializeComponent();
            this.canvas_name = canvas_name;
            this.canvas_width = width;
            this.canvas_height = height;

            Graphics g = this.CreateGraphics();

            // Fit width
            var position = getFitLocation(this.canvas_width, this.canvas_height, workspace_panel.Width, workspace_panel.Height);
            updateLocation(position);

        }

        private Point getFitLocation(int canvasWidth, int canvasHeight, int workSpaceWidth, int workspaceHeight)
        {
            int posX = (int)((workSpaceWidth / 2) - (canvasWidth / 2));
            int posY = (int)((workspaceHeight / 2) - (canvasHeight / 2));
            return new Point(posX,posY);
        }

        private string canvas_name { get; set; } = "";
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
            workspace.AutoScroll =true;
            workspace.Controls.Add(canvas);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            createArtboard(canvas_name,canvas_width, canvas_height);
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
            if(e.Control && e.KeyValue == 0)
            {
                //fit the canvas in screen

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseTemplate chooseTemplate = new ChooseTemplate();
            chooseTemplate.Show();
        }
    }
}
