namespace valentine
{
    partial class ValentineDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValentineDay));
            gifImage = new PictureBox();
            panel1 = new Panel();
            textLabel = new Label();
            buttonTimer = new System.Windows.Forms.Timer(components);
            yesBtn = new Button();
            noBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)gifImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gifImage
            // 
            gifImage.Image = (Image)resources.GetObject("gifImage.Image");
            gifImage.Location = new Point(1376, 560);
            gifImage.Name = "gifImage";
            gifImage.Size = new Size(301, 312);
            gifImage.SizeMode = PictureBoxSizeMode.StretchImage;
            gifImage.TabIndex = 0;
            gifImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textLabel);
            panel1.Location = new Point(940, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 150);
            panel1.TabIndex = 1;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel.Location = new Point(43, 25);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(1125, 101);
            textLabel.TabIndex = 0;
            textLabel.Text = "Ты будешь моей валентинкой?";
            // 
            // buttonTimer
            // 
            buttonTimer.Tick += buttonTimer_Tick;
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.HotPink;
            yesBtn.Font = new Font("Comic Sans MS", 36F);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(1280, 918);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(212, 136);
            yesBtn.TabIndex = 3;
            yesBtn.Text = "Да";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesButton_Click;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.HotPink;
            noBtn.Font = new Font("Comic Sans MS", 36F);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(1558, 918);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(212, 136);
            noBtn.TabIndex = 3;
            noBtn.Text = "Нет";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.MouseEnter += noButton_MouseEnter;
            noBtn.MouseHover += noButton_MouseEnter;
            // 
            // ValentineDay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(3161, 1490);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(panel1);
            Controls.Add(gifImage);
            DoubleBuffered = true;
            Name = "ValentineDay";
            Text = "Valentine's Day";
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)gifImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gifImage;
        private Panel panel1;
        private Label textLabel;
        private System.Windows.Forms.Timer buttonTimer;
        private Button yesBtn;
        private Button noBtn;
    }
}
