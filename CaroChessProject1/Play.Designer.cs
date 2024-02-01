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
            quitToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            continueToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            tiếngViệtToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
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
            btnNewGame = new Button();
            lblScore = new Label();
            menuStrip1.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, quitToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playervsPlayerToolStripMenuItem, playervsComToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(146, 22);
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
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(146, 22);
            quitToolStripMenuItem.Text = "&Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, stopToolStripMenuItem, continueToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(165, 22);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(165, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            stopToolStripMenuItem.Size = new Size(165, 22);
            stopToolStripMenuItem.Text = "&Stop";
            stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
            // 
            // continueToolStripMenuItem
            // 
            continueToolStripMenuItem.Enabled = false;
            continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            continueToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            continueToolStripMenuItem.Size = new Size(165, 22);
            continueToolStripMenuItem.Text = "&Continue";
            continueToolStripMenuItem.Click += continentToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "&Setting";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, tiếngViệtToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(126, 22);
            languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(126, 22);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // tiếngViệtToolStripMenuItem
            // 
            tiếngViệtToolStripMenuItem.Name = "tiếngViệtToolStripMenuItem";
            tiếngViệtToolStripMenuItem.Size = new Size(126, 22);
            tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
            tiếngViệtToolStripMenuItem.Click += tiếngViệtToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(126, 22);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(126, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // gpbLaws
            // 
            gpbLaws.BackColor = SystemColors.Window;
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
            txbPlayerName.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txbPlayerName.Location = new Point(7, 401);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(124, 33);
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
            pctbMark.BorderStyle = BorderStyle.Fixed3D;
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
            pnlChessBoard.BackColor = SystemColors.Window;
            pnlChessBoard.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChessBoard.BorderStyle = BorderStyle.FixedSingle;
            pnlChessBoard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlChessBoard.Location = new Point(225, 25);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(865, 679);
            pnlChessBoard.TabIndex = 14;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.caro;
            pictureBox2.Location = new Point(3, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = SystemColors.ButtonHighlight;
            btnNewGame.Enabled = false;
            btnNewGame.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(7, 553);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(203, 36);
            btnNewGame.TabIndex = 16;
            btnNewGame.Text = "NewGame";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BorderStyle = BorderStyle.Fixed3D;
            lblScore.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(10, 330);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 20);
            lblScore.TabIndex = 17;
            lblScore.Text = "Score ";
            // 
            // frmPlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1111, 720);
            Controls.Add(lblScore);
            Controls.Add(btnNewGame);
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
        private Button btnNewGame;
        private ToolStripMenuItem playervsPlayerToolStripMenuItem;
        private ToolStripMenuItem playervsComToolStripMenuItem;
        private Label lblScore;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem tiếngViệtToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem continueToolStripMenuItem;
    }
}
