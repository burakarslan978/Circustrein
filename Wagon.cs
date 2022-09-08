using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class Wagon
    {
        private int wagonPoints;
        private string animalsInside;
        public int WagonPoints { get { return wagonPoints; } set { wagonPoints = value; } }
        public string AnimalsInside { get { return animalsInside; } set { AnimalsInside = value; } }
        public Wagon() { }

        
        public List<Wagon> getWagons()
        {
            Animal animal = new Animal();
            List<Animal> animals = new List<Animal>();
            animals = animal.getAnimals();
            
            List<Wagon> wagons = new List<Wagon>();

            while (checkWagon())
            {
                foreach (Animal _animal in animals)
                {
                    Wagon newWagon = new Wagon();
                    
                    WagonPoints += _animal.Size;

                    if (checkWagon())
                    {
                        animalsInside += _animal.AnimalName;
                    }
                    newWagon.animalsInside = animalsInside;
                    newWagon.WagonPoints = WagonPoints;
                    wagons.Add(newWagon);
                }
            }
            MessageBox.Show(AnimalsInside);
            return wagons;
            
        }

        public bool checkWagon()
        {
            if (this.WagonPoints < 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
