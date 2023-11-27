using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

            InitializeComponent();
        }
            
        private void OnCounterClicked(object sender, EventArgs e)
        {
            //this.Resources.Remove("Resources/Styles/mystyles.css");
            Application.Current.Resources.Clear();
            Application.Current.Resources.Add(StyleSheet.FromResource
           ("Resources/Styles/mystyles.css", IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            //this.Resources.Remove("Resources/Styles/mystyles.css");
            Application.Current.Resources.Clear();
            Application.Current.Resources.Add(StyleSheet.FromResource
           ("Resources/Styles/mystyles2.css", IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            this.Resources.Clear();
            Resources.MergedDictionaries.Clear();
            Resources.Clear();
            Application.Current.Resources.Clear();

            // Очистите содержимое страницы
        }


    }

}
