   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanCafe.UCQuanCafe.UC  5          QuanCafe.UC.Ban_UC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuanCafe.UC     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      6   .+�5   
   �� $��5q�6   
�������
�������$��1q�6I    �� CornerRadius$ 4��6]   $��0��6n   $
��Auto��6{   ._�5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5       .+�5$      � $��0��6   $��5q�6,   .+�5%      �� -   5         ��Name$ ID��5&      $
��auto��5'      $��5q�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$   ID  ��5)       % !MaterialDesignFloatingHintTextBox#��[ 5*      .��6P   5+      �� 5,      -   5        $ 	trangthai��5-      $
��auto��5.      $��5q�5/      $ Trang thái��50      #��[ 51      .��6P   52      53      �� 54      -   5         ��Name$
 Them��54   )   $��1��6   $
��Left=�6K   $��Center=�6f   $��8q�6�   ��55      �� 56       �� ImageSource$% /QuanCafe;component/img/add.png��6%   58      �� 59      -   5        $	 Xoa��59      $��2��6&   {�.  $
��Left=�6Z   $��Center=�6u   $��8q�6�   	 J� RenderTransformOrigin$	 9.288,0.656&�6�   ��5:      �� 5;      $% /QuanCafe;component/img/del.png��6%   5=      �� 5>      -   5        $ Order��5>      $��3��6(   $��2q�68   $��8q�6D   $��Order��6O   6_   �� 5?      -   5        $ Tinhtien��5?      $��2q�6+   $��4��67   $��8q�6G   $��Thanh Toán��6R   6g   �� 5@      -   5        $ 	ChuyenBan��5@      $��2q�6,   $��8q�68   $��5��6C   $��Chuyển Bàn��6S   6h   �� 5A      -   5        $ refresh��5A      $��6��6@   $��Right=�6P   $��Center=�6l   $��8q�6�   ��5B      �� 5C      $) #/QuanCafe;component/img/refresh.png��6%   5E      5F      5G      � 5I   
   $��1��6   $
��Auto��6   .+�5J      #  MaterialDesignThemes.Wpf.Card  $��10q�6"   $��Stretch=�6.   $��Stretch=�6J   .��5K      &   System.Windows.Controls.DataGrid  -	   5        
  Name$
 	dataGrid1��5L         AutoGenerateColumns .  $��Stretch=�5N      $��10,10,10,-0.4q�5O      $��Stretch=�5P         Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   ��  �� Path$ ID�  5S      $ Tình trạng��6-    6A   �� $ 	TinhTrang� � 	Resources 5U        DataRowContextMenu��%  &	       �� 5V      .@�5W      m� -
   5        $��Order��5W   '   6O   m� 5X      -   5        $��Tính tiền��5X   '   6U   m� 5Y      -   5        $��
Thông tin��5Y   '   6U   m� 5Z      -   5        $��Chuyển bàn��5Z   '   6V   5[      5\         RowStyle 5]      �� 5^       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    .�5_      ��  �� Property �@�ContextMenu �� Value# [ 6<   5`      5b      5c      5d      5e      5f      