using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodieApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeListPage : ContentPage
	{
		public RecipeListPage ()
		{
			InitializeComponent ();
            lstFoodie.ItemsSource = RecipeData.AllRecipesGrouped;
            
		}
	}
}