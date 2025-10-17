namespace SnareFindrums
{
    partial class Form1
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
            this.SnareSelect = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SnareSelect
            // 
            this.SnareSelect.FormattingEnabled = true;
            this.SnareSelect.Items.AddRange(new object[] {
            "Snare 1",
            "Snare 2",
            "Snare 3"});
            this.SnareSelect.Location = new System.Drawing.Point(209, 61);
            this.SnareSelect.Name = "SnareSelect";
            this.SnareSelect.Size = new System.Drawing.Size(387, 21);
            this.SnareSelect.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(307, 111);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(181, 85);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SnareSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SnareSelect;
        private System.Windows.Forms.Button SearchButton;
    }
}

