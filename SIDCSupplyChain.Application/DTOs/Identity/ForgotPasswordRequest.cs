﻿using System.ComponentModel.DataAnnotations;

namespace SIDCSupplyChain.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}