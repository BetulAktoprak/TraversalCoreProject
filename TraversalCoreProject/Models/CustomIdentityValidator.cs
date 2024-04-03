using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length) => new IdentityError
		{
			Code = "PasswordTooShort",
			Description = $"Parola Minimum {length} Karakter Olmalıdır!"
		};

		public override IdentityError PasswordRequiresUpper() => new IdentityError
		{
			Code = "PasswordRequiresUpper",
			Description = "Parola en az bir büyük harf içermelidir!"
		};

		public override IdentityError PasswordRequiresLower() => new IdentityError
		{
			Code = "PasswordRequiresLower",
			Description = "Parola en az bir küçük harf içermelidir!"
		};

		public override IdentityError PasswordRequiresNonAlphanumeric() => new IdentityError
		{
			Code = "PasswordRequiresNonAlphanumeric",
			Description = "Parola en az bir sembol içermelidir!"
		};
		

	}
}
