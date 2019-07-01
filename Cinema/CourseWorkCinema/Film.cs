using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Film
    {
        public int idFilm;
        public string FilmName;
        public string FilmGenre;
        public string Duration;
        public string Time;

        public Film()
        {
            idFilm = 0;
            FilmName = "";
            FilmGenre = "";
            Duration = "";
            Time = "";
        }

        public Film(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idFilm = Convert.ToInt32(val[0]);
                FilmName = val[1];
                FilmGenre = val[2];
                Duration = val[3];
                Time = val[4];
            }
        }
    }
}
