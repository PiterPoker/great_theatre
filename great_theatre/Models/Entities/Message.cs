using System;

namespace great_theatre.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public bool IsCheck { get; set; }
        public bool IsFavorute { get; set; }
        public string Sender { get; set; }
        public string Comment { get; set; }
        public DateTime Time { get; set; }
      
    }
}