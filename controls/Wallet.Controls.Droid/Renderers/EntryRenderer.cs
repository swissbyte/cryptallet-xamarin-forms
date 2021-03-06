﻿/*
 * Copyright 2018 NAXAM CO.,LTD.
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */ 
using System;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Xamarin.Forms;
using Wallet.Controls.Droid.Renderers;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace Wallet.Controls.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public static void Preserve() { }

        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            UpdateBackground();
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Entry.BackgroundColorProperty.PropertyName)
            {
                UpdateBackground();
            }
        }

        void UpdateBackground()
        {
            if (Control == null || Element == null) return;

            Control.SetBackgroundResource(Resource.Drawable.bg_edittext);
            int padding = (int)Context.ToPixels(16);
            Control.SetPadding(padding, padding, padding, padding);
        }
    }
}
