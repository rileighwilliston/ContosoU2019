using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2019.Models
{
    //rwilliston part 2
    public class person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50,ErrorMessage="First name cannot be longer than 50 characters")]
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Email { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public int PostalCode { get; set; }
        public int Province { get; set; }

        //fullname

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string IDFullName
        {
            get
            {
                return "(" + ID + ")" + LastName + ", " + FirstName;
            }
        }
        public string FullAddress
        {
            get
            {
                return Address + ", " +
                        City + ", " +
                        Province + ", " +
                        PostalCode + ", ";
            }
        }
    }
}
