   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  E ARakunWin32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RakunWin32
RakunWin32 O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem ?$clr-namespace:AvalonDock.MVVMTestAppAvalonDock.MVVMTestApp    RakunWin32.RakunStudio   HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h	 dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i
 eXceed.Wpf.AvalonDock.Themes.VS2013, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4E
avalonDock,http://schemas.xceed.com/wpf/xaml/avalondock   	 
  X TXceed.Wpf.Toolkit, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  $localclr-namespace:RakunWin32  0Sys&clr-namespace:System;assembly=mscorlib  6MVVMTestApp$clr-namespace:AvalonDock.MVVMTestApp  h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  -   (   "MahApps.Metro.Controls.MetroWindow   Name$  Window�� � Title$ RakunStudio�� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 	Resources 4 .AvalonDock.MVVMTestApp.ActiveDocumentConverter   ActiveDocumentConverter?  9Xceed.Wpf.AvalonDock.Converters.BoolToVisibilityConverter  BoolToVisibilityConverter  RakunNodeReaderTemplate  
Foreground �� Mode �� 
TargetType �� Triggers :� RoutedEvent	 �� TargetProperty
 W� From	 W� To g� Duration��%  &	        &	      &	 
     '�� �         �� .R��� .+��� #���  ���� *
ModuleName+�� $	��ADD��$��75��$��Right=����� *AddModuleCommand+$ OneWay=��� " �� :� $ Loaded��[��� .���� .��W� $	 Opacity�$
 0X�$ 1X�$ 0:0:2D�.��]� -    ]�Name$ dockManager�� � DataContext &  AvalonDock.MVVMTestApp.Workspace  .+�o� $	��Top=�$	��Top=� J� SnapsToDevicePixels . .@�m� $
��File��.@�m� $	��New�� m� Command �� *
NewCommand+�� m� $
��Save�� �� *ActiveDocument.SaveCommand+m� $��
Save As...�� �� *ActiveDocument.SaveAsCommand+�� m� $��Close�� �� *ActiveDocument.CloseCommand+m� $��_Edit��.@�m� $	��Cut��$
��Left=�$��114.66��
�������m� $
��Copy��$
��Left=�$��114.66��
�������m� $��Paste��$
��Left=�$��114.66��
�������m� $��
Select All��$
��Left=�$��114.66��
�������m� $��_Build��.@�m� $��Compile��$
��Left=�$��114.66��
������� �� *ActiveDocument.BuildCommand+$ OneWay=�m� $��Upload��$
��Left=�$��114.66��
������� �� *ActiveDocument.UploadCommand+$ OneWay=�m� -    m�Name$ MIPort��$
��Port��$
��Left=�$��114.66��
�������   RadioButtonResource 	� 	GroupName J� IsHitTestVisible��%7   &	      	� $��Center=�$ MenuItemRadio�� .  ���� " m�.���  �� Property �@m�Icon �� Value# �  -   m� -   $ MIBoundrate��$��	Boundrate��$
��Left=�$��114.66��
������� ��%7   &	      	� $��Center=�$ MenuItemRadio�� .  ���� " m�.���  �@m�Icon# �  -   m� -   $ 	MIDatabit��$��Databit��$
��Left=�$��114.66��
������� ��%7   &	      	� $��Center=�$ MenuItemRadio�� .  ���� " m�.���  �@m�Icon# �  -   m� $��
Programmer��$
��Left=�$��114.66��
�������m� $��_Tools��.@�m� $��
Add Module��$
��Left=�$��114.66��
������� �� *AddModuleCommand+$ OneWay=�m� $��_Window��.@�m� $��Monitor��$
��Left=�$��114.66��
�������m� $��Object Tree��$
��Left=�$��114.66��
��������� -	    ��Name$ 	statusBar��$��Bottom=�$��0q�����  �� Color �� *	Statusbar+.@�]� ��.  ���� *ActualWidth+ �� ElementName$ 	statusBar��.+��� $
��Wrap=�$��0q����� *StatusString+���� # � ����  �� Orientation$ Vertical=�$��Right=�$��0,0,8,0q�.+��� $
��Wrap=�$��Created By Rakun������ # � ��� .+�)  #Xceed.Wpf.AvalonDock.DockingManager  -
     Name$ 
