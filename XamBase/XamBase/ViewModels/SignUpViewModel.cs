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
            //Device.StartTimer(TimeSpan.FromSeconds(10), () => IsBusy = !IsBusy);
        }

        private bool isValidEmail;

        public bool IsValidEmail
        {
            get => isValidEmail;
            set
            {
                SetProperty(ref isValidEmail, value);
                ValidateAll();
            }
        }

        private bool isValidPhoneNumber;

        public bool IsValidPhoneNumber
        {
            get => isValidPhoneNumber;
            set
            {
                SetProperty(ref isValidPhoneNumber, value);
                ValidateAll();
            }
        }

        private bool isValidPassword;
        public bool IsValidPassword
        {
            get => isValidPassword;
            set
            {
                SetProperty(ref isValidPassword, value);
                ValidateAll();
            }
        }

        private bool isValid;
        public bool IsValid
        {
            get => isValid;
            set => SetProperty(ref isValid, value);
        }


        private User user;

        public User User
        {
            get => user; 
            set => SetProperty(ref user, value); 
        }

        private void CleanData()
        {
            User.Name = string.Empty;
            User.Password = string.Empty;
            User.PhoneNumber = string.Empty;
            User.Address = string.Empty;
            User.Email = string.Empty;
        }

        private void ValidateAll() => IsValid = IsValidEmail && IsValidPassword && IsValidPhoneNumber;

        private void CreateUser()
        {
            IsBusy = true;
        }

    }
}
