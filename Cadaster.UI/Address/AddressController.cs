using Domain;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Cadaster.UI.Helpers;
using System.Threading.Tasks;

namespace Cadaster.UI
{
	public class AddressController
	{
		#region Inner Type

		private class ApiAddressResponse
		{
			public string Logradouro { get; set; }

			public string Bairro { get; set; }

			public string Localidade { get; set; }

			public string UF { get; set; }
		}

		#endregion Inner Type

		#region Fields

		private const string ROUTE = "http://viacep.com.br/ws/{0}/json/";
		private HttpClient client;

		#endregion Fields

		#region Constructor

		public AddressController()
		{
			client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
		}

		#endregion Constructor

		#region Methods

		public async Task<Address> GetAddress(string postalCode)
		{
			var route = string.Format(ROUTE, postalCode.OnlyNumbers());

			using (var response = await client.GetAsync(route))
			{
				var _response = await response.Content.ReadAsStringAsync();
				var deserializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
				var apiResponse = JsonSerializer.Deserialize<ApiAddressResponse>(_response, deserializerOptions);

				return Convert(apiResponse);
			}
		}

		#region DOcumentation

		/// <summary>
		/// ApiAddressResponse is a model based in the ViaCep API return.
		/// </summary>
		/// <param name="apiResponse">API response casted as ApiAddressResponse.</param>
		/// <returns>The converted ApiAddressResponse to Domain.Address.</returns>

		#endregion DOcumentation

		private Address Convert(ApiAddressResponse apiResponse)
		{
			return new Address()
			{
				Burgh = apiResponse.Bairro,
				City = apiResponse.Localidade,
				State = apiResponse.UF,
				Street = apiResponse.Logradouro
			};
		}

		#endregion Methods
	}
}