﻿using Avalonia.FuncUI.DSL;
using System;

namespace Stride.Editor.Presentation.VirtualDom.Controls
{
    public class CheckBox : ViewBuilder<Avalonia.Controls.CheckBox>
    {
        public bool IsVisible
        {
            set { Property(Avalonia.Controls.CheckBox.IsVisibleProperty, value); }
        }

        public bool IsEnabled
        {
            set { Property(Avalonia.Controls.CheckBox.IsEnabledProperty, value); }
        }

        public Action<bool> OnEnabled
        {
            set { Subscribe(Avalonia.Controls.CheckBox.IsEnabledProperty, value, SubPatchOptions.Always); }
        }

        public bool? IsChecked
        {
            set { Property(Avalonia.Controls.CheckBox.IsCheckedProperty, value); }
        }

        public Action<bool?> OnChecked
        {
            set { Subscribe(Avalonia.Controls.CheckBox.IsCheckedProperty, value, SubPatchOptions.Always); }
        }
    }
}
