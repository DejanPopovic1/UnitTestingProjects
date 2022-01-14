using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Project
{
    public class EarthCycle
    {
        public DateTime CurrentDate { get; set; }
        public List<Recording> EarthSunRecordings { get; set; }

        public EarthCycle()
        {

        }

        public EarthCycle(List<Recording> cycleRecordings, DateTime date)
        {
            if (date >= DateTime.Now)
            {
                CurrentDate = date;
                EarthSunRecordings = cycleRecordings;
            }
        }

        public double? EarthSunDistanceByID(int id)
        {
            string distance = EarthSunRecordings.Where(x => x.ID == id).Select(x => x.Distance).ToList().First();
            try
            {
                return double.Parse(distance, CultureInfo.InvariantCulture);
            }
            catch (FormatException e)
            {
                return Double.NaN;
            }
        }

        //These seasons are based on meteorological seasons
        public bool IsWinter(Seasons season)
        {
            if (season == Seasons.NorthHemisphere)
            {
                if (CurrentDate.Date <= new DateTime(2022, 02, 28).Date && CurrentDate.Month <= new DateTime(2022, 02, 28).Month)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (CurrentDate.Date >= new DateTime(2022, 12, 1).Date && CurrentDate.Month >= new DateTime(2022, 12, 1).Month)
                {
                    return true;
                }
                return false;
            }
        }

        public enum Seasons
        {
            NorthHemisphere,
            SouthHemisphere
        }
    }
}
