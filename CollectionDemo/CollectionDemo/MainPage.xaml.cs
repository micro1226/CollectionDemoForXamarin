using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionDemo
{
    public class TestModel
    {
        public string Name { get; set; }
    }

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var array = new List<TestModel>();
            array.Add(new TestModel { Name = "first" });

            //uncomment lines below, it works fine
            array.Add(new TestModel { Name = "second" });
            array.Add(new TestModel { Name = "third" });
            array.Add(new TestModel { Name = "four" });
            CollectionView.ItemsSource = array;
        }
    }
}
