using System;

namespace WebAPIBaseData.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Fecha { get; set; }
    }
}