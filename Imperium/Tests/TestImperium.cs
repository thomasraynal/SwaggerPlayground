﻿using Microsoft.AspNetCore.Hosting;
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Imperium.Tests
{
    public class TestImperium
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
        public async Task ShouldHandleHeaderModelBinding()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("CRACKER_API_KEY", "this is my key");
            var httpResponseMessage = await client.GetAsync($"{_hostUri}/api/cracker/cards");

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);

        }

    }
}
