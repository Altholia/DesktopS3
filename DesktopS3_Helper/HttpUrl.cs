namespace DesktopS3_Helper;

public class HttpUrl
{
    private static readonly string _url = "https://localhost:5001/api/Desktop";

    /// <summary>
    /// Post请求
    /// </summary>
    /// <param name="uri">请求地址</param>
    /// <param name="body">请求体</param>
    /// <returns>返回请求结果</returns>
    public static async Task<HttpResponseMessage> HttpPost(string uri,string body)
    {
        try
        {
            using var client = new HttpClient();

            HttpContent content = new StringContent(body);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string url = _url + uri;
            HttpResponseMessage response = await client.PostAsync(url, content);

            return response;
        }
        catch (HttpRequestException e)
        {
            await Console.Error.WriteLineAsync(e.Message);
            return null!;
        }

    }

    /// <summary>
    /// HTTP的Get请求
    /// </summary>
    /// <param name="uri">请求地址</param>
    /// <returns></returns>
    public static async Task<HttpResponseMessage> HttpGet(string uri)
    {
        try
        {
            using HttpClient client = new();

            string url = _url + uri;
            var response = await client.GetAsync(url);

            return response;
        }
        catch (HttpRequestException e)
        {
            await Console.Error.WriteLineAsync(e.Message);
            return null!;
        }
    }
}