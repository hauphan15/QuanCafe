   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuanCafeQuanCafe  5   	       QuanCafe.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuanCafe     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MainWindow��5   	   $	��460��6   $	��810��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      6!   .+�5   
   � -   5         �Name$
 Menu��5   7   ���	#FF990000$��0��6'    � RowDefinitions 5      �� 5      $��80 �6    �� 5      .+�5      �� $��0��6   .+�5      � .+�5      #  MaterialDesignThemes.Wpf.Chip  -   5          Name$	 ten��5   *   $��0q�67   $��5q�6C   $��James Willock��6N      Icon 5      �� 5       $��img/icon.png��6$   5"      �� 5#      $��50��6   $��0q�6(   .��5$      �� $��img/logout.png��6    5%      5&      �� 5'      -   5        $��Đổi mật khẩu��5'      $��Center=�60   6M   5(      �� 5)      $��1��6   ���	#FF990000{�6#   �� *	IsChecked+ �� ElementName$ EnableListBox��.@�5*      � .+�5+      '  !MaterialDesignThemes.Wpf.PackIcon  $��20��6.   $��30��69   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Coffee=�6E   ���	#DDEAD8D86S   �� 5,      -   5        
 ��Name$
 thucUongBtn��5,   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6`   Z� ��6v   Z� .��6�   THỨC UỐNG5.      5/      � 50      .+�51        $��20��6.   $��30��69   $	 SeatReclineNormal=�6E   ���	#DDEAD8D86^   �� 52      -   5        $
 banBtn��52   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6[   Z� ��6q   Z� .��6�   BÀN54      55      � 56      .+�57        $��20��6.   $��30��69   $	 AccountCardDetails=�6E   ���	#DDEAD8D86_   �� 58      -   5        $
 nhanVienBtn��58   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6`   Z� ��6v   Z� .��6�   NHÂN VIÊN5:      5;      � 5<      .+�5=        $��20��6.   $��30��69   $	 	TableEdit=�6E   ���	#DDEAD8D86V   �� 5>      -   5        $
 	hoaDonBtn��5>   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6^   Z� ��6t   Z� .��6�   
HÓA ĐƠN5@      5A      � 5B      .+�5C        $��20��6.   $��30��69   $	 Store=�6E   ���	#DDEAD8D86R   �� 5D      -   5        $
 khoBtn��5D   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6[   Z� ��6q   Z� .��6�   KHO5F      5G      � 5H      .+�5I        $��20��6.   $��30��69   $	 ChartBar=�6E   ���	#DDEAD8D86U   �� 5J      -	   5        $
 
thongKeBtn��5J   K   $
��Left=�6   $	��165��6?   ���	#DDDCD6D6$��25,0,0,0q�6�   ��6`   Z� ��6v   Z� .��6�   THỐNG KÊ5L      5M      5N      5O      � 5Q   
   -
   5        $
 show��5Q      $��1��6   5S      5T      5U      