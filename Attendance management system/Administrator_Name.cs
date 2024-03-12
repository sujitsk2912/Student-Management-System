using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_management_system
{
    class Administrator_Name
    {
       static string UName;
        public static string Name
        {
            get { return UName; }
            set { UName = value; }
        }
    }
}
