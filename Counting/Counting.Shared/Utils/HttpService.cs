﻿using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Counting.Shared.Utils;

public static class HttpService
{
    private static readonly HttpClient Client = GetHttpClient();

    private static HttpClient GetHttpClient()
    {
        var handler = new HttpClientHandler
        {
            ClientCertificateOptions = ClientCertificateOption.Manual,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
        var client = new HttpClient(handler);

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        client.Timeout = TimeSpan.FromSeconds(600);

        return client;
    }

    public static async Task<T?> PostAsync<T>(string url, object? body, string type = "application/json")
    {
        HttpContent content = new StringContent(JsonConvert.SerializeObject(body ?? new {}));
        content.Headers.ContentType = new MediaTypeHeaderValue(type);
        var res = await Client.PostAsync(url, content);
        var str = await res.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(str);
    }

    public static async Task<string> GetAsync(string url)
    {
        var res = await Client.GetAsync(url);
        return await res.Content.ReadAsStringAsync();
    }
}
