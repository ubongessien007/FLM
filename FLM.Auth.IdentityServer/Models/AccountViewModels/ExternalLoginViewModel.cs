using System.ComponentModel.DataAnnotations;

namespace FLM.Auth.IdentityServer.Models.AccountViewModels
{
	public class ExternalLoginViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}