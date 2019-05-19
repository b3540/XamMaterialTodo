﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamMaterialTodo.DataModels;
using XamMaterialTodo.Usecases;

namespace XamMaterialTodo.Presentations.Detail
{

    public partial class DetailPage : ContentPage
    {
        private readonly DetailPageViewModel viewModel;

        public DetailPage(TodoUsecase todoUsecase, TodoItem item, bool isNew)
        {
            InitializeComponent();
            viewModel = new DetailPageViewModel(todoUsecase, item, isNew);
            this.BindingContext = viewModel;
            viewModel.ClosePageRequest.Subscribe(async _ => 
            {
                await this.Navigation.PopAsync();
            });
        }
    }
}