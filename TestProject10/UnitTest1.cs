using library;

namespace laba10tests
{
    [TestClass]
    public class zAircraftTests
    {
        [TestMethod]
        public void CheckDifferentConstructions()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft();
            zAircraft aircraft2 = new zAircraft("Ми-8", 2000, "ВРД", 5, 1);

            // Act & Assert
            Assert.AreNotEqual(aircraft1, aircraft2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            zAircraft aircraft = new zAircraft("Ми-8", 2000, "ВРД", 5, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. Модель: Ми-8, год выпуска: 2000, тип двигателя: ВРД, количество членов экипажа: 5", aircraft.ToString());
        }

        [TestMethod]
        public void CheckCompare()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("Ми-8", 2005, "ВРД", 5, 1);
            zAircraft aircraft2 = new zAircraft("Ми-24", 2005, "ВРД", 5, 2);

            // Act & Assert
            Assert.AreEqual(0, aircraft1.CompareTo(aircraft2));
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("Ми-8", 1903, "ВРД", 0, 1);
            zAircraft aircraft2 = new zAircraft("Ми-8", 1903, "ВРД", 0, 1);

            // Act & Assert
            Assert.IsTrue(aircraft1.Equals(aircraft2));
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("Ми-8", 2000, "ВРД", 5, 1);
            zAircraft aircraft2 = (zAircraft)aircraft1.ShallowCopy();
            aircraft1.Model = "Ми-24";

            // Act & Assert
            Assert.AreEqual("Ми-24", aircraft1.Model);
            Assert.AreEqual("Ми-8", aircraft2.Model);
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("Ми-8", 2000, "ВРД", 5, 1);
            zAircraft aircraft2 = (zAircraft)aircraft1.Clone();
            aircraft1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(aircraft1, aircraft2);
        }

        [TestMethod]
        public void CheckID()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("Ми-8", 2000, "ВРД", 5, 10);
            zAircraft aircraft2 = (zAircraft)aircraft1.Clone();
            aircraft1.id.Number = 5;

