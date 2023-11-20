using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string City { get; set; }

        public List<string> Claims { get; set; } = new List<string>();

        public List<string> Roles { get; set; } = new List<string>();
    }
}
