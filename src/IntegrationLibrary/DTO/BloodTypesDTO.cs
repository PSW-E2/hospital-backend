﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using IntegrationLibrary.Core.Model;

namespace IntegrationLibrary.DTO
{
    public class BloodTypesDTO
    {
        [Required]
        public BloodTypesEnum BloodType { get; set; }

        [Required]
        //[MaxLength(8)]    Check ApiKey length
        public string ApiKey { get; set; }

        public float BloodQuantity { get; set; }
    }
}