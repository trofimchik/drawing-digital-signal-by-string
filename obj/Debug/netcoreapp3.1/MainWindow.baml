   M S B A M L   `   `   `  ����N  JDigitalSignalDrawer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DigitalSignalDrawerDigitalSignalDrawer  5   	   $    DigitalSignalDrawer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DigitalSignalDrawer     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��920��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � DataContext 5	      #  DigitalSignalDrawer.ViewModel  5
   
   6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��70 �6   6,   �� 5      $	��700 �6   6-   �� 5      $	��150 �6   6-    � RowDefinitions 5   
   �� 5      $��20 �6   6*   �� 5      $	��155 �6   6+   �� 5      $��40 �6   6*   .+�5   
   �� $��0��6   $��1��6   ��6/   �� *InputEncoding+ �� UpdateSourceTrigger$ PropertyChanged=�6u   �� 5   
   $��1��6   .+�5      	�  	� 	GroupName$ Encoding��6   $
��UTF7��6O   $
��UTF7��6g   $��RightToLeft=�6v   ��6/   �� *SetEncoding+6�   	� 5      $ Encoding��6   $
��UTF8��6O   $
��UTF8��6g   $��RightToLeft=�6v   ��6/   �� *SetEncoding+6�   	� 5      $ Encoding��6   $��UTF16��6O   $��UTF16��6h   $��RightToLeft=�6x    d� 	IsChecked$
 TrueY�6�   ��6/   �� *SetEncoding+6�   	� 5      $ Encoding��6   $��UTF32��6O   $��UTF32��6h   $��RightToLeft=�6x   ��6/   �� *SetEncoding+6�   	� 5      $ Encoding��6   $��ASCII��6O   $��ASCII��6h   $��RightToLeft=�6x   ��6/   �� *SetEncoding+6�   5      �� 5!   
   $��1��6   $��1��6$   $��Visible=�65   $��Hidden=�6j   .��5"      �� 	 �� Orientation$	 Vertical=�6   .+�5#      �� ��6   �� *OutputEncodingCharArray+��5$      �� 5%      .R�5&      �� $	 
Horizontal=�6)   5'      ��5)      �� 5*      .R�5+      �� $��1q�6%   
���   �._�5,   "   �� 
 �� TextAlignment$
 Center=�6,   $��58��6T   
���������6C   �� 6_   5-      5.      50      �� 51      -   5         ��Name$ 	Container��51      ��62   �� *LinesCoordinates+��52      �� 53      .R�54      �� 
�������$��Center=�55   "   $
��Left=�56   "   ��57   "   ��  �� Path$ DataContext.CanvasWidth� �� RelativeSource ��  �� AncestorType
 Window��58   "   �� $ DataContext.CanvasHeight� �� 
 Window59      ��5;      �� 5<      .R�5=      �� 
���   �	 �� X1 6#   �� *	First.X+	 �� Y1 6:   �� *	First.Y+	 �� X2 5>   #   �� *
Second.X+	 �� Y2 6;   �� *
Second.Y+��5?   2   �� *StrokeThickness+6`   5@      5B      5C      5D      �� 5F   
   $��1��6   $��2��6"   .+�5G      	� $ 
SignalType��6   $	��NRZ��6S   $��Potential Code NRZ��6j   ��61   �� *SetSignalType+6�   	� 5H      $ 
SignalType��6   $	��AMI��6S   $��Bipolar Code AMI��6j   $
 TrueY�6�   ��61   �� *SetSignalType+6�   	� 5I      $ 
SignalType��6   $��BipolarPulse��6S   $��Bipolar Pulse Code��6s   ��61   �� *SetSignalType+6�   	� 5J      $ 
SignalType��6   $��
Manchester��6S   $��Manchester Code��6q   ��61   �� *SetSignalType+6�   	� 5K      $ 
SignalType��6   $
��2B1Q��6S   $��Potential Code 2B1Q��6k   ��61   �� *SetSignalType+6�   5L      �� 5N   
   $��2��6   $��1��6$   $
��Auto=�64   $��Hidden=�6f   .��5O      �� 
���������6/   �� *OutputEncoding+6Q   5P      5Q      5R      