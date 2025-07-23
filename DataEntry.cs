using System;
using System.ComponentModel.DataAnnotations;

namespace LifeMirror.Models
{
    public class DataEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public string Mood { get; set; }

        public int PhysicalHealth { get; set; }
        public int MentalHealth { get; set; }
        public int FinanceStatus { get; set; }
        public int GoalAchivementHours { get; set; }
        public string PersonalDairy { get; set; }

    }
}