   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      E ARakunWin32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RakunWin32
RakunWin32 5
      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      ?$clr-namespace:AvalonDock.MVVMTestAppAvalonDock.MVVMTestApp 5         RakunWin32.RakunStudio   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h	 dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i
 eXceed.Wpf.AvalonDock.Themes.VS2013, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4E
avalonDock,http://schemas.xceed.com/wpf/xaml/avalondock   	 
  5      X TXceed.Wpf.Toolkit, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      $localclr-namespace:RakunWin32  5
      0Sys&clr-namespace:System;assembly=mscorlib  5      6MVVMTestApp$clr-namespace:AvalonDock.MVVMTestApp  5      h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6;   -   5        (   "MahApps.Metro.Controls.MetroWindow   Name$  Window��5       � Title$ RakunStudio��5       � WindowState$ 	Maximized=�6@    � WindowStyle$
 None=�6X    � 	Resources 5      4 .AvalonDock.MVVMTestApp.ActiveDocumentConverter   ActiveDocumentConverter?  9Xceed.Wpf.AvalonDock.Converters.BoolToVisibilityConverter  BoolToVisibilityConverter  RakunNodeReaderTemplate  
Foreground �� Mode �� 
TargetType �� Triggers :� RoutedEvent	 �� TargetProperty
 W� From	 W� To g� Duration��%  &	        &	      &	 &     '��       5   
   6.     5   
   6/   �� 5   
   .R�5      �� .+�5      �� #���  68   ��6   �� *
ModuleName+68   �� 5      $	��ADD��6   $��75��6'   $��Right=�62   ��6N   �� *AddModuleCommand+$ OneWay=�5      5      �� 5   
   " ��6    5      :� 5      $ Loaded��6   [�5      �� 5      .��5      �� .��5   "   W� $	 Opacity�62   $
 0X�6V   $ 1X�6_   $ 0:0:2D�6f   5    #   5!      5"      5$      5&      5'      .��5(      ]� -   5         ]�Name$ dockManager��5(       � DataContext 5*   
   &  AvalonDock.MVVMTestApp.Workspace  5+      .+�5.   
   o� $	��Top=�6   $	��Top=�6'    J� SnapsToDevicePixels . .@�5/      m� $
��File��6   .@�50      m� $	��New��6    m� Command 6(   �� *
NewCommand+�� 51      m� 52      $
��Save��6    6)   �� *ActiveDocument.SaveCommand+m� 53      $��
Save As...��6    6/   �� *ActiveDocument.SaveAsCommand+�� 54      m� 55      $��Close��6    6*   �� *ActiveDocument.CloseCommand+56      m� 57      $��_Edit��6   .@�58      m� $	��Cut��6   $
��Left=�6(   $��114.66��6C   
�������6R   m� 59      $
��Copy��6   $
��Left=�6)   $��114.66��6D   
�������6S   m� 5:      $��Paste��6   $
��Left=�6*   $��114.66��6E   
�������6T   m� 5;      $��
Select All��6   $
��Left=�6/   $��114.66��6J   
�������6Y   5<      m� 5=      $��_Build��6   .@�5>      m� $��Compile��6   $
��Left=�6,   $��114.66��6G   
������� 6i   �� *ActiveDocument.BuildCommand+$ OneWay=�m� 5?      $��Upload��6   $
��Left=�6+   $��114.66��6F   
������� 6h   �� *ActiveDocument.UploadCommand+$ OneWay=�m� 5@      -   5         m�Name$ MIPort��5@      $
��Port��6+   $
��Left=�69   $��114.66��6T   
������� 5A        RadioButtonResource 	� 	GroupName J� IsHitTestVisible��%S   &	      	� 5B      $��Center=�6S   $ MenuItemRadio��5C       .  60   5D      ��5E      �� 5F      " m�6    .�5G      ��  �� Property �@m�Icon �� Value# �  65   -   5        5I      5K      m� 5L      -   5        $ MIBoundrate��5L      $��	Boundrate��60   $
��Left=�6C   $��114.66��6^   
������� 5M      ��%S   &	      	� 5N      $��Center=�6S   $ MenuItemRadio��5O       .  61   5P      ��5Q      �� 5R      " m�6    .�5S      ��  �@m�Icon# �  65   -   5        5U      5W      m� 5X      -   5        $ 	MIDatabit��5X      $��Databit��6.   $
��Left=�6?   $��114.66��6Z   
������� 5Y      ��%S   &	      	� 5Z      $��Center=�6S   $ MenuItemRadio��5[       .  61   5\      ��5]      �� 5^      " m�6    .�5_      ��  �@m�Icon# �  65   -   5        5a      5c      m� 5d      $��
Programmer��6   $
��Left=�6/   $��114.66��6J   
�������6Y   5e      m� 5f      $��_Tools��6   .@�5g      m� $��
Add Module��6   $
��Left=�6/   $��114.66��6J   
������� 6l   �� *AddModuleCommand+$ OneWay=�5h      m� 5i      $��_Window��6   .@�5j      m� $��Monitor��6   $
��Left=�6,   $��114.66��6G   
�������6V   m� 5k      $��Object Tree��6   $
��Left=�60   $��114.66��6K   
�������6Z   5l      5n      �� 5o   
   -	   5         ��Name$ 	statusBar��5o      $��Bottom=�6'   $��0q�6?   ��5p      �� 5q       �� Color 6"   �� *	Statusbar+.@�5s      ]� ��.  ��6   �� *ActualWidth+ �� ElementName$ 	statusBar��.+�5t      �� $
��Wrap=�6   $��0q�6N   ��60   �� *StatusString+��5u      �� 5v      # � ��6*   5x      �� 5y       �� Orientation$ Vertical=�6   $��Right=�64   $��0,0,8,0q�6K   .+�5z      �� $
��Wrap=�6    $��Created By Rakun��64   ��5{      �� 5|      # � ��6.   5~      5      5�      5�      � 5�   
   .+�5�      )  #Xceed.Wpf.AvalonDock.DockingManager  -
   5          Name$ 
RootLayout��5�   (      AllowMixedOrientation . 
���   �$��1q�5�      ���	#FF2D2D30
�������   AnchorablesSource 60   �� *Tools+   DocumentsSource 5�      �� *Files+   ActiveContent 5�      �� *ActiveDocument+ �� 	Converter# [  $ TwoWay=�    Theme  5�      1 
 +Xceed.Wpf.AvalonDock.Themes.Vs2013DarkTheme  5�      !!   LayoutItemTemplateSelector! 5�      2 ,AvalonDock.MVVMTestApp.PanesTemplateSelector  5�      "   FileViewTemplate" 5�      �� 5�      .R�5�   "   �� $��0q�5�   
   # �� AcceptsReturn# . $ �� TextWrapping$
$ Wrap=�63   ��5�   *   �� *TextContent+% �� UpdateSourceTrigger$% PropertyChanged=�5�   3   5�      &   FileStatsViewTemplate& 5�      �� 5�      .R�5�   "   �� ' �� Padding$' 5q�6)   ._�5�   &   �� $ Vertical=�61   .+�5�   *   �� ��64   �� *
FileSize+�� 5�   *   ��64   �� *LastModified+�� 5�   *   $
��test��62   # . $
$ Wrap=�6S   5�   '   5�   #   5�      (   RakunFileViewTemplate( 5�      �� 5�      5�      5�      ')    LayoutItemContainerStyleSelector) 5�      / )AvalonDock.MVVMTestApp.PanesStyleSelector  5�      *   	ToolStyle* 5�      �� 5�      8	  2Xceed.Wpf.AvalonDock.Controls.LayoutAnchorableItem" 	 6$   .�5�   "   �� .
  (Xceed.Wpf.AvalonDock.Controls.LayoutItem �@
 Title 6:   �� *Model.Title+�� 5�   "    �@
 
IconSource 6?   �� *Model.IconSource+�� 5�   "    � y� 6?   �� *Model.IsVisible+  System.Windows.Visibility+   Hidden, �� ConverterParameter#, Z+ # [ $ TwoWay=��� 5�   "    �@
 	ContentId 6>   �� *Model.ContentId+�� 5�   "    �@
 
IsSelected 6?   �� *Model.IsSelected+$ TwoWay=��� 5�   "    �@
 IsActive 6=   �� *Model.IsActive+$ TwoWay=�5�      -   	FileStyle- 5�      �� 5�      " 
 6$   .�5�   "   ��  �@
 Title 6:   �� *Model.Title+�� 5�   "    �@�ToolTip 6<   �� *Model.FilePath+�� 5�   "    �@
 CloseCommand 6A   �� *Model.CloseCommand+�� 5�   "    �@
 
IconSource 6?   �� *Model.IconSource+�� 5�   "    �@
 	ContentId 6>   �� *Model.ContentId+5�      .   
RakunStyle. 5�      �� 5�      " 
 6$   .�5�   "   ��  �@
 Title 6:   �� *Model.Title+�� 5�   "    �@�ToolTip 6<   �� *Model.FilePath+�� 5�   "    �@
 CloseCommand 6A   �� *Model.CloseCommand+�� 5�   "    �@
 
IconSource 6?   �� *Model.IconSource+�� 5�   "    �@
 	ContentId 6>   �� *Model.ContentId+5�      5�      /   LayoutUpdateStrategy/ 5�      . (AvalonDock.MVVMTestApp.LayoutInitializer  5�      0   DocumentHeaderTemplate0 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   .+�5�      �� $��0,0,4,0q�6B   ��6$   �� *
IconSource+6B   �� 5�      ��6(   �� *Title+5�      5�      1   Layout.1 5�      ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot  -   5        _layoutRoot��2   	RootPanel.2 5�      -  'Xceed.Wpf.AvalonDock.Layout.LayoutPanel  3   Orientation$3 
Horizontal=�6-   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]4   Children.4 5�      6  0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]5   	DockWidth$	5 200 �6:   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]6   Children.6 5�      2  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable  /  )Xceed.Wpf.AvalonDock.Layout.LayoutContent7   	ContentId$7 
ModuleList��6:   8   Title$8 Module List��6Q   9   CanHide9 .  :   CanClose: .  ;   AutoHideWidth$	; 240Q�5�   	   <   Content.< 5�   "   �� #���  6*   ��6c   �� *RakunManager.ReaderList+5�      5�      9  3Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPaneGroup  5�      �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutDocumentPane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]=   Children.= 5�      4  .Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutContent, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]>   Children.> 5�   "   0  *Xceed.Wpf.AvalonDock.Layout.LayoutDocument  $7 
QuickStart��6<   $8 
QuickStart��6S   .< 5�   &   &   RakunWin32.QuickStartUserControl  5�   #   5�      5�      ;  5Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePaneGroup  5�      �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]?   	DockWidth$	? 200 �6?   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]@   Children.@ 5�        .6 5�   "     $7 Monitor��6>   $8 Monitor��6R   .< 5�   &   �� -   5        A ��Name$A Monitor��5�   .   5�   #     5�   "   $7 
properties��6>   $8 
Properties��6U   9 .  : .  $	; 240Q�5�   
   .< 5�   &   1  +Xceed.Wpf.Toolkit.PropertyGrid.PropertyGrid  B   NameColumnWidth$	B 110Q�68   C   AutoGeneratePropertiesC .  {�.  ���	#FF007ACC���	#FF2D2D30���	#FFF1F1F1D   SelectedObjectD 6N   �� *LastFocusedDocument.Content+$ _layoutRoot��E   PropertyDefinitionsE 5�   .   7  1Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinition  ;   5Xceed.Wpf.Toolkit.PropertyGrid.PropertyDefinitionBaseF    TargetProperties=!  7Xceed.Wpf.Toolkit.PropertyGrid.Converters.ListConverter$F 
Background! 6F     5�   .   $F BorderBrush! 6F     5�   .   $F BorderThickness! 6F     5�   .   $F FontSize! 6F     5�   .   $F 	FontStyle! 6F     5�   .   $F Width! 6F     5�   .   $F Height! 6F   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      