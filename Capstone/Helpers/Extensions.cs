using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Helpers
{
    public static class Extensions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if (httpContext.User == null) return string.Empty;

            return httpContext.User.Claims.Single(c => c.Type == "id").Value;
        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

    }
}
