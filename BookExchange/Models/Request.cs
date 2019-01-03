using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookExchange.Models
{
    public class Request
    {
        public int Id { get; set; }
        public BookExchangeUser Requester { get; set; }
        public Book Requester_Book { get; set; }
        public BookExchangeUser CurrentOwner { get; set; }
        public Book CurrentOwner_Book { get; set; }
        public bool Trade_Complete { get; set; }
    }
}
