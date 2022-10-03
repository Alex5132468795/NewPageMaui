namespace MauiApp1;

public partial class MainPage : ContentPage
{
    
    public MainPage()
	{
		InitializeComponent();
	}
	private async void click(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("nwpg1?input="+Name.Text+"&input1="+source.Text+"&input2="+SecondName.Text+"&input3"+FatherName.Text+"");
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{

	}
}

