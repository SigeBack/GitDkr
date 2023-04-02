namespace WindowsForms_Yalovoy_AttendanceJournal
{
    partial class FormJournal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSubject = new System.Windows.Forms.ComboBox();
            this.cBoxClassType = new System.Windows.Forms.ComboBox();
            this.dateTimeEntry = new System.Windows.Forms.DateTimePicker();
            this.tBoxTeacher = new System.Windows.Forms.TextBox();
            this.tBoxGroup = new System.Windows.Forms.TextBox();
            this.tBoxStudent = new System.Windows.Forms.TextBox();
            this.checkBoxAttend = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxSubject);
            this.groupBox1.Controls.Add(this.cBoxClassType);
            this.groupBox1.Controls.Add(this.dateTimeEntry);
            this.groupBox1.Controls.Add(this.tBoxTeacher);
            this.groupBox1.Controls.Add(this.tBoxGroup);
            this.groupBox1.Controls.Add(this.tBoxStudent);
            this.groupBox1.Controls.Add(this.checkBoxAttend);
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните запись в журнал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Посещение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата проведения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Студент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Предмет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вид занятия";
            // 
            // cBoxSubject
            // 
            this.cBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSubject.FormattingEnabled = true;
            this.cBoxSubject.Items.AddRange(new object[] {
            "Математика",
            "Информатика",
            "Экономика",
            "Биология",
            "Философия",
            "Иностранный язык",
            "Физика"});
            this.cBoxSubject.Location = new System.Drawing.Point(290, 107);
            this.cBoxSubject.Name = "cBoxSubject";
            this.cBoxSubject.Size = new System.Drawing.Size(208, 28);
            this.cBoxSubject.TabIndex = 6;
            // 
            // cBoxClassType
            // 
            this.cBoxClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClassType.FormattingEnabled = true;
            this.cBoxClassType.Items.AddRange(new object[] {
            "Практическое занятие",
            "Лабораторная работа",
            "Лекция"});
            this.cBoxClassType.Location = new System.Drawing.Point(290, 48);
            this.cBoxClassType.Name = "cBoxClassType";
            this.cBoxClassType.Size = new System.Drawing.Size(208, 28);
            this.cBoxClassType.TabIndex = 5;
            // 
            // dateTimeEntry
            // 
            this.dateTimeEntry.Location = new System.Drawing.Point(290, 356);
            this.dateTimeEntry.Name = "dateTimeEntry";
            this.dateTimeEntry.Size = new System.Drawing.Size(208, 26);
            this.dateTimeEntry.TabIndex = 4;
            // 
            // tBoxTeacher
            // 
            this.tBoxTeacher.Location = new System.Drawing.Point(290, 163);
            this.tBoxTeacher.Name = "tBoxTeacher";
            this.tBoxTeacher.Size = new System.Drawing.Size(208, 26);
            this.tBoxTeacher.TabIndex = 3;
            // 
            // tBoxGroup
            // 
            this.tBoxGroup.Location = new System.Drawing.Point(290, 230);
            this.tBoxGroup.Name = "tBoxGroup";
            this.tBoxGroup.Size = new System.Drawing.Size(113, 26);
            this.tBoxGroup.TabIndex = 2;
            // 
            // tBoxStudent
            // 
            this.tBoxStudent.Location = new System.Drawing.Point(290, 297);
            this.tBoxStudent.Name = "tBoxStudent";
            this.tBoxStudent.Size = new System.Drawing.Size(208, 26);
            this.tBoxStudent.TabIndex = 1;
            // 
            // checkBoxAttend
            // 
            this.checkBoxAttend.AutoSize = true;
            this.checkBoxAttend.Location = new System.Drawing.Point(290, 413);
            this.checkBoxAttend.Name = "checkBoxAttend";
            this.checkBoxAttend.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAttend.TabIndex = 0;
            this.checkBoxAttend.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(246, 523);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(425, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormJournal
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(574, 596);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(596, 652);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(596, 652);
            this.Name = "FormJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записи журнала";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tBoxTeacher;
        public System.Windows.Forms.TextBox tBoxGroup;
        public System.Windows.Forms.TextBox tBoxStudent;
        public System.Windows.Forms.CheckBox checkBoxAttend;
        public System.Windows.Forms.ComboBox cBoxSubject;
        public System.Windows.Forms.ComboBox cBoxClassType;
        public System.Windows.Forms.DateTimePicker dateTimeEntry;
    }
}