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
            this.debugBox.Location = new System.Drawing.Point(267, 43);
            this.debugBox.Multiline = true;
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(232, 115);
            this.debugBox.TabIndex = 0;
            // 
            // debugOutputLabel
            // 
            this.debugOutputLabel.Location = new System.Drawing.Point(154, 50);
            this.debugOutputLabel.Name = "debugOutputLabel";
            this.debugOutputLabel.Size = new System.Drawing.Size(107, 23);
            this.debugOutputLabel.TabIndex = 1;
            this.debugOutputLabel.Text = "Debug Output:";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(45, 43);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(83, 30);
            this.debugButton.TabIndex = 2;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.debugOutputLabel);
            this.Controls.Add(this.debugBox);
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