﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace Essentials.Sample
{
    public partial class MainPage : ReactiveMasterDetailPage<MainViewModel>
    {
        public MainPage(MainViewModel viewModel)
        {
            ViewModel = viewModel;

            InitializeComponent();

            this.WhenActivated(
                disposables =>
                {
                    this
                        .OneWayBind(ViewModel, vm => vm.MenuItems, v => v.MyListView.ItemsSource)
                        .DisposeWith(disposables);
                    this
                        .Bind(ViewModel, vm => vm.Selected, v => v.MyListView.SelectedItem)
                        .DisposeWith(disposables);
                    this
                        .WhenAnyValue(x => x.ViewModel.Selected)
                        .Where(x => x != null)
                        .Subscribe(
                            _ =>
                            {
                                // Deselect the cell.
                                MyListView.SelectedItem = null;
                                // Hide the master panel.
                                IsPresented = false;
                            })
                        .DisposeWith(disposables);
                });
        }
    }
}
