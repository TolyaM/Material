   M S B A M L   `   `   `  ����U  QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null{Sclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf#MaterialDesignThemes.Wpf.Converters  5   �   C ?Material, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null   Material.App   6   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6P   X TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    6�   f
ConvertersSclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf    6�   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  67  :d2http://schemas.microsoft.com/expression/blend/2008  6�  Fd1p1;http://schemas.openxmlformats.org/markup-compatibility/2006  6�    �� 	Resources  5       �� MergedDictionaries �� Source7 clr-namespace:Material.ViewModelMaterial.ViewModel 5   F   )  #Material.ViewModel.ViewModelLocator   Key  ExpanderStyle �� 
TargetType �� Property �� Value  MaterialDesignPaper �� RelativeSource �� AncestorLevel �� AncestorType	 �� 
TargetType
 � 	Resources �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value<  6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration	   To   From   GeneratedEasingFunction.  (System.Windows.Media.Animation.CubicEase7	  1System.Windows.Media.Animation.EasingFunctionBase 	  
EasingMode   
Storyboard R� KeyTime R� Value
  System.Windows.Visibility g� Duration	 W� To   States   System.Windows.VisualState    
Storyboard! d�Name" � Cursor# �� HeaderStringFormat$ �� ContentStringFormat% J� Opacity& J� RenderTransformOrigin' d� 	IsChecked( �� Mode) �� EndPoint* �� 
StartPoint+ � Offset, J� Effect3  -System.Windows.Media.Effects.DropShadowEffect-   
BlurRadius.   ShadowDepth/   Color0 �� Padding1 � ColumnDefinitions2 �� ContentStringFormat0  *System.Windows.Media.Animation.QuarticEase9  3System.Windows.Media.Animation.EasingDoubleKeyFrame3 O� KeyTime4 O� Value'   !MaterialDesignThemes.Wpf.PackIcon5  Name�   �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]6   Kind7 ��Name8 ��Name9 `� UpdateSourceTrigger: `� 	Converter?   9MaterialDesignThemes.Wpf.Converters.MathMultipleConverter;   	Operation< �� ElementName= �� Path> ��Name? �� Triggers@ :� RoutedEventA :� 
SourceNameB ��Name  OnMouseMove1  
OnChecked1  OnChecked_Copy1C P� PropertyD P� ValueE �� 
TargetNameF � RowDefinitionsG �� Angle�� 5       5      �� 5   
   $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6   5      �� 5   
   $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6   5	      �� 5
   
   $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6   5      �� 5   
   $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6   5      �� 5   
   $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6   5      �� 5   
   $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6   5      �� 5   
   $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6   5      �� 5   
   $x rpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.BlueGrey.xaml?�6   5      �� 5   
   $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6     5      )vm clr-namespace:Material.ViewModel  6F   Locator  5      %�T  &	       7  7  7  �� 5      " 9�6$   .�5   
   ��  � ��$ 0q�6,   �� 5   
    � ��# �  6'   �� 5   
    � �� 6'   �� *(TextElement.Foreground)+ �� *FindAncestor+$ 1��" ��� 5   
    � ��$ Stretch=�67   �� 5    
    � ��$	 Top=�65   �� 5!   
    � �� 5"      �� 5#      "	 9�6   
 5$      ���� 5%      
OnChecked1  .��5&      �� $N H(Panel.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�61   $ 
HeaderSite��6�   .g�5'        $ 0:0:0.1��6*   $ 	#FFE6E9EA��6<     5(      $ 0:0:0.5��6*   $ 	#FFF4F5F5��6<   5)      *� 5*      $7 1(Panel.Background).(LinearGradientBrush.EndPoint)�61   $ 
HeaderSite��6   .'�5+        $ 0:0:0.1��6*   $ 0,-19&�6<     5,      $ 0:0:0.5��6*   $
 0,-4&�6<   5-      *� 5.      $9 3(Panel.Background).(LinearGradientBrush.StartPoint)�61   $ 
HeaderSite��6�   .'�5/        $ 0:0:0.1��6*   $
 -1,0&�6<   50      51      �� 52      OnChecked_Copy1  .��53      �� $N H(Panel.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�61   $ 
HeaderSite��6�   .g�54      �� $ 0:0:0.4��6*   $ 	#FFE6E9EA��6<   �� 55      $ 0:0:0.5��6*   $ Transparent��6<   56      *� 57      $7 1(Panel.Background).(LinearGradientBrush.EndPoint)�61   $ 
HeaderSite��6   .'�58      �� $ 0:0:0.4��6*   $ 0,-19&�6<   �� 59      $ 0:0:0.5��6*   $ 0.5,1&�6<   5:      *� 5;      $9 3(Panel.Background).(LinearGradientBrush.StartPoint)�61   $ 
HeaderSite��6�   .'�5<      �� $ 0:0:0.4��6*   $
 -1,0&�6<   �� 5=      $ 0:0:0.5��6*   $ 0.5,0&�6<   5>      5?      �� 5@      OnMouseMove1  .��5A      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�61   $ 
HeaderSite��6z   .g�5B        $ 0��6*   $ 	#FF30577E��66   5C      r� 5D      $ (Border.BorderThickness)�65   $ 
HeaderSite��6j   .	�5E        $ 0��6.   $ 2q�6:   5F      5G      5H      .R�5I      �� #��z��6   #��z��6C    5J        5K      ExpansionStates�� 5L        5M      $ 0D�69   $ Expanded��6O    6)   Z�  5N        5O      $ EaseOut=�6&   . 5Q      �� .��5R      T� $ 
Visibility�6:   $ PART_Content��6a   ..�5S      i� $ 0��65    5T       
 5U   "   Visible=�66   5W      5X      W� 5Y      $ 0:0:0.3D�6,   $ 1X�6?   $ Opacity�6F   $ PART_Content��6j   5Z      5[        5\      $ 0D�69   $ 	Collapsed��6O    6)   Z�  5]        5^      $ EaseOut=�6&   . 5`      �� .��5a      T� $ 
