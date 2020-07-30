using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamBase.Controls
{
    class DinamicVisibilityToolbarItem : ToolbarItem
    {
        //params:
        //1) nombre de la propiedad a la que está ligada
        //2) Si queremos que de inicio esté visible o no
        //3) Tipo de la clase en la que se está declarando
        //4) The default value for the property.
        //5) El tipo de binding que se hará
        //6) A delegate to be run when a value is set. This parameter is optional. Default is null.
        //7)A delegate to be run when the value has changed. This parameter is optional. Default is null.
        //8) A delegate to be run when the value will change. This parameter is optional. Default is null.
        //9) A delegate used to coerce the range of a value. This parameter is optional. Default is null.
        //10) A Func used to initialize default value for reference types

        public static BindableProperty IsVisibleProperty = 
            BindableProperty.Create(nameof(IsVisible),
                                    typeof(bool), 
                                    typeof(DinamicVisibilityToolbarItem), 
                                    true,
                                    BindingMode.OneWay,
                                    HandleValidateValueDelegate, 
                                    OnIsVisibleChanged
                                    );

        

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
