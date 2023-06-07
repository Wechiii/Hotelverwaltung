using WebApplicationHotel.ViewModels;

namespace WebApplicationHotel.Views;

public partial class BookingView : ContentPage
{
    private BookingViewModel booking = new BookingViewModel();
    public BookingView()
    {
        InitializeComponent();
        this.BindingContext = booking;
    }
}