using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcClient.Models
{
    public partial class Team
    {
        public Team()
        {
            Player = new HashSet<Player>();
        }

     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public int? Championships { get; set; }

        public virtual ICollection<Player> Player { get; set; }
    }
}
