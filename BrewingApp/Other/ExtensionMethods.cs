﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using BrewingApp.Models;

namespace BrewingApp.Other
{
    public static class ExtensionMethods
    {

        public static void AddRange<T>(this ObservableCollection<T> target, ObservableCollection<T> range)
        {
            foreach (T rec in range)
            {
                target.Add( rec );
            }
        }
    }
}