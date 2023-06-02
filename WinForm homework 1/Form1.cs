using System.Configuration;

namespace WinForm_homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label1))
            {
                PlayerChoice(label1);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");
        }
        private bool Stop = true;
        private void label2_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label2))
            {
                PlayerChoice(label2);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label3))
            {
                PlayerChoice(label3);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label4))
            {
                PlayerChoice(label4);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label5))
            {
                PlayerChoice(label5);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label6))
            {
                PlayerChoice(label6);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");
        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label7))
            {
                PlayerChoice(label7);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label8_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label8))
            {
                PlayerChoice(label8);
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }
            }
            else MessageBox.Show("You cant choice this label");

        }
        private void label9_Click(object sender, EventArgs e)
        {
            if (IsLabelFree(label9))
            {
                PlayerChoice(label9);
                IsWinner();
                if (is_Full())
                {
                    MessageBox.Show("Game over");
                    Application.ExitThread();
                    Application.Restart();
                }
                else
                {
                    BotChooice();
                }

            }
            else MessageBox.Show("You cant choice this label");
        }
        private bool is_Full()
        {
            Label[] labels = new Label[9] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            foreach (var item in labels)
            {
                if (item.Text == "") return false;
            }
            return true;
        }
        private bool IsLabelFree(Label label)
        {
            if (label.Text == "") return true;
            return false;
        }
        private void PlayerChoice(Label label)
        {
            label.Text = "X";
            label.ForeColor = Color.White;
            label.Image = Properties.Resources.Ex;
            
        }
        private void BotChooice()
        {
            Label[] labels = new Label[9] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            Random random = new Random();
            int choice = random.Next(0, 9);
            if (IsLabelFree(labels[choice]))
            {
                labels[choice].Text = "O";
                labels[choice].ForeColor = Color.White;
                labels[choice].Image = Properties.Resources.Circle;
            }
            else BotChooice();
            IsWinner();
        }
        private void IsWinner()
        {
            //Checking "X"
            Label[] labels = new Label[9] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            for (int i = 0; i < labels.GetLength(0); i += 3)
            {
                if (labels[i].Text == "X" && labels[i + 1].Text == "X" && labels[i + 2].Text == "X")
                {
                    MessageBox.Show("X won");
                    Application.Exit();

                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (labels[i].Text == "X" && labels[i + 3].Text == "X" && labels[i + 6].Text == "X")
                {
                    MessageBox.Show("X won");
                    Application.Exit();
                }
            }
            if (labels[0].Text == "X" && labels[4].Text == "X" && labels[8].Text == "X")
            {
                MessageBox.Show("X won");
                Application.Exit();
            }
            if (labels[2].Text == "X" && labels[4].Text == "X" && labels[6].Text == "X")
            {
                MessageBox.Show("X won");
                Application.Exit();
            }
            //Checking "O"
            for (int i = 0; i < labels.GetLength(0); i += 3)
            {
                if (labels[i].Text == "O" && labels[i + 1].Text == "O" && labels[i + 2].Text == "O")
                {
                    MessageBox.Show("O won");
                    Application.Exit();
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (labels[i].Text == "O" && labels[i + 3].Text == "O" && labels[i + 6].Text == "O")
                {
                    MessageBox.Show("O won");
                    Application.Exit();
                }
            }
            if (labels[0].Text == "O" && labels[4].Text == "O" && labels[8].Text == "O")
            {
                MessageBox.Show("O won");
                Application.Exit();
            }
            if (labels[2].Text == "O" && labels[4].Text == "O" && labels[6].Text == "O")
            {
                MessageBox.Show("O won");
                Application.Exit();
            }
            
        }

    }
}