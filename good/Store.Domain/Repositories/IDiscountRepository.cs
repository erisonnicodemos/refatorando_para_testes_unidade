using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Repositories
{
    public interface IDiscountRepository
    {
        Discount Get(string code);
    }
}
