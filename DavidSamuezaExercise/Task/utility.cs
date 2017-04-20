using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidSamuezaExercise.Task
{
    public class utility
    {
        public string[] PlacaDay(String dig)
        {

            string[] PlacaDays = null;
            switch (int.Parse(dig))
            {
                case 1:
                    PlacaDays = new string[] { "1", "2" };
                    break;
                case 2:
                    PlacaDays = new string[] { "3", "4" };
                    break;
                case 3:
                    PlacaDays = new string[] { "5", "6" };
                    break;
                case 4:
                    PlacaDays = new string[] { "7", "8" };
                    break;
                case 5:
                    PlacaDays = new string[] { "9", "0" };
                    break;
            }
            return PlacaDays;
        }
    }
}