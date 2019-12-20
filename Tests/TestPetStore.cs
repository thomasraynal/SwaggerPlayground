using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using NUnit.Framework;
using SwaggerPlayground.Modules.PetStore;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwaggerPlayground.Tests
{
    //todo: handle - allowEmptyValue: true
    //todo: handle - default: 20
    //todo: handle - minimum: 1

    //todo: set x-product properties

    [TestFixture]
    public class TestPetStore
    {
        private CancellationTokenSource _cancellationTokenSource;
        private string _hostUri;
        private IWebHost _host;

        //private TestServer _server;
        //private HttpClient _client;

        [OneTimeSetUp]
        public void Startup()
        {
            //https://github.com/NancyFx/Nancy/issues/2997
            //var builder = new WebHostBuilder().UseStartup<TestStartup>();
            //_server = new TestServer(builder)
            //{
            //    AllowSynchronousIO = true
            //};
            //_client = _server.CreateClient();

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

        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            await _host.StopAsync();

            _cancellationTokenSource.Cancel();

            //if (null != _server) _server.Dispose();
            //if (null != _client) _client.Dispose();
        }

        [Test, Order(0)]
        public async Task ShouldPutAPet()
        {
            var pet = new Pet()
            {
                Category = new Category() { Id = 0, Name = "Dog" },
                Name = "Choupette",
                Id = 0,
                Status = Status.Available,
                Tags = new[] { new Tag() { Id = 0, Name = "Pretty" }, new Tag() { Id = 0, Name = "Ferocious" } }.ToList(),
                PhotoUrls = new[] { "http://somewhere.com/this.img" }
            };

            var request = new AddPetRequest()
            {
                Body = pet
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PostAsync($"{_hostUri}/v2/pet", httpContent);

            Assert.AreEqual(HttpStatusCode.Created, httpResponseMessage.StatusCode);
            Assert.AreEqual(request.Body, JsonConvert.DeserializeObject<Pet>(await httpResponseMessage.Content.ReadAsStringAsync()));
        }

        [Test, Order(1)]
        public async Task ShouldTryToPutAPetAndFailWithBadRequestOuterProperty()
        {
            var request = new AddPetRequest()
            {
                Body = null
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PostAsync($"{_hostUri}/v2/pet", httpContent);

            Assert.AreEqual(HttpStatusCode.BadRequest, httpResponseMessage.StatusCode);
            Assert.AreEqual("Body : Body is required", JsonConvert.DeserializeObject<string>(await httpResponseMessage.Content.ReadAsStringAsync()));


        }

        [Test, Order(2)]
        public async Task ShouldTryToPutAPetAndFailWithBadRequestInnerProperty()
        {
            var pet = new Pet()
            {
                Category = new Category() { Id = 0, Name = "Dog" },
                Status = Status.Available,
                Tags = new[] { new Tag() { Id = 0, Name = "Pretty" }, new Tag() { Id = 0, Name = "Ferocious" } }.ToList()
            };

            var request = new AddPetRequest()
            {
                Body = pet
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PostAsync($"{_hostUri}/v2/pet", httpContent);

            Assert.AreEqual(HttpStatusCode.BadRequest, httpResponseMessage.StatusCode);
            Assert.AreEqual("Name : 'Name' must not be empty. | Name : Name is required | PhotoUrls : PhotoUrls is required", JsonConvert.DeserializeObject<string>(await httpResponseMessage.Content.ReadAsStringAsync()));


        }

        [Test, Order(3)]
        public async Task ShouldGetAPet()
        {
            var client = new HttpClient();
            var httpResponseMessage = await client.GetAsync($"{_hostUri}/v2/pet/0");

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);

            var pet = JsonConvert.DeserializeObject<Pet>(await httpResponseMessage.Content.ReadAsStringAsync());

            Assert.NotNull(pet);
        }


        [Test, Order(4)]
        public async Task ShouldUpdateAPet()
        {
            var pet = new Pet()
            {
                Name = "Choupette",
                Category = new Category() { Id = 0, Name = "Dog2" },
                Status = Status.Available,
                Tags = new[] { new Tag() { Id = 0, Name = "Pretty" }, new Tag() { Id = 0, Name = "Ferocious" } }.ToList(),
                PhotoUrls = new[] { "http://somewhere.com/this.img" }
            };

            var request = new UpdatePetRequest()
            {
                Body = pet
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PutAsync($"{_hostUri}/v2/pet", httpContent);

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);
        }


        [Test, Order(5)]
        public async Task ShouldTryToUpdateAPetAndFailWithBadRequest()
        {
            var pet = new Pet()
            {
                Category = new Category() { Id = 0, Name = "ThisCategoryIsNotAllowed" },
                Name = "Choupette",
                Id = 0,
                Status = Status.Available,
                Tags = new[] { new Tag() { Id = 0, Name = "Pretty" }, new Tag() { Id = 0, Name = "Ferocious" } }.ToList(),
                PhotoUrls = new[] { "http://somewhere.com/this.img" }
            };

            var request = new UpdatePetRequest()
            {
                Body = pet
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponseMessage = await client.PutAsync($"{_hostUri}/v2/pet", httpContent);

            Assert.AreEqual(HttpStatusCode.BadRequest, httpResponseMessage.StatusCode);
            Assert.AreEqual("Category : Category must be allowed", JsonConvert.DeserializeObject<string>(await httpResponseMessage.Content.ReadAsStringAsync()));
        }

        [Test, Order(6)]
        public async Task ShoulTryGetAPetAndFailWithNotFound()
        {
            var client = new HttpClient();
            var httpResponseMessage = await client.GetAsync($"{_hostUri}/v2/pet/1");

            Assert.AreEqual(HttpStatusCode.NotFound, httpResponseMessage.StatusCode);
            Assert.AreEqual("Pet 1 not found", JsonConvert.DeserializeObject<string>(await httpResponseMessage.Content.ReadAsStringAsync()));
        }

        [Test, Order(7)]
        public async Task ShouldTryToDeleteAPetAndFailWithNotAuthorized()
        {
            var client = new HttpClient();
            var httpResponseMessage = await client.DeleteAsync($"{_hostUri}/v2/pet/0");

            Assert.AreEqual(HttpStatusCode.Unauthorized, httpResponseMessage.StatusCode);

        }

        [Test, Order(8)]
        public async Task ShouldDeleteAPet()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "basic qfsfsfsfsd");
            var httpResponseMessage = await client.DeleteAsync($"{_hostUri}/v2/pet/0");

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);


        }

    }
}
