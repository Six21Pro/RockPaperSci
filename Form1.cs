namespace RockPaperSci
{
    public partial class Form1 : Form
    {
        char x, y;//used to determine W,L,T tallies
        String wStr, lStr, tStr;//used to display W,L,T tallies

        int q = 0;//randomized variable
        int W, L, T = 0;//the tallie counts
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);
            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 'r';//This is what the user chose

            win(x, y);
        }

        public void win(char x, char y)//determines the result of the RPS.
        {

            if (x == y) { T++; tStr = T.ToString(); label6.Text = tStr; }//TIE
            else if (x == 'r' && y == 'p') { L++; lStr = L.ToString(); label5.Text = lStr; }//LOSS
            else if (x == 'r' && y == 's') { W++; wStr = W.ToString(); label4.Text = wStr; }//WIN
            else if (x == 'p' && y == 's') { L++; lStr = L.ToString(); label5.Text = lStr; }//LOSS
            else if (x == 'p' && y == 'r') { W++; wStr = W.ToString(); label4.Text = wStr; }//WIN
            else if (x == 's' && y == 'r') { L++; lStr = L.ToString(); label5.Text = lStr; }//LOSS
            else if (x == 's' && y == 'p') { W++; wStr = W.ToString(); label4.Text = wStr; }//WIN
        }

        public async void countDown()//function displays a countdown before showing the randomized selection of R,P,S
        {

            pictureBox1.Image = Properties.Resources._1;
            await Task.Delay(1000);//image displays for a second
            //Thread.Sleep(3000);//Freezes the whole window and all functions. No good
            pictureBox1.Image = Properties.Resources._2;
            await Task.Delay(1000);
            //Thread.Sleep(3000);
            pictureBox1.Image = Properties.Resources._3;
            await Task.Delay(1000);
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);

            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 'p';//This is what the user chose

            win(x, y);//user and random choice sent to win function



        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            countDown();
            await Task.Delay(4000);

            q = rand.Next(1, 4);
            if (q == 1)
            { y = 'r'; pictureBox1.Image = Properties.Resources.crash; }
            else if (q == 2) { y = 'p'; pictureBox1.Image = Properties.Resources.news; }
            else if (q == 3) { y = 's'; pictureBox1.Image = Properties.Resources.sci; }
            x = 's';//This is what the user chose

            win(x, y);//user and random choice sent to win function


        }
    }


}
