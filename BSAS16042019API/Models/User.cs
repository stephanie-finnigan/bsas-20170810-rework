using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string FullName
        {
            get
            {
                return Surname + ", " + FirstName;
            }
        }

        public string Rank { get; set; }

        public Station Station { get; set; }

        public int RoleId { get; set; }

        public List<Demand> Demands { get; set; }
    }
}