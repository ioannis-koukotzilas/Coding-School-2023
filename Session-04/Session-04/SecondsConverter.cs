using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {

    public class SecondsConverter {

        public string GetSeconds() {

            /* Write a C# program that takes an integer representing seconds (for example 45678)
             * and converts it to: Minutes, Hours, Days, Years */

            int seconds = 45678;
            float minutes = seconds / 60;
            float hours = minutes / 60;
            float days = hours / 24;
            float years = days / 365;

            string message = seconds + " seconds are " + minutes + " minutes, " + hours + " hours, " + days + " days and " + years + " years.";

            return message;

        }

    }

}
