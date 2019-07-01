using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Ticket
    {
        public int idTicket;
        public int idFilm;
        public int idSession;
        public int idPlace;
        public string Armor;
        public int idEmployee;

        public Ticket()
        {
            idTicket = 0;
            idFilm = 0;
            idSession = 0;
            idPlace = 0;
            Armor = "";
            idEmployee = 0;
        }

        public Ticket(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idTicket = Convert.ToInt32(val[0]);
                idFilm = Convert.ToInt32(val[1]);
                idSession = Convert.ToInt32(val[2]);
                idPlace = Convert.ToInt32(val[3]);
                Armor = val[4];
                idEmployee = Convert.ToInt32(val[5]);
            }
        }
    }
}
