using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Yalovoy_AttendanceJournal
{
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
            cBoxClassType.SelectedIndex = 0;
            cBoxSubject.SelectedIndex = 0;
        }
    }
}
