   M S B A M L   `   `   `  ���� _  [Selen.Wpf.GenericAppTree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=dc472ed4b6daaa58eHclr-namespace:Selen.Wpf.GenericAppTree;assembly=Selen.Wpf.GenericAppTreeSelen.Wpf.GenericAppTree   Selen.Wpf.SystemStyles*   $Selen.Wpf.SystemStyles.AppTreeStylesW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   MenuScrollBar �� 
TargetType �� Property �� Value �� 
TargetType �Name � 	Resources  Key  BackgroundNormal �� Stretch  
Foreground	 �� Triggers
 P� Property P� Value �� 
TargetName  BackgroundHighlighted  BackgroundSelected � RowDefinitions ��Name  VerticalDecrementTemplate �� Interval �� LineUpCommand  VerticalIncrementTemplate �� LineDownCommand  BorderBrush �� EndPoint �� 
StartPoint � Color � Offset 	 FocusBorderBrush 
 
FocusStyle  DisabledBrush �� Color  ItemDisabledBrush  ItemDisabledStyle  C1TreeViewToggle � Cursor � ColumnDefinitions F�Name J� Opacity �� Angle �� CenterX �� CenterY  	IconColor ��Name �� StrokeDashCap  J� IsHitTestVisible  
FocusColor! ��Name" �� RadiusX# �� RadiusY  BrowseTreeItemStyle$ 	�Name% d� IsThreeState& �� 	ClickMode' 	� 	GroupName( d� 	IsChecked) �� Mode  BorderBrushNormal* ��Name  BorderBrushHighlighted+ �� Value, �� Binding  BorderBrushSelected  MenuScrollViewer- �� CornerRadius. ��Name/ �� Orientation0 �� ViewportHeight1 �� ViewportSize2 �� ScrollableHeight3 � Maximum4 � Minimum5 �� VerticalOffset6 � Value7 �� ElementName8 ��Name  AppTree9 ��Name: �� DataType/   )Selen.Wpf.GenericAppTree.AppTreeContainer; �� ItemsSource< �� Path*   $Selen.Wpf.GenericAppTree.AppTreeItem   D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  8d2http://schemas.microsoft.com/expression/blend/2008  RlocalHclr-namespace:Selen.Wpf.GenericAppTree;assembly=Selen.Wpf.GenericAppTree    �� $D >pack://application:,,,/Selen.Wpf.Core;component/Resources.xaml?�%R  &	        7  7  7  7  7  7  7  7  7  7  &	 �    &		 d    &	
 �    7 	 &	     &	 1    &	 F    7  7  &	 �    7  7  7  7  &	 �
    7  7  7  7  7  7  7  7  &	 4    7   &	 *    7  7  (�� �    *, +)(�� �    *, +)�� " ��.���  � ��$ 17����  � ��$ 17����  � �� .  ��  � �� �� " ��.R�� $
 Root�� ���� VerticalIncrementTemplate " ��.R�� $
 Root��$��0,1,0,1q�.+��� $
��rect��8��  F� $ Uniform=�$��4��$��8��+������u0��2G �u0�П���Ѹ��u08�� 	 P� 
 �@J�IsMouseOver . . ��� $
 rect��8   � ��P� 
 � �� . . ��� $
 rect��8   � ���� VerticalDecrementTemplate " ��.R�� $
 Root��$��0,1,0,1q�.+��� $
��rect��8�� F� $ Uniform=�$��4��$��8��+�����2G �X
Ѹ��X
�П�б�	��2G �X
8�� 	 P� 
 �@J�IsMouseOver . . ��� $
 rect��8   � ��P� 
 � �� . . ��� $
 rect��8   � ��.+�� $ VerticalRoot��$��Stretch=� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $ VerticalSmallDecrease��$��16��$��1q���.  8�� $��0��$ 50��#��Z �� $ VerticalSmallIncrease��$��16��$��1q���.  8��	 $��2��$ 50��#��Z �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#7FFFFFFF��$
 0.05Q�� $ 	#B2FFFFFF��$
 0.07Q�� $ 	#00FFFFFF��$ 1Q��� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF6DBDD1��$ 0Q�� $ 	#FF64AEC0��$ 1Q��� " ��.���  �@��CornerRadius$ 2����  �@J�Opacity$ 0Q���  � ��8   �� $ 	#B2FFFFFF���� $ 	#A5FFFFFF���� " ��.���  � ��8   ��  � ��8  ��  �@J�Opacity$ 0Q���  �@J�IsHitTestVisible .  ��  �@��CornerRadius$ 2���� " 	�.R�� $ Arrow�� ����	IconColor 	#FF595959���� DisabledBrush $ 	#A5FFFFFF����
FocusColor 	#FF333333�� �� $
��Auto ��� $��* �.+�F� $ 
ExpandIcon��"�����6 � ��6�6� � �6	$��6��$��Center=�$��0,0,4,0q�$��Center=�$��6��$
 Fill=����	#FF565656$	��0.5��$ 1Q�$y�	Collapsed=����� $ 	0.15,0.85&�$ 	0.85,0.15&�.��� $ 	#FFF3F3F3��$ 0Q�� $ 	#FFEBEBEB��$	 0.5Q�� $ 	#FFDDDDDD��$	 0.5Q�� $ 	#FFCDCDCD��$ 1Q�z�V� .~��� $	 -45Q�$ 3Q�$ 3Q�F� $ CollapseIcon��"�����6 � ��6�6� � �6	$��6��$��Center=�$��Center=�$��6��$ 0Q�$
 Fill=����	#FF262626$	��0.5��$y�	Collapsed=����� 	IconColor��8   �� $ ContentFocusVisual��$��1��$ Round=�$��2q�  .  $y�	Collapsed=����� 8  �� $! Content��$��	6,5.5,4,4q�  . $��1��#��z��#��z��$y�	Collapsed=��� $ DisabledBox��$��13��$��Center=�$��13��$ 0Q�8�� 8�� $	��.75��$" 1��$# 1��$y�	Collapsed=��� $��1�����	#00FFFFFF	 P� 
 �@d�	IsChecked$
 trueY�. ��� $ CollapseIcon�� �@J�Opacity$ 1Q��� $ 
ExpandIcon�� �@J�Opacity$ 0Q��� " Q�.���  � ��$ 1q���  � ��$ 2q���  � �� Z� ��  � �� �� " Q�.R��  �� $��* ��� $
��Auto �.+�� $ HeaderPanel��$��20��$��0��$��32��  . .+�	� $$ ExpandButton��8��  % .  $��2��$& Press=�' �� *Group+( �� *
IsSelected+$) TwoWay=��� $��border��$��2��  .  $��1q�8�� 8�� � $��2��$��1��$��5 0 5 0q�.+��� $! PART_Header��$��Header��#��z��8��   .  $
��Left=�$��Center=��� $* ChildrenPanel��$��1��$y�Visible=�$��10,2,0,2q�	 P� 
 �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ��P� 
 �@��HasItems .  . ��� $ ChildrenPanel�� � y�$ 	Collapsed=��� $+ false��, �� *
IsSelected+.a��� $ ChildrenPanel�� � y�$ 	Collapsed=��� $
+ true��, �� *
IsSelected+.a��� $ border��8   � ���� $ border��8   � ���� " ��.���  � ��$
 Left=���  � ��$	 Top=���  � ��$ Visible=���  � ��$ 0q���  � ��$ 0q���  � �� �� " ��.R��� #��z��#��z��$- 2��._�� #��z�� �� $��* ��� $
��Auto �.+�� $ measureGrid���� $. PART_VerticalScrollBar��$y�Visible=���.  $/ Vertical=�#1 z0 #3 z2 $4 0Q�#6 z5 {�. 8��  $��Stretch=����� *ActualWidth+$7 measureGrid���� $!8 PART_ScrollContentPresenter��# z #��z��$
��0,18q�$	��Top=��� " R�.���  � ��$ 0q���  � ��
 ���� ��  � ��8   ��  � �� �� " R�.R�� $
 Root��.+�� .+��� $9 scrollViewer��8�� $��Visible=�$��Disabled=�.���� �� ":  ; �� *
Children+.R��  �� $��40 ��� .+��� $��25��$��25��$��Center=�$��Center=����� *Icon+�� $��1��$��Center=����� $< Header��� ":  .R�� $��10,0,0,0q� �� $��40 ��� .+��� $��25��$��25��$��Center=�$��Center=����� *Icon+�� $��1��$��Center=����� $< Header