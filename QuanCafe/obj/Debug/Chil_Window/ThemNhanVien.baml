   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:QuanCafe.Chil_WindowQuanCafe.Chil_Window  5   	   '    !QuanCafe.Chil_Window.ThemNhanVien   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:QuanCafe.Chil_Window     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  ThemNhanVien��5   	   $	��600��6   $	��400��6+      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �� .+�5   
   �� -   5         ��Name$ id��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 ID *��6   $��	20,20,0,0q�6D   $
��Left=�6W   $��50��6r    % !MaterialDesignFloatingHintTextBox#��[ 6}   �� 5   
   -   5        $ hoten��5      $ Họ Tên *��6!   $��	20,20,0,0q�6K   $
��Left=�6^   $	��200��6y   #��[ 6�   G� 5   
   -   5         G�Name$
 Pass��5      $ 
Password *��6$      
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � � ) %MaterialDesignFloatingHintPasswordBox#��[ 5   L   $��	20,20,0,0q�5      $	��150��6)   $
��Left=�65   �� 5   
   -   5        $ diachi��5       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5      $��80��6S    �� AcceptsReturn . 	 �� TextWrapping$
	 Wrap=�5      "
 �� VerticalScrollBarVisibility$

 Auto=�6%   $ This is a text area��6H   $��
20,20,10,0q�5   #   � 5   
   $��0,20,0,0q�6   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ ngaysinh��5      $	��100��6+   $��20,0,0,0q�67   $ 
Ngày Sinh��6I    ( $MaterialDesignFloatingHintDatePicker#��[ 6t     5      -   5        $ 
ngayvaolam��5      $	��100��6-   $��50,0,0,0q�69   $ Ngày vào làm��6K   #��[ 6y   5      �� 5   
   -   5        $ luong��5      $ Lương��6!   $��	20,20,0,0q�6H   $
��Left=�6[   $	��150��6v   #��[ 6�   �� 5   
   -   5        $	 sdt��5      $ Số điện thoại��6   $��	20,20,0,0q�6N   $
��Left=�6a   $	��150��6|   #��[ 6�   �� 5    
   -	   5         ��Name$ chucvu��5       $ Chức Vụ *��6#   $��	20,20,0,0q�6N   $	��150��6a   $
��Left=�6m   .@�5!      ��  �� 
IsSelected . .��6-   Nhân viên5#      �� 5$      .��6   
Quản lý5&      5'      � 5(   
   $��0,20,0,0q�6   .+�5)      �� -
   5         ��Name$ ok��5)      $	��100��6!   $��Thêm��6-   $��	40,10,0,0q�6<   6O   �� 5*      -   5        $ cencel��5*      $	��100��6%   $��cancel��61   $��
110,10,0,0q�6B   6V   5+      5,      5-      