using System.Collections.ObjectModel;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Playlist> Playlists { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Playlists = new ObservableCollection<Playlist>
        {
            new Playlist { Title = "Top Hits 2024", Image = "spotify1.jpg" },
            new Playlist { Title = "Workout Mix", Image = "spotify2.jpg" },
            new Playlist { Title = "Chill Vibes", Image = "spotify3.jpg" }
        };

        BindingContext = this;
    }
}

public class Playlist
{
    public string Title { get; set; }
    public string Image { get; set; }
}
