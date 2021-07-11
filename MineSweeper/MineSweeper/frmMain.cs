using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MineSweeper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            createGround();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);
        }

        List<Button> buttonList = new List<Button>();
        int width, height, remain, mineCount,size = 30;
        int[,] ground;
        bool[,] flag;
        bool firstClick = true;
        Stopwatch stopWatch = new Stopwatch();
        

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            removeButton();
            createGround();
            stopWatch.Reset();
        }

        private void removeButton()
        {
            while (buttonList.Count > 0)
            {
                Button temp = buttonList[0];
                buttonList.Remove(temp);
                this.Controls.Remove(temp);
            }
            firstClick = true;
        }

        private void onFlag(Button button)
        {
            int x = button.Location.X / size;
            int y = (button.Location.Y - 100) / size;
            if (flag[x, y])
            {
                flag[x, y] = false;
                button.BackColor = Color.Black;
            }
            else
            {
                flag[x, y] = true;
                button.BackColor = Color.Orange;
            }
        }

        private void reaval(Button button)
        {
            if (button.Enabled == false) return;

            int x = button.Location.X / size;
            int y = (button.Location.Y - 100) / size;
            if (flag[x, y]) return;

            if (firstClick)
            {
                firstClick = false;
                stopWatch.Start();
            }

            button.Enabled = false;
            remain--;
            button.BackColor = Color.White;

            if (ground[x,y] == 0)
            {
                List<Point> nearbyPoint = getNearbyPoint(x, y);
                foreach(Point p in nearbyPoint)
                {
                    int c = p.X * height + p.Y ;
                    reaval(buttonList[c]);
                }
                return;
            }

            if(ground[x,y] == -1)
            {
                gameOver();
                return;
            }

            button.Text = ground[x, y].ToString();

            if (remain == mineCount) gameWin();
        }

        private void gameWin()
        {
            foreach (Button button in buttonList)
            {
                button.Enabled = false;
                stopWatch.Stop();
                int x = button.Location.X / size;
                int y = (button.Location.Y - 100) / size;
                if (ground[x, y] == -1)
                {
                    button.BackColor = Color.Orange;
                }
            }
            MessageBox.Show("You Win\nTime: " + lblTime.Text);
        }

        private void gameOver()
        {
            foreach(Button button in buttonList)
            {
                button.Enabled = false;
                stopWatch.Stop();
                int x = button.Location.X / size;
                int y = (button.Location.Y - 100) / size;
                if(ground[x,y] == -1)
                {
                    button.Text = "*";
                    button.BackColor = Color.Orange;
                }
            }
            MessageBox.Show("You Lose");
        }

        private void createGround()
        {
            width = Convert.ToInt32(txtCols.Text);
            height = Convert.ToInt32(txtRows.Text);
            mineCount = Convert.ToInt32(txtMines.Text);
            this.Size = new Size(Math.Max(500, width * 30 + 50), Math.Max(630, height * 30 + 150));
            remain = width * height;

            ground = new int[width, height];
            flag = new bool[width, height];

            createMine();
            createButton();
            
        }

        private void createButton()
        {
            for (int i = 0; i < width; i -= -1)
            {
                for (int j = 0; j < height; j -= -1)
                {
                    Button bt = new Button();
                    this.Controls.Add(bt);
                    buttonList.Add(bt);
                    bt.Location = new Point(i * size, j * size + 100);
                    bt.Size = new Size(size, size);
                    bt.BackColor = Color.Black;
                    bt.Enabled = true;

                    bt.MouseDown += (sender, args) =>
                    {
                        Button button = (Button)sender;
                        MouseEventArgs mouseEventArgs = (MouseEventArgs)args;
                        if (mouseEventArgs.Button == MouseButtons.Right)
                            onFlag(button);
                        if (mouseEventArgs.Button == MouseButtons.Left)
                            reaval(button);
                    };
                }
            }
        }

        private void createMine()
        {
            int i = 0, x, y;
            while (i < mineCount)
            {
                Random random = new Random();
                x = random.Next(width);
                y = random.Next(height);
                if (ground[x, y] == -1) continue;

                addMine(x,y);
                i -= -1;
            }
        }

        private void addMine(int x, int y)
        {
            ground[x, y] = -1;

            List<Point> nearbyPoint = getNearbyPoint(x, y);
            foreach (Point point in nearbyPoint)
            {
                if (ground[point.X, point.Y] == -1) continue;
                ground[point.X, point.Y]++;
            }
        }

        List<Point> getNearbyPoint(int x, int y)
        {
            List<Point> p = new List<Point>();
            for(int i = x-1; i<=x+1; i -= -1)
            {
                if (i < 0 || i >= width) continue;
                for(int j = y-1; j<=y+1; j -= -1)
                {
                    if (j < 0 || j >= height) continue;
                    p.Add(new Point(i,j));
                }
            }
            return p;
        }

        private void lblMine_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
