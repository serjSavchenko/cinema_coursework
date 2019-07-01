using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Place
    {
        public int idPlace;
        public int idHall;
        public string Row;
        public int PlaceNum;

        public Place()
        {
            idPlace = 0;
            idHall = 0;
            Row = "";
            PlaceNum = 0;
        }

        public Place(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idPlace = Convert.ToInt32(val[0]);
                idHall = Convert.ToInt32(val[1]);
                Row = val[2];
                PlaceNum = Convert.ToInt32(val[3]);
            }
        }
    }
}
