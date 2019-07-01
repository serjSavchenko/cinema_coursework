using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Position
    {
        public int idPosition;
        public string PosName;

        public Position()
        {
            idPosition = 0;
            PosName = "";
        }

        public Position(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idPosition = Convert.ToInt32(val[0]);
                PosName = val[1];
            }
        }
    }
}
