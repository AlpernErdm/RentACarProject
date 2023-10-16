﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;//Veri varmış gibi davranıyoruz //global değişken _cars 
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, BrandId = 1,ColorId=1,DailyPrice=100,ModelYear=2004,Description="Beyaz Opel Astra"},
                new Car { CarId = 2, BrandId = 2,ColorId=3,DailyPrice=200,ModelYear=2016,Description="Citroen 3008"},
                new Car { CarId = 3, BrandId = 2,ColorId=2,DailyPrice=150,ModelYear=2015,Description="Citroen 2008"},
                new Car { CarId = 4, BrandId = 3,ColorId=4,DailyPrice=400,ModelYear=2019,Description="Audi A5"},
                new Car { CarId = 5, BrandId = 1,ColorId=1,DailyPrice=500,ModelYear=2021,Description="Citroen 3008"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }

        public void Remove(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }


    }
}