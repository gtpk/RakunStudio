   M S B A M L   `   `   `  ����D  @TabWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TabWindow	TabWindow  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TabBorderBrush  �� Color * &TabItemCloseButtonHoverBackgroundBrush * &TabItemCloseButtonHoverForegroundBrush  tabItemCloseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius F�Name �� StrokeStartLineCap	 �� StrokeEndLineCap
 �� Stretch E� 
StartPoint �� Point �� Triggers P� Property P� Value �� 
TargetName#    TabWindow.CloseEnabledTabItem �� 	Resources  Key �� 
StartPoint �� EndPoint � Color � Offset  TabItemBackground �Name J� SnapsToDevicePixels J� IsHitTestVisible ]�Name ��Name ��Name  TabItemSelectedBackground ]� 
Conditions �� Property �� Value  TabItemMouseOverBorderBrush  TabItemMouseOverBackground�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !localclr-namespace:TabWindow  5      %  &	        &	 '     &	 J     &	 n     7  7  7  7  '   c    7  7   7  7  7  7  �� 5      $  DarkSlateGray��6-   �� 5      $  	IndianRed��6E   �� 5      $  
WhiteSmoke��6E   �� 5
      " ��6,   .�5   
   ��  � ��$ 13��6#   �� 5   
    � ��$ 13��6"   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ buttonBorder��6   $ 2��63   #��z��6D   
�������$��1q�6�   ._�5      F� $ 
buttonPath��6   $��2q�63   
�������$��2��6P   $ Round=�6d   $	 Round=�6   $

 Fill=�6�   ��5      B� 5   "   .��5   &   E� $	 0,0&�61   .��5   *   �� $ 13,13&�66   5   '   E� 5   &   $
 0,13&�61   .��5   *   �� $
 13,0&�66   5   '   5   #   5      5       5      P� 5       �@J�IsMouseOver . . �5       �� $ buttonBorder��6%   8    � ��6U   �� 5!      $ 
buttonPath��6%   8   � ��6O   5"      P� 5#       � {� .  . �5$      ��  � y�$ 	Collapsed=�6;   5%      P� 5&       � �� . . �5'      �� $ buttonBorder��6%   8   � ��6U   �� 5(      $ 
buttonPath��6%   8   � ��6O   5)      5+      5-      5.      �� 50      "   6    51   
   ���� 52      TabItemMouseOverBackground $ 0.5,0&�6E   $ 0.5,1&�6X   .��53      � $ 	AliceBlue��6   $	 0.0Q�61   � 54      $ 
PowderBlue��6   $	 1.0Q�62   55      �� 56      TabItemBackground $ 0.5,0&�6<   $ 0.5,1&�6M   .��57      � $ 
WhiteSmoke��6   $	 0.0Q�62   � 58      $ 	LightGray��6   $	 1.0Q�61   59      �� 5:      TabItemSelectedBackground $  #F8F7F8��6@   �� 5;      TabItemMouseOverBorderBrush $  
DodgerBlue��6B   5<      .�5>   
   ��  � ��$ Stretch=�67   �� 5?   
    � ��$ Stretch=�65   �� 5@   
    � ��
 �   �6'   �� 5A   
    � ��8   6'   �� 5B   
    � ��$ 6,2,6,1q�6$   �� 5C   
    � ��8  6(   �� 5D   
    � �� 5E      �� 5F      "   6"   .R�5G      � $ 
gridHeader��6N    .  . .+�5H      �� $ tabItemBorder��6!   #��z��68   #��z��6b   $��1,1,1,0q�6�   ._�5I      ]� $ tabItemDockPanel��6(   .+�5J   "   �� $ tabItemCloseButton��6)   8�� $��Right=�6v   $��3,0,3,0q�6�   $y�Hidden=�6�   �� 5K   "   $ tabItemContent��63   # z 6K   ��. #��z��6�   #��z��6�   $��Header��6$  #��z��6;  5L      5M      5N       5O      P� 5P       �@��
IsSelected . . �5Q      ��  �@K�ZIndex$ 1��6=   �� 5R      $ tabItemBorder��6;   8   � ��6V   �� 5S      $ tabItemCloseButton��6;    � y�$ Visible=�6[   5T      P� 5U       � {� .  . �5V      �� $ tabItemBorder��6;    � �� �#F4F4F46V   �� 5W      $ tabItemBorder��6<    � �� �	#FFC9C7BA6W   �� 5X      # � ��6;    � ��5Y      ]� 5Z       5[      �� 5\   "    �@��
IsSelected .  6B   �� 5]   "    �@J�IsMouseOver . 6C   ./�5_      �� $ tabItemBorder��6<   8   � ��6W   �� 5`      $ tabItemBorder��6;   8   � ��6V   5a      P� 5b       �@��TabStripPlacement$ Bottom=�6?   . �5c      �� $ tabItemBorder��6@    � ��$ 1,0,1,1q�6[   5d      P� 5e       �@��TabStripPlacement$
 Left=�6?   . �5f      �� $ tabItemBorder��6@    � ��$ 1,1,0,1q�6[   5g      P� 5h       �@��TabStripPlacement$ Right=�6?   . �5i      �� $ tabItemBorder��6@    � ��$ 0,1,1,1q�6[   5j      ]� 5k       5l      �� 5m   "    �@��
IsSelected . 6B   �� 5n   "    �@��TabStripPlacement$	 Top=�6I   ./�5p      ��  � ��$ -2,-2,-2,-1q�67   �� 5q      $ tabItemDockPanel��67    � ��$ 0,0,0,1q�6U   5r      ]� 5s       5t      �� 5u   "    �@��
IsSelected . 6B   �� 5v   "    �@��TabStripPlacement$ Bottom=�6I   ./�5x      ��  � ��$ -2,-1,-2,-2q�67   �� 5y      $ tabItemDockPanel��67    � ��$ 0,1,0,0q�6U   5z      ]� 5{       5|      �� 5}   "    �@��
IsSelected . 6B   �� 5~   "    �@��TabStripPlacement$
 Left=�6I   ./�5�      ��  � ��$ -2,-2,-1,-2q�67   �� 5�      $ tabItemDockPanel��67    � ��$ 0,0,1,0q�6U   5�      ]� 5�       5�      �� 5�   "    �@��
IsSelected . 6B   �� 5�   "    �@��TabStripPlacement$ Right=�6I   ./�5�      ��  � ��$ -1,-2,-2,-2q�67   �� 5�      $ tabItemDockPanel��67    � ��$ 1,0,0,0q�6U   5�      5�      5�      5�      5�      