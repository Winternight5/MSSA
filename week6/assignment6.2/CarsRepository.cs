using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    interface CRUD
    {
        string AddRecord(string vin, Car obj);
        void DeleteRecord(Car obj);
        ICollection<Car> GetCars();
        Car FindByVIN(string vin);
        void UpdateRecord(string vin, Car changes);

    }
    internal class CarRepository : CRUD
    {
        Entities entities; // representing db
        public CarRepository()
        {
            entities = new Entities();
        }


        public string AddRecord(string vin, Car obj)
        {
            var car = entities.Cars.Find(vin);
            if (car == null)
            {
                entities.Cars.Add(obj);// update list
                entities.SaveChanges();// update db(actual table)
                return null;
            }

            return "VIN already exist";
        }

        public void DeleteRecord(Car obj)
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car FindByVIN(string vin)
        {
            var emp = entities.Cars.First(n => n.VIN == vin);
            if (emp != null)
            {
                return emp;
            }
            else
                return null;
        }

        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        public void UpdateRecord(string vin, Car changes)
        {
            var updateCar = entities.Cars.Find(vin);
            updateCar.VIN = changes.VIN;
            updateCar.Make = changes.Make;
            updateCar.Model = changes.Model;
            updateCar.Year = changes.Year;
            updateCar.Price = changes.Price;
            entities.SaveChanges();
        }
    }
}
