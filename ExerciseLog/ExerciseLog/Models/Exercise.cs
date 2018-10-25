using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseLog.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Exercise_Date { get; set; }
        public string Run_Distance { get; set; }
        public string Run_Duration { get; set; }
        public int Pushup_Count { get; set; }
        public string Plank_Duration { get; set; }
        public string Comments { get; set; }
    }
}