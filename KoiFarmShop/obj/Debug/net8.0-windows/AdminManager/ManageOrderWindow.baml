   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:KoiFarmShop.AdminManagerKoiFarmShop.AdminManager  5   	   0    *KoiFarmShop.AdminManager.ManageOrderWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:KoiFarmShop.AdminManager     5   	   -   5          � Title$  ManageOrderWindow��5	   	   $	��600��6#   $
��1050��60    � WindowStartupLocation$ CenterScreen=�6=   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Admin��6   $��Center=�6)   $��14(�6F   $��0 10 0 0q�6T   �� 5      $��Products��6   $��Center=�6,   $��16(�6I   $
��Bold"�6W   $��0 20 0 0q�6i   �� 5      -   5        $��Users��5      $��30��6)   $��
20 10 20 0q�65   6J   �� 5       -   5        $��Products��5       $��30��6,   $��
20 10 20 0q�68   6M   �� 5!      -   5        $��	Suppliers��5!      $��30��6-   $��
20 10 20 0q�69   6M   �� 5"      -   5        $��	KoiBreeds��5"      $��30��6-   $��
20 10 20 0q�69   6M   �� 5#      -   5        $��Orders��5#      $��30��6*   $��
20 10 20 0q�66   ���	#FFC5E4FF6a   �� 5$      -   5        $��OrderDetails��5$      $��30��60   $��
20 10 20 0q�6<   6P   �� 5%      -   5        $��Shipping��5%      $��30��6,   $��
20 10 20 0q�68   6L   �� 5&      -	   5        $��Log Out��5&      $��30��6+   $��
20 50 20 0q�67   6K   5'      5(      �� 5+   
   $��1��6   $��10q�6%   .+�5-      �� $��Product Management��6   $��20(�62   $
��Bold"�6@   $��
10 20 0 10q�6R   �� 5/       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�51      �� -
   5         ��Name$ cmbUser��51      $	��200��6,   $��0 0 20 0q�68   $y�	Collapsed=�6J   52      �� 54      -   5         ��Name$ lvOrderData��54      $��	0 10 0 10q�6,   $
��Left=�6?   $	��753��6Z    �� View 55      �� 56      .P�57      �� $��OrderId��6)   	 �� Width$		 100��6:   
 �� DisplayMemberBinding
 6F   �� *	OrderId+�� 58      $��UserId��6)   $	 75��69   
 6D   �� *UserId+�� 59      $��UserName��6)   $		 115��6;   
 6G   �� *	User.Name+�� 5:      $��	OrderDate��6)   $		 124��6<   
 6H   �� *	OrderDate+�� 5;      $��
TotalPrice��6)   $		 130��6=   
 6I   �� *
TotalPrice+�� 5<      $��ShippingAddress��6)   $		 100��6B   
 6N   �� *ShippingAddress+�� 5=      $��Status��6)   $		 100��69   
 6E   �� *StatusDescription+5>      5@      �� 5B      $ 
Horizontal=�6   $��0 0 0 10q�62   .+�5C      �� -   5        $ cmbEmployee��5C      $	��200��60   5D      � 5F      $��50��6    5G      �� 5H      $��* �6'   �� 5I      $��* �6'   �� 5J      $��* �6'   .+�5L      �� -   5        $��Accept Order��5L      $��10,10,185,10q�60   6F   �� 5M      -   5        $��Cancel Order��5M      $��125,10,65,10q�60   6F   �� 5N      -   5        $��Complete Order��5N      $��244,10,243,10q�62   $��2��6`   �� 5O      -   5        $��Create Shipping��5O      $��67,10,124,10q�63    J� RenderTransformOrigin$ 2.327,0.772&�6`   $��1��6�   5P      5Q      5R      5S      