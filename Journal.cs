using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Yalovoy_AttendanceJournal
{
    internal class Journal
    {
        /*public int Journal_id;
        public int ClassType_id;
        public int Subject_id;
        public int Teacher_id;
        public int Group_id;
        public int Student_id;
        */
        [Key] public int Journal_id { get; set; }
        public string ClassType { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string Group { get; set; }
        public string Student { get; set; }
        public DateTime Date { get; set; }
        public bool Attendance { get; set; }

        public override string ToString()
        {
            return ClassType + " " + Subject + " " + Student + " " + Date;
        }
    }
}
