
namespace Assignment3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load50FibMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load100FibMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 422);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileMenuItem,
            this.load50FibMenuItem,
            this.load100FibMenuItem,
            this.toolStripMenuItem1,
            this.saveFileMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // LoadFileMenuItem
            // 
            this.LoadFileMenuItem.Name = "LoadFileMenuItem";
            this.LoadFileMenuItem.Size = new System.Drawing.Size(320, 26);
            this.LoadFileMenuItem.Text = "Load From File";
            this.LoadFileMenuItem.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // load50FibMenuItem
            // 
            this.load50FibMenuItem.Name = "load50FibMenuItem";
            this.load50FibMenuItem.Size = new System.Drawing.Size(320, 26);
            this.load50FibMenuItem.Text = "Load Fibonacci numbers (first 50)";
            this.load50FibMenuItem.Click += new System.EventHandler(this.Load50FibMenuItem_Click);
            // 
            // load100FibMenuItem
            // 
            this.load100FibMenuItem.Name = "load100FibMenuItem";
            this.load100FibMenuItem.Size = new System.Drawing.Size(320, 26);
            this.load100FibMenuItem.Text = "Load Fibonacci numbers (first 100)";
            this.load100FibMenuItem.Click += new System.EventHandler(this.Load100FibMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(317, 6);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(320, 26);
            this.saveFileMenuItem.Text = "Save File";
            this.saveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "321 Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.LoadFromFile_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem load50FibMenuItem;
        private System.Windows.Forms.ToolStripMenuItem load100FibMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
    }
}

