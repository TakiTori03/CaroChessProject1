using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using String = System.String;
using System.Media;

namespace CaroChessProject1
{
    public partial class frmPlay : Form
    {
        bool PvsP;
        bool PvsC;
        int CheDo;

        private StreamReader FR;

        string P1;
        string P2;

        int score1;
        int score2;

        frmPvP P1vsP2 = null;
        frmPvC PvsCOM = null;

        //music
        bool isOnMusic;

        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }

        private int current;
        public int Current { get => current; set => current = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private Stack<Point> comeback;
        public Stack<Point> Comeback { get => comeback; set => comeback = value; }

        private Stack<Point> advance;
        public Stack<Point> Advance { get => advance; set => advance = value; }

        public void funData1(TextBox Player1) { P1 = Player1.Text; }
        public void funData2(TextBox Player2) { P2 = Player2.Text; }
        public frmPlay()
        {
            InitializeComponent();

            prgbCoolDown.Step = Cons.CoolDownStep;
            prgbCoolDown.Maximum = Cons.CoolDownTime;
            prgbCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.CoolDownInterval;
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            lblLaws.Text = "-Each player fills in each box on the \nboard.\n- The player who fills in at least 5 \nconsecutive chess pieces in the \nsame row, column or \ndiagonal without being blocked by \nthe opponent at both ends will win. \n-If two players fill in all the boxes on\nthe board and still don't win, the\n twoplayers will draw.";
        }

        private void frmPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the game ?", "Game Caro", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        public void Quit()
        {
            this.Close();  //Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        void DrawChessBoard()
        {
            pnlChessBoard.Controls.Clear();
            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.NumberChess_Height; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j <= Cons.NumberChess_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Width,
                        Height = Cons.Chess_Height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                    };

                    btn.Click += Btn_Click;
                    pnlChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.Chess_Height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Advance = new Stack<Point>();

            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
            {
                return;
            }

            Mark(btn);
            Comeback.Push(GetChessPoint(btn));

            Current = Current == 1 ? 0 : 1;
            changePlayer();

            tmCoolDown.Start();
            prgbCoolDown.Value = 0;

            if (isEndGame(btn))
            {
                EndGame();

            }

        }

        private void Sound()
        {
            SoundPlayer bloop = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\bloop.wav");
            bloop.Play();
        }


        public bool Undo()
        {
            if (Comeback.Count <= 0)
            {
                tmCoolDown.Stop();
                prgbCoolDown.Value = 0;
                return false;
            }
            prgbCoolDown.Value = 0;
            Point point = Comeback.Peek();

            Advance.Push(point);

            Point oldpoint = Comeback.Pop();

            Button btn = Matrix[oldpoint.Y][oldpoint.X];

            btn.BackgroundImage = null;

            Current = Current == 1 ? 0 : 1;
            changePlayer();

            return true;

        }
        public bool Redo()
        {
            if (Advance.Count <= 0)
            {
                tmCoolDown.Stop();
                prgbCoolDown.Value = 0;
                return false;
            }

            prgbCoolDown.Value = 0;
            Point point = Advance.Peek();

            Comeback.Push(point);

            Point oldpoint = Advance.Pop();
            Button btn = Matrix[oldpoint.Y][oldpoint.X];

            btn.BackgroundImage = Player[Current].Mark;

            Current = Current == 1 ? 0 : 1;

            changePlayer();

            return true;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DrawChessBoard();

            pnlChessBoard.Enabled = true;
            btnStart.Enabled = false;
            btnRefresh.Enabled = true;
            btnPlayervsPlayer.Enabled = true;
            btnPlayervsComputer.Enabled = true;
            btnUndo.Enabled = true;
            btnRedo.Enabled = true;
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = true;

            if (P2 == null)
            {

                lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + "Computer";
                PlayervsCom(P1);
            }
                
            else if (P1 != "" && P2 != "")
            {
                lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + P2;
                PlayervsPlayer(P1, P2);
            }
                

            /* P1 = null;
             P2 = null;*/

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to refresh game ?", "Game Caro", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DrawChessBoard();
                prgbCoolDown.Value = 0;
                tmCoolDown.Stop();

                pnlChessBoard.Enabled = true;
                btnStart.Enabled = false;
                btnRefresh.Enabled = true;
                btnPlayervsPlayer.Enabled = true;
                btnPlayervsComputer.Enabled = true;
                btnUndo.Enabled = true;
                btnRedo.Enabled = true;
                undoToolStripMenuItem.Enabled = true;
                redoToolStripMenuItem.Enabled = true;
                if (P2 == null)
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + "Computer";
                    PlayervsCom(P1);
                }else if (P1 != "" && P2 != "")
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + P2;
                    PlayervsPlayer(P1, P2);
                }                 
            }
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[current].Mark;
            //BackgroundMusic();
            Sound();
            //current = current == 1 ? 0 : 1;
        }

        private void changePlayer()
        {
            txbPlayerName.Text = Player[current].Name;
            pctbMark.Image = Player[current].Mark;
        }

        void PlayervsPlayer(string P1, string P2)
        {
            PvsP = true;
            PvsC = false;
            if (PvsP == true)
            {
                CheDo = 1;
                this.Player = new List<Player>()
                {
                    new Player (P1, Image.FromFile(Application.StartupPath+"\\Image\\O.png")),
                    new Player (P2, Image.FromFile(Application.StartupPath+ "\\Image\\X.png")),
                };
                Comeback = new Stack<Point>();
                Advance = new Stack<Point>();
                int Rnum;
                Random rad = new Random();
                Rnum = rad.Next(0, 100);
                current = Rnum % 2;
                changePlayer();
            }
        }

        void PlayervsCom(String P1)
        {
            PvsC = true;
            PvsP = false;
            if (PvsC == true)
            {
                CheDo = 2;
                this.Player = new List<Player>() {
                new Player(P1,Image.FromFile(Application.StartupPath+ "\\Image\\O.png")),
                new Player("Computer",Image.FromFile(Application.StartupPath+ "\\Image\\X.png")),
                };
                Comeback = new Stack<Point>();
                Advance = new Stack<Point>();

                //MarkPlayer = new List<Point>();

                current = 0;

                changePlayer();
            }
        }

        private void btnPlayervsPlayer_Click(object sender, EventArgs e)
        {
            NewPvsP();
        }
        private void playervsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPvsP();
        }
        private void NewPvsP()
        {
            if (MessageBox.Show("Do you want to start a new game ?", "Game Caro", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                prgbCoolDown.Value = 0;
                tmCoolDown.Stop();
                score1 = score2 = 0;
                if (P1vsP2 == null)
                {
                    P1vsP2 = new frmPvP();
                    P1vsP2.PlayGame = this;
                }
                P1vsP2.Show();
                this.Hide();
                pnlChessBoard.Enabled = false;
                btnStart.Enabled = true;
                btnRefresh.Enabled = false;
                btnPlayervsComputer.Enabled = false;
                btnPlayervsPlayer.Enabled = false;
                btnRedo.Enabled = false;
                btnUndo.Enabled = false;

            }

        }
        private void btnPlayervsComputer_Click(object sender, EventArgs e)
        {
            NewPvsC();
        }
        private void playervsComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPvsC();
        }
        private void NewPvsC()
        {

            if (MessageBox.Show("Do you want to start a new game ?", "Game Caro", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                prgbCoolDown.Value = 0;
                tmCoolDown.Stop();
                score1 = score2 = 0;
                if (PvsCOM == null)
                {
                    PvsCOM = new frmPvC();
                    PvsCOM.PlayGame = this;
                }
                PvsCOM.Show();
                this.Hide();
                pnlChessBoard.Enabled = false;
                btnStart.Enabled = true;
                btnRefresh.Enabled = false;
                btnPlayervsComputer.Enabled = false;
                btnPlayervsPlayer.Enabled = false;
                btnRedo.Enabled = false;
                btnUndo.Enabled = false;
            }

        }
         

private void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            if (Comeback.Count == Cons.NumberChess_Height * Cons.NumberChess_Width)
            {
                score1++;
                score2++;
                if (P2 == null)
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + "Computer";
                }
                else if (P1 != "" && P2 != "")
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + P2;
                }
                MessageBox.Show($"DRAW !!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (current == 0)
                {
                    score2++;
                }
                else if (current == 1)
                {
                    score1++;
                }

                if (P2 == null)
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + "Computer";
                }
                else if (P1 != "" && P2 != "")
                {
                    lblScore.Text = "Score " + P1 + " " + score1 + " : " + score2 + " " + P2;
                }

                MessageBox.Show($"Congratulations to player *{Player[current == 0 ? 1 : 0].Name}* for defeating *{Player[current].Name}* !!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private Point GetChessPoint(Button btn)
        {

            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;

            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.NumberChess_Width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else break;
            }

            if (countLeft + countRight >= 5)
            {
                if (point.X - countLeft + 1 == 0 || point.X + countRight == Cons.NumberChess_Width - 1)
                {
                    return true;
                }
                if (Matrix[point.Y][point.X - countLeft].BackgroundImage == null || Matrix[point.Y][point.X + countRight + 1].BackgroundImage == null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.NumberChess_Height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else break;
            }

            if (countTop + countBottom >= 5)
            {
                if (point.Y - countTop + 1 == 0 || point.Y + countBottom == Cons.NumberChess_Height - 1)
                {
                    return true;
                }
                if (Matrix[point.Y - countTop][point.X].BackgroundImage == null || Matrix[point.Y + countBottom + 1][point.X] == null)
                {
                    return true;
                }
            }
            return false;
        }
        //cheo xuoi
        private bool isEndPrimaryCross(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else break;
            }

            int countBottom = 0;
            for (int i = 1; i < Cons.NumberChess_Width - point.X; i++)
            {
                if (point.Y + i >= Cons.NumberChess_Height || point.X + i >= Cons.NumberChess_Width) break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else break;
            }

            if (countTop + countBottom >= 5)
            {
                if (point.Y - countTop + 1 == 0 || point.Y + countBottom == Cons.NumberChess_Height - 1 || point.X - countTop + 1 == 0 || point.X + countBottom == Cons.NumberChess_Width - 1)
                {
                    return true;
                }
                if (Matrix[point.Y - countTop][point.X - countTop].BackgroundImage == null || Matrix[point.Y + countBottom + 1][point.X + countBottom + 1] == null)
                {
                    return true;
                }
            }
            return false;
        }
        //cheo nguoc
        private bool isEndPrimary(Button btn)
        {

            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = 0; i < Cons.NumberChess_Width - point.X; i++)
            {
                if (point.X + i >= Cons.NumberChess_Width || point.Y - i < 0) break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else break;
            }

            int countBottom = 0;
            for (int i = 1; i <= point.X; i++)
            {
                if (point.Y + i >= Cons.NumberChess_Height || point.X - i < 0) break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else break;
            }

            if (countTop + countBottom >= 5)
            {
                if (point.Y - countTop + 1 == 0 || point.Y + countBottom == Cons.NumberChess_Height - 1 || point.X + countTop == Cons.NumberChess_Width || point.X - countBottom == 0)
                {
                    return true;
                }
                if (Matrix[point.Y - countTop][point.X + countTop].BackgroundImage == null || Matrix[point.Y + countBottom + 1][point.X - countBottom - 1] == null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isDraw()
        {
            if (Comeback.Count == Cons.NumberChess_Height * Cons.NumberChess_Width)
            {
                return true;
            }
            return false;

        }

        private bool isEndGame(Button btn)
        {
            if (isDraw())
                return true;
            /*
            foreach(Point curPoint in Comeback)
            {
                if (Matrix[curPoint.Y][curPoint.X].BackgroundImage == btn.BackgroundImage)
                {
                    if (isEndVertical(Matrix[curPoint.Y][curPoint.X]) || isEndHorizontal(Matrix[curPoint.Y][curPoint.X]) || isEndPrimary(Matrix[curPoint.Y][curPoint.X]) || isEndPrimaryCross(Matrix[curPoint.Y][curPoint.X]) )
                        return true;
                }
            }
            return false;*/
            if (isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndPrimaryCross(btn))
            {
                return true;
            }
            return false;
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prgbCoolDown.PerformStep();
            if (prgbCoolDown.Value >= prgbCoolDown.Maximum)
            {
                EndGame();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

     
    }
}

       


    

