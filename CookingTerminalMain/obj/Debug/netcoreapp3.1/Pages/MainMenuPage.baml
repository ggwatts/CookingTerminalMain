   M S B A M L   `   `   `  ����N  JCookingTerminalMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CookingTerminalMain.PagesCookingTerminalMain.Pages  5      E'clr-namespace:CookingTerminalMain.PagesCookingTerminalMain.Pages  5      O,clr-namespace:CookingTerminalMain.ViewModelsCookingTerminalMain.ViewModels  5      ,    &CookingTerminalMain.Pages.MainMenuPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CookingTerminalMain.Pages     5      9views'clr-namespace:CookingTerminalMain.Pages     5      C
viewmodels,clr-namespace:CookingTerminalMain.ViewModels     5        N� Title$  MainMenuPage��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � 
�������$��0��6'   � 5   
   
�������$��2��6'   $��3��64   � 5   
   $��0��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5       $��* �6#   �� 5!      $��* �6#   �� 5"      $��* �6#   �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5'      �� $��\Images\PP-Logo-small.png��6   $��80��67   $��0��6C   $��2��6S   $
��Left=�6g   $��30,0,0,0q�6�   �� 5*      $��7��6   $��Center=�6)   $��Right=�6D   .+�5+      �� $��5��6   $��Logga ut��6)      RedActionButton#��[  6<   $��45��6e   $��90��6q   $��
 30 0 30 0q�6|   $��15(�6�   
 � Tag$ Login��5/      ��5-      �� *
ChangePage+��5.      ��  �� RelativeSource �� *Self+ �� Path$	 Tag� � 	Resources 50       �� 
TargetType �� Property	 �� Value��%^   '��       �� 51      " ��6    .�52      ��  �@��CornerRadius$	 5��6=   53      54      55      56      57      �� 5;   
   $��Center=�6   $��Center=�6Z   $��1��6v   $��10q�6�   ��64   �� *OrdersOngoing+��5<      �� 5=      .R�5>      �� 
 �� Orientation$
 
Horizontal=�6!   5?      ��5A      �� 5B      .R�5E      �� $��40q�6   
�������$��2q�6@    �� CornerRadius$ 8,8,8,8��6T   ._�5G      �� .+�5I      �� $
 
Horizontal=�6)   $��Center=�6B   .+�5J   "   �� $��	OrderID: ��6,   $��Center=�6=   $	��Top=�6Z   $��5 5 0 0q�6r   $��15(�6�   �� 5K   "   $
 
Horizontal=�6-   $��Center=�6F   .+�5L   &   �� $��#��60   $�� 0 5 0 5q�6:   $��15(�6L   $
��Bold"�6Z   �� 5M   &   $��Center=�6I   $	��Top=�6f   $�� 0 5 5 5q�6~   $��15(�6�   $
��Bold"�6�   ��60   �� *	OrderID+6�   5N   #   5O      �� 5R      $��5q�6%   $	��170��60   $��6��6<   $ 3,3,3,3��6G   
�������$��1q�6u   �� 5U      $��Center=�6M   $	��200��6h   $	��350��6t     	Scrollbar#���  6�   ��6+   �� *	PizzaList+��5V   "   �� 5W   &   .R�5X   *   �� $
 Vertical=�65   .+�5Z   .   �� $
��Bold"�6N   $��Center=�6a   $��	0 10 10 0q�6~   $��15(�6�   ��68   �� *Type+6�   �� 5]   .   $��Center=�6d   ��6;   �� *PizzaIngredients+��5^   2   �� 5_   6   .R�5`   :   � 5a   7   ��5c   2   �� 5d   6   .R�5e   :   �� .+�5g   >   �� $��5 0 0 0q�6^   $��15(�6o   ��6H   �� *Type+,5i   ?   5k   ;   5l   7   5n   /   5o   +   5p   '   5r      �� 5t      $��Bottom=�6)   $
 Vertical=�6D   .+�5w   "   �� $��5q�6)   $	��170��64   $��6��6@   $ 3,3,3,3��6K   
�������$��1q�6y   �� 5z   "   $��Tillaga��6)     GreenActionButton#��[ 6<   $��15(�6g   $ ChosenOrder��5}   %   $��50��67   ��5{   %   �� *DataContext.CookOrder+ ��  �� AncestorType ItemsControl��5|   %   �� *	OrderID+ 5~   &   ��%^   '��       �� 5   *   " ��60   .�5�   .   ��  �@��CornerRadius$	 5��6M   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�   
   $��2��6   $��Ordrar som väntar:��6!   $��14(�6;   $��5q�6I   $	��Top=�6T   $
��Bold"�6l   �� 5�   
   $��Center=�6=   $��3��6Y   ��6   �� *WaitingOrders+��5�      �� 5�      .R�5�      �� $
 
Horizontal=�6!   6<   5�      ��5�      �� 5�      .R�5�      �� $��20q�6   
���   �$��1q�6=   
�������$ 3,3,3,3��6d   ._�5�      �� .+�5�      �� $��	OrderID: ��6(   $��Center=�69   $	��Top=�6V   $��5q�6n   $��15(�6y   �� 5�      $
 
Horizontal=�6)   $��Center=�6B   .+�5�   "   �� $��#��6,   $��0 0 0 0q�66   $��15(�6H   $
��Bold"�6V   �� 5�   "   $��Center=�6E   $	��Top=�6b   $��	0 0 10 10q�6z   $��15(�6�   $
��Bold"�6�   ��6,   �� *	OrderID+6�   5�      5�      5�      5�      5�      5�      5�      