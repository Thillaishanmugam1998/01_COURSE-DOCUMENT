   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         Button_1 �� 
TargetType �� Property �� Value��%8  &	        �� 5   
   " ��6!   .�5      ��  � ��
 �����6+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 	10,0,10,0q�6'   �� 5       � ��$ 30��6'   �� 5       � ��$	 100��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5"   
   �� 5#      $
��301* �6   �� 5$      $
��404* �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   .+�5+   
   �� $��In Line Control Style��6   $��1��61   $��Center=�6A   $��	10,0,75,0q�6\   $��25��6o   $��2��6{   ��5,      �� 5-      " ��6   .�5.      ��  � ��
 ��ح�63   �� 5/       � ��
 �����63   �� 50       � ��$ 14(�61   �� 51       � ��$
 Bold"�63   52      54      �� 57   
   $	��ICS��6   $��0��6   $��Center=�6/   $��	10,0,10,0q�6J   $��25��6]   $��75��6i   $
��Bold"�6t   �� 58   
   $	��WCS��6   $��1��6   $��0��6-   $��Center=�6=   $��	10,0,10,0q�6X   $��25��6k   $��75��6w   #��[  6�   �� 59   
   $	��ACS��6   $��2��6   $��0��6-   $��Center=�6=   $��	10,0,10,0q�6X   $��25��6k   $��75��6w     Button_2#��[ 6�   �� 5:   
   $��Window Control Style��6   $��1��60   $��1��6>   $��Center=�6N   $��	10,0,75,0q�6i   $��25��6|   $
��Auto��6�   #��[  6�   $��2��6�   �� 5;   
   $��Application Control Style��6   $��2��65   $��1��6C   $��Center=�6S   $��	10,0,75,0q�6n   $��25��6�   $
��Auto��6�   #��[ 6�   $��2��6�   �� 5>   
   $��CLICK ME��6   $��24��6$   $��0��60   $��3��6@   $��Center=�6M   $
��Bold"�6h   $��133,0,134,0q�6{   ��5?      �� 5@      " ��6    �� Triggers 5A      P� 5C       P� Property � ��	 P� Value$
	 True��67   . �5D      ��  � ��
 �  ��6;   5E      5G      5I      5K      5M      