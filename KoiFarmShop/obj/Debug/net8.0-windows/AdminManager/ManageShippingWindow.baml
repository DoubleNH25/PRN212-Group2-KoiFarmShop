   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:KoiFarmShop.AdminManagerKoiFarmShop.AdminManager  5   	   3    -KoiFarmShop.AdminManager.ManageShippingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:KoiFarmShop.AdminManager     5   	   -   5          � Title$  ManageShippingWindow��5	   	   $	��600��6&   $
��1050��63    � WindowStartupLocation$ CenterScreen=�6@   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Admin��6   $��Center=�6)   $��14(�6F   $��0 10 0 0q�6T   �� 5      $��Shipping��6   $��Center=�6,   $��16(�6I   $
��Bold"�6W   $��0 20 0 0q�6i   �� 5      -   5        $��Users��5      $��30��6)   $��
20 10 20 0q�65   6J   �� 5       -   5        $��Products��5       $��30��6,   $��
20 10 20 0q�68   6L   �� 5!      -   5        $��	Suppliers��5!      $��30��6-   $��
20 10 20 0q�69   6M   �� 5"      -   5        $��	KoiBreeds��5"      $��30��6-   $��
20 10 20 0q�69   6M   �� 5#      -   5        $��Orders��5#      $��30��6*   $��
20 10 20 0q�66   6J   �� 5$      -   5        $��OrderDetails��5$      $��30��60   $��
20 10 20 0q�6<   6P   �� 5%      -   5        $��Shipping��5%      $��30��6,   $��
20 10 20 0q�68   ���	#FFC5E4FF6c   �� 5&      -	   5        $��Log Out��5&      $��30��6+   $��
20 50 20 0q�67   6K   5'      5(      �� 5+   
   $��1��6   $��10q�6%   .+�5-      �� $��Shipping Management��6   $��20(�63   $
��Bold"�6A   $��
10 20 0 10q�6S   �� 50      -
   5         ��Name$ lvShippingData��50      $��	0 10 0 10q�6/    �� View 51      �� 52      .P�53      �� $��
ShippingId��6)    �� Width$ 95��6=    �� DisplayMemberBinding 6H   �� *
ShippingId+�� 54      $��OrderId��6)   $	 100��6:    6F   �� *	OrderId+�� 55      $��ShippingDate��6)   $	 125��6?    6K   �� *ShippingDate+�� 56      $��DeliveryDate��6)   $	 125��6?    6K   �� *DeliveryDate+�� 57      $��ShippingMethod��6)   $	 165��6A    6M   �� *ShippingMethod+�� 58      $��Status��6)   $	 100��69    6E   �� *Status+�� 59      $��Employee��6)   $	 165��6;    6G   �� *Employee.Name+5:      5<      �� 5>      -   5        	 ��Name$	 cmbEmployee��5>      $	��150��6,   $��0 0 20 0q�68   
 �� DisplayMemberPath$

 Name��5?       �� SelectedValuePath$ 
EmployeeId��6$   �� 5@      -   5        $	 
cmbOrderId��5@      $	��150��6+   $��0 0 20 0q�67   $
 OrderId��5A      $ OrderId��6'   � 5D      $��50��6    5E      �� 5F      $��* �6'   �� 5G      $��* �6'   .+�5I      �� -   5        $��Update��5I      $��10,10,343,10q�6*   $��0��6@   6P   �� 5J      -   5        $��Refresh��5J      $��116,10,232,10q�6+   6B   5K      5L      5M      5N      