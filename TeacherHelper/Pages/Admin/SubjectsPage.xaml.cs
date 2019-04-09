﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeacherHelper.ViewModels.Admin;

namespace TeacherHelper.Pages.Admin
{
    /// <summary>
    /// Interaction logic for SubjectsPage.xaml
    /// </summary>
    public partial class SubjectsPage : Page
    {
        public SubjectsPage()
        {
            InitializeComponent();
            this.DataContext = new SubjectsPageViewModel();
        }
    }
}
