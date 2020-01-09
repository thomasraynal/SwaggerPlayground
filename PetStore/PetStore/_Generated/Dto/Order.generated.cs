
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class Order
    {
      public long Id {get; set; }
      public long PetId {get; set; }
      public int Quantity {get; set; }
      public DateTime ShipDate {get; set; }
      public OrderStatus OrderStatus {get; set; }
      public bool Complete {get; set; }

    }

    public abstract class OrderValidatorBase : AbstractValidator<Order>
    {
        public OrderValidatorBase()
        {
        }
    }

}

