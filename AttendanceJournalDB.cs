using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Yalovoy_AttendanceJournal
{
    internal class AttendanceJournalDB
    {
        JournalContextMSSQL db;
<<<<<<< HEAD
<<<<<<< HEAD
//some change
>>>>>>> parent of 2882989 (New files added. New features in AttendanceJournalDB.cs and FormMain.cs)
        public AttendanceJournalDB()
        {
            db = new JournalContextMSSQL();
            db.Journals.Load();
        }
        public void AddJournal(Journal journal){
            db.Journals.Add(journal);
            db.SaveChanges();
        }
        public BindingList<Journal> ReadJournals()
        {
            return db.Journals.Local.ToBindingList();
        }

        public Journal GetJournal(int idJournal)
        {
            return db.Journals.Find(idJournal);
        }

        public void DeleteJournal(Journal journal)
        {
            db.Journals.Remove(journal);
            db.SaveChanges();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
