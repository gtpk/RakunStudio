   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35N;clr-namespace:System.Windows;assembly=PresentationFrameworkSystem.Windows  5   	    	TabWindow!   TabWindow.DropOverlayWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   Mlocal;clr-namespace:System.Windows;assembly=PresentationFramework      5   	     � Title$  DropOverlayWindow��5   	   $	��300��6#   $	��300��60    � AllowsTransparency . 
������  � WindowStyle$
 None=�6o    � ShowInTaskbar .   � DataContext 5   	   ��  �� RelativeSource �� *Self+.��5      �  � RowDefinitions 5   
   �� 5	      #��Z��6   �� 5
      $��* �6   .+�5   
   �� $��1��6   $
��auto��6    J� Opacity$	 0.5Q�6,   $��9q�6:   $��8,7,8,8q�6N   ��5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � ��
 �� Value

 ���� 64   �� 5      	 � ��

 ���� 63    �� Triggers 5      �� 5       �� Binding 6&   �� *IsTabTargetOver+ �� Value True6J   .a�5      �� 	 � ��
 �	#FF1E90FF6<   �� 5      	 � ��

 ��İ�6;   5      5      5      �� 5   
   -   5         ��Name$ btnDropTarget��5      $��1��6(   $��Center=�65   $	��149��6R   $��49��6^   $	 0.7Q�6j   $	��Top=�6x   $��1,5,1,1q�6�   .��5      �� ��5      �� 5      " ��6   .�5      �� 	 � ��$
 Images\TabTop.png��63    5      �� 5        6*   �� *IsTabTargetOver+ True6N   .a�5!   "   �� 	 � ��$
 Images\TabTopHover.png��6;   5"      5$      5&      5'      5(      5)      