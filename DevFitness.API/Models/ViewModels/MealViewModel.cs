using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Models.ViewModels
{
    public class MealViewModel
    {
        public MealViewModel(string description, int calories, DateTime date, int id)
        {
            Description = description;
            Calories = calories;
            Date = date;
            Id = id;
        }

        public string Description { get; private set; }
        public int Calories { get; private set; }
        public DateTime Date { get; private set; }
        public int Id { get; private set; }
    }
}
