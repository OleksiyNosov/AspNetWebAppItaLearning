using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PostData
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Field cannot be empty")]
        [MaxLength(350, ErrorMessage = "Field must contain less characters")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Field cannot be empty")]
        [MaxLength(350, ErrorMessage = "Field must contain less characters")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Field cannot be empty")]
        [MaxLength(350, ErrorMessage = "Field must contain less characters")]
        [MinLength(3, ErrorMessage = "Field must contain more than 2 characters")]
        public string Login { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Range(18, 140)]
        public string Age { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }
    }
}