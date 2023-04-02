using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsForms_Yalovoy_AttendanceJournal
{
    internal class JournalContextMSSQL : DbContext
    {
        public JournalContextMSSQL() : base("JournalConnectMSSQL")
        { }
// new amazing code
// haha I know its funny
// gg wp git gud
        public DbSet<Journal> Journals { get; set; }
    }
}
