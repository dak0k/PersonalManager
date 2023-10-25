namespace PersonalManager
{
    partial class Form1
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
            _mainListView = new ListView();
            _userName = new ColumnHeader();
            _userLastName = new ColumnHeader();
            _userFatherName = new ColumnHeader();
            _userDepartment = new ColumnHeader();
            _userJob = new ColumnHeader();
            _userTimeStamp = new ColumnHeader();
            _userIMG = new PictureBox();
            label1 = new Label();
            _userNameInput = new TextBox();
            label2 = new Label();
            _userLastNameInput = new TextBox();
            label3 = new Label();
            _userFatherNameInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            _userDepartmentInput = new TextBox();
            label6 = new Label();
            _userJobInput = new TextBox();
            _userTimeStampInput = new TextBox();
            label10 = new Label();
            _dismissBtn = new Button();
            _changeJobBtn = new Button();
            _chatBtn = new Button();
            label7 = new Label();
            _statusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)_userIMG).BeginInit();
            SuspendLayout();
            // 
            // _mainListView
            // 
            _mainListView.Columns.AddRange(new ColumnHeader[] { _userName, _userLastName, _userFatherName, _userDepartment, _userJob, _userTimeStamp });
            _mainListView.Location = new Point(7, 5);
            _mainListView.Name = "_mainListView";
            _mainListView.Size = new Size(492, 360);
            _mainListView.TabIndex = 0;
            _mainListView.UseCompatibleStateImageBehavior = false;
            _mainListView.View = View.Details;
            _mainListView.ItemSelectionChanged += ListView_SelectionChanged;
            _mainListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // _userName
            // 
            _userName.Text = "Имя";
            _userName.Width = 75;
            // 
            // _userLastName
            // 
            _userLastName.Text = "Фамилия";
            _userLastName.Width = 75;
            // 
            // _userFatherName
            // 
            _userFatherName.Text = "Отчество";
            _userFatherName.Width = 75;
            // 
            // _userDepartment
            // 
            _userDepartment.Text = "Отдел";
            _userDepartment.Width = 75;
            // 
            // _userJob
            // 
            _userJob.Text = "Должность";
            _userJob.Width = 75;
            // 
            // _userTimeStamp
            // 
            _userTimeStamp.Text = "Дата приёма";
            _userTimeStamp.Width = 120;
            // 
            // _userIMG
            // 
            _userIMG.Location = new Point(505, 12);
            _userIMG.Name = "_userIMG";
            _userIMG.Size = new Size(125, 160);
            _userIMG.TabIndex = 1;
            _userIMG.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // _userNameInput
            // 
            _userNameInput.Cursor = Cursors.Hand;
            _userNameInput.Location = new Point(637, 35);
            _userNameInput.Name = "_userNameInput";
            _userNameInput.Size = new Size(125, 27);
            _userNameInput.TabIndex = 3;
            _userNameInput.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            label2.Click += label1_Click;
            // 
            // _userLastNameInput
            // 
            _userLastNameInput.Cursor = Cursors.Hand;
            _userLastNameInput.Location = new Point(637, 88);
            _userLastNameInput.Name = "_userLastNameInput";
            _userLastNameInput.Size = new Size(125, 27);
            _userLastNameInput.TabIndex = 3;
            _userLastNameInput.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            label3.Click += label1_Click;
            // 
            // _userFatherNameInput
            // 
            _userFatherNameInput.Cursor = Cursors.Hand;
            _userFatherNameInput.Location = new Point(637, 145);
            _userFatherNameInput.Name = "_userFatherNameInput";
            _userFatherNameInput.Size = new Size(125, 27);
            _userFatherNameInput.TabIndex = 3;
            _userFatherNameInput.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 65);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Фамилия";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 191);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 2;
            label5.Text = "Отдел";
            label5.Click += label1_Click;
            // 
            // _userDepartmentInput
            // 
            _userDepartmentInput.Cursor = Cursors.Hand;
            _userDepartmentInput.Location = new Point(503, 214);
            _userDepartmentInput.Name = "_userDepartmentInput";
            _userDepartmentInput.Size = new Size(257, 27);
            _userDepartmentInput.TabIndex = 3;
            _userDepartmentInput.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 247);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 2;
            label6.Text = "Должность";
            label6.Click += label1_Click;
            // 
            // _userJobInput
            // 
            _userJobInput.Cursor = Cursors.Hand;
            _userJobInput.Location = new Point(503, 270);
            _userJobInput.Name = "_userJobInput";
            _userJobInput.Size = new Size(257, 27);
            _userJobInput.TabIndex = 3;
            _userJobInput.TextChanged += textBox1_TextChanged;
            // 
            // _userTimeStampInput
            // 
            _userTimeStampInput.Cursor = Cursors.Hand;
            _userTimeStampInput.Location = new Point(505, 338);
            _userTimeStampInput.Name = "_userTimeStampInput";
            _userTimeStampInput.Size = new Size(257, 27);
            _userTimeStampInput.TabIndex = 3;
            _userTimeStampInput.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(505, 315);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 2;
            label10.Text = "Дата приёма";
            label10.Click += label1_Click;
            // 
            // _dismissBtn
            // 
            _dismissBtn.Cursor = Cursors.Hand;
            _dismissBtn.Location = new Point(7, 371);
            _dismissBtn.Name = "_dismissBtn";
            _dismissBtn.Size = new Size(126, 41);
            _dismissBtn.TabIndex = 4;
            _dismissBtn.Text = "УВОЛИТЬ";
            _dismissBtn.UseVisualStyleBackColor = true;
            _dismissBtn.Click += dismissBtn_Click;
            // 
            // _changeJobBtn
            // 
            _changeJobBtn.Cursor = Cursors.Hand;
            _changeJobBtn.Location = new Point(7, 418);
            _changeJobBtn.Name = "_changeJobBtn";
            _changeJobBtn.Size = new Size(258, 46);
            _changeJobBtn.TabIndex = 4;
            _changeJobBtn.Text = "СМЕНИТЬ ДОЛЖНОСТЬ";
            _changeJobBtn.UseVisualStyleBackColor = true;
            _changeJobBtn.Click += button3_Click;
            // 
            // _chatBtn
            // 
            _chatBtn.Cursor = Cursors.Hand;
            _chatBtn.Location = new Point(139, 371);
            _chatBtn.Name = "_chatBtn";
            _chatBtn.Size = new Size(126, 41);
            _chatBtn.TabIndex = 4;
            _chatBtn.Text = "НАПИСАТЬ";
            _chatBtn.UseVisualStyleBackColor = true;
            _chatBtn.Click += dismissBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(561, 371);
            label7.Name = "label7";
            label7.Size = new Size(143, 46);
            label7.TabIndex = 5;
            label7.Text = "СТАТУС";
            // 
            // _statusLabel
            // 
            _statusLabel.AutoSize = true;
            _statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _statusLabel.Location = new Point(582, 424);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(96, 28);
            _statusLabel.TabIndex = 6;
            _statusLabel.Text = "*СТАТУС*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 480);
            Controls.Add(_statusLabel);
            Controls.Add(label7);
            Controls.Add(_changeJobBtn);
            Controls.Add(_chatBtn);
            Controls.Add(_dismissBtn);
            Controls.Add(_userTimeStampInput);
            Controls.Add(label10);
            Controls.Add(_userJobInput);
            Controls.Add(label6);
            Controls.Add(_userDepartmentInput);
            Controls.Add(label5);
            Controls.Add(_userFatherNameInput);
            Controls.Add(label3);
            Controls.Add(_userLastNameInput);
            Controls.Add(label2);
            Controls.Add(_userNameInput);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(_userIMG);
            Controls.Add(_mainListView);
            Name = "Form1";
            Text = "Personal Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_userIMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView _mainListView;
        private PictureBox _userIMG;
        private Label label1;
        private TextBox _userNameInput;
        private Label label2;
        private TextBox _userLastNameInput;
        private Label label3;
        private TextBox _userFatherNameInput;
        private Label label4;
        private Label label5;
        private TextBox _userDepartmentInput;
        private Label label6;
        private TextBox _userJobInput;
        private TextBox _userTimeStampInput;
        private Label label10;
        private Button _dismissBtn;
        private Button _changeJobBtn;
        private Button _chatBtn;
        private ColumnHeader _userName;
        private ColumnHeader _userLastName;
        private ColumnHeader _userFatherName;
        private ColumnHeader _userDepartment;
        private ColumnHeader _userJob;
        private ColumnHeader _userTimeStamp;
        private Label label7;
        private Label _statusLabel;
    }
}