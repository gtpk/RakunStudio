   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35N;clr-namespace:System.Windows;assembly=PresentationFrameworkSystem.Windows   	TabWindow!   TabWindow.DropOverlayWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      Mlocal;clr-namespace:System.Windows;assembly=PresentationFramework        � Title$  DropOverlayWindow��$	��300��$	��300�� � AllowsTransparency . 
������  � WindowStyle$
 None=� � ShowInTaskbar .   � DataContext ��  �� RelativeSource �� *Self+.���  � RowDefinitions �� #��Z���� $��* �.+��� $��1��$
��auto�� J� Opacity$	 0.5Q�$��9q�$��8,7,8,8q�����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value

 ���� �� 	 � ��

 ����  �� Triggers ��  �� Binding �� *IsTabTargetOver+ �� Value True.a��� 	 � ��
 �	#FF1E90FF�� 	 � ��

 ��İ��� -    ��Name$ btnDropTarget��$��1��$��Center=�$	��149��$��49��$	 0.7Q�$	��Top=�$��1,5,1,1q�.���� ���� " ��.��� 	 � ��$
 Images\TabTop.png�� ��  �� *IsTabTargetOver+ True.a��� 	 � ��$
 Images\TabTopHover.png��