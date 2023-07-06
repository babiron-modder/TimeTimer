using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimeTimer
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private bool mouse_down;
        private Point click_point;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(1, 1);
            mouse_down = false;
            click_point = new Point();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            draw_timer.Enabled = true;
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
            this.TopMost = true;
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            var pic_size = pictureBox_main.Size;
            var margin = 2;
            int side_length = (pic_size.Width < pic_size.Height) ? pic_size.Width : pic_size.Height;
            pictureBox_main.Image = null;
            bmp.Dispose();
            bmp = new Bitmap(side_length, side_length);


            side_length = side_length - margin * 2;
            Graphics g = Graphics.FromImage(bmp);

            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 120, 120, 120)), margin, margin, side_length, side_length);
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 50, 50, 50)), margin + 1, margin + 1, side_length - 2, side_length - 2);



            if (timer_setting_current >= timer_setting_maxsec)
            {
                g.FillPie(new SolidBrush(Color.FromArgb(220, 120, 30, 30)), margin + 3, margin + 3,
                                        side_length - 6, side_length - 6, -90, 360 * timer_setting_current / timer_setting_maxsec);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.FromArgb(220, 30, 30, 30)),
                                        margin + 3, margin + 3, side_length - 6, side_length - 6);
                g.FillPie(new SolidBrush(Color.FromArgb(220, 50, 255, 50)), margin + 3, margin + 3,
                                        side_length - 6, side_length - 6, -90,
                                        -360 * ((timer_setting_maxsec - timer_setting_current) / (float)timer_setting_maxsec));
            }

            /*
            
            g.FillEllipse(new SolidBrush(Color.FromArgb(220, 50, 255, 50)),
                                    margin + 3, margin + 3, side_length - 6, side_length - 6);
            g.FillPie(new SolidBrush(Color.FromArgb(220, 30, 30, 30)), margin + 3, margin + 3,
                                    side_length - 6, side_length - 6, -90, 360 * timer_setting_current / timer_setting_maxsec);

            g.FillEllipse(Brushes.White, margin + 3, margin + 3, side_length - 6, side_length - 6);
            g.FillPie(new SolidBrush(Color.FromArgb(220, 255, 50, 50)), margin + 3, margin + 3,
                                    side_length - 6, side_length - 6, -90, 270);
            */

            g.Dispose();
            pictureBox_main.Image = bmp;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click_point.X = Cursor.Position.X - this.Left;
                click_point.Y = Cursor.Position.Y - this.Top;
                mouse_down = true;
            }

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            mouse_down = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down && e.Button == MouseButtons.Left)
            {
                this.Left = Cursor.Position.X - click_point.X;
                this.Top = Cursor.Position.Y - click_point.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
            }
        }

        private void toolStripComboBox_size_TextChanged(object sender, EventArgs e)
        {
            var tmp = toolStripComboBox_size.Text.Split('x');
            try
            {
                if (int.Parse(tmp[0]) > 0 && int.Parse(tmp[1]) > 0)
                {
                    this.Width = int.Parse(tmp[0]);
                    this.Height = int.Parse(tmp[1]);
                }
            }
            catch (Exception) { }
        }

        // ここからメインのタイマー機能＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        private int timer_setting_maxsec = 60 * 60;
        private int timer_setting_current = 0;

        private void timer_counter_Tick(object sender, EventArgs e)
        {
            if (timer_setting_maxsec > timer_setting_current)
            {
                timer_setting_current += 1;
                toolStripComboBox_time.Text = timer_setting_current.ToString() + "/" + timer_setting_maxsec.ToString();
            }
        }

        private void toolStripMenuItem_timeStart_Click(object sender, EventArgs e)
        {
            timer_counter.Enabled = true;
        }

        private void toolStripMenuItem_timeStop_Click(object sender, EventArgs e)
        {
            timer_counter.Enabled = false;
        }

        private void toolStripMenuItem_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox_time_TextChanged(object sender, EventArgs e)
        {
            var tmp = toolStripComboBox_time.Text.Split('/');
            try
            {
                if (int.Parse(tmp[0]) >= 0 && int.Parse(tmp[1]) > 0)
                {
                    this.timer_setting_current = int.Parse(tmp[0]);
                    this.timer_setting_maxsec = int.Parse(tmp[1]);
                }
            }
            catch (Exception) { }
        }

        private void toolStripMenuItem_timeRest_Click(object sender, EventArgs e)
        {
            timer_setting_current = 0;
            toolStripComboBox_time.Text = timer_setting_current.ToString() + "/" + timer_setting_maxsec.ToString();
        }
    }
}