namespace CaroChessProject1
{
    partial class frmPvP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPvP));
            lblPlayervsPlayer = new Label();
            lbl1 = new Label();
            label1 = new Label();
            txbPlayerName1 = new TextBox();
            txbPlayerName2 = new TextBox();
            lbl3 = new Label();
            lbl4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnOK = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            errNull = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNull).BeginInit();
            SuspendLayout();
            // 
            // lblPlayervsPlayer
            // 
            lblPlayervsPlayer.AutoSize = true;
            lblPlayervsPlayer.Font = new Font("Monotype Corsiva", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlayervsPlayer.Location = new Point(147, 9);
            lblPlayervsPlayer.Name = "lblPlayervsPlayer";
            lblPlayervsPlayer.Size = new Size(269, 49);
            lblPlayervsPlayer.TabIndex = 0;
            lblPlayervsPlayer.Text = "Player vs Player";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(17, 71);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(191, 28);
            lbl1.TabIndex = 1;
            lbl1.Text = "Enter player name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 124);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter player name:";
            // 
            // txbPlayerName1
            // 
            txbPlayerName1.Location = new Point(223, 76);
            txbPlayerName1.Name = "txbPlayerName1";
            txbPlayerName1.Size = new Size(150, 23);
            txbPlayerName1.TabIndex = 3;
            txbPlayerName1.TextChanged += txbPlayerName1_TextChanged;
            // 
            // txbPlayerName2
            // 
            txbPlayerName2.Location = new Point(223, 129);
            txbPlayerName2.Name = "txbPlayerName2";
            txbPlayerName2.Size = new Size(150, 23);
            txbPlayerName2.TabIndex = 4;
            txbPlayerName2.TextChanged += txbPlayerName2_TextChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(392, 72);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(87, 28);
            lbl3.TabIndex = 5;
            lbl3.Text = "Symbol:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(392, 124);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(87, 28);
            lbl4.TabIndex = 6;
            lbl4.Text = "Symbol:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(497, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(497, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(232, 185);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(128, 35);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(54, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(422, 168);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // errNull
            // 
            errNull.ContainerControl = this;
            // 
            // frmPvP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 241);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnOK);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(txbPlayerName2);
            Controls.Add(txbPlayerName1);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(lblPlayervsPlayer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPvP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PvP";
            FormClosing += PvP_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNull).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayervsPlayer;
        private Label lbl1;
        private Label label1;
        private TextBox txbPlayerName1;
        private TextBox txbPlayerName2;
        private Label lbl3;
        private Label lbl4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnOK;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ErrorProvider errNull;
    }
}