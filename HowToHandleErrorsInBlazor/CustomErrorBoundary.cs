using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HowToHandleErrorsInBlazor
{
    public class CustomErrorBoundary : ErrorBoundary
    {
        [Inject]
        private IWebAssemblyHostEnvironment Environment { get; set; }

        protected override Task OnErrorAsync(Exception exception)
        {
            if (Environment.IsDevelopment())
                return base.OnErrorAsync(exception);
            else
                return Task.CompletedTask;
        }
    }
}
