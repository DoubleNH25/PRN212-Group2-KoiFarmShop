   M S B A M L   `   `   `  ����  KoiFarmShop<    6KoiFarmShop.AdminManager.SaveWindow.SaveKoiBreedWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$ Save Koi Breed��5   	   $	��300��6    $	��300��6-   .��5	      � ���	#FFF1F4F6 � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��1��6!   $��Koi Breed Details��61   ���	#FFF69191$
��Bold"�5      $��Segoe UI Black)�6&   $��18(�5      $
��Left=�6"   $��Center=�5      $��10,0,0,0q�6/   � 5   
   $��1��6   $��2��6   $
��10,0q�60    5      �� 5      $��88 �6#   �� 5       5       �� 5!      $��35 �6    �� 5"      $��35 �6    �� 5#      $��70 �6    .+�5&      �� $��Breed ID��6   $��5,0,5,0q�6'   $��0��68   $��Center=�6H   $��25��6c   �� 5'      -   5         ��Name$ 
txtBreedId��5'      $��5,5,5,5q�6*   $��1��6;   $��0��6K    �� 
IsReadOnly$
 True��6X   �� 5)      $��
Breed Name��6   $��5,0,5,0q�6)   $��0��6:   $��1��6J   $��Center=�6W   $��25��6r   �� 5*      -   5        $ txtName��5*      $��5,5,5,5q�6'   $��1��68   $��1��6H   �� 5,      $��Description��6   $��5,5,5,0q�6*   $��0��6;   $��2��6K   $	��Top=�6X   $��26��6p   �� 5-      -   5        $ txtDescription��5-      $��5,5,5,5q�6.   $��1��6?   $��2��6O    �� TextWrapping$
 Wrap=�6\    �� AcceptsReturn$
 True��6p   5.      � 51   
   $��2��6   $��2��6   $��Center=�60    52      �� 53      $
��Auto �6#   �� 54      $��10 �6#   �� 55      $
��Auto �6#   .+�57      �� -   5         ��Name$ btnSave��57      $
��Save��6&   $��70��65   $��30��6@   $��0��6L   6\   �� 58      -   5        $ btnClose��58      $��Close��6'   $��70��67   $��30��6B   $��2��6N   6^   59      5:      5;      