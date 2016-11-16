namespace WhileLoops
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
            this.starLabel = new System.Windows.Forms.Label();
            this.starInput = new System.Windows.Forms.TextBox();
            this.starButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.growButton = new System.Windows.Forms.Button();
            this.fadeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.ForeColor = System.Drawing.Color.White;
            this.starLabel.Location = new System.Drawing.Point(16, 24);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(91, 13);
            this.starLabel.TabIndex = 0;
            this.starLabel.Text = "How Many Stars?";
            // 
            // starInput
            // 
            this.starInput.Location = new System.Drawing.Point(118, 19);
            this.starInput.Name = "starInput";
            this.starInput.Size = new System.Drawing.Size(45, 20);
            this.starInput.TabIndex = 1;
            // 
            // starButton
            // 
            this.starButton.Location = new System.Drawing.Point(185, 15);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(58, 26);
            this.starButton.TabIndex = 2;
            this.starButton.Text = "Enter";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(19, 77);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(71, 24);
            this.moveButton.TabIndex = 3;
            this.moveButton.Text = "Movement";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // growButton
            // 
            this.growButton.Location = new System.Drawing.Point(105, 78);
            this.growButton.Name = "growButton";
            this.growButton.Size = new System.Drawing.Size(75, 23);
            this.growButton.TabIndex = 4;
            this.growButton.Text = "Grow";
            this.growButton.UseVisualStyleBackColor = true;
            this.growButton.Click += new System.EventHandler(this.growButton_Click);
            // 
            // fadeButton
            // 
            this.fadeButton.Location = new System.Drawing.Point(197, 78);
            this.fadeButton.Name = "fadeButton";
            this.fadeButton.Size = new System.Drawing.Size(75, 23);
            this.fadeButton.TabIndex = 5;
            this.fadeButton.Text = "Fade";
            this.fadeButton.UseVisualStyleBackColor = true;
            this.fadeButton.Click += new System.EventHandler(this.fadeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fadeButton);
            this.Controls.Add(this.growButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.starButton);
            this.Controls.Add(this.starInput);
            this.Controls.Add(this.starLabel);
            this.Name = "Form1";
            this.Text = "while Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.TextBox starInput;
        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button growButton;
        private System.Windows.Forms.Button fadeButton;
    }
}

