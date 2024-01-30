namespace CaroChessProject1
{
    partial class frmPvC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPvC));
            lblPlayervsCom = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            txbPlayerName = new TextBox();
            lblComputer = new Label();
            pictureBox1 = new PictureBox();
            lbl3 = new Label();
            lbl4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnOK = new Button();
            errNull = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNull).BeginInit();
            SuspendLayout();
            // 
            // lblPlayervsCom
            // 
            lblPlayervsCom.AutoSize = true;
            lblPlayervsCom.Font = new Font("Monotype Corsiva", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlayervsCom.Location = new Point(126, 9);
            lblPlayervsCom.Name = "lblPlayervsCom";
            lblPlayervsCom.Size = new Size(317, 49);
            lblPlayervsCom.TabIndex = 0;
            lblPlayervsCom.Text = "Player vs Computer";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(22, 70);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(197, 28);
            lbl1.TabIndex = 1;
            lbl1.Text = "Enter player name :";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(22, 123);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(139, 28);
            lbl2.TabIndex = 2;
            lbl2.Text = "Player name :";
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(236, 75);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(163, 23);
            txbPlayerName.TabIndex = 3;
            txbPlayerName.TextChanged += txbPlayerName_TextChanged;
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblComputer.Location = new Point(215, 124);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(102, 28);
            lblComputer.TabIndex = 4;
            lblComputer.Text = "Computer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(419, 70);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(93, 28);
            lbl3.TabIndex = 6;
            lbl3.Text = "Symbol :";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(419, 124);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(93, 28);
            lbl4.TabIndex = 7;
            lbl4.Text = "Symbol :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(518, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(518, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(224, 182);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(123, 37);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // errNull
            // 
            errNull.ContainerControl = this;
            // 
            // frmPvC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(584, 241);
            ControlBox = false;
            Controls.Add(btnOK);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(pictureBox1);
            Controls.Add(lblComputer);
            Controls.Add(txbPlayerName);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblPlayervsCom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmPvC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PvC";
            FormClosing += PvC_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNull).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayervsCom;
        private Label lbl1;
        private Label lbl2;
        private TextBox txbPlayerName;
        private Label lblComputer;
        private PictureBox pictureBox1;
        private Label lbl3;
        private Label lbl4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnOK;
        private ErrorProvider errNull;
    }
}