﻿using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class PedidosResponse
    {
        public _Links _links { get; set; }
        public Summary summary { get; set; }
        public List<Order> orders { get; set; }
    }
}