Visibility�6:   $ PART_Content��6a   ..�5b      i� $ 0:0:0.3��65    5c       
 5d   "   	Collapsed=�68   5f      5g      W� 5h      $ 0:0:0.3D�6,   $ 0X�6?   $ Opacity�6F   $ PART_Content��6j   5i      5j      . 5l        Expanded��.  5m      �� .��5n      W� $ 0D�6*   $ 1X�67   $ Opacity�6>   $ PART_Content��6b   T� 5o      $ 
Visibility�68   $ PART_Content��6_   ..�5p      i� $ 0��63    5q      
 5r       Visible=�64   5t      5u      5v      5w        5x      	Collapsed��.  5y      �� .��5z      W� $ 0D�6*   $ 0X�67   $ Opacity�6>   $ PART_Content��6b   T� 5{      $ 
Visibility�68   $ PART_Content��6_   ..�5|      i� $ 0��63    5}      
 5~       
Hidden=�63   5�      5�      5�      5�      5�      ._�5�      � .+�5�      ]� #��z��6   .+�5�      d� $! 
HeaderSite��6#   $��0q�67   $
" Hand��6K   #��z��6Y   #��z��6�   #$ z# 6�   $	��Top=�6�   #��z��6�   $��14(�6)  $
% 0.87Q�6�  $& 0.5,0.5&�6�  ' 67  �� *
IsExpanded+$( TwoWay=� �� *TemplatedParent+��5�      �� 5�      $) 0.5,1&�6.   $* 0.5,0&�6?   .��5�      � $+ 0Q�6)   � 5�      $+ 1Q�6)   5�      , 5�        5�      $- 0Q�6+   $. 0Q�6:   $/ 	#FFC3C3C3��6J   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      ��5�      �� 5�      " d�6    .�5�      ��  � ��
 ���� 69   �� 5�       � ��$ Stretch=�6B   �� 5�       � ��$ Center=�6@   �� 5�       � �� 5�      �� 5�       "	 d�60   .R�5�   "   �� #��z��6)   $0 24,12q�6S   ._�5�   $   � 1 5�   &   �� 5�   (   �� 5�   (   $
