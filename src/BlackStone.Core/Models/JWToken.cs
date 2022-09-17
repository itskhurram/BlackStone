using System.ComponentModel.DataAnnotations;

namespace BlackStone.Core.Models {
	public class JWToken {
		[Required]
		public string? Token { get; set; }
		[Required]
		public string? RefreshToken { get; set; }
		public DateTime TokenExpirationTimeInMinutes { get; set; }
		public DateTime RefreshTokenExpirationTimeInMinutes { get; set; }
	}
}
