using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Repositories
{
    public interface IDeliveryFeeRepository
    {
        decimal Get(string zipCode);
    }
}
