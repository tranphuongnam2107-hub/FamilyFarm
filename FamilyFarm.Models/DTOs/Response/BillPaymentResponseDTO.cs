﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyFarm.Models.Mapper;

namespace FamilyFarm.Models.DTOs.Response
{
    public class BillPaymentResponseDTO
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public BillPaymentMapper Data { get; set; }
    }
}
