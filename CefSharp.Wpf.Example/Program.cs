// Copyright © 2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Windows;

namespace CefSharp.Wpf.Example
{
    public static class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            try
            {
                var application = new App();
                application.InitializeComponent();
                return application.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
    }
}
