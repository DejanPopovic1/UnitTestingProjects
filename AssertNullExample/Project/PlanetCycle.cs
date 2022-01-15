using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Project
{
    public class PlanetCycle
    {
        public DateTime CurrentDate { get; set; }
        public List<Recording> EarthSunRecordings { get; set; }

        public PlanetCycle()
        {

        }

        public PlanetCycle(List<Recording> cycleRecordings, DateTime date)
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
            catch (FormatException)
            {
                return Double.NaN;
            }
        }

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

        public List<double> GetListWithinOneAstronomicalUnit()
        {
            return EarthSunRecordings.Where(x => double.Parse(x.Distance, CultureInfo.InvariantCulture) <= 1.00).Select(x => double.Parse(x.Distance, CultureInfo.InvariantCulture)).ToList();
        }

        public enum Seasons
        {
            NorthHemisphere,
            SouthHemisphere
        }
    }
}
