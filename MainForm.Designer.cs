namespace MPT_PC_DB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilterButton = new System.Windows.Forms.Button();
            this.clearAllBoxButton = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.buildingNameBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.programmListBox = new System.Windows.Forms.TextBox();
            this.cabinetNumBox = new System.Windows.Forms.TextBox();
            this.OSBox = new System.Windows.Forms.TextBox();
            this.HDDBox = new System.Windows.Forms.TextBox();
            this.ozuBox = new System.Windows.Forms.TextBox();
            this.processorBox = new System.Windows.Forms.TextBox();
            this.graphicCardBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.All_PC_dataFrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createForAllAndSave = new System.Windows.Forms.Button();
            this.PCidBox = new System.Windows.Forms.ComboBox();
            this.saveQR = new System.Windows.Forms.Button();
            this.QRCodeBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveQRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQRButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_PC_dataFrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FilterButton);
            this.tabPage1.Controls.Add(this.clearAllBoxButton);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.updateBtn);
            this.tabPage1.Controls.Add(this.buildingNameBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.programmListBox);
            this.tabPage1.Controls.Add(this.cabinetNumBox);
            this.tabPage1.Controls.Add(this.OSBox);
            this.tabPage1.Controls.Add(this.HDDBox);
            this.tabPage1.Controls.Add(this.ozuBox);
            this.tabPage1.Controls.Add(this.processorBox);
            this.tabPage1.Controls.Add(this.graphicCardBox);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.All_PC_dataFrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о ПК";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(356, 132);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(142, 52);
            this.FilterButton.TabIndex = 22;
            this.FilterButton.Text = "Фильтровать по зданию";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // clearAllBoxButton
            // 
            this.clearAllBoxButton.Location = new System.Drawing.Point(14, 7);
            this.clearAllBoxButton.Name = "clearAllBoxButton";
            this.clearAllBoxButton.Size = new System.Drawing.Size(140, 27);
            this.clearAllBoxButton.TabIndex = 21;
            this.clearAllBoxButton.Text = "Очистить поля";
            this.clearAllBoxButton.UseVisualStyleBackColor = true;
            this.clearAllBoxButton.Click += new System.EventHandler(this.clearAllBoxButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(230, 157);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 27);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(121, 157);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 27);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Изменить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // buildingNameBox
            // 
            this.buildingNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingNameBox.FormattingEnabled = true;
            this.buildingNameBox.Items.AddRange(new object[] {
            "Нежинская, 7",
            "Нахимовский проспект, 21"});
            this.buildingNameBox.Location = new System.Drawing.Point(356, 53);
            this.buildingNameBox.Name = "buildingNameBox";
            this.buildingNameBox.Size = new System.Drawing.Size(142, 24);
            this.buildingNameBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Список программ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Кабинет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Здание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ОС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Жёсткий диск (в ГБ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ОЗУ (в ГБ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Процессор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Видеокарата";
            // 
            // programmListBox
            // 
            this.programmListBox.Location = new System.Drawing.Point(533, 104);
            this.programmListBox.Multiline = true;
            this.programmListBox.Name = "programmListBox";
            this.programmListBox.Size = new System.Drawing.Size(224, 80);
            this.programmListBox.TabIndex = 9;
            // 
            // cabinetNumBox
            // 
            this.cabinetNumBox.Location = new System.Drawing.Point(356, 104);
            this.cabinetNumBox.Name = "cabinetNumBox";
            this.cabinetNumBox.Size = new System.Drawing.Size(142, 22);
            this.cabinetNumBox.TabIndex = 8;
            // 
            // OSBox
            // 
            this.OSBox.Location = new System.Drawing.Point(533, 57);
            this.OSBox.Name = "OSBox";
            this.OSBox.Size = new System.Drawing.Size(142, 22);
            this.OSBox.TabIndex = 6;
            // 
            // HDDBox
            // 
            this.HDDBox.Location = new System.Drawing.Point(186, 104);
            this.HDDBox.Name = "HDDBox";
            this.HDDBox.Size = new System.Drawing.Size(142, 22);
            this.HDDBox.TabIndex = 5;
            // 
            // ozuBox
            // 
            this.ozuBox.Location = new System.Drawing.Point(186, 57);
            this.ozuBox.Name = "ozuBox";
            this.ozuBox.Size = new System.Drawing.Size(142, 22);
            this.ozuBox.TabIndex = 4;
            // 
            // processorBox
            // 
            this.processorBox.Location = new System.Drawing.Point(12, 104);
            this.processorBox.Name = "processorBox";
            this.processorBox.Size = new System.Drawing.Size(142, 22);
            this.processorBox.TabIndex = 3;
            // 
            // graphicCardBox
            // 
            this.graphicCardBox.Location = new System.Drawing.Point(12, 57);
            this.graphicCardBox.Name = "graphicCardBox";
            this.graphicCardBox.Size = new System.Drawing.Size(142, 22);
            this.graphicCardBox.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 157);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(103, 27);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // All_PC_dataFrid
            // 
            this.All_PC_dataFrid.AllowUserToAddRows = false;
            this.All_PC_dataFrid.AllowUserToDeleteRows = false;
            this.All_PC_dataFrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_PC_dataFrid.Location = new System.Drawing.Point(11, 190);
            this.All_PC_dataFrid.MultiSelect = false;
            this.All_PC_dataFrid.Name = "All_PC_dataFrid";
            this.All_PC_dataFrid.ReadOnly = true;
            this.All_PC_dataFrid.RowHeadersWidth = 51;
            this.All_PC_dataFrid.RowTemplate.Height = 24;
            this.All_PC_dataFrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.All_PC_dataFrid.Size = new System.Drawing.Size(848, 275);
            this.All_PC_dataFrid.TabIndex = 0;
            this.All_PC_dataFrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.All_PC_dataFrid_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.createForAllAndSave);
            this.tabPage2.Controls.Add(this.PCidBox);
            this.tabPage2.Controls.Add(this.saveQR);
            this.tabPage2.Controls.Add(this.QRCodeBox);
            this.tabPage2.Controls.Add(this.createQRButton);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создание QR-кода";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createForAllAndSave
            // 
            this.createForAllAndSave.Location = new System.Drawing.Point(96, 252);
            this.createForAllAndSave.Name = "createForAllAndSave";
            this.createForAllAndSave.Size = new System.Drawing.Size(134, 72);
            this.createForAllAndSave.TabIndex = 16;
            this.createForAllAndSave.Text = "Создать QR для всех ПК и сохранить";
            this.createForAllAndSave.UseVisualStyleBackColor = true;
            this.createForAllAndSave.Click += new System.EventHandler(this.createForAllAndSave_Click);
            // 
            // PCidBox
            // 
            this.PCidBox.FormattingEnabled = true;
            this.PCidBox.Location = new System.Drawing.Point(105, 183);
            this.PCidBox.Name = "PCidBox";
            this.PCidBox.Size = new System.Drawing.Size(114, 24);
            this.PCidBox.TabIndex = 15;
            // 
            // saveQR
            // 
            this.saveQR.Enabled = false;
            this.saveQR.Location = new System.Drawing.Point(530, 299);
            this.saveQR.Name = "saveQR";
            this.saveQR.Size = new System.Drawing.Size(114, 33);
            this.saveQR.TabIndex = 14;
            this.saveQR.Text = "Сохранить QR";
            this.saveQR.UseVisualStyleBackColor = true;
            this.saveQR.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // QRCodeBox
            // 
            this.QRCodeBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QRCodeBox.ContextMenuStrip = this.contextMenuStrip1;
            this.QRCodeBox.Location = new System.Drawing.Point(442, 17);
            this.QRCodeBox.Name = "QRCodeBox";
            this.QRCodeBox.Size = new System.Drawing.Size(280, 280);
            this.QRCodeBox.TabIndex = 13;
            this.QRCodeBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Enabled = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveQRToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 28);
            // 
            // saveQRToolStripMenuItem
            // 
            this.saveQRToolStripMenuItem.Enabled = false;
            this.saveQRToolStripMenuItem.Name = "saveQRToolStripMenuItem";
            this.saveQRToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.saveQRToolStripMenuItem.Text = "Созранить QR";
            this.saveQRToolStripMenuItem.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // createQRButton
            // 
            this.createQRButton.Location = new System.Drawing.Point(105, 213);
            this.createQRButton.Name = "createQRButton";
            this.createQRButton.Size = new System.Drawing.Size(114, 33);
            this.createQRButton.TabIndex = 12;
            this.createQRButton.Text = "Создать QR";
            this.createQRButton.UseVisualStyleBackColor = true;
            this.createQRButton.Click += new System.EventHandler(this.createQRButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "ID ПК";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 502);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютеры МПТ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_PC_dataFrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView All_PC_dataFrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cabinetNumBox;
        private System.Windows.Forms.TextBox OSBox;
        private System.Windows.Forms.TextBox HDDBox;
        private System.Windows.Forms.TextBox ozuBox;
        private System.Windows.Forms.TextBox processorBox;
        private System.Windows.Forms.TextBox graphicCardBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox buildingNameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox QRCodeBox;
        private System.Windows.Forms.Button createQRButton;
        private System.Windows.Forms.Button saveQR;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox PCidBox;
        private System.Windows.Forms.Button clearAllBoxButton;
        private System.Windows.Forms.Button createForAllAndSave;
        public System.Windows.Forms.TextBox programmListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveQRToolStripMenuItem;
        private System.Windows.Forms.Button FilterButton;
    }
}