using Microsoft.Maui.Controls;

namespace AlignmentExplorer;

public partial class MainPage : ContentPage
{
    private Frame _demoFrame;

    public MainPage()
    {
        InitializeComponent();

        // Находим синий прямоугольник по имени
        _demoFrame = this.FindByName<Frame>("DemoFrame");
    }

    // Горизонтальное выравнивание
    private void OnHorizontalStart(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.HorizontalOptions = LayoutOptions.Start;
    }

    private void OnHorizontalCenter(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.HorizontalOptions = LayoutOptions.Center;
    }

    private void OnHorizontalEnd(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.HorizontalOptions = LayoutOptions.End;
    }

    private void OnHorizontalFill(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.HorizontalOptions = LayoutOptions.Fill;
    }

    // Вертикальное выравнивание
    private void OnVerticalStart(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.VerticalOptions = LayoutOptions.Start;
    }

    private void OnVerticalCenter(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.VerticalOptions = LayoutOptions.Center;
    }

    private void OnVerticalEnd(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.VerticalOptions = LayoutOptions.End;
    }

    private void OnVerticalFill(object sender, EventArgs e)
    {
        if (_demoFrame != null)
            _demoFrame.VerticalOptions = LayoutOptions.Fill;
    }
}