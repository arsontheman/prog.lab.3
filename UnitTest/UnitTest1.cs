using Microsoft.VisualStudio.TestTools.UnitTesting;
using prog.lab._3;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFoundationHeight()
        {
            // Arrange
            Office office = new Office { Name = "Офісний будинок", NumberOfFloors = 10 };
            Factory factory = new Factory { Name = "Завод", NumberOfWorkshops = 5 };

            // Act
            double officeFoundationHeight = office.FoundationHeight();
            double factoryFoundationHeight = factory.FoundationHeight();

            // Assert
            Assert.AreEqual(0.5, officeFoundationHeight, 0.00001, "Невірна висота фундаменту для офісу");
            Assert.AreEqual(0.00001, factoryFoundationHeight, 0.0000001, "Невірна висота фундаменту для заводу");
        }

        [TestMethod]
        public void TestFindMaxFoundationHeight()
        {
            // Arrange
            Building[] buildings = new Building[]
            {
            new Office { Name = "Офісний будинок 1", NumberOfFloors = 10 },
            new Factory { Name = "Завод 1", NumberOfWorkshops = 5 },
            new Office { Name = "Офісний будинок 2", NumberOfFloors = 15 },
            new Factory { Name = "Завод 2", NumberOfWorkshops = 8 },
            new Office { Name = "Офісний будинок 3", NumberOfFloors = 12 }
            };

            // Act
            double maxFoundationHeight = FindMaxFoundationHeight(buildings);

            // Assert
            Assert.AreEqual(0.75, maxFoundationHeight, 0.00001, "Невірна максимальна висота фундаменту");
        }

        private double FindMaxFoundationHeight(Building[] buildings)
        {
            double maxHeight = 0;
            foreach (var building in buildings)
            {
                double height = building.FoundationHeight();
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
            }
            return maxHeight;
        }
    }

}
