using Microsoft.Maui.Controls;

namespace MauiApp1;
[QueryProperty(nameof(IM), "input1")]
[QueryProperty(nameof(STR), "input")]
[QueryProperty(nameof(ST), "input2")]
[QueryProperty(nameof(TSR), "input3")]
public partial class NewPage1 : ContentPage
{
    public string IM
    {
        set
        {
            image.Source = value;
        }
    }
    public string STR
    {
        set
        {
            name.Text += value;
        }
    }
    public string ST
    {
        set
        {
            secondName.Text += value;
        }
    }
    public string TSR
    {
        set
        {
            fatherName.Text += value;
        }
    }

    public NewPage1()
	{
		InitializeComponent();
	}
}