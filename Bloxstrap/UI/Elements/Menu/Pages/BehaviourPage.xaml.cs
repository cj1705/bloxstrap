﻿using Bloxstrap.UI.ViewModels.Menu;

namespace Bloxstrap.UI.Elements.Menu.Pages
{
    /// <summary>
    /// Interaction logic for BehaviourPage.xaml
    /// </summary>
    public partial class BehaviourPage
    {
        public BehaviourPage()
        {
            DataContext = new BehaviourViewModel();
            InitializeComponent();
        }
    }
}
