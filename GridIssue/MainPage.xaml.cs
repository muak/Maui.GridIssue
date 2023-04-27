namespace GridIssue;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        mainLabel.Text = @"2Columns / RowHeight Default BR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextEnd";

        mainLabel2.Text = @"2Columns / RowHeight Auto BR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextEnd";

        mainLabel3.Text = @"1Column BR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextBR
TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextEnd";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        

        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}


