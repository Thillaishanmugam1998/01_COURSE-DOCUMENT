   M S B A M L   `   `   `  ����K  GWPF DATABINDINGS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_DATABINDINGSWPF_DATABINDINGS  5   	   &     WPF_DATABINDINGS.ElementBindings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_DATABINDINGS     5   	     � Title$  ElementBindings��5   	   $	��450��6!   $	��800��6.   .��5	      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ textBoxWithoutBinding��5      $��0��61   $��0��6>   $	��150��6N   $��5q�6Z   �� 5   
   -   5        $��1��5      $��0��6   $ ��Click Me (Without Binding)��6.   $	��150��6S   $��5q�6_   5      �� 5   
   -   5        $ textBoxSource��5      $��0��6)   $��1��66   $	��150��6F   $��5q�6R   �� 5   
   -   5        $��1��5      $��1��6   $%��Click Me (With Element Binding)��6.   $��
120,5,93,5q�6X   5      �� 5!   
   $��2��6   $��1��6   $	��150��6/   $��5q�6;   ��5"      ��  �� ElementName$ textBoxSource�� �� Path$
 Text� �� UpdateSourceTrigger$ PropertyChanged=�5#      5$      