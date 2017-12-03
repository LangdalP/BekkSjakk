using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BekkSjakk.Helpers
{
    public static class DateTimeOffsetDisplayHelper
    {
        private const int SECOND = 1;
        private const int MINUTE = 60 * SECOND;
        private const int HOUR = 60 * MINUTE;
        private const int DAY = 24 * HOUR;
        private const int MONTH = 30 * DAY;

        // From here: https://stackoverflow.com/questions/11/calculate-relative-time-in-c-sharp
        public static string DateTimeOffsetToRelativeString(DateTimeOffset when)
        {
            var ts = new TimeSpan(DateTimeOffset.UtcNow.Ticks - when.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "et sekund siden" : ts.Seconds + " sekunder siden";

            if (delta < 2 * MINUTE)
                return "et minutt siden";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutter siden";

            if (delta < 90 * MINUTE)
                return "en time siden";

            if (delta < 24 * HOUR)
                return ts.Hours + " timer siden";

            if (delta < 48 * HOUR)
                return "i går";

            if (delta < 30 * DAY)
                return ts.Days + " dager siden";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "en måned siden" : months + " måneder siden";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "et år siden" : years + " år siden";
            }
        }
    }
}