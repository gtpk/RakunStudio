   M S B A M L   `   `   `  ���� D  @TabWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TabWindow	TabWindow  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TabBorderBrush  �� Color * &TabItemCloseButtonHoverBackgroundBrush * &TabItemCloseButtonHoverForegroundBrush  tabItemCloseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius F�Name �� StrokeStartLineCap	 �� StrokeEndLineCap
 �� Stretch E� 
StartPoint �� Point �� Triggers P� Property P� Value �� 
TargetName#    TabWindow.CloseEnabledTabItem �� 	Resources  Key �� 
StartPoint �� EndPoint � Color � Offset  TabItemBackground �Name J� SnapsToDevicePixels J� IsHitTestVisible ]�Name ��Name ��Name  TabItemSelectedBackground ]� 
Conditions �� Property �� Value  TabItemMouseOverBorderBrush  TabItemMouseOverBackground�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     !localclr-namespace:TabWindow  %x  &	        &	      &	 .     &	 D     7  7  7  7  '   �    7  7   7  7  7  7  �� $  DarkSlateGray���� $  	IndianRed���� $  
WhiteSmoke���� " ��.���  � ��$ 13����  � ��$ 13����  � �� �� " ��.R��� $ buttonBorder��$ 2��#��z��
�������$��1q�._�F� $ 
buttonPath��$��2q�
�������$��2��$ Round=�$	 Round=�$

 Fill=���B� .��E� $	 0,0&�.���� $ 13,13&�E� $
 0,13&�.���� $
 13,0&� P�  �@J�IsMouseOver . . ��� $ buttonBorder��8    � ���� $ 
buttonPath��8   � ��P�  � {� .  . ���  � y�$ 	Collapsed=�P�  � �� . . ��� $ buttonBorder��8   � ���� $ 
buttonPath��8   � ���� "    ���� TabItemMouseOverBackground $ 0.5,0&�$ 0.5,1&�.��� $ 	AliceBlue��$	 0.0Q�� $ 
PowderBlue��$	 1.0Q��� TabItemBackground $ 0.5,0&�$ 0.5,1&�.��� $ 
WhiteSmoke��$	 0.0Q�� $ 	LightGray��$	 1.0Q��� TabItemSelectedBackground $  #F8F7F8���� TabItemMouseOverBorderBrush $  
DodgerBlue��.���  � ��$ Stretch=���  � ��$ Stretch=���  � ��
 �   ���  � ��8   ��  � ��$ 6,2,6,1q���  � ��8  ��  � �� �� "   .R�� $ 
gridHeader�� .  . .+��� $ tabItemBorder��#��z��#��z��$��1,1,1,0q�._�]� $ tabItemDockPanel��.+��� $ tabItemCloseButton��8�� $��Right=�$��3,0,3,0q�$y�Hidden=��� $ tabItemContent��# z ��. #��z��#��z��$��Header��#��z�� P�  �@��
IsSelected . . ���  �@K�ZIndex$ 1���� $ tabItemBorder��8   � ���� $ tabItemCloseButton�� � y�$ Visible=�P�  � {� .  . ��� $ tabItemBorder�� � �� �#F4F4F4�� $ tabItemBorder�� � �� �	#FFC9C7BA�� # � �� � ��]�  ��  �@��
IsSelected .  ��  �@J�IsMouseOver . ./��� $ tabItemBorder��8   � ���� $ tabItemBorder��8   � ��P�  �@��TabStripPlacement$ Bottom=�. ��� $ tabItemBorder�� � ��$ 1,0,1,1q�P�  �@��TabStripPlacement$
 Left=�. ��� $ tabItemBorder�� � ��$ 1,1,0,1q�P�  �@��TabStripPlacement$ Right=�. ��� $ tabItemBorder�� � ��$ 0,1,1,1q�]�  ��  �@��
IsSelected . ��  �@��TabStripPlacement$	 Top=�./���  � ��$ -2,-2,-2,-1q��� $ tabItemDockPanel�� � ��$ 0,0,0,1q�]�  ��  �@��
IsSelected . ��  �@��TabStripPlacement$ Bottom=�./���  � ��$ -2,-1,-2,-2q��� $ tabItemDockPanel�� � ��$ 0,1,0,0q�]�  ��  �@��
IsSelected . ��  �@��TabStripPlacement$
 Left=�./���  � ��$ -2,-2,-1,-2q��� $ tabItemDockPanel�� � ��$ 0,0,1,0q�]�  ��  �@��
IsSelected . ��  �@��TabStripPlacement$ Right=�./���  � ��$ -1,-2,-2,-2q��� $ tabItemDockPanel�� � ��$ 1,0,0,0q