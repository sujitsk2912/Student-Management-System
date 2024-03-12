using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_management_system
{
     class Staff_Name
    {
        static string SName;
        public static string Name
        {
            get { return SName; }
            set { SName = value; }
        }
    }

    class Staff_ID
    {
        static string StaffID;
        public static string FID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }
    }
}
