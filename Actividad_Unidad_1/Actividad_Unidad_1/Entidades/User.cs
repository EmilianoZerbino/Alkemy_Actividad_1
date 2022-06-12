using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Actividad_Unidad_1.Entidades
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
