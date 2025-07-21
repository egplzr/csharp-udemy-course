using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section008Codes.Course.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}