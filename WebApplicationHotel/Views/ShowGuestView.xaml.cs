using WebApplicationHotel.ViewModels;

namespace WebApplicationHotel.Views;

public partial class ShowGuestView : ContentPage
{
    private ShowGuestViewModel showGuests = new ShowGuestViewModel();
    public ShowGuestView()
    {
        InitializeComponent();
        this.BindingContext = showGuests;
    }
}