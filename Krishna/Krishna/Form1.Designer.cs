namespace Krishna
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sephiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.filterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgeDetectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sephiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pixellateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelEdgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.filterToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // cannyEdgeDetectionToolStripMenuItem
            // 
            this.cannyEdgeDetectionToolStripMenuItem.Name = "cannyEdgeDetectionToolStripMenuItem";
            this.cannyEdgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sephiaToolStripMenuItem
            // 
            this.sephiaToolStripMenuItem.Name = "sephiaToolStripMenuItem";
            this.sephiaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // bayerToolStripMenuItem
            // 
            this.bayerToolStripMenuItem.Name = "bayerToolStripMenuItem";
            this.bayerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.66834F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16583F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16583F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 238);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(145, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 74);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 72);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(145, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 72);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(3, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 74);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(145, 161);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(136, 74);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // filterToolStripMenuItem1
            // 
            this.filterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem1,
            this.cannyEdgeDetectionToolStripMenuItem1,
            this.sephiaToolStripMenuItem1,
            this.pixellateToolStripMenuItem,
            this.sobelEdgeDetectionToolStripMenuItem});
            this.filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            this.filterToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem1.Text = "Filter";
            // 
            // grayscaleToolStripMenuItem1
            // 
            this.grayscaleToolStripMenuItem1.Name = "grayscaleToolStripMenuItem1";
            this.grayscaleToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.grayscaleToolStripMenuItem1.Text = "Grayscale";
            this.grayscaleToolStripMenuItem1.Click += new System.EventHandler(this.GrayscaleToolStripMenuItem1_Click);
            // 
            // cannyEdgeDetectionToolStripMenuItem1
            // 
            this.cannyEdgeDetectionToolStripMenuItem1.Name = "cannyEdgeDetectionToolStripMenuItem1";
            this.cannyEdgeDetectionToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.cannyEdgeDetectionToolStripMenuItem1.Text = "Canny Edge Detection";
            this.cannyEdgeDetectionToolStripMenuItem1.Click += new System.EventHandler(this.CannyEdgeDetectionToolStripMenuItem1_Click);
            // 
            // sephiaToolStripMenuItem1
            // 
            this.sephiaToolStripMenuItem1.Name = "sephiaToolStripMenuItem1";
            this.sephiaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.sephiaToolStripMenuItem1.Text = "Sephia";
            this.sephiaToolStripMenuItem1.Click += new System.EventHandler(this.SephiaToolStripMenuItem1_Click);
            // 
            // pixellateToolStripMenuItem
            // 
            this.pixellateToolStripMenuItem.Name = "pixellateToolStripMenuItem";
            this.pixellateToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pixellateToolStripMenuItem.Text = "Pixellate";
            this.pixellateToolStripMenuItem.Click += new System.EventHandler(this.PixellateToolStripMenuItem_Click);
            // 
            // sobelEdgeDetectionToolStripMenuItem
            // 
            this.sobelEdgeDetectionToolStripMenuItem.Name = "sobelEdgeDetectionToolStripMenuItem";
            this.sobelEdgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sobelEdgeDetectionToolStripMenuItem.Text = "Sobel Edge Detection";
            this.sobelEdgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.SobelEdgeDetectionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sephiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayerToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgeDetectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sephiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pixellateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelEdgeDetectionToolStripMenuItem;
    }
}

