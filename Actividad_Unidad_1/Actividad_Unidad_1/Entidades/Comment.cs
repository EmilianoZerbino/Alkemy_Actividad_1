using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad_Unidad_1.Entidades
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public DateTime Date { get; set; }
        public string comment { get; set; }
        public User User { get; set; }
    }
}
