﻿using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class MultiPagamentoPreAutorizadoResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public Amount amount { get; set; }
        public int installmentCount { get; set; }
        public List<Payment> payments { get; set; }
        public _Links _links { get; set; }
    }
}
