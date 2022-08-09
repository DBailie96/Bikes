using Bikes.Services;
using Entities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace Bikes.Pages
{
    public partial class Index
    {
        bool isLoading;
        List<Bike> bikesList = new();

        int windowWidth;
        int windowHeight;

        [Inject]
        public IBikeDataService BikeDataService { get; set; }

        [Inject]
        public BrowserService browserService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            bikesList = await BikeDataService.GetBikes();
            var dimensions = await browserService.GetDimensions();

            windowWidth = dimensions.Width;
            windowHeight = dimensions.Height;
        }
    }

}
