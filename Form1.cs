using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enTurn { Player1 = 1, Player2 = 2 };
        enum enWinner { Player1 = 1, Player2 = 2, Draw = 3 };

        enTurn turn = enTurn.Player1;
        struct stGameStatus
        {
            public enWinner winner = enWinner.Draw;
            public bool GameOver = false;
            public short PlayCount = 0;
            public stGameStatus()
            {
            }
        };

        stGameStatus GameStatus;
        

        void EndGame()
        {
            lbPlayer.Text = "Game Over";
            switch(GameStatus.winner)
            {
                case enWinner.Player1:
                    lbWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lbWinner.Text = "Player 2";
                    break;
                default:
                    lbWinner.Text = "Draw";
                    break;
                    
            }
            MessageBox.Show("Game Over","Game Over",MessageBoxButtons.OK);
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            return false;
                
        }

        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
            {
                GameStatus.winner = (button1.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button4, button5, button6))
            {
                GameStatus.winner = (button3.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button7, button8, button9))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button1, button4, button7))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button2, button5, button8))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button3, button6, button9))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button1, button5, button9))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
            else if (CheckValues(button3, button4, button7))
            {
                GameStatus.winner = (button6.Image.Tag == "X") ? enWinner.Player1 : enWinner.Player2;
                return;
            }
        }

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (turn)
                {
                    case enTurn.Player1:
                        btn.Image = Resources.X;
                        turn = enTurn.Player2;
                        lbPlayer.Text = "Player 2";
                        btn.Tag = "X";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                    case enTurn.Player2:
                        btn.Image = Resources.O;
                        turn = enTurn.Player1;
                        lbPlayer.Text = "Player 1";
                        btn.Tag = "O";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Wrong Choice","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.winner = enWinner.Draw;
                EndGame();
            }
        }

        void Restart()
        {
            // Picture Boxes
            button1.Image = Resources.question_mark_96;
            button1.Tag = "?";
            button1.BackColor = Color.Black;
            button2.Image = Resources.question_mark_96;
            button2.Tag = "?";
            button2.BackColor = Color.Black;
            button3.Image = Resources.question_mark_96;
            button3.Tag = "?";
            button3.BackColor = Color.Black;
            button4.Image = Resources.question_mark_96;
            button4.Tag = "?";
            button4.BackColor = Color.Black;
            button5.Image = Resources.question_mark_96;
            button5.Tag = "?";
            button5.BackColor = Color.Black;
            button6.Image = Resources.question_mark_96;
            button6.Tag = "?";
            button6.BackColor = Color.Black;
            button7.Image = Resources.question_mark_96;
            button7.Tag = "?";
            button7.BackColor = Color.Black;
            button8.Image = Resources.question_mark_96;
            button8.Tag = "?";
            button8.BackColor = Color.Black;
            button9.Image = Resources.question_mark_96;
            button9.Tag = "?";
            button9.BackColor = Color.Black;

            // Labels
            lbPlayer.Text = "Player1";
            lbWinner.Text = "In Progress";

            // Enums
            turn = enTurn.Player1;
            GameStatus.winner = enWinner.Draw;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(white);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 805, 150, 805, 600);
            e.Graphics.DrawLine(pen, 1005, 150, 1005, 600);
            e.Graphics.DrawLine(pen, 600, 300, 1200, 300);
            e.Graphics.DrawLine(pen, 600, 450, 1200, 450);



        }



        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeImage(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeImage(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeImage(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeImage(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeImage(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeImage(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeImage(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeImage(button9);
        }
    }
}