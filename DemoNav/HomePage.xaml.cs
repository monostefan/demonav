using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoNav
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var defaultAction = new Command(async () =>
            {
                await this.DisplayAlert("Hallo", "Burim", "Voll nöd");
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Contacts",
                Icon = "contacts.png",
                Command = defaultAction
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Reminder",
                Icon = "reminders.png",
                Command = defaultAction
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Todo",
                Icon = "todo.png",
                Command = defaultAction
            });
        }
    }
}

