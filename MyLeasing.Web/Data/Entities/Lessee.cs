using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public string Address { get; internal set; }
        public string CellPhone { get; internal set; }
        public string Document { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string FixedPhone { get; internal set; }
    }
}
