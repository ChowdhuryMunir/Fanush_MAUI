using FanushMobileApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanushMobileApp.Services
{
    public class JobPostingService
    {
        private string baseUrl { get; set; }
        public JobPostingService()
        {
            baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5041/api/JobPosting/" : "http://10.0.2.2:5041/api/JobPosting/";


        }

        public async Task<List<JobPosting>> GetAllJobPosting()
        {
            try
            {
                List<JobPosting> jobPostingList = new List<JobPosting>();
                string url = baseUrl + "GetAllJobPosting";
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                client.Timeout = TimeSpan.FromSeconds(30);
                HttpResponseMessage httpResponseMessage = await client.GetAsync("");
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string contentMessage = await httpResponseMessage.Content.ReadAsStringAsync();
                    jobPostingList = JsonConvert.DeserializeObject<List<JobPosting>>(contentMessage);
                }
                return await Task.FromResult(jobPostingList.ToList());

            }
            catch (Exception)
            {
                return null;

            }



        }
    }
}
