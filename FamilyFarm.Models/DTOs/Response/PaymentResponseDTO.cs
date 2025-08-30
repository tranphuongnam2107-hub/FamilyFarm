﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyFarm.Models.Mapper;
using FamilyFarm.Models.Models;

namespace FamilyFarm.Models.DTOs.Response
{
    public class PaymentResponseDTO
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        //public int Count { get; set; }
        public List<PaymentTransaction>? Data { get; set; }
        //public PaymentDataMapper Data { get; set; }
    }
}
