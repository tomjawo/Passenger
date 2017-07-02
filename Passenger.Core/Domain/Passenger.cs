using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    public class Passenger
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Node Address { get; set; }
        

    }
}
