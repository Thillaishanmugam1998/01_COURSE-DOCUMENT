   M S B A M L   `   `   `  ����K  GWPF DATABINDINGS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_DATABINDINGSWPF_DATABINDINGS  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   '    !WPF_DATABINDINGS.ResourceBindings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_DATABINDINGS     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  ResourceBindings��5	   	   $	��450��6"   $	��800��6/    � 	Resources 5         TextBoxBackgroundBrush �� Color  ButtonBackgroundBrush  
SharedText��%�   &	        &	 #     &	 G     �� 5   
   $ 	LightBlue��69   �� 5   
   $ 
LightGreen��68   ��5   
    This is resource bound text!��6F   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ textBoxWithoutBinding��5      $��0��61   $��0��6>   $	��150��6N   $��5q�6Z   �� 5    
   -   5        $��1��5       $��0��6   $ ��Click Me (Without Binding)��6.   $	��150��6S   $��5q�6_   5!      �� 5$   
   $��0��6   $��1��6   $��
120,5,69,5q�6/   #��[ 5%      #��[  5&      �� 5'   
   -   5        $��1��5'      $��1��6   $&�� Click Me (With Resource Binding)��6.   $��
120,5,69,5q�6Y   #��[ 5(      5)      5*      5+      