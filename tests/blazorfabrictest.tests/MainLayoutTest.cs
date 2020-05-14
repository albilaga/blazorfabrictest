using BlazorFabric;
using blazorfabrictest.Client.Shared;
using Bunit;
using Bunit.Mocking.JSInterop;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace blazorfabrictest.tests
{
    public class MainLayoutTest : ComponentTestFixture
    {
        [Fact]
        public void Test1()
        {
            Services.AddBlazorFabric();
            Services.AddMockJsRuntime();
            Services.AddOptions()
                .AddAuthorizationCore()
                .AddLogging()
                .AddSingleton<SignOutSessionStateManager>();
                //.AddSingleton<AuthenticationStateProvider>();
            var mainLayout = RenderComponent<MainLayout>();
        }
    }
}
