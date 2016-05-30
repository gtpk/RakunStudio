﻿/************************************************************************

   AvalonDock

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the New BSD
   License (BSD) as published at http://avalondock.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up AvalonDock in Extended WPF Toolkit Plus at http://xceed.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like facebook.com/datagrids

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using Xceed.Wpf.AvalonDock.Controls;
using RakunWin32;

namespace AvalonDock.MVVMTestApp
{
    class PanesStyleSelector : StyleSelector
    {
        public Style ToolStyle
        {
            get;
            set;
        }

        public Style FileStyle
        {
            get;
            set;
        }

        public Style RakunStyle
        {
            get;
            set;
        }

        public override System.Windows.Style SelectStyle(object item, System.Windows.DependencyObject container)
        {
            if (item is ToolViewModel)
                return ToolStyle;

            

            if (item is RakunFileViewModel)
            {
                LayoutDocumentItem test = container as LayoutDocumentItem;
                if (test != null)
                {
                    RakunViewerUserControl doc = new RakunViewerUserControl();
                    test.View.Content = doc;
                }
                (item as RakunFileViewModel).View = test.View.Content as RakunViewerUserControl;

                (item as RakunFileViewModel).AddModule(Workspace.This.RakunManager.startingNode);
                return RakunStyle;
            }

            if (item is FileViewModel)
                return FileStyle;

            return base.SelectStyle(item, container);
        }
    }

}
