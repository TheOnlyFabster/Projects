   M S B A M L   `   `   `  ����J  FWpfApplication6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:UIElement	UIElement  5          UIElement.Window1   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:UIElement     5        � Title$  ListView Example��5      $	��300��6   $	��400��6(    � 	Resources 5         myStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5	   
   " ��6    .�5
      ��  � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��
 � � �6+   5      5      .��5      � .+�5   
   �� -   5        $
��list��5   A   #��[  6   $��5q�6M   $��Stretch=�6X   ��5      �� 5      .R�5      � .+�5      �� $��Name: ��6$   �� 5      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5      $��, ��6$   �� 5      $��Age: ��6$   �� 5      $
��Bold"�6=   ��6$   �� *	Capital+6=   �� 5      $�� (��6$   �� 5      $��	Underline{�6:   
����  � � Cursor$
 Hand��6h   ��6$   �� *Mail+6h   �� 5      $��)��6$   5      5       �� View 5#      �� 5&       �� ColumnHeaderTemplate 5'      �� 5(      .R�5)      �� 
���**��$��2q�69    �� CornerRadius$ 5��6M   ��5*   "   �� 5+   &   .��5,   *   � 	 � Offset$	 0Q�67   
 � Color$
 Wheat��6B   � 5-   *   $	 1Q�67   $
 
LightCoral��6B   5.   '   ._�50   "   �� 
����  �$��14(�6>   $
��Bold"�6L   $��5q�6^   $
��Auto��6z   ��6i   �� 6z   51      52      .P�55      ��  �� Width$
 Auto��6%   $��State Nick Name��62    �� CellTemplate 56      �� 57      .R�58   "   9�  9� ExpandDirection$
 Down=�6+   .��59   &   ��  %� IsVirtualizing . .+�5:   &   �� 
��� � �$��14(�6C   ��6Q   �� *
NickName+5;   '   5<   #   5=      5?      �� 5@      $
 Auto��6%   $��
State Name��62    �� DisplayMemberBinding 6F   ��  �� Path$
 Name��� 5A      $
 Auto��6%   $��State Capital��62    6I   �� $ Capital�5C      5G      5J      5M      