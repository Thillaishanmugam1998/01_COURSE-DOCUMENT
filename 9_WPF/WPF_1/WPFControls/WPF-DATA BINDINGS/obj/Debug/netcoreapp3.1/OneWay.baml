   M S B A M L   `   `   `  ����L  HWPF-DATA BINDINGS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_DATA_BINDINGSWPF_DATA_BINDINGS  5   	       WPF_DATA_BINDINGS.OneWay   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPF_DATA_BINDINGS     5   	     � Title$  OneWay��5   	   $	��450��6   $	��800��6%   .��5
   
   � $��50q�6    � RowDefinitions 5      �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6    � ColumnDefinitions 5      �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   .+�5   
   �� -   5         ��Name$ Source��5      $�� Source��6!   $��30��63   $	��250��6?   $��0��6K   $��0��6X   
�����_�
���   �$��2q�6�   �� 5   
   -   5        $ Destination��5      $�� Destination��6&   $��30��6=   $	��250��6I   $��1��6U   $��0��6b   
�����_�
���   �$��2q�6�   �� 5   
   -   5         ��Name$ 
txt_source��5      $��30��6'   $	��250��63   $��0��6?   $��1��6L   �� 5   
   -   5        $ txt_destination��5      $��30��6,   $	��250��68   $��1��6D   $��1��6Q   ��6a   ��  �� ElementName$ 
txt_source�� �� Path$
 Text� �� Mode$ OneWay=�5      5      