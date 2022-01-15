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
                    Distance = "0.9840"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9888"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = ""
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0050"
                },
                new Recording(){
                    ID = 4,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.00"
                },
                new Recording(){
                    ID = 5,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0163AU"
                },
                new Recording(){
                    ID = 6,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0161"
                },
                new Recording(){
                    ID = 7,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0116 astronomical units"
                },
                new Recording(){
                    ID = 8,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0039"
                },
                new Recording(){
                    ID = 9,
                    Date = new DateTime(2020, 1, 1),
                    Distance = null
                },
                new Recording(){
                    ID = 10,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9878"
                },
                new Recording(){
                    ID = 11,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9837"
                },
            };
            PlanetCycle earthCycles1 = new PlanetCycle(earthSunRecordings, new DateTime(2020, 1, 1));
            PlanetCycle earthCycles2 = new PlanetCycle(earthSunRecordings, new DateTime(2045, 4, 3));
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
                    Distance = "0.9840"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9888"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = ""
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0050"
                },
                new Recording(){
                    ID = 4,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.00"
                },
                new Recording(){
                    ID = 5,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0163AU"
                },
                new Recording(){
                    ID = 6,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0161"
                },
                new Recording(){
                    ID = 7,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0116 astronomical units"
                },
                new Recording(){
                    ID = 8,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.0039"
                },
                new Recording(){
                    ID = 9,
                    Date = new DateTime(2020, 1, 1),
                    Distance = null
                },
                new Recording(){
                    ID = 10,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9878"
                },
                new Recording(){
                    ID = 11,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9837"
                },
            };
            PlanetCycle earthCycles = new PlanetCycle(earthSunRecordings, new DateTime(2045, 1, 1));
            Assert.Zero((double)earthCycles.EarthSunDistanceByID(4));
            Assert.NotZero((double)earthCycles.EarthSunDistanceByID(0));
            Assert.IsNaN(earthCycles.EarthSunDistanceByID(5));
        }

        [Test]
        public void Test3()
        {
            List<Recording> earthSunRecordings1 = new List<Recording>() {
                new Recording(){
                    ID = 0,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9840"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9888"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9800"
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "0.9950"
                }
            };

            List<Recording> earthSunRecordings2 = new List<Recording>() {
                new Recording(){
                    ID = 0,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.01"
                },
                new Recording(){
                    ID = 1,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.008"
                },
                new Recording(){
                    ID = 2,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.009"
                },
                new Recording(){
                    ID = 3,
                    Date = new DateTime(2020, 1, 1),
                    Distance = "1.007"
                }
            };
            PlanetCycle earthCycles1 = new PlanetCycle(earthSunRecordings1, new DateTime(2045, 1, 1));
            PlanetCycle earthCycles2 = new PlanetCycle(earthSunRecordings2, new DateTime(2045, 1, 1));
            Assert.IsNotEmpty(earthCycles1.GetListWithinOneAstronomicalUnit());
            Assert.IsEmpty(earthCycles2.GetListWithinOneAstronomicalUnit());
        }
    }
}