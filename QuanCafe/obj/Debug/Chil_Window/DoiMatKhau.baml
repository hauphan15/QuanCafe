   M S B A M L   `   `   `  ����C  ?QuanCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:QuanCafe.Chil_WindowQuanCafe.Chil_Window  5   	   %    QuanCafe.Chil_Window.DoiMatKhau   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:QuanCafe.Chil_Window     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  
DoiMatKhau��5   
   $	��300��6   $	��300��6*      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   G� -   5         G�Name$ Pass1��5      $��0��6%   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mật khẩu cũ��62      
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � � ) %MaterialDesignFloatingHintPasswordBox#��[ 5   L   $��Center=�5      $	��200��61   $��Center=�6=   G� 5   
   -   5        $ Pass2��5      $��1��6%   $ Mật khẩu mới��62   
 � � �
 � � �#��[ 5   L   $��Center=�5      $	��200��61   $��Center=�6=   G� 5   
   -   5        $ Pass3��5      $��2��6%   $ Nhập lại��62   
 � � �
 � � �#��[ 5   L   $��Center=�5       $	��200��61   $��Center=�6=   � 5!   
   $��3��6   .+�5"      �� -   5        $��OK��5"      $��80��6"   $��	40,20,0,0q�6-   6@   �� 5#      -   5        $��Cancel��5#      $��80��6&   $��	50,20,0,0q�62   6E   5$      5%      5&      