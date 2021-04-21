using Domain;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cadaster.UI
{
	public class AddressController
	{
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
			var route = string.Format(ROUTE, OnlyNumbers(postalCode));

			using (var response = await client.GetAsync(route))
			{
				var _response = await response.Content.ReadAsStringAsync();
				var deserializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

				return JsonSerializer.Deserialize<Address>(_response, deserializerOptions);
			}
		}

		private string OnlyNumbers(string postalCode)
		{
			return Regex.Replace(postalCode, @"\D+", string.Empty);
		}

		#endregion Methods
	}
}