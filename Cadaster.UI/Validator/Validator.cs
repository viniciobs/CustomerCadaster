using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cadaster.UI
{
	public static class Validator
	{
		#region Methods

		#region Documentation

		/// <summary>
		/// Validates the phone mask.
		/// Valid values are "099 99999-9999" using the zero, white space and "-" optionaly. In addition to it, the first number 9 of the second group is optional.
		/// </summary>
		/// <param name="phone">Phone number to validate.</param>
		/// <returns>True if is valid, and false otherwise.</returns>

		#endregion Documentation

		public static bool ValidatePhone(string phone)
		{
			if (string.IsNullOrEmpty(phone)) return false;

			return Regex.Match(phone, @"^0?[0-9]{2}\s?9?[0-9]{4}\-?[0-9]{4}$").Success;
		}

		#region Documentation

		/// <summary>
		/// Validates the CPF mask.
		/// Valid values are "999.999.999-99" using the "." and "-" optionaly
		/// </summary>
		/// <param name="document">CPF number to validate.</param>
		/// <returns>True if is valid, and false otherwise.</returns>

		#endregion Documentation

		public static bool ValidateCPF(string document)
		{
			int[] docNums;

			#region Inner Function

			bool ValidateDigit(int op)
			{
				var sum = 0;
				var _op = op;

				for (var i = 0; (op - 1) >= 1; i++)
				{
					sum += docNums[i] * op;
					op--;
				}

				var reminder = (sum * 10) % 11;

				if (reminder == 10) reminder = 0;
				if (reminder != docNums[_op - 1]) return false;

				return true;
			}

			#endregion Inner Function

			if (string.IsNullOrEmpty(document)) return false;
			if (!Regex.Match(document, @"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}$").Success) return false;

			docNums = Regex.Replace(document, @"\D+", string.Empty).Select(x => int.Parse(x.ToString())).ToArray();

			if (!ValidateDigit(10)) return false;
			if (!ValidateDigit(11)) return false;

			return true;
		}

		#region Documentation

		/// <summary>
		/// Validates the CNPJ mask.
		/// </summary>
		/// <param name="document">CNPJ number to validate.</param>
		/// <returns>True if is valid, and false otherwise.</returns>

		#endregion Documentation

		public static bool ValidateCNPJ(string document)
		{
			if (string.IsNullOrEmpty(document)) return false;

			return Regex.Match(document, @"^[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}$").Success;
		}

		#region Documentation

		/// <summary>
		/// Validates the postal code.
		/// Valid values are "99999-999" using the "-" optionaly.
		/// </summary>
		/// <param name="postalCode">Postal code to validate.</param>
		/// <returns>True if is valid, and false otherwise.</returns>

		#endregion Documentation

		public static bool ValidatePostalCode(string postalCode)
		{
			if (string.IsNullOrEmpty(postalCode)) return false;

			return Regex.Match(postalCode, @"^[0-9]{5}\-?[0-9]{3}$").Success;
		}

		public static bool ValidateEmail(string email)
		{
			if (string.IsNullOrEmpty(email)) return false;

			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		#endregion Methods
	}
}