RootLayout��   AllowMixedOrientation . 
���   �$��1q����	#FF2D2D30
�������   AnchorablesSource �� *Tools+   DocumentsSource �� *Files+   ActiveContent �� *ActiveDocument+ �� 	Converter# [  $ TwoWay=�    Theme  1 
 +Xceed.Wpf.AvalonDock.Themes.Vs2013DarkTheme  !!   LayoutItemTemplateSelector! 2 ,AvalonDock.MVVMTestApp.PanesTemplateSelector  "   FileViewTemplate" �� .R��� $��0q�# �� AcceptsReturn# . $ �� TextWrapping$
$ Wrap=����� *TextContent+% �� UpdateSourceTrigger$% PropertyChanged=�&   FileStatsViewTemplate& �� .R��� ' �� Padding$' 5q�._��� $ Vertical=�.+��� ���� *
FileSize+�� ���� *LastModified+�� $
��test��# . $
$ Wrap=�(   RakunFileViewTemplate( �� ')    LayoutItemContainerStyleSelector) / )AvalonDock.MVVMTestApp.PanesStyleSelector  *   	ToolStyle* �� 8	  2Xceed.Wpf.AvalonDock.Controls.LayoutAnchorableItem" 	 .��� .
  (Xceed.Wpf.AvalonDock.Controls.LayoutItem �@
 Title �� *Model.Title+��  �@
 
IconSource �� *Model.IconSource+��  � y� �� *Model.IsVisible+  System.Windows.Visibility+   Hidden, �� ConverterParameter#, Z+ # [ $ TwoWay=���  �@
 	ContentId �� *Model.ContentId+��  �@
 
IsSelected �� *Model.IsSelected+$ TwoWay=���  �@
 IsActive �� *Model.IsActive+$ TwoWay=�-   	FileStyle- �� " 
 .���  �@
 Title �� *Model.Title+��  �@�ToolTip �� *Model.FilePath+��  �@
 CloseCommand �� *Model.CloseCommand+��  �@
 
IconSource �� *Model.IconSource+��  �@
 	ContentId �� *Model.ContentId+.   
RakunStyle. �� " 
 .���  �@
 Title �� *Model.Title+��  �@�ToolTip �� *Model.FilePath+��  �@
 CloseCommand �� *Model.CloseCommand+��  �@
 
IconSource �� *Model.IconSource+��  �@
 	ContentId �� *Model.ContentId+/   LayoutUpdateStrategy/ . (AvalonDock.MVVMTestApp.LayoutInitializer  0   DocumentHeaderTemplate0 �� .R��� $ 
Horizontal=�.+��� $��0,0,4,0q����� *
IconSource+�� ���� *Title+1   Layout.1 ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot  -   _layoutRoot��2   	RootPanel.2 -  'Xceed.Wpf.AvalonDock.Layout.LayoutPanel  3   Orientation$3 
Horizontal=��  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]4   Children.4 6  0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]5   	DockWidth$	5 200 ��  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]6   Children.6 2  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable  /  )Xceed.Wpf.AvalonDock.Layout.LayoutContent7   	ContentId$7 
ModuleList��8   Title$8 Module List��9   CanHide9 .  :   CanClose: .  ;   AutoHideWidth$	; 240Q�<   Content.< �� #���  ���� *RakunManager.ReaderList+9  3Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPaneGroup  �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutDocumentPane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]=   Children.= 4  .Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutContent, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]>   Children.> 0  *Xceed.Wpf.AvalonDock.Layout.LayoutDocument  $7 
QuickStart��$8 
QuickStart��.< &   RakunWin32.QuickStartUserControl  ;  5Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePaneGroup  �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]?   	DockWidth$	? 200 ��  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]@   Children.@   .6   $7 Monitor��$8 Monitor��.< �� -   A ��Name$A Monitor��  $7 
properties��$8 
Properties��9 .  : .  $	; 240Q�.< 1  +Xceed.Wpf.Toolkit.PropertyGrid.PropertyGrid  B   NameColumnWidth$	B 110Q�C   AutoGeneratePropertiesC .  {�.  ���	#FF007ACC���	#FF2D2D30���	#FFF1F1F1D   SelectedObjectD �� *LastFocusedDocument.Content+$ _layoutRoot��E   PropertyDefinitionsE 7  1Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition  ;   5Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinitionBaseF    TargetProperties=!  7Xceed.Wpf.Toolkit.PropertyGrid.Converters.ListConverter$F 
Background!   $F BorderBrush!   $F BorderThickness!   $F FontSize!   $F 	FontStyle!   $F Width!   $F Height! 