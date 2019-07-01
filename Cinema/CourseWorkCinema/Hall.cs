using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Hall
    {
        public int idHall;
        public string HallName;
        public string QuantityPlaces;
        public string QuantityRows;
        public int PlacesByRow;

        public Hall()
        {
            idHall = 0;
            HallName = "";
            QuantityPlaces = "";
            QuantityRows = "";
            PlacesByRow = 0;
        }

        public Hall(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idHall = Convert.ToInt32(val[0]);
                HallName = val[1];
                QuantityPlaces = val[2];
                QuantityRows = val[3];
                PlacesByRow = Convert.ToInt32(QuantityPlaces) / Convert.ToInt32(QuantityRows);
            }
        }
    }
}
