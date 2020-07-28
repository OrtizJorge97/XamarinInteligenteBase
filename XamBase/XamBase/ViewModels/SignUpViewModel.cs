using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamBase.Model.BaseTypes;
using XamBase.Model.Entities;

namespace XamBase.ViewModels
{
    class SignUpViewModel : BaseViewModel
    {
        public SignUpViewModel()
        {
            Title = "Nuevo Usuario";
            User = new User();
            Device.StartTimer(TimeSpan.FromSeconds(10), () => IsBusy = !IsBusy);
        }

        private User user;

        public User User
        {
            get => user; 
            set => SetProperty(ref user, value); 
        }

    }
}
