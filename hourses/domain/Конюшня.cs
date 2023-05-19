using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace hourses.domain
{
    class Конюшня
    {       
        private Конюшня()
        {
           
        }

        public static List<Кінь> ГенеруюКоней(int count)
        {
            List<Кінь> кіньs = new List<Кінь>();
            int dy = 80;

            for(int i = 0; i < count; i++)
            {
                Кінь кінь = new Кінь($"Кінь-{i}", randomColor(), dy * i);
                кіньs.Add(кінь);
            }

            return кіньs;
        }

        private static Color randomColor()
        {
            return Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
        }
    }
}
