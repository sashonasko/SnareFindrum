namespace Snare
{
    partial class Snare
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
            SearchButton = new Button();
            SnareSelect = new ComboBox();
            SnarePic = new PictureBox();
            SnareName = new Label();
            SnareDesc = new Label();
            PlayButton = new Button();
            StopButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SnarePic).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(339, 91);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(149, 88);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SnareSelect
            // 
            SnareSelect.FormattingEnabled = true;
            SnareSelect.Items.AddRange(new object[] { "Pearl Export snare 14", "Joey Jordison Signature Snare" });
            SnareSelect.Location = new Point(166, 62);
            SnareSelect.Name = "SnareSelect";
            SnareSelect.Size = new Size(474, 23);
            SnareSelect.TabIndex = 1;
            SnareSelect.SelectedIndexChanged += SnareSelect_SelectedIndexChanged;
            // 
            // SnarePic
            // 
            SnarePic.Location = new Point(12, 91);
            SnarePic.Name = "SnarePic";
            SnarePic.Size = new Size(258, 257);
            SnarePic.SizeMode = PictureBoxSizeMode.StretchImage;
            SnarePic.TabIndex = 2;
            SnarePic.TabStop = false;
            SnarePic.Visible = false;
            // 
            // SnareName
            // 
            SnareName.AutoSize = true;
            SnareName.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SnareName.Location = new Point(353, 91);
            SnareName.Name = "SnareName";
            SnareName.Size = new Size(135, 27);
            SnareName.TabIndex = 3;
            SnareName.Text = "Snare Title";
            SnareName.Visible = false;
            SnareName.Click += label1_Click;
            // 
            // SnareDesc
            // 
            SnareDesc.AutoSize = true;
            SnareDesc.Font = new Font("Showcard Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SnareDesc.Location = new Point(89, 351);
            SnareDesc.Name = "SnareDesc";
            SnareDesc.Size = new Size(117, 14);
            SnareDesc.TabIndex = 4;
            SnareDesc.Text = "Snare Description";
            SnareDesc.Visible = false;
            // 
            // PlayButton
            // 
            PlayButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayButton.Location = new Point(323, 293);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(110, 55);
            PlayButton.TabIndex = 5;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Visible = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            StopButton.Location = new Point(530, 293);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(110, 55);
            StopButton.TabIndex = 6;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Visible = false;
            StopButton.Click += StopButton_Click;
            // 
            // BackButton
            // 
            BackButton.Cursor = Cursors.IBeam;
            BackButton.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(642, 427);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(146, 96);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Snare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 535);
            Controls.Add(BackButton);
            Controls.Add(StopButton);
            Controls.Add(PlayButton);
            Controls.Add(SnareDesc);
            Controls.Add(SnareName);
            Controls.Add(SnarePic);
            Controls.Add(SnareSelect);
            Controls.Add(SearchButton);
            Name = "Snare";
            Text = "Snare Findrum";
            Load += Snare_Load;
            ((System.ComponentModel.ISupportInitialize)SnarePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        public ComboBox SnareSelect;
        private PictureBox SnarePic;
        private Label SnareName;
        private Label SnareDesc;
        private Button PlayButton;
        private Button StopButton;
        private Button BackButton;
    }
}
