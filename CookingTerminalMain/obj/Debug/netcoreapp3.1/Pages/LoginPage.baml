   M S B A M L   `   `   `  ����N  JCookingTerminalMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CookingTerminalMain.PagesCookingTerminalMain.Pages  5      )    #CookingTerminalMain.Pages.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CookingTerminalMain.Pages     5      -   5          N�Name$
  Page��5	       N� Title$ 	LoginPage��5
      .��5      �� $��Center=�6   $��
0 -100 0 0q�6,   .+�5   
   �� $��/Images/PP-Logo.png��6   $	��200��6-   $	��200��6=   � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��1.1* �6#   .+�5      ��  �� Orientation$ Vertical=�6   $��Right=�5      $��0��5      .+�5      �� $��AnvändarID��6   $��5q�6.      FontSizeSmall#��[  69   �� 5      $��	Lösenord��6   $��5q�6,   #��[  67   5      �� 5      $ Vertical=�6   $
��Left=�5      $��1��5       .+�5!      �� $	��150��5"      $��5q�6&   $��3q�61   ��5!      �� *UserID+ �� Mode$ OneWayToSource=�.��5"   =    =� ErrorTemplate 5#      �� 5$      .R�5%      ��   
HoverBrush#��[ 6%   5&      .��5'   0   5(      G� 5*      -   5         G�Name$ PasswordText��5*      
 � Tag$ Password��64   $	��150��6C   $��5q�6O   $��3q�6Z   �� 5-      $��Logga in��6   $��14(�6,     GreenActionButton#��[ 5.      ��5/      �� *Login+��50      ��  �� ElementName$
 Page��	 � 	Resources	 51      
 �� 
TargetType �� Property �� Value��%^   '��       �� 52      "
 ��6   .�53      ��  �@��CornerRadius$ 5��69   54      55      56      57      58      59      5:      