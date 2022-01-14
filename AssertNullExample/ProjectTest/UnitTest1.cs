using NUnit.Framework;
using Project;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<Recording> earthSunRecordings = new List<Recording>() {
                new Recording(){
                    ID = 0,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.000"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.003"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = ""
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.007"
                },
                new Recording(){
                    ID = 4,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.00"
                },
                new Recording(){
                    ID = 5,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.010AU"
                },
                new Recording(){
                    ID = 6,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.011"
                },
                new Recording(){
                    ID = 7,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.010 astronomical units"
                },
                new Recording(){
                    ID = 8,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.007"
                },
                new Recording(){
                    ID = 9,
                    Date = new DateTime(2020, 1, 1),
                    Distance = null
                },
                new Recording(){
                    ID = 10,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.003"
                },
                new Recording(){
                    ID = 11,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.000"
                },
            };
            EarthCycle earthCycles1 = new EarthCycle(earthSunRecordings, new DateTime(2020, 1, 1));
            EarthCycle earthCycles2 = new EarthCycle(earthSunRecordings, new DateTime(2045, 4, 3));
            Assert.IsNull(earthCycles1.EarthSunRecordings);
            Assert.IsNotNull(earthCycles2.EarthSunRecordings);
        }

        [Test]
        public void Test2()
        {
            List<Recording> earthSunRecordings = new List<Recording>() {
                new Recording(){
                    ID = 0,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.000"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.003"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = ""
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.007"
                },
                new Recording(){
                    ID = 4,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.00"
                },
                new Recording(){
                    ID = 5,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.010AU"
                },
                new Recording(){
                    ID = 6,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.011"
                },
                new Recording(){
                    ID = 7,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.010 astronomical units"
                },
                new Recording(){
                    ID = 8,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.007"
                },
                new Recording(){
                    ID = 9,
                    Date = new DateTime(2020, 1, 1),
                    Distance = null
                },
                new Recording(){
                    ID = 10,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.003"
                },
                new Recording(){
                    ID = 11,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.000"
                },
            };
            EarthCycle earthCycles = new EarthCycle(earthSunRecordings, new DateTime(2045, 1, 1));

            Assert.Zero((double)earthCycles.EarthSunDistanceByID(4));
            Assert.NotZero((double)earthCycles.EarthSunDistanceByID(0));
            Assert.IsNaN(earthCycles.EarthSunDistanceByID(5));
            Assert.IsEmpty(earthCycles.EarthSunRecordings[2].Distance);
            Assert.IsNotEmpty(earthCycles.EarthSunRecordings[0].Distance);
        }
    }
}