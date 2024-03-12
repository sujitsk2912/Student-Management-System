using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_management_system
{
     class Student_Name
    {
        static string StudName;
        public static string SName
        {
            get { return StudName; }
            set { StudName = value; }
        }
    }

    class Student_ID
    {
        static string StudID;
        public static string SID
        {
            get { return StudID; }
            set { StudID = value; }
        }
    }
}
