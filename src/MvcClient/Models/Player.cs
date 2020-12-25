using System;
using System.Collections.Generic;

namespace MvcClient.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string NameSurname { get; set; }

        public virtual Team Team { get; set; }
    }
}
