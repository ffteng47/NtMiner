﻿using NTMiner.Views;
using NTMiner.Vms;
using System.Windows;

namespace NTMiner {
    public partial class App : Application {
        public App() {
            Logger.Disable();
            Write.Disable();
            VirtualRoot.SetOut(NotiCenterWindowViewModel.Instance);
            AppUtil.Init(this);
            InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e) {
            NotiCenterWindow.Instance.ShowWindow();
            MainWindow = new MainWindow();
            MainWindow.Show();
            VirtualRoot.StartTimer(new WpfTimer());
            base.OnStartup(e);
        }
    }
}
