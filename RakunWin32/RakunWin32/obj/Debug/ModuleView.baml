   M S B A M L   `   `   `  ����E  ARakunWin32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RakunWin32
RakunWin32  5          RakunWin32.ModuleView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:RakunWin32     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5      -   5          >�Name$  UserControl��5      
������� � 	Resources 5         	OnCreated �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  	ValueList   RakunWin32.PathPointNode   PathType	   DraggingCommand
   EnterCommand   LeaveCommand �� Orientation  ListBoxItemStyle1 �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value # RakunValueNodeViewModelTemplate   DirectionType��%X  &	        &	 L    &	 <    &	 �    �� 5      .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6#   $ 
RootLayout��6�   .\�5        $ 0��6   $ 0Q�6'     5      $ 0:0:0.3��6   $ 1Q�6-    5        5      $ EaseOut=�6   5      5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6#   $ 
RootLayout��6�   .\�5        $ 0��6   $ 0Q�6'     5      $ 0:0:0.3��6   $ 1Q�6-    5        5      $ EaseOut=�6   5      5      5      �� 5      .R�5       � .+�5!        $
��Left=�6   $��0q�65   $��Center=�6@   $ Value=�6[   ���	#FF4CFFCE	 6�   �� *PathPointSelectCommand+
 6�   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+  5"      $��Right=�6   $��0,0,3,0q�66   $��Center=�6G   $ Value=�6b   ���	#FF4CFFCE	 6�   �� *PathPointSelectCommand+
 6�   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+�� 5#      $��Stretch=�6   $
��Auto��6/   $��Center=�6=   $
��Auto��6X   $
��15,0q�6e   $ 
Horizontal=�6s   .+�5$      �� $��0q�6   $
��Wrap=�6   $��Stretch=�6J   $��15.96��6f   $��9.333(�6u   ��60   �� *
NodeName+6u   5%      5&      5'      �� 5(      " ��6$   .�5)      ��  � ��
 ���� 6"   �� 5*       � �� 62   �� *HorizontalContentAlignment+ �� " ���� 5+       � �� 60   �� *VerticalContentAlignment+ �� " ���� 5,       � ��$ 2,0,0,0q�6   �� 5-       � �� 5.      �� 5/      " ��6   .R�50      �� $ Bd��6   #��z��6   #��z��6G   #��z��6{    . ._�51   	   �� # z 6   #��z��6V   52   	    53      P� 54   	    �@��
IsSelected . . �55   
   �� $ Bd��6'   # � ��67    � ���� 56   
   # � ��6'    � ��57   
   ]� 58   	    59   
   �� 5:       �@��
IsSelected . 6+   �� 5;       �@��IsSelectionActive .  6;   ./�5=   
   �� $ Bd��6'   # � ��67    � ���� 5>   
   # � ��6'    � ��5?   
   P� 5@   	    � {� .  . �5A   
   �� # � ��6'    � ��5B   
   5D      5F      5G      �� 5H      .R�5I      � $
��Auto��6
   $
��Auto��6   .+�5J        $
��Left=�6   $��0q�65   $��Center=�6@   $ Value=�6[   ���	#FF4CFFCE$��10��6  $��10��6  |�. 	 6�   �� *PathPointSelectCommand+
 6�   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6+  �� 5K      $��Stretch=�6   $
��Auto��6/   $��Center=�6=   $
��15,0q�6X   $ 
Horizontal=�6f   .+�5L      �� $��0q�6   $
��Wrap=�6   $��Stretch=�6K   $��15.96��6g   $��9.333(�6v   ��60   �� *	ValueName+6v   5M        5N      $��Right=�6   $��0,0,3,0q�66   $��Center=�6G   $ Value=�6b   ���	#FF4CFFCE$��10��6  $��10��6&  |�. $	 OUT=�6C  	 6�   �� *PathPointSelectCommand+
 6�   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6C  5O      5P      5Q       � Triggers 5R      :� 5S       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5T      �� #��[  6   5U      .��5X      �� -   5        $ 
RootLayout��5X   
    �� CornerRadius$ 15��6   ���	#00000000  J� RenderTransformOrigin$  0.5,0.5&�6�   ! � LayoutTransform! 5Y      V� 5Z      .~�5[      �� " �� ScaleX$	" 1.2Q�6   # �� ScaleY$	# 1.2Q�6"   �� 5\      �� 5]      T� 5^      5_      z�5a      V� 5b      .~�5c      �� �� 5d      �� 5e      T� 5f      5g      .  (System.Windows.Interactivity.Interaction$   Triggers$ 5j      /  )System.Windows.Interactivity.EventTrigger  5k      %   	EventName$% Loaded��6   .  (System.Windows.Interactivity.TriggerBase&   Actions.& 5l      F  @Microsoft.Expression.Interactivity.Media.ControlStoryboardAction  ?	  9Microsoft.Expression.Interactivity.Media.StoryboardAction' 	  
Storyboard#' [  6!   5m      ._�5p      � -   5        ( �Name$( 
LayoutRoot��5p   	   $��5q�6   ���	#00000000) J� IsHitTestVisible) . .+�5q      � -   5        $( 	InputNode��5q   
   $��Center=�6   $��0,0,0,-0.001q�68   .+�5r      �� -   5        $ RootLayout_Copy5��5r      $ 15��6'   ���	#7F000000$��-5q�6�   �� 5s      $��Center=�6   .+�5t      �� $��Center=�6!   $��0q�6<   $ 
Horizontal=�6G   .+�5u        $
��Left=�6.   $��Center=�6�   $��0,0,3,0q�6�   $ Value=�6  ���	#FF4CFFCE	 6I   �� *PathPointSelectCommand+
 6|   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6  �� 5v      $ 
Horizontal=�6%   $��0,0,3,0q�6>   .+�5w      �� -   5        * ��Name$* TBTitle3��5w   (   $
��Left=�6:   $
��Wrap=�6U   $��Center=�6�     
Foreground#���  6�   + �� TextAlignment$+ Center=�6�   $��9.333(�6�   $��0q�6�   $��70��6  ��6i   �� *ModuleInfo.ModuleName+6  �� 5x      -   5        $* TBTitle3_Copy��5x   (   $
��Wrap=�6?   $��:��6S   $��Center=�6\   #���  6w   $+ Center=�6�   $��9.333(�6�   $	��3,0q�6�   �� 5y      -   5        , ��Name$, tbinput��5y   &   - �� TextWrapping$
- Wrap=�67   $��Center=�6b   $��9.333(�6}   $��20��6�   ��6K   �� *input+6�   5z        5{      $
��Left=�6.   $��Center=�6�   $��0,0,3,0q�6�   $	 OUT=�6  $ Value=�6  ���	#FF4CFFCE	 6I   �� *PathPointSelectCommand+
 6|   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6+  5|      5}      5~      � 5      -	   5        $( 	ValueNode��5   
   $��Center=�6   $y�	Collapsed=�68   .+�5�      �� -
   5        $ RootLayout_Copy4��5�      $ 15��6'   ���	#7F000000$��-5q�6�   �� 5�      $��Center=�6   .+�5�      �� $��Center=�6   $��0q�6-   $ 
Horizontal=�68   .+�5�        $
��Left=�6   $��Center=�6�   $��0,0,3,0q�6�   $ Value=�6�   ���	#FF4CFFCE	 67   �� *PathPointSelectCommand+
 6j   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6  �� 5�      -   5        $* TBTitle1��5�      $
��Left=�6$   $
��Wrap=�6?   $��Center=�6z   #���  6�   $+ Center=�6�   $��9.333(�6�   $��0,0,4,0q�6�   $��70��6�   ��6S   �� *ModuleInfo.ModuleName+6�     5�      $
��Left=�6   $��Center=�6�   $��0,0,3,0q�6�   $	 OUT=�6�   $ Value=�6  ���	#FF4CFFCE	 67   �� *PathPointSelectCommand+
 6j   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6  5�      5�      5�      � 5�      -   5        $( 
ModuleNode��5�   
   $y�	Collapsed=�6   .+�5�      �� -   5        $ RootLayout_Copy��5�      $ 15��6&   ���	#7F000000$��-5q�6�   �� 5�      .+�5�      � $��Center=�6   .+�5�      �� -   5        $* TBTitle��5�      $
��Left=�6#   $
��Wrap=�6>   $	��Top=�6n   #���  6�   $+ Center=�6�   $��9.333(�6�   $��0,0,45,0q�6�   ��6R   �� *
ModuleName+6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�     5�      $
��Left=�6   	 67   �� *PathPointSelectCommand+
 6j   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+5�      �� 5�      #���  64   ) . }�. #���  6�   $��0q�6�   
����������	#00828790��6   �� *ModuleValues+��6  Z� 6  5�      5�      � 5�      -   5        $( StartingNode��5�   
   $y�	Collapsed=�6    .+�5�      �� -   5        $ RootLayout_Copy1��5�      $ 15��6'   ���	#7F530000$��-5q�6�   �� 5�      .+�5�      � $��Center=�6   .+�5�      �� -   5        $* TBTitle2��5�      $
��Left=�6$   $
��Wrap=�6?   $	��Top=�6S   #���  6k   $+ Center=�6�   $��9.333(�6�   $��0,0,45,0q�6�   $��Starting Point��6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�   5�      5�      5�      � 5�      -   5        $( IFNode��5�   
   $y�	Collapsed=�6   .+�5�      �� -   5        $ RootLayout_Copy2��5�      $ 15��6'   ���	#7F000F55$��-5q�6�   �� 5�      .+�5�      � $��Center=�6   .+�5�      �� $
��Left=�6   $
��Wrap=�6-   $	��Top=�6A   #���  6Y   $+ Center=�6�   $��9.333(�6�   $��0,0,45,0q�6�   ��6�   �� *ModuleInfo.ModuleName+5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�     5�      $��0,0,-6,0q�6   $
��Left=�6.   	 6I   �� *PathPointSelectCommand+
 6|   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+�� 5�      $��Right=�6   $
��Wrap=�6.   $��Center=�6B   #���  6]   $��0,0,12.998,-0.002q�6�   $��9.333(�6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   .   
MySequence$. TrueSequence=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�   �� 5�      $��Right=�6   $
��Wrap=�6.   $��Center=�6B   #���  6]   $
��True��6�   $��0,0,12.999,-0.001q�6�   $��9.333(�6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   $. FalseSequence=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�   �� 5�      $��Right=�6   $
��Wrap=�6.   $��Center=�6B   #���  6]   $��False��6�   $��0,0,13,0q�6�   $��9.333(�6�   5�      �� 5�      #���  64   ) . }�. #���  6�   $��0q�6�   
�������$��0q�6  ���	#00828790��6   �� *ModuleValues+��6  Z� 6"  5�      5�      � 5�      -   5        $( ForNode��5�   
   $y�	Collapsed=�6   .+�5�      �� -   5        $ RootLayout_Copy3��5�      $ 15��6'   ���	#7F003000$��-5q�6�   �� 5�      .+�5�      � $��Center=�6   .+�5�      �� $
��Left=�6   $
��Wrap=�6-   $	��Top=�6A   #���  6Y   $+ Center=�6�   $��9.333(�6�   $��0,0,45,0q�6�   $	��FOR��6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�     5�      $��0,0,-6,0q�6   $
��Left=�6.   	 6I   �� *PathPointSelectCommand+
 6|   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+�� 5�      $��Right=�6   $
��Wrap=�6.   $��Center=�6B   #���  6]   $��0,0,12.998,-0.002q�6�   $��9.333(�6�   5�      � 5�      $��Center=�6   $��0,5,0,0q�6'   .+�5�        $��0q�6   $��Right=�6'   $	 OUT=�6�   	 6C   �� *PathPointSelectCommand+
 6v   �� *PathPointEnterCommand+ 6�   �� *PathPointLeaveCommand+6�   �� 5�      $��Right=�6   $
��Wrap=�6.   $��Center=�6B   #���  6]   $
��Roop��6�   $��0,0,12.999,-0.001q�6�   $��9.333(�6�   5�      �� 5�      #���  64   ) . }�. #���  6�   $��0q�6�   
�������$��0q�6  ���	#00828790��6   �� *ModuleValues+��6  Z� 6"  5�      5�      5�      5�      5�      