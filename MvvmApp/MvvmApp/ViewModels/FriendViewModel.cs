using MvvmApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmApp.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        FriendsListViewModel lvm;

        public Friend Friend { get; private set; }

        public FriendViewModel()
        {
            Friend = new Friend();
        }

        public FriendsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Friend.Name; }
            set
            {
                if (Friend.Name != value)
                {
                    Friend.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Second
        {
            get { return Friend.Second; }
            set
            {
                if (Friend.Second != value)
                {
                    Friend.Second = value;
                    OnPropertyChanged("Second");
                }
            }
        }
        public string Email
        {
            get { return Friend.Email; }
            set
            {
                if (Friend.Email != value)
                {
                    Friend.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string Phone
        {
            get { return Friend.Phone; }
            set
            {
                if (Friend.Phone != value)
                {
                    Friend.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }
        public string Birthday
        {
            get { return Friend.Birthday; }
            set
            {
                if (Friend.Birthday != value)
                {
                    Friend.Birthday = value;
                    OnPropertyChanged("Birthday");
                }
            }
        }
        public string Age
        {
            get { return Friend.Age; }
            set
            {
                if (Friend.Age != value)
                {
                    Friend.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
        public string Work
        {
            get { return Friend.Work; }
            set
            {
                if (Friend.Work != value)
                {
                    Friend.Work = value;
                    OnPropertyChanged("Work");
                }
            }
        }
        public string Description
        {
            get { return Friend.Description; }
            set
            {
                if (Friend.Description != value)
                {
                    Friend.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Name.Trim()) ||
                    !string.IsNullOrEmpty(Second.Trim()) ||
                    !string.IsNullOrEmpty(Phone.Trim()) ||
                    !string.IsNullOrEmpty(Email.Trim()) ||
                    !string.IsNullOrEmpty(Birthday.Trim()) ||
                    !string.IsNullOrEmpty(Age.Trim()) ||
                    !string.IsNullOrEmpty(Work.Trim());
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}