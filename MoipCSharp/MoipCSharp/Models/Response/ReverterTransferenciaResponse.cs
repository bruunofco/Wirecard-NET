﻿using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ReverterTransferenciaResponse
    {
        public int fee { get; set; }
        public int amount { get; set; }
        public string id { get; set; }
        public Transferinstrument transferInstrument { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public _Links _links { get; set; }
    }
}