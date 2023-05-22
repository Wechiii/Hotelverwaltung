using WebApplicationHotel.ViewModels;

namespace WebApplicationHotel.Views;

public partial class InsertGuestView : ContentPage
{
    private InsertGuestViewModel insertGuest = new InsertGuestViewModel();
	public InsertGuestView()
	{
        InitializeComponent();
        this.BindingContext = insertGuest;
    }

}