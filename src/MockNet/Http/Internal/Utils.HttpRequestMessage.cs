using System.Text;
using System.Threading.Tasks;
using SystemHttpRequestMessage = System.Net.Http.HttpRequestMessage;
using SystemHttpContent = System.Net.Http.HttpContent;

namespace Theorem.MockNet.Http
{
    internal static partial class Utils
    {
        internal static class HttpRequestMessage
        {
            public static async Task<string> ToStringAsync(SystemHttpRequestMessage request)
            {
                var sb = new StringBuilder()
                    .AppendLine($"{request.Method} {request.RequestUri.PathAndQuery}")
                    .AppendHeaders(request.Headers)
                    .AppendHeaders(request.Content?.Headers)
                    .AppendLine();

                if (request.Content is SystemHttpContent)
                {
                    var content = await request.Content?.ReadAsStringAsync();

                    sb.AppendContent(content);
                }

                return sb.TrimEnd().ToString();
            }
        }
    }
}
