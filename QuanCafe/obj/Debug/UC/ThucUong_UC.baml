   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanCafe.UCQuanCafe.UC  5          QuanCafe.UC.ThucUong_UC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuanCafe.UC     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   $
��Auto��6   .+�5      #  MaterialDesignThemes.Wpf.Card  $��10q�6"   .��5      � .+�5      �� -   5         ��Name$
 idTU��5      $
��auto��5      $��5q�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID thức uống��5       % !MaterialDesignFloatingHintTextBox#��[ 5       .��6P   5!      �� 5#      -   5        $ tenTU��5$      $
��auto��5%      $��5q�5&      $ Tên thức uống��5'      #��[ 5(      .��6P   5)      �� 5*      -   5        $ loaiTU��5+      $
��auto��5,      $��5q�5-      $ loại��5.      #��[ 5/      .��6P   50      �� 51      -   5        $ giaTU��52      $
��auto��53      $��5q�54      $ 	Giá bán��55      #��[ 56      .��6P   57      �� 58      -   5        $ 	khuyenmai��59      $
��auto��5:      $��5q�5;      $ Khuyến Mãi��5<      #��[ 5=      .��6P   5>      �� 5?      -   5        $ imgsrc��5@      $
��auto��5A      $��5q�5B      $ 
img source��5C      #��[ 5D      .��6P   5E      �� 5F      -   5         ��Name$ browse��5F      $��browse��6-   $��10q�6>   $��Bottom=�6J   5G      5H      5I      � 5K   
   $��1��6   $
��Auto��6   .+�5L      � $��10q�6   .+�5M      �� -   5        $
 them��5M      $��0 0 10 0q�5N       $  MaterialDesignRaisedAccentButton#��[ 5O      $	��100��5P      $��25��5Q       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��5R      .��6j   THÊM5T      �� 5V      -	   5        $	 xoa��5V      $��0 0 10 0q�5W      #��[ 5X      $	��100��5Y      $��25��5Z      $5 /Resource name: MaterialDesignRaisedAccentButton��5[      .��6i   XÓA5]      �� 5_      -
   5        $ capNhat��5_      #��[ 5`      $	��100��5a      $��25��5b      $5 /Resource name: MaterialDesignRaisedAccentButton��5c      .��6m   CẬP NHẬT5e      5f      5g      � 5i   
   $��2��6   $
��Auto��6   .+�5j        $��10q�6"   $��Stretch=�6.   $��Stretch=�6J   .��5k      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5l         AutoGenerateColumns . $��Stretch=�5n      $��
10,10,10,0q�5o      $��Stretch=�5p      64   5q      5r      5s      5t      