using System.Text.Json;
using Tesera.Types;

namespace Tesera
{
	public  class TeseraClient
	{
		readonly HttpClient _httpClient;
		readonly JsonSerializerOptions _jsonSerializerOptions = new() { IncludeFields = true, PropertyNameCaseInsensitive = true };

		public TeseraClient(HttpClient? httpClient) => _httpClient = httpClient ?? new();
		public TeseraClient() : this(null) { }

		public T? Get<T>(string requestUri, JsonSerializerOptions? jsonSerializerOptions = null)
		{
			using Task<Stream> task = _httpClient.GetStreamAsync(requestUri);
			return JsonSerializer.Deserialize<T>(task.Result, jsonSerializerOptions ?? _jsonSerializerOptions);
		}

		public T? Get<T>(UriGetRequest<T> uriGetRequest) => this.Get<T>(uriGetRequest.GetUri());

		public async Task<T?> GetAsync<T>(string requestUri, JsonSerializerOptions? jsonSerializerOptions = null)
		{
			using Stream stream = await _httpClient.GetStreamAsync(requestUri);
			return JsonSerializer.Deserialize<T>(stream, jsonSerializerOptions ?? _jsonSerializerOptions);
		}

		public async Task<T?> GetAsync<T>(UriGetRequest<T> uriGetRequest) => await this.GetAsync<T>(uriGetRequest.GetUri());
	}
}