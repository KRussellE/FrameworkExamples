using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkExamples.NetStandard2
{
    public static class HttpRequestExtenstions
    {
        public static string GetReferrer(this HttpRequest request)
        {
            string referer = request.Headers["GET"];

            if (referer == null)
            {
                return null;
            }

            return referer;

        }
    }
}
