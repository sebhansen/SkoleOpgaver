using System;
using System.Collections.Generic;
using System.Text;

namespace Ex15_Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.low)
                return 12.5;
            if (amulet.Quality == Level.medium)
                return 20;
            if (amulet.Quality == Level.high)
                return 27.5;
            return Convert.ToDouble(amulet.Quality);
        }

        public double GetValueOfCourse(Course course)
        {
            double price = 0;
            if (course.DurationInMinutes == 0)
                price = 0;
            else if (course.DurationInMinutes % 60 == 0)
                price = course.DurationInMinutes / 60 * 875; //Vi har ingen remainders, så det er kun hele timer vi ganger med time prisen
            else if (course.DurationInMinutes % 60 > 0)
                price = course.DurationInMinutes / 60 * 875 + 875; //Vi ved altid at hvis vi har en remainder, så er der påbegyndt en ny time, så vi tilføjer 875 til totalen
            return price;
        }
    }
}
