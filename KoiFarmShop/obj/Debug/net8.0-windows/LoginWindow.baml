   M S B A M L   `   `   `  ����F  BKoiFarmShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KoiFarmShopKoiFarmShop  5   	       KoiFarmShop.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KoiFarmShop     5   	     � Title$  LoginWindow��5      $	��550��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�5	       � WindowStyle$
 None=�5
       � 
ResizeMode$ NoResize=�5      
������  � AllowsTransparency$
 True��5      .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5   	    J� Opacity$
 0.95Q�5   	   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #0099FF��6#   
 � Offset$
 0Q�63   � 5      $	 #DA34AE��6#   $

 0.75Q�63   � 5      $	 	#FF60B1E7��6#   $
 1Q�65   � 5      $	 	#FF596FDD��6#   $
 0.309Q�65   � 5      $	 	#FF8C57CA��6#   $
 0.484Q�65   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $	 DarkRed��6#   $
 0Q�63   � 5       $	 DarkBlue��6#   $
 1Q�64   5!      ._�5$      �  � RowDefinitions 5%      �� 5&      $��30 �6$   �� 5'      .+�5+      � $��0��6    � ColumnDefinitions 5,      �� 5-      �� 5.      $��25 �6+   �� 5/      $��25 �6+   �� 50      $��5 �6+   .+�53      �� $"��HOTEL MANAGEMENT APPLICATION��6    
�������$��10(�55      $��
Montserrat)�56      $��Center=�57      $��10,0,0,0q�58      �� 5:      -   5         ��Name$ btnMinimize��5:      $��0q�5;      $��-��5<      
�������$��16(�5>      $��
Montserrat)�5?       � Cursor$
 Hand��5@      $��1��5A      ��5C      �� 5D       �� 
TargetType" ��6$   .�5E   "   ��  �� Property � �� �� Value
 ��  �6?    �� Triggers 5F   "   P� 5G   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5H   *   ��  � �� �#278BEF6G   5I   '   5K      ��5M      �� 5N       �� 
TargetType" ��6.   .R�5O   "   �� $��18��6)   $��18��64   $ 9��5P   !   #��z��5Q   !   ._�5R   &   �� $��Center=�67   $��Center=�5S   /   5T   #   5U      5W      �� 5Y      -   5        $ btnClose��5Y      $��0q�5Z      $��X��5[      
�������$��12(�5]      $��
Montserrat)�5^      $
 Hand��5_      $��2��5`      ��5b      �� 5c      " ��6$   .�5d   "   ��  � ��
 �  ��6?    5e   "   P� 5f   &    �@J�IsMouseOver$
 True��6E   . �5g   *   ��  � �� �#C62DAE6G   5h   '   5j      ��5l      �� 5m      " ��6.   .R�5n   "   �� $��18��6)   $��18��64   $ 9��5o   !   #��z��5p   !   ._�5q   &   �� $��Center=�67   $��Center=�5r   /   5s   #   5t      5v      5w      �� 5z      $��1��5{       �� Orientation$ Vertical=�5|      $��186,35,186,0q�5}      .+�5      �� $L��FC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\logo.png��6   $	��306��5�      $	��138��6    �� 5�      $��	DOULENH25��6    
�������$��25(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��Center=�5�      �� 5�      $&�� More And More Beautiful KOI Shop��6    
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $
��Wrap=�5�       �� TextAlignment$ Center=�5�      $��0,5,0,0q�5�      �� 5�      $��Email��6    
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,35,0,0q�5�      �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      .��6)   ��5�      �� 5�       �� ImageSource$Q KC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\user-icon.png��6)    j� Stretch$
 None=�5�   !    j� 
AlignmentX$
 Left=�5�   !   .��5�   .   5�      �� 5�      $��Password��6    
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,15,0,0q�5�      G� 5�      -   5         G�Name$ txtPassword��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�      �� 5�      $P JC:\Users\Admin\source\repos\2024KoiFarmShop\KoiFarmShop\image\key-icon.png��6)   $
 None=�5�   !   $
 Left=�5�   !   5�      �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � ��
 �  ��6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   !   #��z��5�   !   ._�5�   &   �� $��Center=�67   $��Center=�5�   /   5�   #   5�      5�      �� 5�      -   5        $ btnRegister��5�      $��0q�5�      $��REGISTER��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��56��5�   3   $	��391��6?   ��5�      �� 5�      " ��6$   .�5�   "   ��  � ��
 ��  �6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��120��6)   $��30��65   $ 20��5�   !   #��z��5�   !   ._�5�   &   �� $��Center=�67   $��Center=�5�   !   5�   #   5�      5     5     5     5     5     5     