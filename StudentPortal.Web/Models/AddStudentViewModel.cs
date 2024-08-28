using StudentPortal.Web.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models
{
    public class AddStudentViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Suscribed { get; set; }
    }
    public class AddEmployeeViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Email length can't be more than 100 characters.")]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Phone number length can't be more than 15 characters.")]
        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
    public class ModAppmst
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
    public class AppMstViewModel
    {
        public List<Appmst> FromTable { get; set; }
        public List<Appmst> FromProcedure { get; set; }
    }
}
