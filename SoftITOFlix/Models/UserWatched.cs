using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SoftITOFlix.Models
{
	public class UserWatched
	{
		public long UserId { get; set; }
		public long EpisodeId { get; set; }
		[ForeignKey("UserId")]
		public SoftITOFlixUser? SoftITOFlixUser { get; set; }
        [ForeignKey("EpisodeId")]
        public Episode? Episode { get; set; }



    }
}

