   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KoiFarmShop.StaffKoiFarmShop.Staff  5   	   5    /KoiFarmShop.Staff.ExecuteShippingProgressWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:KoiFarmShop.Staff     5   	   -   5          � Title$#  ExecuteShippingProgressWindow��5	   	   $	��600��60   $
��1050��6=    � WindowStartupLocation$ CenterScreen=�6J   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� -   5        ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Employee��6   $��Center=�6,   $��14(�6I   $��0 10 0 0q�6W   �� 5      $��Shipping��6   $��Center=�6,   $��16(�6I   $
��Bold"�6W   $��0 20 0 0q�6i   �� 5      $��Shipping��6   $��30��6,   $��
20 10 20 0q�68   ���	#FFC5E4FF6L   �� 5      -   5        $��Log Out��5      $��30��6+   $��
20 50 20 0q�67   6K   5      5       �� 5#   
   $��1��6   $��10q�6%   .+�5%      �� $��Koi Farm Shop��6   $��40(�6-   $
��Bold"�6;   $��
10 20 0 10q�6M   �� 5'       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�5(      �� -   5         ��Name$ cmbUser��5(      $	��200��6,   $��0 0 20 0q�68   $y�	Collapsed=�6J   �� 5)      -   5        $ cmbEmployee��5)      $	��150��60   $��0 0 20 0q�6<    �� DisplayMemberPath$
 Name��6N    �� SelectedValuePath$ 
EmployeeId��6g   $y�	Collapsed=�6�   5*      �� 5,      -   5        	 ��Name$	 lvShippingData��5,      $��	0 10 0 10q�6/   
 �� View
 5-      �� 5.      .P�5/      �� $��
ShippingId��6)    �� Width$ 95��6=    �� DisplayMemberBinding 6H   �� *
ShippingId+�� 50      $��OrderId��6)   $	 100��6:    6F   �� *	OrderId+�� 51      $��ShippingDate��6)   $	 125��6?    6K   �� *ShippingDate+�� 52      $��DeliveryDate��6)   $	 125��6?    6K   �� *DeliveryDate+�� 53      $��ShippingMethod��6)   $	 165��6A    6M   �� *ShippingMethod+�� 54      $��Status��6)   $	 100��69    6E   �� *Status+�� 55      $��Employee��6)   $	 165��6;    6G   �� *Employee.Name+56      58      � 59      $��50��6    5:      �� 5;      $��* �6'   �� 5<      $��* �6'   .+�5>      �� -   5        $��
In TranSit��5>      $��10,10,343,10q�6.   $��0��6D   6T   �� 5?      -   5        $��	Delivered��5?      $��116,10,232,10q�6-   6D   5@      5A      5B      5C      