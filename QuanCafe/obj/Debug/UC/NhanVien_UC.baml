   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanCafe.UCQuanCafe.UC  5          QuanCafe.UC.NhanVien_UC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuanCafe.UC     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   $
��Auto��6   .+�5      #  MaterialDesignThemes.Wpf.Card  $��10q�6"   .��5      � .+�5      �� -   5         ��Name$
 idNV��5      $
��auto��5      $��5q�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID nhân viên��5       % !MaterialDesignFloatingHintTextBox#��[ 5       .��6P   5!      �� 5#      -   5        $ hoTen��5$      $
��auto��5%      $��5q�5&      $ 	Họ tên��5'      #��[ 5(      .��6P   5)      �� 5+      -   5        $ diaChi��5,      $
��auto��5-      $��5q�5.      $ Địa chỉ��5/      #��[ 50      .��6P   51      �� 53      -   5        $ ngaySinh��54      $
��auto��55      $��5q�56      $ 
Ngày sinh��57      #��[ 58      .��6P   59      �� 5;      -   5        $ 
ngayVaoLam��5<      $
��auto��5=      $��5q�5>      $ Ngày vào làm��5?      #��[ 5@      .��6P   5A      �� 5C      -   5        $ luong��5D      $
��auto��5E      $��5q�5F      $ Lương��5G      #��[ 5H      .��6P   5I      �� 5L      -   5        $	 sdt��5M      $
��auto��5N      $��5q�5O      $ Số điện thoại��5P      #��[ 5Q      .��6P   5R      �� 5T      -   5        $ chucVu��5U      $
��auto��5V      $��5q�5W      $ Chức vụ��5X      #��[ 5Y      .��6P   5Z      5\      5]      5^      � 5`   
   $��1��6   $
��Auto��6   .+�5a      � $��10q�6   .+�5b      �� -	   5         ��Name$
 them��5b      $��0 0 10 0q�5c       $  MaterialDesignRaisedAccentButton#��[ 5d      $	��100��5e      $��25��5f       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��5g      .��6j   THÊM5i      �� 5k      -
   5        $	 xoa��5k      $��0 0 10 0q�5l      #��[ 5m      $	��100��5n      $��25��5o      $5 /Resource name: MaterialDesignRaisedAccentButton��5p      .��6i   XÓA5r      �� 5t      -   5        $ capNhat��5t      $��0,0,10,0q�5u      #��[ 5v      $	��100��5w      $��25��5x      $5 /Resource name: MaterialDesignRaisedAccentButton��5y      .��6m   CẬP NHẬT5{      5|      5}      � 5   
   $��2��6   $
��Auto��6   .+�5�        $��10q�6"   $��Stretch=�6.   $��Stretch=�6J   .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5�         AutoGenerateColumns . $��Stretch=�5�      $��5q�5�      $��Stretch=�5�      64   5�      5�      5�      5�      