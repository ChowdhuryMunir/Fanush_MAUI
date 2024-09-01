using FanushMobileApp.Models;
using FanushMobileApp.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace FanushMobileApp
{
    public partial class MainPage : ContentPage
    {
        public JobPostingService JobPostingService { get; set; }
        public List<JobPosting> JobPostingList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            JobPostingService = new JobPostingService();
            JobPostingList = new List<JobPosting>();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            activityIndicator.IsRunning = true;
            JobPostingList = await JobPostingService.GetAllJobPosting();
            activityIndicator.IsRunning = false;
            if (JobPostingList != null)
            {
                jobPostingData.ItemsSource = JobPostingList.ToList();
            }
            jobPostingData.SelectedItem = null;
        }

        private void btnDeleteJobPosting_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEditJobPosting_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAddJobPosting_Clicked(object sender, EventArgs e)
        {

        }
    }

}
