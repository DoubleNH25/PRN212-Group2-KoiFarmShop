   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KoiFarmShop.CustomerKoiFarmShop.Customer  5   	   -    'KoiFarmShop.Customer.OrderDetailsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KoiFarmShop.Customer     5   	   -   5          � Title$  OrderDetailsWindow��5	   	   $	��600��6$   $
��1050��61    � WindowStartupLocation$ CenterScreen=�6>   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� -   5        ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Customer��6   $��Center=�6,   $��14(�6I   $��0 10 0 0q�6W   �� 5      $��Order Details��6   $��Center=�61   $��16(�6N   $
��Bold"�6\   $��0 20 0 0q�6n   �� 5      -   5        $
��Home��5      $��30��6(   $��
20 10 20 0q�64   6H   �� 5       -   5        $��Products��5       $��30��6,   $��
20 10 20 0q�68   6L   �� 5!      -   5        $��Orders��5!      $��30��6*   $��
20 10 20 0q�66   6J   �� 5"      -   5        $��OrderDetails��5"      $��30��60   $��
20 10 20 0q�6<   ���	#FFC5E4FF6g   �� 5#      -   5        $��Shipping��5#      $��30��6,   $��
20 10 20 0q�68   6L   �� 5$      -   5        $��Log Out��5$      $��30��6+   $��
20 50 20 0q�67   6K   5%      5&      �� 5)   
   $��1��6   $��10q�6%   .+�5,      �� $��Koi Farm Shop��6   $��40(�6-   $
��Bold"�6;   $��
10 20 0 10q�6M   �� 5.       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�50      �� -	   5         ��Name$ 
cmbProduct��50      $	��200��6/   $��0 0 20 0q�6;   $y�	Collapsed=�6M   51      �� 53      -
   5         ��Name$ lvOrderDetailData��53      $��	0 10 0 10q�62   $
��Left=�6E   $	��637��6`    �� View 54      �� 55      .P�56      �� $��OrderDetailId��6)   	 �� Width$		 100��6@   
 �� DisplayMemberBinding
 6L   �� *OrderDetailId+�� 57      $��OrderId��6)   $	 75��6:   
 6E   �� *	OrderId+�� 58      $��Product Name��6)   $		 124��6?   
 6K   �� *Product.Name+�� 59      $��Quantity��6)   $		 130��6;   
 6G   �� *
Quantity+�� 5:      $��Price��6)   $		 100��68   
 6D   �� *Price+�� 5;      $��Status��6)   $		 100��69   
 6E   �� *StatusDetailDescription+5<      5>      � 5B      $��70��6    5C      �� 5D      $	��130 �6'   �� 5E      $	��52* �6'   �� 5F      $
��323* �6'   .+�5H      �� -   5        $��Cancel Order Detail��5H      $��10,10,10,10q�67   $��0��6L   6\   5I      5J      5K      5L      