﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftITOFlix.Models
{
	public class MediaStar
	{
        public int MediaId { get; set; }
        [ForeignKey("MediaId")]
        public Media? Media { get; set; }



        public int StarId { get; set; }
        [ForeignKey("StarId")]
        public Star? Star { get; set; }
    }
}

