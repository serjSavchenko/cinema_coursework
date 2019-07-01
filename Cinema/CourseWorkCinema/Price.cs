using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Price
    {
        public int idPrice;
        public int idSession;
        public string PriceValue;

        public Price()
        {
            idPrice = 0;
            idSession = 0;
            PriceValue = "";
        }

        public Price(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idPrice = Convert.ToInt32(val[0]);
                idSession = Convert.ToInt32(val[1]);
                PriceValue = val[2];
            }
        }
    }
}
