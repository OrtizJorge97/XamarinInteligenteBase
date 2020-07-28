﻿using System;
using System.Collections.Generic;
using System.Text;
using XamBase.Model.BaseTypes;

namespace XamBase.Model.Entities
{
    /*
     - Name
- Address
- PhoneNumber - Email
- Password*/

    public enum LoginStatus
    {
        Ok,
        UserPasswordError,
        Blocked,
        Logout,
        Error
    }
    public class User : ObservableObject
    {
        private string name;

        public string Name
        {
            get => name; 
            set => SetProperty(ref name, value);
        }

        private string address;

        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get => phoneNumber; 
            set => SetProperty(ref phoneNumber, value); 
        }

        private string email;

        public string Email
        {
            get => email; 
            set => SetProperty(ref email, value); 
        }

        private string password;

        public string Password
        {
            get => password; 
            set => SetProperty(ref password, value); 
        }

        public LoginStatus Login()
        {
            return LoginStatus.Ok;
        }




    }
}
