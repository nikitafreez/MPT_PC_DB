namespace MPT_PC_DB
{
    partial class EmailCodeCheck
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
            this.codeCheckButton = new System.Windows.Forms.Button();
            this.codeCheckTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeCheckButton
            // 
            this.codeCheckButton.Location = new System.Drawing.Point(49, 109);
            this.codeCheckButton.Name = "codeCheckButton";
            this.codeCheckButton.Size = new System.Drawing.Size(205, 31);
            this.codeCheckButton.TabIndex = 13;
            this.codeCheckButton.Text = "Подтвердить";
            this.codeCheckButton.UseVisualStyleBackColor = true;
            this.codeCheckButton.Click += new System.EventHandler(this.codeCheckButton_Click);
            // 
            // codeCheckTextBox
            // 
            this.codeCheckTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeCheckTextBox.Location = new System.Drawing.Point(49, 63);
            this.codeCheckTextBox.Name = "codeCheckTextBox";
            this.codeCheckTextBox.Size = new System.Drawing.Size(205, 30);
            this.codeCheckTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Код из письма";
            // 
            // EmailCodeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 172);
            this.Controls.Add(this.codeCheckButton);
            this.Controls.Add(this.codeCheckTextBox);
            this.Controls.Add(this.label3);
            this.Name = "EmailCodeCheck";
            this.Text = "Компьютеры МПТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button codeCheckButton;
        private System.Windows.Forms.TextBox codeCheckTextBox;
        private System.Windows.Forms.Label label3;
    }
}