��Auto �69   .+�5�   &   �� #��z��67   #��z��6k   #2 z$ 6�   $��0,0,16,0q�6�   $��Center=�6�   d� 5�   &   $��1��63   #��z��6C   $��Center=�6�   ' 6m   �� *	IsChecked+$( TwoWay=� �� *TemplatedParent+��5�   (   �� 5�   *   " d�60   .�5�   ,   ��  � �� 5�   .   �� 5�   0   "	 d�6@   .R�5�   2   �� 
������  5�   4     5�   6   CheckStates�� 5�   8     5�   :   $ 	Unchecked��6K   $ 0D�6\   $ Checked��6r    5�   <     5�   >   $ EaseOut=�6J   . 5�   <   �� .��5�   >   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6\   $ 
ExpandPath��6�   .\�5�   @     $3 0��6U   $4 0Q�6a     5�   @   $3 0:0:0.2��6U   $
4 -180Q�6g   5�   ?   5�   =   5�   ;     5�   :   $ 0D�6[   $ 	Unchecked��6�    6K   Z�  6q   Z� . 5�   <   �� .��5�   >   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6\   $ 
ExpandPath��6�   .\�5�   @     $3 0��6U   $
4 -180Q�6a   5�   ?   5�   =   5�   ;     5�   :   $ 0D�6[   $ Checked��6�    6K   Z�  6q   Z� . 5�   <   �� .��5�   >   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6\   $ 
ExpandPath��6�   .\�5�   @     $3 0��6U   $4 0Q�6a   5�   ?   5�   =   5�   ;     5�   :   $ Checked��6K   $ 0D�6Z   $ 	Unchecked��6p    5�   <     5�   >   $ EaseOut=�6J   . 5�   <   �� .��5�   >   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6\   $ 
ExpandPath��6�   .\�5�   @     $3 0��6U   $
4 -180Q�6a     5�   @   $3 0:0:0.2��6U   $4 0Q�6g   5�   ?   5�   =   5�   ;   . 5�   8     Checked��.  5�   :   �� .��5�   <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�   >     $3 0:0:0.2��6S   $
4 -180Q�6e   5�   =   5�   ;   5�   9     5�   8   	Unchecked��.  5�   :   �� .��5�   <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�   >     $3 0:0:0.2��6S   $4 0Q�6e   5�   =   5�   ;   5�   9   5�   7   ._�5�   4     $5 
ExpandPath��6L   #��z��6`   $��24��6�   $6 ChevronDown=�6�   $
% 0.38Q�6�   $& 0.5,0.5&�6�   $��24��6�   z�5�   6   V� 5�   8   .~�5�   :   �� �� 5�   :   �� 5�   :   T� 5�   :   5�   9   5�   5   5�   3   5�   1   5�   -   5�   +   5�   '   5�   %   5�   #   5�   !   5�      5�      5      �� 5     $7 ContentSite��6   $��Bottom=�62   ._�5     �� $8 ContentPanel��6#   #��z��69   #��z��6|   #��z��6�   ��5     `� 5     $9 Default=�6)   : 5       5      $; Multiply=�6A   .1�5     �� $< PART_Content��6&   $= ActualHeight�6A   �� 5	     $< PART_Content��6&   $= Opacity�6A   5
     ��5     `� 5     $9 Default=�6)   : 5       5      $; Multiply=�6A   .1�5     �� $< PART_Content��6&   $= ActualWidth�6A   �� 5     $< PART_Content��6&   $= Opacity�6A   5     .+�5     �� $> PART_Content��6+   #��z��6A   #��z��6u   #2 z$ 6�   |�.  6�   5     5     5     5     5     ? 5     :� 5     $@ UIElement.MouseMove��6   $A 
HeaderSite��6A   .[�5     �� $"B OnMouseMove1_BeginStoryboard��6$   8��  6J   5     :� 5     $@ ToggleButton.Checked��6   $A 
HeaderSite��6B   .[�5      �� 8�� 6$   5!     :� 5"     $@ ToggleButton.Unchecked��6   $A 
HeaderSite��6D   .[�5#     �� $%B OnChecked_Copy1_BeginStoryboard��6$   8�� 6M   5$     P� 5%     C �@9�ExpandDirection$
D Down=�65   P� 5&     C �@9�ExpandDirection$D Right=�65   . �5'     �� $E 
HeaderSite��65    � ��$
 Left=�6M   �� 5(     $E ContentSite��65    � ��$ Right=�6N   �� 5)     $E ContentPanel��62    �@��Orientation$ 
Horizontal=�6L   �� 5*     $E ContentPanel��6-    � ��$
 Auto��6G   �� 5+     $E 
HeaderSite��6,    � �� 5,     �� 5-     " d�6   .�5.     ��  � ��
 ���� 67   �� 5/      � ��$
 Left=�6@   �� 50      � ��$ Stretch=�6>   �� 51      � �� 52     �� 53     "	 d�6.   .R�54      �� #��z��6'   $0 12,24q�6Q   ._�55  "   � F 56  $   �� 57  &   $
��Auto �64   �� 58  &   .+�5:  $   d� #��z��61   $��Center=�6[   $��0��6�   $& 0.5,0.5&�6�   ' 6x   �� *	IsChecked+$( TwoWay=� �� *TemplatedParent+z�5;  &   �� 5<  (   $	G -90Q�68   ��5>  &   �� 5?  (   " d�6.   .�5@  *   ��  � �� 5A  ,   �� 5B  .   "	 d�6>   .R�5C  0   �� 
������  5D  2     5E  4   CheckStates�� 5F  6     5G  8   $ 	Unchecked��6I   $ 0D�6Z   $ Checked��6p    5H  :     5I  <   $ EaseOut=�6H   . 5K  :   �� .��5L  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5M  >     $3 0��6S   $4 0Q�6_     5N  >   $3 0:0:0.2��6S   $
4 -180Q�6e   5O  =   5P  ;   5Q  9     5R  8   $ 0D�6Y   $ 	Unchecked��6�    6I   Z�  6o   Z� . 5S  :   �� .��5T  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5U  >     $3 0��6S   $
4 -180Q�6_   5V  =   5W  ;   5X  9     5Y  8   $ 0D�6Y   $ Checked��6�    6I   Z�  6o   Z� . 5Z  :   �� .��5[  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5\  >     $3 0��6S   $4 0Q�6_   5]  =   5^  ;   5_  9     5`  8   $ Checked��6I   $ 0D�6X   $ 	Unchecked��6n    5a  :     5b  <   $ EaseOut=�6H   . 5d  :   �� .��5e  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5f  >     $3 0��6S   $
4 -180Q�6_     5g  >   $3 0:0:0.2��6S   $4 0Q�6e   5h  =   5i  ;   5j  9   . 5l  6     Checked��.  5m  8   �� .��5n  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5o  <     $3 0:0:0.2��6Q   $
4 -180Q�6c   5p  ;   5q  9   5r  7     5s  6   	Unchecked��.  5t  8   �� .��5u  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5v  <     $3 0:0:0.2��6Q   $4 0Q�6c   5w  ;   5x  9   5y  7   5z  5   ._�5|  2     $5 
ExpandPath��6J   #��z��6^   $��24��6�   $6 ChevronDown=�6�   $
% 0.38Q�6�   $& 0.5,0.5&�6�   $��24��6�   z�5}  4   V� 5~  6   .~�5  8   �� �� 5�  8   �� 5�  8   T� 5�  8   5�  7   5�  3   5�  1   5�  /   5�  +   5�  )   5�  %   �� 5�  $   #��z��65   $��Center=�6Y   $��0,16,0,0q�6v   $��1��6�   $	��Top=�6�   5�  #   5�  !   5�     5�     5�     5�     5�     P� 5�     C �@9�ExpandDirection$
D Left=�65   . �5�     �� $E 
HeaderSite��65    � ��$ Right=�6M   �� 5�     $E ContentSite��65    � ��$
 Left=�6N   �� 5�     $E ContentPanel��62    �@��Orientation$ 
