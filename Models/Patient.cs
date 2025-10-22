using System;
using System.ComponentModel.DataAnnotations;

namespace PatientManagementSystem.Models
{
    public class Patient
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Owner's name is required")]
        [Display(Name = "Owner's Name")]
        public string OwnerName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Pet's name is required")]
        [Display(Name = "Pet's Name")]
        public string PetName { get; set; }

        [Required(ErrorMessage = "Species is required")]
        public string Species { get; set; }

        [Required(ErrorMessage = "Sex is required")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Diagnosis is required")]
        public string Diagnosis { get; set; }

        [Display(Name = "Additional Details")]
        public string Details { get; set; }
    }
}
