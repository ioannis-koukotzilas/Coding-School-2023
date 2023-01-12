using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {

    internal class SecondsConverterRewrite {

        public string GetSeconds() {

            /* Rewrite Program #5 using .Net Libraries.
            */

            int seconds = 45678;

            // TODO: Fix it. Wrong result.

            TimeSpan ts = TimeSpan.FromSeconds(seconds);

            string message = string.Format("{0:D2} Minutes, {1:D2} Hours {2:D1} Days",
                ts.Minutes,
                ts.Hours,
                ts.Days
            );

            return message;

        }

    }

}