Horizontal=�6L   �� 5�     $E ContentPanel��6-    � ��$
 Auto��6G   �� 5�     $E 
HeaderSite��6,    � �� 5�     �� 5�     " d�6   .�5�     ��  � ��
 ���� 67   �� 5�      � ��$ Right=�6@   �� 5�      � ��$ Stretch=�6>   �� 5�      � �� 5�     �� 5�     "	 d�6.   .R�5�      �� #��z��6'   $0 12,24q�6Q   ._�5�  "   � F 5�  $   �� 5�  &   $
��Auto �64   �� 5�  &   .+�5�  $   d� #��z��61   $��Center=�6[   $��0��6�   $& 0.5,0.5&�6�   ' 6x   �� *	IsChecked+$( TwoWay=� �� *TemplatedParent+z�5�  &   �� 5�  (   $G 90Q�68   ��5�  &   �� 5�  (   " d�6.   .�5�  *   ��  � �� 5�  ,   �� 5�  .   "	 d�6>   .R�5�  0   �� 
������  5�  2     5�  4   CheckStates�� 5�  6     5�  8   $ 	Unchecked��6I   $ 0D�6Z   $ Checked��6p    5�  :     5�  <   $ EaseOut=�6H   . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $4 0Q�6_     5�  >   $3 0:0:0.2��6S   $
4 -180Q�6e   5�  =   5�  ;   5�  9     5�  8   $ 0D�6Y   $ 	Unchecked��6�    6I   Z�  6o   Z� . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $
4 -180Q�6_   5�  =   5�  ;   5�  9     5�  8   $ 0D�6Y   $ Checked��6�    6I   Z�  6o   Z� . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $4 0Q�6_   5�  =   5�  ;   5�  9     5�  8   $ Checked��6I   $ 0D�6X   $ 	Unchecked��6n    5�  :     5�  <   $ EaseOut=�6H   . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $
4 -180Q�6_     5�  >   $3 0:0:0.2��6S   $4 0Q�6e   5�  =   5�  ;   5�  9   . 5�  6     Checked��.  5�  8   �� .��5�  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5�  <     $3 0:0:0.2��6Q   $
4 -180Q�6c   5�  ;   5�  9   5�  7     5�  6   	Unchecked��.  5�  8   �� .��5�  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5�  <     $3 0:0:0.2��6Q   $4 0Q�6c   5�  ;   5�  9   5�  7   5�  5   ._�5�  2     $5 
ExpandPath��6J   #��z��6^   $��24��6�   $6 ChevronDown=�6�   $
% 0.38Q�6�   $& 0.5,0.5&�6�   $��24��6�   z�5�  4   V� 5�  6   .~�5�  8   �� �� 5�  8   �� 5�  8   T� 5�  8   5�  7   5�  3   5�  1   5�  /   5�  +   5�  )   5�  %   �� 5�  $   #��z��65   $��Center=�6Y   $��0,16,0,0q�6v   $��1��6�   $	��Top=�6�   5�  #   5   !   5     5     5     5     5     P� 5     C �@9�ExpandDirection$D Up=�65   . �5	     �� $E 
HeaderSite��65    � ��$ Bottom=�6M   �� 5
     $E ContentSite��65    � ��$	 Top=�6N   �� 5     $E ContentPanel��62    �@��Orientation$ Vertical=�6L   �� 5     $E ContentPanel��6,    � ��$
 Auto��6F   �� 5     $E 
