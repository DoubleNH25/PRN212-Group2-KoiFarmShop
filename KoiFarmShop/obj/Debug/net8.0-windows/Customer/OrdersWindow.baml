   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KoiFarmShop.CustomerKoiFarmShop.Customer  5   	   '    !KoiFarmShop.Customer.OrdersWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KoiFarmShop.Customer     5   	   -   5          � Title$  OrdersWindow��5	   	   $	��600��6   $
��1050��6+    � WindowStartupLocation$ CenterScreen=�68   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� -   5        ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Customer��6   $��Center=�6,   $��14(�6I   $��0 10 0 0q�6W   �� 5      $��Orders��6   $��Center=�6*   $��16(�6G   $
��Bold"�6U   $��0 20 0 0q�6g   �� 5      -   5        $
��Home��5      $��30��6(   $��
20 10 20 0q�64   6H   �� 5       -   5        $��Products��5       $��30��6,   $��
20 10 20 0q�68   6L   �� 5!      -   5        $��Orders��5!      $��30��6*   $��
20 10 20 0q�66   ���	#FFC5E4FF6a   �� 5"      -   5        $��OrderDetails��5"      $��30��60   $��
20 10 20 0q�6<   6P   �� 5#      -   5        $��Shipping��5#      $��30��6,   $��
20 10 20 0q�68   6L   �� 5$      -   5        $��Log Out��5$      $��30��6+   $��
20 50 20 0q�67   6K   5%      5&      �� 5)   
   $��1��6   $��10q�6%   .+�5+      �� $��Koi Farm Shop��6   $��40(�6-   $
��Bold"�6;   $��
10 20 0 10q�6M   �� 5-       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�5/      �� -	   5         ��Name$ cmbUser��5/      $	��200��6,   $��0 0 20 0q�68   $y�	Collapsed=�6J   50      �� 52      -
   5         ��Name$ lvOrderData��52      $��	0 10 0 10q�6,   $
��Left=�6?   $	��637��6Z    �� View 53      �� 54      .P�55      �� $��OrderId��6)   	 �� Width$		 100��6:   
 �� DisplayMemberBinding
 6F   �� *	OrderId+�� 56      $��UserName��6)   $	 75��6;   
 6F   �� *	User.Name+�� 57      $��	OrderDate��6)   $		 124��6<   
 6H   �� *	OrderDate+�� 58      $��
TotalPrice��6)   $		 130��6=   
 6I   �� *
TotalPrice+�� 59      $��ShippingAddress��6)   $		 100��6B   
 6N   �� *ShippingAddress+�� 5:      $��Status��6)   $		 100��69   
 6E   �� *StatusDescription+5;      5=      � 5A      $��50��6    5B      �� 5C      $	��120 �6'   .+�5E      �� -   5        $��Cancel Order��5E      $��10q�60   $��0��6<   6L   5F      5G      5H      5I      