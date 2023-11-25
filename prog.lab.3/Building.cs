using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog.lab._3
{
    public abstract class Building
    {
        public string Name { get; set; }

        // Абстрактний метод для висоти фундаменту
        public abstract double FoundationHeight();
    }

    public class Office : Building
    {
        public int NumberOfFloors { get; set; }

        // Перевизначення методу для висоти фундаменту офісу
        public override double FoundationHeight()
        {
            return 0.05 * NumberOfFloors;
        }
    }

    public class Factory : Building
    {
        public int NumberOfWorkshops { get; set; }

        // Перевизначення методу для висоти фундаменту заводу
        public override double FoundationHeight()
        {
            return 0.000002 * NumberOfWorkshops;
        }
    }
    public class BuildingViewModel
    {
        public string Name { get; set; }
        public double FoundationHeight { get; set; }
    }
}
