﻿#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class SaldosResponse
    {
        public int unavailable { get; set; }
        public int future { get; set; }
        public int current { get; set; }
        public _Links _links { get; set; }
        public string date { get; set; }
    }
}
