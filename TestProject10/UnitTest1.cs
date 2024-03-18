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
            zAircraft aircraft2 = new zAircraft("��-8", 2000, "���", 5, 1);

            // Act & Assert
            Assert.AreNotEqual(aircraft1, aircraft2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            zAircraft aircraft = new zAircraft("��-8", 2000, "���", 5, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. ������: ��-8, ��� �������: 2000, ��� ���������: ���, ���������� ������ �������: 5", aircraft.ToString());
        }

        [TestMethod]
        public void CheckCompare()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("��-8", 2005, "���", 5, 1);
            zAircraft aircraft2 = new zAircraft("��-24", 2005, "���", 5, 2);

            // Act & Assert
            Assert.AreEqual(0, aircraft1.CompareTo(aircraft2));
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("��-8", 1903, "���", 0, 1);
            zAircraft aircraft2 = new zAircraft("��-8", 1903, "���", 0, 1);

            // Act & Assert
            Assert.IsTrue(aircraft1.Equals(aircraft2));
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("��-8", 2000, "���", 5, 1);
            zAircraft aircraft2 = (zAircraft)aircraft1.ShallowCopy();
            aircraft1.Model = "��-24";

            // Act & Assert
            Assert.AreEqual("��-24", aircraft1.Model);
            Assert.AreEqual("��-8", aircraft2.Model);
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("��-8", 2000, "���", 5, 1);
            zAircraft aircraft2 = (zAircraft)aircraft1.Clone();
            aircraft1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(aircraft1, aircraft2);
        }

        [TestMethod]
        public void CheckID()
        {
            // Arrange
            zAircraft aircraft1 = new zAircraft("��-8", 2000, "���", 5, 10);
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
            Helicopter helicopter2 = new Helicopter("��-8", 2000, "���", 5, 4, 1);

            // Act & Assert
            Assert.AreNotEqual(helicopter1, helicopter2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Helicopter helicopter = new Helicopter("��-8", 2000, "���", 5, 4, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. ������: ��-8, ��� �������: 2000, ��� ���������: ���, ���������� ������ �������: 5, ���������� �������� 4", helicopter.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("��-8", 2000, "���", 5, 4, 1);
            Helicopter helicopter2 = new Helicopter("��-8", 2000, "���", 5, 4, 1);

            // Act & Assert
            Assert.IsTrue(helicopter1.Equals(helicopter2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("��-8", 2000, "���", 5, 4, 1);
            Helicopter helicopter2 = (Helicopter)helicopter1.Clone();
            helicopter1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(helicopter1, helicopter2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Helicopter helicopter1 = new Helicopter("��-8", 2000, "���", 5, 4, 1);
            Helicopter helicopter2 = (Helicopter)helicopter1.ShallowCopy();
            helicopter1.Model = "��-24";

            // Act & Assert
            Assert.AreEqual("��-24", helicopter1.Model);
            Assert.AreEqual("��-8", helicopter2.Model);
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
            Airplane airplane2 = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);

            // Act & Assert
            Assert.AreNotEqual(airplane1, airplane2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Airplane airplane = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);

            // Act & Assert
            Assert.AreEqual("id: 1. ������: ��-21, ��� �������: 2000, ��� ���������: ���, ���������� ������ �������: 6, ����� ���������� 200, ������������ ��������� ������ 5000", airplane.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Airplane airplane1 = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);
            Airplane airplane2 = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);

            // Act & Assert
            Assert.IsTrue(airplane1.Equals(airplane2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Airplane airplane1 = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);
            Airplane airplane2 = (Airplane)airplane1.Clone();
            airplane1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(airplane1, airplane2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Airplane airplane1 = new Airplane("��-21", 2000, "���", 6, 200, 5000, 1);
            Airplane airplane2 = (Airplane)airplane1.ShallowCopy();
            airplane1.Model = "��-214";

            // Act & Assert
            Assert.AreEqual("��-214", airplane1.Model);
            Assert.AreEqual("��-21", airplane2.Model);
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
            Fighterjet fighterjet2 = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);

            // Act & Assert
            Assert.AreNotEqual(fighterjet1, fighterjet2);
        }

        [TestMethod]
        public void CheckShowMethod()
        {
            // Arrange
            Fighterjet fighterjet = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);

            // Act & Assert
            Assert.AreEqual("id: 1. ������: ��-57, ��� �������: 2010, ��� ���������: ���, ���������� ������ �������: 1, ����� ���������� 0, ������������ ��������� ������ 2000, ����� ����������� �������������������", fighterjet.ToString());
        }

        [TestMethod]
        public void CheckEquals()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);
            Fighterjet fighterjet2 = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);

            // Act & Assert
            Assert.IsTrue(fighterjet1.Equals(fighterjet2));
        }

        [TestMethod]
        public void CheckClone()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);
            Fighterjet fighterjet2 = (Fighterjet)fighterjet1.Clone();
            fighterjet1.ReleaseYear = 2020;

            // Act & Assert
            Assert.AreNotEqual(fighterjet1, fighterjet2);
        }

        [TestMethod]
        public void CheckCopy()
        {
            // Arrange
            Fighterjet fighterjet1 = new Fighterjet("��-57", 2010, "���", 1, 0, 2000, "�������������������", 1);
            Fighterjet fighterjet2 = (Fighterjet)fighterjet1.ShallowCopy();
            fighterjet1.Model = "���-31";

            // Act & Assert
            Assert.AreEqual("���-31", fighterjet1.Model);
            Assert.AreEqual("��-57", fighterjet2.Model);
        }
    }
}