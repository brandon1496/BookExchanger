using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookExchange.Models
{
    // Add profile data for application users by adding properties to the BookExchangeUser class
    public class BookExchangeUser : IdentityUser
    {
        [Required]
        [PersonalData]
        public string FirstName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
