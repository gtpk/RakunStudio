   M S B A M L   `   `   `  ���� E  ARakunWin32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RakunWin32
RakunWin32      RakunWin32.ModuleView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:RakunWin32     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  -     >�Name$  UserControl��
������� � 	Resources    	OnCreated �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  	ValueList   RakunWin32.PathPointNode   PathType	   DraggingCommand
   EnterCommand   LeaveCommand �� Orientation  ListBoxItemStyle1 �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value # RakunValueNodeViewModelTemplate   DirectionType��%<  &	        &	 v    &	 �    &	 �    �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ 
RootLayout��.\�  $ 0��$ 0Q�  $ 0:0:0.3��$ 1Q�   $ EaseOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ 
RootLayout��.\�  $ 0��$ 0Q�  $ 0:0:0.3��$ 1Q�   $ EaseOut=��� .R�� .+�  $
��Left=�$��0q�$��Center=�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+  $��Right=�$��0,0,3,0q�$��Center=�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Stretch=�$
��Auto��$��Center=�$
��Auto��$
��15,0q�$ 
Horizontal=�.+��� $��0q�$
��Wrap=�$��Stretch=�$��15.96��$��9.333(����� *
NodeName+�� " ��.���  � ��
 ���� ��  � �� �� *HorizontalContentAlignment+ �� " ����  � �� �� *VerticalContentAlignment+ �� " ����  � ��$ 2,0,0,0q���  � �� �� " ��.R��� $ Bd��#��z��#��z��#��z�� . ._��� # z #��z�� P�  �@��
IsSelected . . ��� $ Bd��# � �� � ���� # � �� � ��]�  ��  �@��
IsSelected . ��  �@��IsSelectionActive .  ./��� $ Bd��# � �� � ���� # � �� � ��P�  � {� .  . ��� # � �� � ���� .R�� $
��Auto��$
��Auto��.+�  $
��Left=�$��0q�$��Center=�$ Value=����	#FF4CFFCE$��10��$��10��|�. 	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Stretch=�$
��Auto��$��Center=�$
��15,0q�$ 
Horizontal=�.+��� $��0q�$
��Wrap=�$��Stretch=�$��15.96��$��9.333(����� *	ValueName+  $��Right=�$��0,0,3,0q�$��Center=�$ Value=����	#FF4CFFCE$��10��$��10��|�. $	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+ � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� #��[  .���� -   $ 
RootLayout�� �� CornerRadius$ 15�����	#00000000  J� RenderTransformOrigin$  0.5,0.5&�! � LayoutTransform! V� .~��� " �� ScaleX$	" 1.2Q�# �� ScaleY$	# 1.2Q��� �� T� z�V� .~��� �� �� T� .  (System.Windows.Interactivity.Interaction$   Triggers$ /  )System.Windows.Interactivity.EventTrigger  %   	EventName$% Loaded��.  (System.Windows.Interactivity.TriggerBase&   Actions.& F  @Microsoft.Expression.Interactivity.Media.ControlStoryboardAction  ?	  9Microsoft.Expression.Interactivity.Media.StoryboardAction' 	  
Storyboard#' [  ._�� -   ( �Name$( 
LayoutRoot��$��5q����	#00000000) J� IsHitTestVisible) . .+�� -   $( 	InputNode��$��Center=�$��0,0,0,-0.001q�.+��� -   $ RootLayout_Copy5��$ 15�����	#7F000000$��-5q��� $��Center=�.+��� $��Center=�$��0q�$ 
Horizontal=�.+�  $
��Left=�$��Center=�$��0,0,3,0q�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $ 
Horizontal=�$��0,0,3,0q�.+��� -   * ��Name$* TBTitle3��$
��Left=�$
��Wrap=�$��Center=�  
Foreground#���  + �� TextAlignment$+ Center=�$��9.333(�$��0q�$��70������ *ModuleInfo.ModuleName+�� -   $* TBTitle3_Copy��$
��Wrap=�$��:��$��Center=�#���  $+ Center=�$��9.333(�$	��3,0q��� -   , ��Name$, tbinput��- �� TextWrapping$
- Wrap=�$��Center=�$��9.333(�$��20������ *input+  $
��Left=�$��Center=�$��0,0,3,0q�$	 OUT=�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+� -	   $( 	ValueNode��$��Center=�$y�	Collapsed=�.+��� -
   $ RootLayout_Copy4��$ 15�����	#7F000000$��-5q��� $��Center=�.+��� $��Center=�$��0q�$ 
Horizontal=�.+�  $
��Left=�$��Center=�$��0,0,3,0q�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� -   $* TBTitle1��$
��Left=�$
��Wrap=�$��Center=�#���  $+ Center=�$��9.333(�$��0,0,4,0q�$��70������ *ModuleInfo.ModuleName+  $
��Left=�$��Center=�$��0,0,3,0q�$	 OUT=�$ Value=����	#FF4CFFCE	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+� -   $( 
ModuleNode��$y�	Collapsed=�.+��� -   $ RootLayout_Copy��$ 15�����	#7F000000$��-5q��� .+�� $��Center=�.+��� -   $* TBTitle��$
��Left=�$
��Wrap=�$	��Top=�#���  $+ Center=�$��9.333(�$��0,0,45,0q����� *
ModuleName+� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+  $
��Left=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� #���  ) . }�. #���  $��0q�
����������	#00828790���� *ModuleValues+��Z� � -   $( StartingNode��$y�	Collapsed=�.+��� -   $ RootLayout_Copy1��$ 15�����	#7F530000$��-5q��� .+�� $��Center=�.+��� -   $* TBTitle2��$
��Left=�$
��Wrap=�$	��Top=�#���  $+ Center=�$��9.333(�$��0,0,45,0q�$��Starting Point��� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+� -   $( IFNode��$y�	Collapsed=�.+��� -   $ RootLayout_Copy2��$ 15�����	#7F000F55$��-5q��� .+�� $��Center=�.+��� $
��Left=�$
��Wrap=�$	��Top=�#���  $+ Center=�$��9.333(�$��0,0,45,0q����� *ModuleInfo.ModuleName+� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+  $��0,0,-6,0q�$
��Left=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Right=�$
��Wrap=�$��Center=�#���  $��0,0,12.998,-0.002q�$��9.333(�� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�.   
MySequence$. TrueSequence=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Right=�$
��Wrap=�$��Center=�#���  $
��True��$��0,0,12.999,-0.001q�$��9.333(�� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�$. FalseSequence=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Right=�$
��Wrap=�$��Center=�#���  $��False��$��0,0,13,0q�$��9.333(��� #���  ) . }�. #���  $��0q�
�������$��0q����	#00828790���� *ModuleValues+��Z� � -   $( ForNode��$y�	Collapsed=�.+��� -   $ RootLayout_Copy3��$ 15�����	#7F003000$��-5q��� .+�� $��Center=�.+��� $
��Left=�$
��Wrap=�$	��Top=�#���  $+ Center=�$��9.333(�$��0,0,45,0q�$	��FOR��� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+  $��0,0,-6,0q�$
��Left=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Right=�$
��Wrap=�$��Center=�#���  $��0,0,12.998,-0.002q�$��9.333(�� $��Center=�$��0,5,0,0q�.+�  $��0q�$��Right=�$	 OUT=�	 �� *PathPointSelectCommand+
 �� *PathPointEnterCommand+ �� *PathPointLeaveCommand+�� $��Right=�$
��Wrap=�$��Center=�#���  $
��Roop��$��0,0,12.999,-0.001q�$��9.333(��� #���  ) . }�. #���  $��0q�
�������$��0q����	#00828790���� *ModuleValues+��Z� 