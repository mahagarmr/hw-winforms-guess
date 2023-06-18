namespace hw_winforms_guess
{
    public partial class Form1 : Form
    {
        int PickedNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pickedNum;

            try
            {
                pickedNum = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                        "it's not a number =( .",
                        "error ??",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                return;
            }

            if (!(pickedNum >= 1 && pickedNum <= 2000))
            {
                MessageBox.Show(
                    "must be in range (1 .. 2000) .",
                    "error ??",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return;
            }


            Random rnd = new Random();
            int guessNum = rnd.Next(1, 2000 + 1);
            int min = 1, max = 2000 + 1;
            int attempts = 0;
            DialogResult d;

            while (guessNum != PickedNum)
            {
                attempts++;

                d = MessageBox.Show(
                    $"i guess it's {guessNum} ??",
                    "guessing :-/",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (d == DialogResult.Yes)
                {
                    PickedNum = guessNum;

                    d = MessageBox.Show(
                        $"gg :-p. attempts : {attempts}",
                        "end game",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Information);

                    if (d == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }

                    textBox1.Clear();
                    return;
                }

                d = MessageBox.Show(
                    $"ok. maybe less then {guessNum} ??",
                    "guessing :-/",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (d == DialogResult.Yes)
                {
                    max = guessNum;
                    guessNum = rnd.Next(min, max);
                }

                else if (d == DialogResult.No)
                {
                    min = guessNum + 1;
                    guessNum = rnd.Next(min, max);
                }
            }
        }
    }
}