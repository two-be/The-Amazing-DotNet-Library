using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace Softveloper.Extensions
{
    public static class HttpRequestExtendsions
    {
        public static string GetStringValue(this HttpRequest request, string key)
        {
            StringValues values = string.Empty;
            var success = request.Form.TryGetValue(key, out values);
            if (success)
            {
                var value = string.Join(string.Empty, values);
                return value;
            }
            return string.Empty;
        }
    }
}
