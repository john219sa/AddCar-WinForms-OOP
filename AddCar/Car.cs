using System;
using System.Collections.Generic;
using System.Text;

namespace AddCar
{
     class Car
    {
        private String carName;
        private int carId;
        private int carYears;
        private String carModel;
        private String carColor;
        public void setName(String name) { carName = name; }
        public void setId(int id) { carId = id; }
        public void setYears(int years) { carYears = years; }
        public void setModel(String model) { carModel = model; }
        public void setColor(String color) { carColor = color; }

        public String getName() { return carName; }
        public int getId() { return carId; }
        public int getYears() { return carYears; }

        public String getModel() { return carModel; }

        public String getColor() { return carColor; }
    }
}
