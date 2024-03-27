﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SoftITOFlix.Models;

// Add profile data for application users by adding properties to the SoftITOFlixUser class
public class SoftITOFlixUser : IdentityUser<long>
{
    [Column(TypeName = "date")]
    public DateTime BirthDate { get; set; }


    [Column(TypeName = "nvarchar(100)")]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = "";

    public bool Passive { get; set; }

}

