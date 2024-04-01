using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOOLS.CursorFuruFuru
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private bool movingFoward = true;
        private Point startPosition = new Point(100, 100);
        private Point endPosition = new Point(500, 400);

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            updateIntervalLabel();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (movingFoward)
            {
                Cursor.Position = startPosition;
                movingFoward = false;
            }
            else
            {
                Cursor.Position = endPosition;
                movingFoward = true;
            }
        }

        private void updateIntervalLabel()
        {
            intervalLabel.Text = (timer.Interval / 1000.0).ToString("0.##");
        }

        private void intervalUpdateButton_Click(object sender, EventArgs e)
        {
            string input = intervalInputBox.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("値を入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (int.TryParse(input, out int interval))
                {
                    timer.Interval = interval * 1000;
                }
                else
                {
                    MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            updateIntervalLabel();
        }
    }
}
