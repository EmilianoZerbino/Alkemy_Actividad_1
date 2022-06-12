using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad_Unidad_1.Entidades
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