HeaderSite��6,    � �� 5     �� 5     " d�6   .�5     ��  � ��
 ���� 67   �� 5      � ��$ Stretch=�6@   �� 5      � ��$ Center=�6>   �� 5      � �� 5     �� 5     "	 d�6.   .R�5      �� #��z��6'   $0 24,12q�6Q   ._�5  "   � 1 5  $   �� 5  &   �� 5  &   $
��Auto �67   .+�5  $   �� #��z��65   $��0,0,16,0q�6Y   $��Center=�6k   d� 5  $   $��1��61   #��z��6A   $& 0.5,0.5&�6�   $��Center=�6�   ' 6k   �� *	IsChecked+$( TwoWay=� �� *TemplatedParent+z�5  &   �� 5  (   $
G -180Q�68   ��5!  &   �� 5"  (   " d�6.   .�5#  *   ��  � �� 5$  ,   �� 5%  .   "	 d�6>   .R�5&  0   �� 
������  5'  2     5(  4   CheckStates�� 5)  6     5*  8   $ 	Unchecked��6I   $ 0D�6Z   $ Checked��6p    5+  :     5,  <   $ EaseOut=�6H   . 5.  :   �� .��5/  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�50  >     $3 0��6S   $4 0Q�6_     51  >   $3 0:0:0.2��6S   $
4 -180Q�6e   52  =   53  ;   54  9     55  8   $ 0D�6Y   $ 	Unchecked��6�    6I   Z�  6o   Z� . 56  :   �� .��57  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�58  >     $3 0��6S   $
4 -180Q�6_   59  =   5:  ;   5;  9     5<  8   $ 0D�6Y   $ Checked��6�    6I   Z�  6o   Z� . 5=  :   �� .��5>  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5?  >     $3 0��6S   $4 0Q�6_   5@  =   5A  ;   5B  9     5C  8   $ Checked��6I   $ 0D�6X   $ 	Unchecked��6n    5D  :     5E  <   $ EaseOut=�6H   . 5G  :   �� .��5H  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5I  >     $3 0��6S   $
4 -180Q�6_     5J  >   $3 0:0:0.2��6S   $4 0Q�6e   5K  =   5L  ;   5M  9   . 5O  6     Checked��.  5P  8   �� .��5Q  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5R  <     $3 0:0:0.2��6Q   $
4 -180Q�6c   5S  ;   5T  9   5U  7     5V  6   	Unchecked��.  5W  8   �� .��5X  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5Y  <     $3 0:0:0.2��6Q   $4 0Q�6c   5Z  ;   5[  9   5\  7   5]  5   ._�5_  2     $5 
ExpandPath��6J   #��z��6^   $��24��6�   $6 ChevronDown=�6�   $
% 0.38Q�6�   $& 0.5,0.5&�6�   $��24��6�   z�5`  4   V� 5a  6   .~�5b  8   �� �� 5c  8   �� 5d  8   T� 5e  8   5f  7   5h  3   5i  1   5j  /   5l  +   5m  )   5o  %   5p  #   5q  !   5r     5t     5u     5w     5x     P� 5y     C �@9�ExpandDirection$
D Down=�65   . �5z     �� $E 
HeaderSite��65    � ��$	 Top=�6M   �� 5{     $E ContentSite��65    � ��$ Bottom=�6N   �� 5|     $E ContentPanel��62    �@��Orientation$ Vertical=�6L   �� 5}     $E ContentPanel��6,    � ��$
 Auto��6F   �� 5~     $E 
HeaderSite��6,    � �� 5     �� 5�     " d�6   .�5�     ��  � ��
 ���� 67   �� 5�      � ��$ Stretch=�6@   �� 5�      � ��$ Center=�6>   �� 5�      � �� 5�     �� 5�     "	 d�6.   .R�5�      �� #��z��6'   $0 24,12q�6Q   ._�5�  "   � 1 5�  $   �� 5�  &   �� 5�  &   $
��Auto �67   .+�5�  $   �� #��z��65   #��z��6i   #2 z$ 6�   $��0,0,16,0q�6�   $��Center=�6�   d� 5�  $   $��1��61   #��z��6A   $��Center=�6�   ' 6k   �� *	IsChecked+$( TwoWay=� �� *TemplatedParent+��5�  &   �� 5�  (   " d�6.   .�5�  *   ��  � �� 5�  ,   �� 5�  .   "	 d�6>   .R�5�  0   �� 
������  5�  2     5�  4   CheckStates�� 5�  6     5�  8   $ 	Unchecked��6I   $ 0D�6Z   $ Checked��6p    5�  :     5�  <   $ EaseOut=�6H   . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $4 0Q�6_     5�  >   $3 0:0:0.2��6S   $
4 -180Q�6e   5�  =   5�  ;   5�  9     5�  8   $ 0D�6Y   $ 	Unchecked��6�    6I   Z�  6o   Z� . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $
4 -180Q�6_   5�  =   5�  ;   5�  9     5�  8   $ 0D�6Y   $ Checked��6�    6I   Z�  6o   Z� . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $4 0Q�6_   5�  =   5�  ;   5�  9     5�  8   $ Checked��6I   $ 0D�6X   $ 	Unchecked��6n    5�  :     5�  <   $ EaseOut=�6H   . 5�  :   �� .��5�  <   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6Z   $ 
ExpandPath��6�   .\�5�  >     $3 0��6S   $
4 -180Q�6_     5�  >   $3 0:0:0.2��6S   $4 0Q�6e   5�  =   5�  ;   5�  9   . 5�  6     Checked��.  5�  8   �� .��5�  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5�  <     $3 0:0:0.2��6Q   $
4 -180Q�6c   5�  ;   5�  9   5�  7     5�  6   	Unchecked��.  5�  8   �� .��5�  :   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6X   $ 
ExpandPath��6�   .\�5�  <     $3 0:0:0.2��6Q   $4 0Q�6c   5�  ;   5�  9   5�  7   5�  5   ._�5�  2     $5 
ExpandPath��6J   #��z��6^   $��24��6�   $6 ChevronDown=�6�   $
% 0.38Q�6�   $& 0.5,0.5&�6�   $��24��6�   z�5�  4   V� 5�  6   .~�5�  8   �� �� 5�  8   �� 5�  8   T� 5�  8   5�  7   5�  3   5�  1   5�  /   5�  +   5�  )   5�  %   5�  #   5�  !   5�     5�     5�     5�     5�     5�     5�     5�  	   5�     5�     