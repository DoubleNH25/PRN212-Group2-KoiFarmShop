   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:KoiFarmShop.AdminManagerKoiFarmShop.AdminManager  5   	   6    0KoiFarmShop.AdminManager.ManageOrderDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:KoiFarmShop.AdminManager     5   	   -   5          � Title$  ManageOrderDetailWindow��5	   	   $	��600��6)   $
��1050��66    � WindowStartupLocation$ CenterScreen=�6C   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FFF69191._�5      �� .+�5      �� $��80��6   $��80��6$   
������� �� CornerRadius$ 40��6C   $��0 20 0 0q�6U   $��Center=�6g   ._�5      A� ��5      �� 5       �� ImageSource$O IC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\profile.png��6)   5      5      �� 5      $��Admin��6   $��Center=�6)   $��14(�6F   $��0 10 0 0q�6T   �� 5      $��Products��6   $��Center=�6,   $��16(�6I   $
��Bold"�6W   $��0 20 0 0q�6i   �� 5      -   5        $��Users��5      $��30��6)   $��
20 10 20 0q�65   6J   �� 5       -   5        $��Products��5       $��30��6,   $��
20 10 20 0q�68   6M   �� 5!      -   5        $��	Suppliers��5!      $��30��6-   $��
20 10 20 0q�69   6M   �� 5"      -   5        $��	KoiBreeds��5"      $��30��6-   $��
20 10 20 0q�69   6M   �� 5#      -   5        $��Orders��5#      $��30��6*   $��
20 10 20 0q�66   6K   �� 5$      -   5        $��OrderDetails��5$      $��30��60   $��
20 10 20 0q�6<   ���	#FFC5E4FF6g   �� 5%      -   5        $��Shipping��5%      $��30��6,   $��
20 10 20 0q�68   6L   �� 5&      -	   5        $��Log Out��5&      $��30��6+   $��
20 50 20 0q�67   6K   5'      5(      �� 5+   
   $��1��6   $��10q�6%   .+�5-      �� $��Product Management��6   $��20(�62   $
��Bold"�6@   $��
10 20 0 10q�6R   �� 5/       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�51      �� -
   5         ��Name$ cmbUser��51      $	��200��6,   $��0 0 20 0q�68   $y�	Collapsed=�6J   52      �� 55      $ 
Horizontal=�6   $��0 0 0 10q�62   .+�57      �� -   5        $ cmbBreed��57      $	��200��6-   $��0 0 20 0q�69   $y�	Collapsed=�6K   �� 58      -   5        $ cmbSupplier��58      $	��200��60   $y�	Collapsed=�6<   59      �� 5<      $ 
Horizontal=�6   $��0 0 0 10q�62   .+�5>      �� -   5        $ 
cmbProduct��5>      $	��200��6/   $��0 0 20 0q�6;   $y�	Collapsed=�6M   5?      �� 5A      -   5         ��Name$ lvOrderDetailData��5A      $��	0 10 0 10q�62   $
��Left=�6E   $	��738��6`    �� View 5B      �� 5C      .P�5D      �� $��OrderDetailId��6)   	 �� Width$		 100��6@   
 �� DisplayMemberBinding
 6L   �� *OrderDetailId+�� 5E      $��OrderId��6)   $	 75��6:   
 6E   �� *	OrderId+�� 5F      $��	ProductId��6)   $	 75��6<   
 6G   �� *	ProductId+�� 5G      $��Product Name��6)   $		 140��6?   
 6K   �� *Product.Name+�� 5H      $��Quantity��6)   $		 130��6;   
 6G   �� *
Quantity+�� 5I      $��Price��6)   $		 110��68   
 6D   �� *Price+�� 5J      $��Status��6)   $		 100��69   
 6E   �� *StatusDetailDescription+5K      5M      � 5P      $��50��6    5Q      �� 5R      $��* �6'   �� 5S      $��* �6'   �� 5T      $��* �6'   .+�5V      �� -   5        $��Accept Order��5V      $��10,10,185,10q�60   6F   �� 5W      -   5        $��Cancel Order��5W      $��125,10,65,10q�60   6F   5X      5Y      5Z      5[      