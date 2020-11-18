using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Enums
{
    public enum EOrderStatus
    {
        WaitingPayment = 1,
        WaitingDelivery = 2,
        Canceled = 3
    }
}
