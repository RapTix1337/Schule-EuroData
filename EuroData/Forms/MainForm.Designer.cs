namespace EuroData.Forms
{
    partial class MainForm
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
            this.debugBox = new System.Windows.Forms.TextBox();
            this.debugOutputLabel = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(300, 54);
            this.debugBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.debugBox.Multiline = true;
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(565, 425);
            this.debugBox.TabIndex = 0;
            // 
            // debugOutputLabel
            // 
            this.debugOutputLabel.Location = new System.Drawing.Point(173, 62);
            this.debugOutputLabel.Name = "debugOutputLabel";
            this.debugOutputLabel.Size = new System.Drawing.Size(120, 29);
            this.debugOutputLabel.TabIndex = 1;
            this.debugOutputLabel.Text = "Debug Output:";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(51, 54);
            this.debugButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(93, 38);
            this.debugButton.TabIndex = 2;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.debugOutputLabel);
            this.Controls.Add(this.debugBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox debugBox;
        private System.Windows.Forms.Label debugOutputLabel;
        private System.Windows.Forms.Button debugButton;

        #endregion
    }
}