namespace dbgdgui
{
    partial class FormGoldenDragon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoldenDragon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buttonEscape = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAllData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTicketsSold = new System.Windows.Forms.DataGridView();
            this.buttonUnSold = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTicketsToSold = new System.Windows.Forms.DataGridView();
            this.comboBoxTimeOnlySeance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSold = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.dataGridViewSeance = new System.Windows.Forms.DataGridView();
            this.comboBoxTimeSeance = new System.Windows.Forms.ComboBox();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSeance = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAllData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsSold)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsToSold)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeance)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripButton,
            this.cutToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "Продать билет";
            this.pasteToolStripButton.Click += new System.EventHandler(this.buttonSold_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "Отменить продажу билета";
            this.cutToolStripButton.Click += new System.EventHandler(this.buttonUnSold_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "О программе";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // buttonEscape
            // 
            this.buttonEscape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEscape.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEscape.Location = new System.Drawing.Point(698, 644);
            this.buttonEscape.Name = "buttonEscape";
            this.buttonEscape.Size = new System.Drawing.Size(83, 31);
            this.buttonEscape.TabIndex = 12;
            this.buttonEscape.Text = "Выход";
            this.buttonEscape.UseVisualStyleBackColor = true;
            this.buttonEscape.Click += new System.EventHandler(this.buttonEscape_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAllData);
            this.tabControl1.Location = new System.Drawing.Point(4, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 608);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageAllData
            // 
            this.tabPageAllData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAllData.Controls.Add(this.groupBox3);
            this.tabPageAllData.Controls.Add(this.groupBox2);
            this.tabPageAllData.Controls.Add(this.groupBox1);
            this.tabPageAllData.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllData.Name = "tabPageAllData";
            this.tabPageAllData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllData.Size = new System.Drawing.Size(769, 582);
            this.tabPageAllData.TabIndex = 0;
            this.tabPageAllData.Text = "Управление сеансами и билетами";
            this.tabPageAllData.UseVisualStyleBackColor = true;
            this.tabPageAllData.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageAllData_Paint_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewTicketsSold);
            this.groupBox3.Controls.Add(this.buttonUnSold);
            this.groupBox3.Location = new System.Drawing.Point(6, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 162);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проданные билеты";
            // 
            // dataGridViewTicketsSold
            // 
            this.dataGridViewTicketsSold.AllowUserToAddRows = false;
            this.dataGridViewTicketsSold.AllowUserToDeleteRows = false;
            this.dataGridViewTicketsSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTicketsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketsSold.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewTicketsSold.MultiSelect = false;
            this.dataGridViewTicketsSold.Name = "dataGridViewTicketsSold";
            this.dataGridViewTicketsSold.RowTemplate.ReadOnly = true;
            this.dataGridViewTicketsSold.Size = new System.Drawing.Size(574, 135);
            this.dataGridViewTicketsSold.TabIndex = 13;
            // 
            // buttonUnSold
            // 
            this.buttonUnSold.Location = new System.Drawing.Point(599, 19);
            this.buttonUnSold.Name = "buttonUnSold";
            this.buttonUnSold.Size = new System.Drawing.Size(75, 23);
            this.buttonUnSold.TabIndex = 5;
            this.buttonUnSold.Text = "Отменить";
            this.buttonUnSold.UseVisualStyleBackColor = true;
            this.buttonUnSold.Click += new System.EventHandler(this.buttonUnSold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewTicketsToSold);
            this.groupBox2.Controls.Add(this.comboBoxTimeOnlySeance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonSold);
            this.groupBox2.Location = new System.Drawing.Point(7, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Билеты";
            // 
            // dataGridViewTicketsToSold
            // 
            this.dataGridViewTicketsToSold.AllowUserToAddRows = false;
            this.dataGridViewTicketsToSold.AllowUserToDeleteRows = false;
            this.dataGridViewTicketsToSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTicketsToSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketsToSold.Location = new System.Drawing.Point(13, 19);
            this.dataGridViewTicketsToSold.MultiSelect = false;
            this.dataGridViewTicketsToSold.Name = "dataGridViewTicketsToSold";
            this.dataGridViewTicketsToSold.RowTemplate.ReadOnly = true;
            this.dataGridViewTicketsToSold.Size = new System.Drawing.Size(570, 150);
            this.dataGridViewTicketsToSold.TabIndex = 11;
            // 
            // comboBoxTimeOnlySeance
            // 
            this.comboBoxTimeOnlySeance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeOnlySeance.FormattingEnabled = true;
            this.comboBoxTimeOnlySeance.Items.AddRange(new object[] {
            "Все",
            "12:00",
            "15:00",
            "18:00",
            "22:00"});
            this.comboBoxTimeOnlySeance.Location = new System.Drawing.Point(595, 46);
            this.comboBoxTimeOnlySeance.Name = "comboBoxTimeOnlySeance";
            this.comboBoxTimeOnlySeance.Size = new System.Drawing.Size(79, 21);
            this.comboBoxTimeOnlySeance.TabIndex = 5;
            this.comboBoxTimeOnlySeance.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeOnlySeance_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Время сеанса:";
            // 
            // buttonSold
            // 
            this.buttonSold.Location = new System.Drawing.Point(595, 86);
            this.buttonSold.Name = "buttonSold";
            this.buttonSold.Size = new System.Drawing.Size(75, 23);
            this.buttonSold.TabIndex = 5;
            this.buttonSold.Text = "Продать";
            this.buttonSold.UseVisualStyleBackColor = true;
            this.buttonSold.Click += new System.EventHandler(this.buttonSold_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewFilm);
            this.groupBox1.Controls.Add(this.dataGridViewSeance);
            this.groupBox1.Controls.Add(this.comboBoxTimeSeance);
            this.groupBox1.Controls.Add(this.comboBoxFilm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAddSeance);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить сеанс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Фильмы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сеансы";
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.AllowUserToAddRows = false;
            this.dataGridViewFilm.AllowUserToDeleteRows = false;
            this.dataGridViewFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(273, 40);
            this.dataGridViewFilm.MultiSelect = false;
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.ReadOnly = true;
            this.dataGridViewFilm.Size = new System.Drawing.Size(473, 120);
            this.dataGridViewFilm.TabIndex = 10;
            // 
            // dataGridViewSeance
            // 
            this.dataGridViewSeance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSeance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeance.Location = new System.Drawing.Point(13, 40);
            this.dataGridViewSeance.Name = "dataGridViewSeance";
            this.dataGridViewSeance.Size = new System.Drawing.Size(254, 120);
            this.dataGridViewSeance.TabIndex = 9;
            this.dataGridViewSeance.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewSeance_UserDeletingRow);
            // 
            // comboBoxTimeSeance
            // 
            this.comboBoxTimeSeance.FormattingEnabled = true;
            this.comboBoxTimeSeance.Items.AddRange(new object[] {
            "12:00",
            "15:00",
            "18:00",
            "22:00"});
            this.comboBoxTimeSeance.Location = new System.Drawing.Point(62, 170);
            this.comboBoxTimeSeance.Name = "comboBoxTimeSeance";
            this.comboBoxTimeSeance.Size = new System.Drawing.Size(87, 21);
            this.comboBoxTimeSeance.TabIndex = 5;
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Items.AddRange(new object[] {
            "Marlowe",
            "The Big Boss",
            "Fist of Fury",
            "Way of the Dragon",
            "Enter the Dragon",
            "Game of Death"});
            this.comboBoxFilm.Location = new System.Drawing.Point(323, 170);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(172, 21);
            this.comboBoxFilm.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильм:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время:";
            // 
            // buttonAddSeance
            // 
            this.buttonAddSeance.Location = new System.Drawing.Point(670, 165);
            this.buttonAddSeance.Name = "buttonAddSeance";
            this.buttonAddSeance.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSeance.TabIndex = 5;
            this.buttonAddSeance.Text = "Добавить";
            this.buttonAddSeance.UseVisualStyleBackColor = true;
            this.buttonAddSeance.Click += new System.EventHandler(this.buttonAddSeance_Click);
            // 
            // FormGoldenDragon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.buttonEscape;
            this.ClientSize = new System.Drawing.Size(799, 676);
            this.Controls.Add(this.buttonEscape);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoldenDragon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр \"Золотой дракон\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGoldenDragon_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAllData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsSold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsToSold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button buttonEscape;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPageAllData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewTicketsSold;
        private System.Windows.Forms.Button buttonUnSold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTicketsToSold;
        private System.Windows.Forms.ComboBox comboBoxTimeOnlySeance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.DataGridView dataGridViewSeance;
        private System.Windows.Forms.ComboBox comboBoxTimeSeance;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSeance;
    }
}

