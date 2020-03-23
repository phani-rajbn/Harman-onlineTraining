using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class WebApiClient
    {
        static async Task Main()
        {
            using(var client = new HttpClient())
            {
                var task = client.GetAsync("http://localhost:24183/api/Employee");
                var res = await task;
                Task<string> data = res.Content.ReadAsStringAsync();
                Console.WriteLine(data.Result);
                Console.ReadKey();
            }
        }
    }
}