            // Act & Assert
            Assert.IsFalse(aircraft1.id.Equals(aircraft2.id));
        }
    }
    [TestClass]
    public class HelicopterTests
    {
        [TestMethod]
        public void CheckDifferentConstructions()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter();
            Helicopter helicopter2 = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);

            // Act & Assert
            Assert.AreNotEqual(helicopter1, helicopter2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Helicopter helicopter = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. Модель: Ми-8, год выпуска: 2000, тип двигателя: ВРД, количество членов экипажа: 5, Количество лопастей 4", helicopter.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);
            Helicopter helicopter2 = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);

            // Act & Assert
            Assert.IsTrue(helicopter1.Equals(helicopter2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);
            Helicopter helicopter2 = (Helicopter)helicopter1.Clone();
            helicopter1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(helicopter1, helicopter2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("Ми-8", 2000, "ВРД", 5, 4, 1);
            Helicopter helicopter2 = (Helicopter)helicopter1.ShallowCopy();
            helicopter1.Model = "Ми-24";

            // Act & Assert
            Assert.AreEqual("Ми-24", helicopter1.Model);
            Assert.AreEqual("Ми-8", helicopter2.Model);
        }
    }
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void CheckDifferentConstructions()
        {
            // Arrange
            Airplane airplane1 = new Airplane();
            Airplane airplane2 = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);

            // Act & Assert
            Assert.AreNotEqual(airplane1, airplane2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Airplane airplane = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. Модель: МС-21, год выпуска: 2000, тип двигателя: ТРД, количество членов экипажа: 6, число пассажиров 200, максимальная дистанция полета 5000", airplane.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Airplane airplane1 = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);
            Airplane airplane2 = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);

            // Act & Assert
            Assert.IsTrue(airplane1.Equals(airplane2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Airplane airplane1 = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);
            Airplane airplane2 = (Airplane)airplane1.Clone();
            airplane1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(airplane1, airplane2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Airplane airplane1 = new Airplane("МС-21", 2000, "ТРД", 6, 200, 5000, 1);
            Airplane airplane2 = (Airplane)airplane1.ShallowCopy();
            airplane1.Model = "Ту-214";

            // Act & Assert
            Assert.AreEqual("Ту-214", airplane1.Model);
            Assert.AreEqual("МС-21", airplane2.Model);
        }
    }
    [TestClass]
    public class FighterjetTests
    {
        [TestMethod]
        public void CheckDifferentConstructions()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet();
            Fighterjet fighterjet2 = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);

            // Act & Assert
            Assert.AreNotEqual(fighterjet1, fighterjet2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Fighterjet fighterjet = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);

            // Act & Assert
            Assert.AreEqual("id: 1. Модель: Су-57, год выпуска: 2010, тип двигателя: ТРД, количество членов экипажа: 1, число пассажиров 0, максимальная дистанция полета 2000, класс истребителя Многофункциональный", fighterjet.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);
            Fighterjet fighterjet2 = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);

            // Act & Assert
            Assert.IsTrue(fighterjet1.Equals(fighterjet2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);
            Fighterjet fighterjet2 = (Fighterjet)fighterjet1.Clone();
            fighterjet1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(fighterjet1, fighterjet2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("Су-57", 2010, "ТРД", 1, 0, 2000, "Многофункциональный", 1);
            Fighterjet fighterjet2 = (Fighterjet)fighterjet1.ShallowCopy();
            fighterjet1.Model = "МиГ-31";

            // Act & Assert
            Assert.AreEqual("МиГ-31", fighterjet1.Model);
            Assert.AreEqual("Су-57", fighterjet2.Model);
        }
    }
    [TestClass]
    public class RunnerTest
    {
        [TestMethod]
        public void TestRunnerDefaultConstructor()
        {
            // Arrange
            Runner runner = new Runner();

            // Act

            // Assert
            Assert.AreEqual(1, runner.Speed);
            Assert.AreEqual(1, runner.Distance);
        }
        [TestMethod]
        public void TestRunnerParameterizedConstructor()
        {
            // Arrange
            double distance = 5;
            double speed = 2.5;

            // Act
            Runner runner = new Runner(distance, speed);

            // Assert
            Assert.AreEqual(distance, runner.Distance);
            Assert.AreEqual(speed, runner.Speed);
        }
        [TestMethod]
        public void TestRunnerCopiedConstructor()
        {
            // Arrange
            Runner runner = new Runner(7, 8);

            // Act
            Runner runner2 = new Runner(runner);

            // Assert
            Assert.AreEqual(runner.Distance, runner2.Distance);
            Assert.AreEqual(runner.Speed, runner2.Speed);
        }
        [TestMethod]
        public void GetTime_ReturnsCorrectTime()
        {
            // Arrange
            Runner runner = new Runner(10, 2);

            // Act
            double time = runner.GetTime();

            // Assert
            Assert.AreEqual(5, time);
        }
        [TestMethod]
        public void GetTime_Static_ReturnsCorrectTime()
        {
            // Arrange
            double distance = 10;
            double speed = 2;

            // Act
            double time = Runner.GetTime(distance, speed);

            // Assert
            Assert.AreEqual(5, time);
        }
        [TestMethod]
        public void GetTime_Static_ReturnsCorrectTime2()
        {
            // Arrange
            Runner runner = new Runner(10, 2);
            double distance = 10;
            double speed = 2;

            // Act
            double time = Runner.GetTime(runner);
            double time2 = Runner.GetTime(distance, speed);

            // Assert
            Assert.AreEqual(time, time2);
        }
        [TestMethod]
        public void OperatorIncrement_IncreasesDistance()
        {
            // Arrange
            Runner runner = new Runner(10, 2);

            // Act
            runner++;

            // Assert
            Assert.AreEqual(10.1, runner.Distance);
        }

        [TestMethod]
        public void OperatorDecrement_DecreasesSpeed()
        {
            // Arrange
            Runner runner = new Runner(10, 2);

            // Act
            runner--;

            // Assert
            Assert.AreEqual(1.95, runner.Speed);
        }
        [TestMethod]
        public void Test()
        {
            // Arrange
            Runner runner = new Runner { Distance = 1000, Speed = 10 };

            // Act
            double speedIncrease = (double)runner;

            // Assert
            Assert.AreEqual((runner.Distance / (runner.Distance / runner.Speed * 0.95)) - runner.Speed, speedIncrease);
        }
        [TestMethod]
        public void TestImplicitOperator_ConvertsToTimeString()
        {
            // Arrange
            Runner runner = new Runner(10, 2);

            // Act
            string timeString = runner;

            // Assert
            Assert.AreEqual("05:00:00", timeString);
        }
        [TestMethod]
        public void MinusOperatorTest()
        {
            // Arrange
            Runner r1 = new Runner(10, 2);
            Runner r2 = new Runner(8, 3);
            double expectedDistance = 9.0;

            // Act
            double result = r1 - r2;

            // Assert
            Assert.AreEqual(expectedDistance, result);
        }
        [TestMethod]
        public void MinusOperatorTest2()
        {
            // Arrange
            Runner r1 = new Runner(8, 3);
            Runner r2 = new Runner(10, 2);
            double expectedDistance = 9.0;

            // Act
            double result = r1 - r2;

            // Assert
            Assert.AreEqual(expectedDistance, result);
        }
        [TestMethod]
        public void MinusOperatorTest3()
        {
            // Arrange
            Runner r1 = new Runner(10, 2);
            Runner r2 = new Runner(8, 9999999999999999999);
            double expectedDistance = -1;

            // Act
            double result = r1 - r2;

            // Assert
            Assert.AreEqual(expectedDistance, result);
        }
        [TestMethod]
        public void OperatorPalkaZagibulinaVverh()
        {
            // Arrange
            var originalRunner = new Runner(10, 5);
            double increaseSpeed = 2;

            // Act
            var newRunner = originalRunner ^ increaseSpeed;

            // Assert
            Assert.AreEqual(originalRunner.Distance, newRunner.Distance);
            Assert.AreEqual(originalRunner.Speed + increaseSpeed, newRunner.Speed);
        }
        [TestMethod]
        public void TestEquals_EqualRunners_ReturnsTrue()
        {
            // Arrange
            Runner runner1 = new Runner(10, 5);
            Runner runner2 = new Runner(10, 5);

            // Act
            bool result = runner1.Equals(runner2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEquals_DifferentRunners_ReturnsFalse()
        {
            // Arrange
            Runner runner1 = new Runner(10, 5);
            Runner runner2 = new Runner(15, 7);

            // Act
            bool result = runner1.Equals(runner2);

            // Assert
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class RunnerArrayTests
    {
        [TestMethod]
        public void TestRunnerArrayConstructorWithoutParameters()
        {
            // Arrange
            RunnerArray runnerArray = new RunnerArray();

            // Act

            // Assert
            Assert.IsNotNull(runnerArray);
            Assert.AreEqual(0, runnerArray.Length);
        }
        [TestMethod]
        public void TestConstructorWithSize()
        {
            // Arrange
            int size = 5;

            // Act
            RunnerArray runnerArray = new RunnerArray(size);

            // Assert
            Assert.IsNotNull(runnerArray);
            Assert.AreEqual(size, runnerArray.Length);
        }
        [TestMethod]
        public void TestConstructorWithRunnersParameter()
        {
            // Arrange
            Runner[] runners = new Runner[]
            {
                new Runner(10, 5),
                new Runner(15, 7),
                new Runner(8, 4)
            };

            // Act
            RunnerArray runnerArray = new RunnerArray(runners);

            // Assert
            Assert.AreEqual(runners.Length, runnerArray.Length);
            for (int i = 0; i < runners.Length; i++)
            {
                Assert.AreEqual(runners[i].Distance, runnerArray[i].Distance);
                Assert.AreEqual(runners[i].Speed, runnerArray[i].Speed);
            }
        }
        [TestMethod]
        public void TestRunnerArrayCopyConstructor()
        {
            // Arrange
            Runner runner1 = new Runner(10, 5);
            RunnerArray originalArray = new RunnerArray(new Runner[] { runner1 });

            // Act
            RunnerArray copiedArray = new RunnerArray(originalArray);

            // Assert
            Assert.AreEqual(originalArray.Length, copiedArray.Length);

            for (int i = 0; i < originalArray.Length; i++)
            {
                Assert.AreEqual(originalArray[i].Distance, copiedArray[i].Distance);
                Assert.AreEqual(originalArray[i].Speed, copiedArray[i].Speed);
            }
        }
        [TestMethod]
        public void TestSortRunners()
        {
            // Arrange
            Runner runner1 = new Runner(10, 5);
            Runner runner2 = new Runner(5, 2);
            Runner runner3 = new Runner(5, 3);
            Runner runner4 = new Runner(15, 4);

            RunnerArray runnerArray = new RunnerArray(new Runner[] { runner1, runner2, runner3, runner4 });

            // Act
            runnerArray.SortRunners();

            // Assert
            Assert.AreEqual(runnerArray[0].Distance, 15);
            Assert.AreEqual(runnerArray[1].Distance, 10); 
            Assert.AreEqual(runnerArray[2].Speed, 3); 
            Assert.AreEqual(runnerArray[3].Speed, 2);  
        }
        [TestMethod]
        public void TestOutOfRangeIndex()
        {
            // Arrange
            RunnerArray runnerArray = new RunnerArray(3);
            int index = 5;

            // Act & Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                var runner = runnerArray[index];
            });
        }
    }
}