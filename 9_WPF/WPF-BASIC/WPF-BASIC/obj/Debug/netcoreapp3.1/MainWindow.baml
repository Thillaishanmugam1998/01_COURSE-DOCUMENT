   M S B A M L   `   `   `  ����D  @WPF-BASIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_BASIC	WPF_BASIC  5   	       WPF_BASIC.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPF_BASIC     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         WindowButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6*   .�5      ��  � ��
 � � �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 10,5q�6(   5      5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5"   
   �� $��0��6   $��0��6!   $��Enter Name:��61   $��Center=�6D   $��5q�6_   $
��Bold"�6j   �� 5#   
   $��0��6   $��1��6   $	��200��6/   $��5q�6;    � ToolTip$ Hover over me!��6F   �� 5%   
   $��1��6   $��0��6!   $��Select Gender:��61   $��Center=�6G   $��5q�6b   $
��Bold"�6m   �� 5&   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��5q�6K   .+�5'      	� $
��Male��6   	 	� 	GroupName$	 Gender��6)   $��5q�6<   	� 5(      $��Female��6   $	 Gender��6+   $��5q�6>   5)      �� 5,   
   -   5        $��2��5,      $��0��6   $��Submit��6.     AppButtonStyle#��[ 6?   6g   �� 5/   
   $��2��6   $��1��6   $��Cancel��6.   #��[  6?   50      52      