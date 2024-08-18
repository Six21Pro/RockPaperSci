namespace RockPaperSci
{
    public partial class Form1 : Form
    {
        char x, y;

        int z, q = 0;
        int W, L, T = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);

            // while (pictureBox1.Image == Properties.Resources._3) { 
            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 'r';

            win(x, y);


            // }

            //Form2 form2 = new Form2();
            //form2.ShowDialog();
        }

        public void win(char x, char y)
        {
            
            if (x == y) { T++; }//TIE
            else if (x == 'r' && y == 'p') { L++; }
            else if (x == 'r' && y == 's') { W++;
                label4.Text = W.ToString();
            }
            else if (x == 'p' && y == 's') { L++; }
            else if (x == 'p' && y == 'r') { W++; label4.Text = "W.ToString()"; }
            else if (x == 's' && y == 'r') { L++; }
            else if (x == 's' && y == 'p') { W++; label4.Text = W.ToString(); }
        }

        public async void countDown()
        {

            pictureBox1.Image = Properties.Resources._1;
            await Task.Delay(1000);
            //Thread.Sleep(3000);
            pictureBox1.Image = Properties.Resources._2;
            await Task.Delay(1000);
            //Thread.Sleep(3000);
            pictureBox1.Image = Properties.Resources._3;
            await Task.Delay(1000);
            //Thread.Sleep(3000);
            //setQ();
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);

            // while (pictureBox1.Image == Properties.Resources._3) { 
            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 'p';

            win(x, y);


           
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);

            // while (pictureBox1.Image == Properties.Resources._3) { 
            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 's';

            win(x, y);

           
        }
    }


}
