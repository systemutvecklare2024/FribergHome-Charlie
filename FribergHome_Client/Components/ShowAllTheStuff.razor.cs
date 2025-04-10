
using System.Net.Http.Json;
using FribergHome_Client.Services;
using FribergHome_Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace FribergHome_Client.Components
{
	public partial class ShowAllTheStuff
	{
		public IEnumerable<PropertyDTO> _properties { get; set; } = [];
		[Inject] public HttpClient HttpClient { get; set; }
		protected override async Task OnInitializedAsync()
		{

			await base.OnInitializedAsync();
			_properties = await HttpClient.GetFromJsonAsync<IEnumerable<PropertyDTO>>("api/Properties");
		}
	}
}
