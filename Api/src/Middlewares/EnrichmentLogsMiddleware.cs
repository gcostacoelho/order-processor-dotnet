using System.Diagnostics;
using Serilog.Context;

namespace Api.src.Middlewares;

public class EnrichmentLogsMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task Invoke(HttpContext context)
    {
        using (LogContext.PushProperty("TraceId", Activity.Current?.TraceId.ToString()))
        using (LogContext.PushProperty("SpanId", Activity.Current?.SpanId.ToString()))
        {
            await _next(context);
        }
    }
}
