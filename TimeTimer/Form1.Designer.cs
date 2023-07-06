namespace TimeTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox_main = new PictureBox();
            contextMenuStrip_main = new ContextMenuStrip(components);
            toolStripComboBox_time = new ToolStripComboBox();
            toolStripMenuItem_timeStart = new ToolStripMenuItem();
            toolStripMenuItem_timeStop = new ToolStripMenuItem();
            toolStripMenuItem_timeRest = new ToolStripMenuItem();
            toolStripComboBox_size = new ToolStripComboBox();
            toolStripMenuItem_end = new ToolStripMenuItem();
            draw_timer = new System.Windows.Forms.Timer(components);
            timer_counter = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_main).BeginInit();
            contextMenuStrip_main.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_main
            // 
            pictureBox_main.ContextMenuStrip = contextMenuStrip_main;
            pictureBox_main.Dock = DockStyle.Fill;
            pictureBox_main.Location = new Point(0, 0);
            pictureBox_main.Name = "pictureBox_main";
            pictureBox_main.Size = new Size(150, 150);
            pictureBox_main.TabIndex = 0;
            pictureBox_main.TabStop = false;
            pictureBox_main.MouseDown += Form1_MouseDown;
            pictureBox_main.MouseLeave += Form1_MouseLeave;
            pictureBox_main.MouseMove += Form1_MouseMove;
            pictureBox_main.MouseUp += Form1_MouseUp;
            // 
            // contextMenuStrip_main
            // 
            contextMenuStrip_main.Items.AddRange(new ToolStripItem[] { toolStripComboBox_time, toolStripMenuItem_timeStart, toolStripMenuItem_timeStop, toolStripMenuItem_timeRest, toolStripComboBox_size, toolStripMenuItem_end });
            contextMenuStrip_main.Name = "contextMenuStrip_main";
            contextMenuStrip_main.Size = new Size(182, 168);
            // 
            // toolStripComboBox_time
            // 
            toolStripComboBox_time.Items.AddRange(new object[] { "0/1800", "0/3600", "0/7200" });
            toolStripComboBox_time.Name = "toolStripComboBox_time";
            toolStripComboBox_time.Size = new Size(121, 23);
            toolStripComboBox_time.Text = "0/3600";
            toolStripComboBox_time.TextChanged += toolStripComboBox_time_TextChanged;
            // 
            // toolStripMenuItem_timeStart
            // 
            toolStripMenuItem_timeStart.Name = "toolStripMenuItem_timeStart";
            toolStripMenuItem_timeStart.Size = new Size(181, 22);
            toolStripMenuItem_timeStart.Text = "スタートする(&S)";
            toolStripMenuItem_timeStart.Click += toolStripMenuItem_timeStart_Click;
            // 
            // toolStripMenuItem_timeStop
            // 
            toolStripMenuItem_timeStop.Name = "toolStripMenuItem_timeStop";
            toolStripMenuItem_timeStop.Size = new Size(181, 22);
            toolStripMenuItem_timeStop.Text = "時間を止める(&H)";
            toolStripMenuItem_timeStop.Click += toolStripMenuItem_timeStop_Click;
            // 
            // toolStripMenuItem_timeRest
            // 
            toolStripMenuItem_timeRest.Name = "toolStripMenuItem_timeRest";
            toolStripMenuItem_timeRest.Size = new Size(181, 22);
            toolStripMenuItem_timeRest.Text = "時間をリセット(&R)";
            toolStripMenuItem_timeRest.Click += toolStripMenuItem_timeRest_Click;
            // 
            // toolStripComboBox_size
            // 
            toolStripComboBox_size.Items.AddRange(new object[] { "100x100", "150x150", "200x200", "250x250", "300x300" });
            toolStripComboBox_size.Name = "toolStripComboBox_size";
            toolStripComboBox_size.Size = new Size(121, 23);
            toolStripComboBox_size.Text = "150x150";
            toolStripComboBox_size.TextChanged += toolStripComboBox_size_TextChanged;
            // 
            // toolStripMenuItem_end
            // 
            toolStripMenuItem_end.Name = "toolStripMenuItem_end";
            toolStripMenuItem_end.Size = new Size(181, 22);
            toolStripMenuItem_end.Text = "終了する(&Q)";
            toolStripMenuItem_end.Click += toolStripMenuItem_end_Click;
            // 
            // draw_timer
            // 
            draw_timer.Tick += timer_main_Tick;
            // 
            // timer_counter
            // 
            timer_counter.Interval = 1000;
            timer_counter.Tick += timer_counter_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(150, 150);
            Controls.Add(pictureBox_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_main).EndInit();
            contextMenuStrip_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_main;
        private System.Windows.Forms.Timer draw_timer;
        private ContextMenuStrip contextMenuStrip_main;
        private ToolStripMenuItem toolStripMenuItem_end;
        private ToolStripComboBox toolStripComboBox_size;
        private ToolStripComboBox toolStripComboBox_time;
        private ToolStripMenuItem toolStripMenuItem_timeStart;
        private ToolStripMenuItem toolStripMenuItem_timeStop;
        private ToolStripMenuItem toolStripMenuItem_timeRest;
        private System.Windows.Forms.Timer timer_counter;
    }
}