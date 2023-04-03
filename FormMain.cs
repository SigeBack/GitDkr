using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace WindowsForms_Yalovoy_AttendanceJournal
{
    public partial class FormMain : Form
    {
        AttendanceJournalDB dbAttendanceJournal;
<<<<<<< HEAD
<<<<<<< HEAD
//shared code added humu
>>>>>>> new-features
>>>>>>> parent of 2882989 (New files added. New features in AttendanceJournalDB.cs and FormMain.cs)
        public FormMain()
        {
            InitializeComponent();
            dbAttendanceJournal = new AttendanceJournalDB();
            dataGridJournals.DataSource = dbAttendanceJournal.ReadJournals();
            ConfigDataGridJournals();
        }
        private void ConfigDataGridJournals()
        {
            dataGridJournals.ReadOnly = true;
            dataGridJournals.RowHeadersVisible = false;
            dataGridJournals.AllowUserToAddRows = false;
            dataGridJournals.AllowUserToDeleteRows = false;
            dataGridJournals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridJournals.Columns[0].HeaderText = "№";
            dataGridJournals.Columns[0].Width = 40;
            dataGridJournals.Columns[1].HeaderText = "Тип занятия";
            dataGridJournals.Columns[1].Width = 150;
            dataGridJournals.Columns[2].HeaderText = "Предмет";
            dataGridJournals.Columns[2].Width = 100;
            dataGridJournals.Columns[3].HeaderText = "Преподаватель";
            dataGridJournals.Columns[3].Width = 150;
            dataGridJournals.Columns[4].HeaderText = "Группа";
            dataGridJournals.Columns[4].Width = 80;
            dataGridJournals.Columns[5].HeaderText = "Студент";
            dataGridJournals.Columns[5].Width = 150;
            dataGridJournals.Columns[6].HeaderText = "Дата занятия";
            dataGridJournals.Columns[6].Width = 80;
            dataGridJournals.Columns[7].HeaderText = "Посещение";
            dataGridJournals.Columns[7].Width = 80;
        }

        private void btnAddJournal_Click_1(object sender, EventArgs e)
        {
            FormJournal formJournal = new FormJournal();

        FlagReturn:
            
            DialogResult result = formJournal.ShowDialog();

            bool fillerflag = false;
            if(result == DialogResult.OK)
            {
                if(String.IsNullOrWhiteSpace(formJournal.tBoxTeacher.Text) ||
                    String.IsNullOrWhiteSpace(formJournal.tBoxGroup.Text) ||
                    String.IsNullOrWhiteSpace(formJournal.tBoxStudent.Text)
                )
                {
                    MessageBox.Show("Заполните все поля!");
                    fillerflag = true;
                    goto FlagReturn;
                }
            }
            if (result != DialogResult.OK) return;

                Journal journal = new Journal();
                journal.ClassType = formJournal.cBoxClassType.SelectedItem.ToString();
                journal.Subject = formJournal.cBoxSubject.SelectedItem.ToString();
                journal.Teacher = formJournal.tBoxTeacher.Text;
                journal.Group = formJournal.tBoxGroup.Text;
                journal.Student = formJournal.tBoxStudent.Text;
                journal.Date = formJournal.dateTimeEntry.Value;
                journal.Attendance = formJournal.checkBoxAttend.Checked;
            if (!fillerflag)
            {
                dbAttendanceJournal.AddJournal(journal);
            }
        }

        private void btnDeleteJournal_Click(object sender, EventArgs e)
        {
            if (dataGridJournals.Rows.Count > 0)
            {
                int index = dataGridJournals.SelectedRows[0].Index;
                int idJournal = int.Parse(dataGridJournals[0, index].Value.ToString());
                Journal journal = dbAttendanceJournal.GetJournal(idJournal);

                string message = "Вы действительно отите удалить Запись журнала \n" + journal.ToString();
                string caption = "Подтвердите удаление";

                DialogResult result = MessageBox.Show(message, caption,
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button1
                );
                if (result != DialogResult.Yes) return;

                dbAttendanceJournal.DeleteJournal(journal);
                dataGridJournals.Refresh();
                MessageBox.Show("Запись журнала " + journal.ToString() + " удалена");
            }
        }

        private void btnEditJournal_Click(object sender, EventArgs e)
        {
            if (dataGridJournals.Rows.Count > 0)
            {
                int index = dataGridJournals.SelectedRows[0].Index;
                int idJournal = int.Parse(dataGridJournals[0, index].Value.ToString());
                Journal journal = dbAttendanceJournal.GetJournal(idJournal);

                FormJournal formJournal = new FormJournal();
                formJournal.cBoxClassType.SelectedItem = journal.ClassType;
                formJournal.cBoxSubject.SelectedItem = journal.Subject;
                formJournal.tBoxTeacher.Text = journal.Teacher;
                formJournal.tBoxGroup.Text = journal.Group;
                formJournal.tBoxStudent.Text = journal.Student;
                formJournal.dateTimeEntry.Value = journal.Date;
                formJournal.checkBoxAttend.Checked = journal.Attendance;

                DialogResult result = formJournal.ShowDialog();
                if (result != DialogResult.OK) return;

                
                journal.ClassType = formJournal.cBoxClassType.SelectedItem.ToString();
                journal.Subject = formJournal.cBoxSubject.SelectedItem.ToString();
                journal.Teacher = formJournal.tBoxTeacher.Text;
                journal.Group = formJournal.tBoxGroup.Text;
                journal.Student = formJournal.tBoxStudent.Text;
                journal.Date = formJournal.dateTimeEntry.Value;
                journal.Attendance = formJournal.checkBoxAttend.Checked;

                dbAttendanceJournal.SaveChanges();
                dataGridJournals.Refresh();
            }
        }
    }
}

