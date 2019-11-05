namespace EditX
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.newProject_btn = new System.Windows.Forms.Button();
            this.openProject_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navBar_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.navBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(329, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "EditX";
            // 
            // newProject_btn
            // 
            this.newProject_btn.BackColor = System.Drawing.SystemColors.InfoText;
            this.newProject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProject_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.newProject_btn.Location = new System.Drawing.Point(308, 170);
            this.newProject_btn.Name = "newProject_btn";
            this.newProject_btn.Size = new System.Drawing.Size(159, 66);
            this.newProject_btn.TabIndex = 1;
            this.newProject_btn.Text = "New Project";
            this.newProject_btn.UseVisualStyleBackColor = false;
            this.newProject_btn.Click += new System.EventHandler(this.newProject_btn_Click);
            // 
            // openProject_btn
            // 
            this.openProject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProject_btn.Location = new System.Drawing.Point(308, 253);
            this.openProject_btn.Name = "openProject_btn";
            this.openProject_btn.Size = new System.Drawing.Size(159, 66);
            this.openProject_btn.TabIndex = 2;
            this.openProject_btn.Text = "Open Project";
            this.openProject_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 424);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "version 1.0.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.navBar_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // navBar_panel
            // 
            this.navBar_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.navBar_panel.Controls.Add(this.pictureBox1);
            this.navBar_panel.Controls.Add(this.label3);
            this.navBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar_panel.Location = new System.Drawing.Point(0, 0);
            this.navBar_panel.Margin = new System.Windows.Forms.Padding(0);
            this.navBar_panel.Name = "navBar_panel";
            this.navBar_panel.Size = new System.Drawing.Size(798, 40);
            this.navBar_panel.TabIndex = 0;
            this.navBar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBar_panel_MouseDown);
            this.navBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBar_panel_MouseMove);
            this.navBar_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBar_panel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(760, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "EditX";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openProject_btn);
            this.Controls.Add(this.newProject_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditX";
            this.panel1.ResumeLayout(false);
            this.navBar_panel.ResumeLayout(false);
            this.navBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newProject_btn;
        private System.Windows.Forms.Button openProject_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navBar_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

