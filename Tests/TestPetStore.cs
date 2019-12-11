using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using NUnit.Framework;
using SwaggerPlayground.Modules.PetStore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Tests
{
    [TestFixture]
    public class TestPetStore
    {
        [Test]
        public async Task CreateApiHostAndFetchSomePets()
        {
            var builder = new WebHostBuilder().UseStartup<TestStartup>();

            using (var server = new TestServer(builder))
            {
                using (var client = server.CreateClient())
                {
                    var pet = new Pet()
                    {
                        Category = new Category() { Id = 0, Name = "Dog" },
                        Name = "Choupette",
                        Id = 0,
                    };

                    var httpContent = new StringContent(JsonConvert.SerializeObject(pet), Encoding.UTF8, "application/json");

                    //await client.PutAsync("/pet", ,)



                }
            }
        }
    }
}
