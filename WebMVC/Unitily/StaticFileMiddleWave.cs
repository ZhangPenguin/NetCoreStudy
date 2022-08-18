namespace WebMVC.Unitily
{
    public class StaticFileMiddleWave
    {
        private readonly RequestDelegate _next; 
        public StaticFileMiddleWave(RequestDelegate next)
        {
            _next = next;   
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            Console.WriteLine("before");
            await _next.Invoke(httpContext);
            Console.WriteLine("after");
        }

    }
}
