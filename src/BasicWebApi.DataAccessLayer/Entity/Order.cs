﻿using BasicWebApi.DataAccessLayer.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWebApi.Shared.Enums;

namespace BasicWebApi.DataAccessLayer.Entity
{
    public class Order : BaseEntity
    {
        public DateTime CreationDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public double TotalPrice { get; set; }

        public OrderStatus Status { get; set; }
    }
}
