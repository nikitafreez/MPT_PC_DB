namespace MPT_PC_DB
{
    partial class FilterForm
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
            this.buildingNameComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cabinetNumTextBox = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildingNameComboBox
            // 
            this.buildingNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingNameComboBox.FormattingEnabled = true;
            this.buildingNameComboBox.Items.AddRange(new object[] {
            "Нежинская, 7",
            "Нахимовский проспект, 21"});
            this.buildingNameComboBox.Location = new System.Drawing.Point(79, 51);
            this.buildingNameComboBox.Name = "buildingNameComboBox";
            this.buildingNameComboBox.Size = new System.Drawing.Size(142, 24);
            this.buildingNameComboBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Кабинет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Здание";
            // 
            // cabinetNumTextBox
            // 
            this.cabinetNumTextBox.Location = new System.Drawing.Point(79, 102);
            this.cabinetNumTextBox.Name = "cabinetNumTextBox";
            this.cabinetNumTextBox.Size = new System.Drawing.Size(142, 22);
            this.cabinetNumTextBox.TabIndex = 19;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(97, 130);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(103, 27);
            this.applyBtn.TabIndex = 23;
            this.applyBtn.Text = "Применить";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 192);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.buildingNameComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cabinetNumTextBox);
            this.Name = "FilterForm";
            this.Text = "Компьютеры МПТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buildingNameComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cabinetNumTextBox;
        private System.Windows.Forms.Button applyBtn;
    }
}