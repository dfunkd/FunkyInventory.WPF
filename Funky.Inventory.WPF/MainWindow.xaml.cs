using Funky.Inventory.WPF.Models.Recipes.Enums;
using System.Windows;
using System.Windows.Input;

namespace Funky.Inventory.WPF;

public partial class MainWindow : Window
{
    public List<string> RecipeTypes { get;set; }
    public List<string> MeasurementTypes { get;set; }

    public MainWindow()
    {
        InitializeComponent();

        RecipeTypes = [.. Enum.GetValues(typeof(RecipeType)).Cast<RecipeType>().Select(s => s.ToString()).OrderBy(o => o)];
        MeasurementTypes = [.. Enum.GetValues(typeof(MeasurementType)).Cast<MeasurementType>().Select(s => s.ToString())];
    }

    #region Events
    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        footer.Text = $"© {@DateTime.Now:yyyy} Funky Designs";
    }

    private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);
        DragMove();
    }

    private void OnCloseClick(object sender, RoutedEventArgs e)
        => Close();
    #endregion
}
