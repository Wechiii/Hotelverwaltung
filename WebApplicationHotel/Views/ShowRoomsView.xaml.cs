using WebApplicationHotel.ViewModels;

namespace WebApplicationHotel.Views;

public partial class ShowRoomsView : ContentPage
{
	private ShowRoomsViewModel showRooms= new ShowRoomsViewModel();
	public ShowRoomsView()
	{
		InitializeComponent();
		this.BindingContext = showRooms;
	}
}