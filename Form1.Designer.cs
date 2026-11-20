namespace kenanilanoyunu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            snake = new PictureBox();
            apple = new PictureBox();
            bomb = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)snake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            SuspendLayout();
            // 
            // snake
            // 
            snake.Image = (Image)resources.GetObject("snake.Image");
            snake.Location = new Point(377, 547);
            snake.Margin = new Padding(3, 4, 3, 4);
            snake.Name = "snake";
            snake.Size = new Size(103, 120);
            snake.SizeMode = PictureBoxSizeMode.Zoom;
            snake.TabIndex = 0;
            snake.TabStop = false;
            // 
            // apple
            // 
            apple.Image = (Image)resources.GetObject("apple.Image");
            apple.Location = new Point(107, 107);
            apple.Margin = new Padding(3, 4, 3, 4);
            apple.Name = "apple";
            apple.Size = new Size(80, 93);
            apple.SizeMode = PictureBoxSizeMode.Zoom;
            apple.TabIndex = 1;
            apple.TabStop = false;
            // 
            // bomb
            // 
            bomb.Image = (Image)resources.GetObject("bomb.Image");
            bomb.Location = new Point(686, 267);
            bomb.Margin = new Padding(3, 4, 3, 4);
            bomb.Name = "bomb";
            bomb.Size = new Size(80, 93);
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.TabIndex = 2;
            bomb.TabStop = false;
            bomb.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 679);
            Controls.Add(bomb);
            Controls.Add(apple);
            Controls.Add(snake);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Snake and apple";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)snake).EndInit();
            ((System.ComponentModel.ISupportInitialize)apple).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ResumeLayout(false);
        }

        private PictureBox snake;
        private PictureBox apple;
        private PictureBox bomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}