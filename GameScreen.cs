using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class GameScreen : Form
    {


        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1; 
        enum enPlayer{ Player1, Player2 }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayerCount;
        }

        public bool CheckValues(Button bt1, Button bt2, Button bt3)
        {
            if (bt1.Tag.ToString() != "?" && bt1.Tag.ToString() == bt2.Tag.ToString() && bt1.Tag.ToString() == bt3.Tag.ToString())
            {
                if (bt1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            } 

            GameStatus.GameOver = false;
            return false;
        }

        void EndGame()
        {
            lblTurn.Text = "GAME OVER";

            switch(GameStatus.Winner)
            {
                case enWinner.Player1:

                    LblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:

                    LblWinner.Text = "Player 2";
                    break;

                default:

                    LblWinner.Text = "Draw";
                    break;  


            }
            
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void CheckWinner()
        {
            if (CheckValues(Bt1, Bt2, Bt3))
                return;
            if (CheckValues(Bt4, Bt5, Bt6))
                return;
            if (CheckValues(Bt7, Bt8, Bt9))
                return;
            if (CheckValues(Bt1, Bt4, Bt7))
                return;
            if (CheckValues(Bt2, Bt5, Bt8))
                return;
            if (CheckValues(Bt3, Bt6, Bt9))
                return;
            if (CheckValues(Bt1, Bt5, Bt9))
                return;
            if (CheckValues(Bt3, Bt5, Bt7))
                return;
        }
        public void ChangeImage(Button btn)
        {
           if(btn.Tag.ToString()=="?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayerCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayerCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           if(GameStatus.PlayerCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
            
        }
        public GameScreen()
        {
            InitializeComponent();
        }

      

        private void XO_Draw(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);

            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 423, 122, 423, 410);
            e.Graphics.DrawLine(Pen, 592, 122, 592, 410);

            e.Graphics.DrawLine(Pen, 300, 210, 715, 210);
            e.Graphics.DrawLine(Pen, 300, 316, 715, 316);


        }
        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
        }

        private void RestartGame()
        {
            RestButton(Bt1);
            RestButton(Bt2);
            RestButton(Bt3);
            RestButton(Bt4);
            RestButton(Bt5);
            RestButton(Bt6);
            RestButton(Bt7);
            RestButton(Bt8);
            RestButton(Bt9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayerCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            LblWinner.Text = "In Progress";
        }

        private void BtRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Application.Exit();
            //Form TheMain = new Form1();
           // TheMain.ShowDialog();
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }
        
        private void lblTurn_Click(object sender, EventArgs e)
        {

        }
    }
}
