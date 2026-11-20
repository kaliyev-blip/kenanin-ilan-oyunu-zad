namespace kenanilanoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int speed = 5;
        int dx = 0;
        int dy = 0;
        int score = 0;
        bool GameOver = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                dx = -1;
                dy = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                dx = 1;
                dy = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                dx = 0;
                dy = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                dx = 0;
                dy = 1;
            }

            if (e.KeyCode == Keys.Enter && GameOver)
            {
                RestartGame();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameOver) return;

            snake.Left += dx * speed;
            snake.Top += dy * speed;

            if (snake.Left < 0)
            {
                snake.Left = 0;
            }
            if (snake.Right > ClientSize.Width)
            {
                snake.Left = ClientSize.Width - snake.Width;
            }
            if (snake.Top < 0)
            {
                snake.Top = 0;
            }
            if (snake.Bottom > ClientSize.Height)
            {
                snake.Top = ClientSize.Height - snake.Height;
            }

            if (bomb.Visible && snake.Bounds.IntersectsWith(bomb.Bounds))
            {
                EndGame();
                return;
            }

            if (snake.Bounds.IntersectsWith(apple.Bounds))
            {
                score++;
                speed++;
                NewPositions();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NewPositions();
        }

        private void RandomLocation(PictureBox item)
        {
            do
            {
                item.Left = random.Next(0, ClientSize.Width - item.Width);
                item.Top = random.Next(0, ClientSize.Height - item.Height);
            }
            while (item.Bounds.IntersectsWith(snake.Bounds));
        }

        private void NewPositions()
        {
            RandomLocation(apple);
            bomb.Visible = random.Next(100) < 40;
            RandomLocation(bomb);
            timer2.Stop();
            timer2.Start();
        }

        private void EndGame()
        {
            GameOver = true;
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Oyun bitdi\nNetice: " + score + "\nYeni oyun üçün Enter basın");
        }

        private void RestartGame()
        {
            GameOver = false;
            score = 0;
            speed = 5;
            dx = 0;
            dy = 0;
            snake.Location = new Point(330, 410);
            NewPositions();
            timer1.Start();
        }
    }
}