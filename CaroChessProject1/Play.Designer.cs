namespace CaroChessProject1
{
    partial class frmPlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            playervsPlayerToolStripMenuItem = new ToolStripMenuItem();
            playervsComToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            gpbLaws = new GroupBox();
            lblLaws = new Label();
            lblPlayerNameAndMark = new Label();
            txbPlayerName = new TextBox();
            btnStart = new Button();
            pctbMark = new PictureBox();
            lblTime = new Label();
            prgbCoolDown = new ProgressBar();
            btnUndo = new Button();
            btnRedo = new Button();
            btnPlayervsPlayer = new Button();
            btnPlayervsComputer = new Button();
            btnQuit = new Button();
            pnlChessBoard = new Panel();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            btnRefresh = new Button();
            lblScore = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gpbLaws.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1111, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playervsPlayerToolStripMenuItem, playervsComToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(98, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // playervsPlayerToolStripMenuItem
            // 
            playervsPlayerToolStripMenuItem.Name = "playervsPlayerToolStripMenuItem";
            playervsPlayerToolStripMenuItem.Size = new Size(149, 22);
            playervsPlayerToolStripMenuItem.Text = "PlayervsPlayer";
            playervsPlayerToolStripMenuItem.Click += playervsPlayerToolStripMenuItem_Click;
            // 
            // playervsComToolStripMenuItem
            // 
            playervsComToolStripMenuItem.Name = "playervsComToolStripMenuItem";
            playervsComToolStripMenuItem.Size = new Size(149, 22);
            playervsComToolStripMenuItem.Text = "PlayervsCom";
            playervsComToolStripMenuItem.Click += playervsComToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "&Setting";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pctbCaroChess;
            pictureBox1.Location = new Point(219, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // gpbLaws
            // 
            gpbLaws.Controls.Add(lblLaws);
            gpbLaws.Location = new Point(7, 165);
            gpbLaws.Name = "gpbLaws";
            gpbLaws.Size = new Size(203, 158);
            gpbLaws.TabIndex = 2;
            gpbLaws.TabStop = false;
            gpbLaws.Text = "Laws";
            // 
            // lblLaws
            // 
            lblLaws.AutoSize = true;
            lblLaws.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaws.Location = new Point(8, 15);
            lblLaws.Name = "lblLaws";
            lblLaws.Size = new Size(0, 13);
            lblLaws.TabIndex = 0;
            // 
            // lblPlayerNameAndMark
            // 
            lblPlayerNameAndMark.AutoSize = true;
            lblPlayerNameAndMark.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlayerNameAndMark.Location = new Point(3, 364);
            lblPlayerNameAndMark.Name = "lblPlayerNameAndMark";
            lblPlayerNameAndMark.Size = new Size(212, 25);
            lblPlayerNameAndMark.TabIndex = 3;
            lblPlayerNameAndMark.Text = "Player Name And Mark";
            // 
            // txbPlayerName
            // 
            txbPlayerName.Enabled = false;
            txbPlayerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPlayerName.Location = new Point(7, 401);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(124, 25);
            txbPlayerName.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.Enabled = false;
            btnStart.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(7, 432);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(125, 35);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pctbMark
            // 
            pctbMark.Location = new Point(137, 401);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(73, 65);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 6;
            pctbMark.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(33, 470);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(156, 28);
            lblTime.TabIndex = 7;
            lblTime.Text = "Time is limited !!";
            // 
            // prgbCoolDown
            // 
            prgbCoolDown.Location = new Point(15, 501);
            prgbCoolDown.Name = "prgbCoolDown";
            prgbCoolDown.Size = new Size(195, 10);
            prgbCoolDown.TabIndex = 8;
            // 
            // btnUndo
            // 
            btnUndo.Enabled = false;
            btnUndo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUndo.Location = new Point(7, 517);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(100, 28);
            btnUndo.TabIndex = 9;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Enabled = false;
            btnRedo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedo.Location = new Point(110, 517);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(100, 28);
            btnRedo.TabIndex = 10;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnPlayervsPlayer
            // 
            btnPlayervsPlayer.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayervsPlayer.Location = new Point(7, 593);
            btnPlayervsPlayer.Name = "btnPlayervsPlayer";
            btnPlayervsPlayer.Size = new Size(203, 36);
            btnPlayervsPlayer.TabIndex = 11;
            btnPlayervsPlayer.Text = "Player vs Player";
            btnPlayervsPlayer.UseVisualStyleBackColor = true;
            btnPlayervsPlayer.Click += btnPlayervsPlayer_Click;
            // 
            // btnPlayervsComputer
            // 
            btnPlayervsComputer.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayervsComputer.Location = new Point(7, 632);
            btnPlayervsComputer.Name = "btnPlayervsComputer";
            btnPlayervsComputer.Size = new Size(203, 36);
            btnPlayervsComputer.TabIndex = 12;
            btnPlayervsComputer.Text = "Player vs Computer";
            btnPlayervsComputer.UseVisualStyleBackColor = true;
            btnPlayervsComputer.Click += btnPlayervsComputer_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(7, 671);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(203, 36);
            btnQuit.TabIndex = 13;
            btnQuit.Text = "Quit Game";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChessBoard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlChessBoard.Location = new Point(225, 169);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(865, 540);
            pnlChessBoard.TabIndex = 14;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.caro;
            pictureBox2.Location = new Point(3, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Enabled = false;
            btnRefresh.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(7, 553);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(203, 36);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(10, 330);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(54, 18);
            lblScore.TabIndex = 17;
            lblScore.Text = "Score ";
            // 
            // frmPlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 720);
            Controls.Add(lblScore);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox2);
            Controls.Add(pnlChessBoard);
            Controls.Add(btnQuit);
            Controls.Add(btnPlayervsComputer);
            Controls.Add(btnPlayervsPlayer);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(prgbCoolDown);
            Controls.Add(lblTime);
            Controls.Add(pctbMark);
            Controls.Add(btnStart);
            Controls.Add(txbPlayerName);
            Controls.Add(lblPlayerNameAndMark);
            Controls.Add(gpbLaws);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CaroChess";
            FormClosing += frmPlay_FormClosing;
            Load += frmPlay_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gpbLaws.ResumeLayout(false);
            gpbLaws.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private PictureBox pictureBox1;
        private GroupBox gpbLaws;
        private Label lblPlayerNameAndMark;
        private TextBox txbPlayerName;
        private Button btnStart;
        private PictureBox pctbMark;
        private Label lblTime;
        private ProgressBar prgbCoolDown;
        private Button btnUndo;
        private Button btnRedo;
        private Button btnPlayervsPlayer;
        private Button btnPlayervsComputer;
        private Button btnQuit;
        private Panel pnlChessBoard;
        private System.Windows.Forms.Timer tmCoolDown;
        private Label lblLaws;
        private PictureBox pictureBox2;
        private Button btnRefresh;
        private ToolStripMenuItem playervsPlayerToolStripMenuItem;
        private ToolStripMenuItem playervsComToolStripMenuItem;
        private Label lblScore;
        private ToolStripMenuItem settingToolStripMenuItem;
    }
}
