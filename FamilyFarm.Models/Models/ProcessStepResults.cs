﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FamilyFarm.Models.Models
{
    public class ProcessStepResults
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string StepResultId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public required string StepId { get; set; }
        public required string? StepResultComment { get; set; }
        public required DateTime? CreatedAt { get; set; }
    }
}
