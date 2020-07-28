using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamBase.Controls
{
    class DinamicVisibilityToolbarItem : ToolbarItem
    {
        public static BindableProperty IsVisibleProperty = BindableProperty.Create(nameof(IsVisible),
            typeof(bool), typeof(DinamicVisibilityToolbarItem), true, BindingMode.OneWay,
            HandleValidateValueDelegate, OnIsVisibleChanged);

        

        public bool IsVisible 
        {
            get => (bool)GetValue(IsVisibleProperty);
            set => SetValue(IsVisibleProperty, value);
        }

        private static void OnIsVisibleChanged
            (BindableObject bindable, object oldValue, object newValue)
        {
            var item = bindable as DinamicVisibilityToolbarItem;
            if (oldValue != newValue && item.Parent != null)
            {
                var items = ((ContentPage)item.Parent).ToolbarItems;
                if((bool)newValue && !items.Contains(item))
                {
                    items.Add(item);
                }
                else if(!(bool)newValue && items.Contains(item))
                {
                    items.Remove(item);
                }    
            }

            
        }

        private static bool HandleValidateValueDelegate(BindableObject bindable, object newValue)
        {
            return (newValue is bool);
        }

        public DinamicVisibilityToolbarItem()
        {

        }
     }
}
