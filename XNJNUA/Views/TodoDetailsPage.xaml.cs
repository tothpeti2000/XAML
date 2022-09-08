﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XNJNUA.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace XNJNUA.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TodoDetalsPage : Page
    {
        public TodoItem Todo { get; set; }
        public IEnumerable<Priority> PriorityDisplayNames 
        {
            get => Enum.GetValues(typeof(Priority)).Cast<Priority>();
        }

        public TodoDetalsPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }
    }
}
