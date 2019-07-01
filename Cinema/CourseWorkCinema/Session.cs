using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Session
    {
        public int idSession;
        public int idHall;
        public string Date;
        public int idFilm;

        public Session()
        {
            idSession = 0;
            idHall = 0;
            Date = "";
            idFilm = 0;
        }

        public Session(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idSession = Convert.ToInt32(val[0]);
                idHall = Convert.ToInt32(val[1]);
                Date = val[2];
                idFilm = Convert.ToInt32(val[3]);
            }
        }
    }
}
