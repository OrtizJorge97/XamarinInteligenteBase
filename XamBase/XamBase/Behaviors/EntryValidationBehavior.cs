using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamBase.Model.Helpers;

namespace XamBase.Behaviors
{
    //Repasar bien este pedo alv :'v porque no le entiendo alachingada :'v
    class EntryValidationBehavior : Behavior<Entry>
    {
        static readonly BindablePropertyKey IsValidPropertyKey =
        BindableProperty.CreateReadOnly
            (nameof(IsValid), typeof(bool), typeof(EntryValidationBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;
        /// <summary>
        /// 
        /// </summary>
        static readonly BindableProperty ValidationTypeProperty =
        BindableProperty.Create(nameof(ValidationType), typeof(ValidationType), typeof(EntryValidationBehavior), ValidationType.None);

        public ValidationType ValidationType
        {
            get { return (ValidationType)base.GetValue(ValidationTypeProperty); }
            set { base.SetValue(ValidationTypeProperty, value); }
        }
        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            //BindingContext = bindable.BindingContext; //Asignar el binding context al behavior
            bindable.BindingContextChanged += Bindable_BindingContextChanged;
            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            var entry = sender as Entry;
            BindingContext = entry.BindingContext;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            BindingContext = null;
            bindable.TextChanged -= Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = sender as Entry;
            IsValid = ValidationHelpers.ValidateString(ValidationType, entry.Text);
            entry.TextColor = IsValid ? Color.Black : Color.Red;
        }

        public EntryValidationBehavior()
        {

        }
    }
}
