using System.Text.Json;
using Tesera.Types;

namespace Tesera
{
	public  class TeseraClient
	{
		readonly HttpClient _httpClient;
		readonly JsonSerializerOptions _jsonSerializerOptions = new() { IncludeFields = true, PropertyNameCaseInsensitive = true };

		public TeseraClient(HttpClient? httpClient = null) => _httpClient = httpClient ?? new();

		public T? Get<T>(string requestUri, JsonSerializerOptions? jsonSerializerOptions = null)
		{
			using Task<Stream> task = _httpClient.GetStreamAsync(requestUri);
			return JsonSerializer.Deserialize<T>(task.Result, jsonSerializerOptions ?? _jsonSerializerOptions);
		}

		public T? Get<T>(UriGetRequest<T> uriGetRequest) => this.Get<T>(uriGetRequest.GetUri());
	}
}