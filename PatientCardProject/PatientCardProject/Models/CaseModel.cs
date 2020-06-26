using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCardProject.Models
{
    [Table("tbl2Cases", Schema ="dbo")]
    public class CaseModel
    {
        [Key]
        public int ID { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage ="Please Fill the CaseNumber")]
        public string CaseNumber { get; set; }

        public PatientDetail PatientId { get; set; }

        public HealthCenterDetail HealthCenterId { get; set; }

        public DoctorDetail ConsulatedBy { get; set; }

        [Required(ErrorMessage = "Please Fill the Fee")]
        [Range(0,10000,ErrorMessage ="Invalid Range")]
        public decimal Fee { get; set; }

        public DateTime RegisterDate { get; set; }
    }
    public enum PatientDetail
    {
        [Display(Name = "Pankaj R. Patel")]
        Pankaj=1,
        [Display(Name = "Nisarg B Kapadia")]
        Nisarg=2,
        [Display(Name = "Nikunj V Gandhi")]
        Nikunj=3,
        [Display(Name = "Jinal Patel")]
        Jinal=4,
        [Display(Name = "Jaydeep Jadav")]
        Jaydeep=5,
        [Display(Name = "Hardik Patel")]
        Hardik=6,
        [Display(Name = "Pritesh Prajapati")]
        Pritesh=7,
        [Display(Name = "Alpesh Panchal")]
        Alpesh=8
    }
    public enum HealthCenterDetail
    {
        [Display(Name = "HealthCenter1")]
        HealthCenter1=1,
        [Display(Name = "HealthCenter2")]
        HealthCenter2=2,
        [Display(Name = "HealthCenter3")]
        HealthCenter3=3,
        [Display(Name = "HealthCenter4")]
        HealthCenter4=4,
        [Display(Name = "HealthCenter5")]
        HealthCenter5=5,
        [Display(Name = "HealthCenter6")]
        HealthCenter6=6,
        [Display(Name = "HealthCenter7")]
        HealthCenter7=7,
        [Display(Name = "HealthCenter8")]
        HealthCenter8=8,
        [Display(Name = "HealthCenter9")]
        HealthCenter9=9,
        [Display(Name = "HealthCenter11")]
        HealthCenter11=11
    }
    public enum DoctorDetail
    {
        [Display(Name = "Dr.Umesh Gamit")]
        Umesh = 1,
        [Display(Name = "Dr.Swapnil Tandel")]
        Swapnil=2,
        [Display(Name = " Dr. Dipak Patel")]
        Dipak=3,
        [Display(Name = "Dr. Poonam Prajapati")] 
        Poonam=4,
        [Display(Name = " Dr. Rumana Kadri")]
        Rumana=5,
        [Display(Name = "Dr. Sanket Patel")] 
        Sanket=6,
        [Display(Name = "Dr. Megha Patel")] 
        Megha=7
    }
}
