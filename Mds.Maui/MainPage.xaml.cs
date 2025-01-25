namespace Mds.Maui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Battery.BatteryInfoChanged += this.Battery_BatteryInfoChanged;

        this.DisplayInfo(Battery.State, Battery.ChargeLevel);

    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            this.CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void DisplayInfo(BatteryState state, double chargeLevel)
    {
        BatteryInfoLabel.Text = state switch
        {
            BatteryState.Charging => "Battery is currently charging",
            BatteryState.Discharging => "Charger is not connected and the battery is discharging",
            BatteryState.Full => "Battery is full",
            BatteryState.NotCharging => "The battery isn't charging.",
            BatteryState.NotPresent => "Battery is not available.",
            BatteryState.Unknown => "Battery is unknown",
            _ => "Battery is unknown"
        };

        BatteryLevelLabel.Text = $"Battery is {chargeLevel * 100}% charged.";
    }

    private void Battery_BatteryInfoChanged(object? sender, BatteryInfoChangedEventArgs e)
    {
        this.DisplayInfo(e.State, e.ChargeLevel);
    }

    private void VibrateStartButton_Clicked(object sender, EventArgs e)
    {
        int secondsToVibrate = Random.Shared.Next(1, 7);
        TimeSpan vibrationLength = TimeSpan.FromSeconds(secondsToVibrate);

        Vibration.Default.Vibrate(vibrationLength);
    }

    private void VibrateStopButton_Clicked(object sender, EventArgs e) =>
        Vibration.Default.Cancel();
}

