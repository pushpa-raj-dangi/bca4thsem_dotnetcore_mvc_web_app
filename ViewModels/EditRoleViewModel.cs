using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebApp.ViewModels
{
    public class EditRoleViewModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        [Required(ErrorMessage = "Role Name is required")]
        public string MyProperty { get; set; }
        public List<string> Users { get; set; }

    }
}
