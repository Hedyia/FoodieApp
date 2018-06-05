namespace FoodieApp
{
    using Xamarin.Forms;
    public class RequiredValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = string.IsNullOrEmpty(sender.Text) ? Color.FromHex("#FFCDD2") : Color.Default;
        }
    }
}
