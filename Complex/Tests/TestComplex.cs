using ComplexApp.Complex;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Complex.Tests
{
    [TestFixture]
    public class TestComplex
    {

        private CancellationTokenSource _cancellationTokenSource;
        private string _hostUri;
        private IWebHost _host;

        [OneTimeSetUp]
        public async Task Startup()
        {

            _cancellationTokenSource = new CancellationTokenSource();

            _hostUri = "http://localhost:8080";

            var task = Task.Run(() =>
            {
                _host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls(_hostUri)
                .UseStartup<TestStartup>()
                .Build();

                _host.Run();

            }, _cancellationTokenSource.Token);

            await Task.Delay(1000);

        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            await _host.StopAsync();

            _cancellationTokenSource.Cancel();
        }

        [Test, Order(0)]
        public async Task ShouldPostAComplexA()
        {

            var request = new PostComplexARequest()
            {
                Request = new ComplexObjectA() { PropA = new[] { ("str1", 1), ("str2", 2), ("str3", 3) } }
            };


            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PostAsync($"{_hostUri}/complexA", httpContent);

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);
        }
    }
}
