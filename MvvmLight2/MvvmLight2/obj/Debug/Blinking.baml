   M S B A M L   `   `   `  ����E  AMvvmLight2, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null'clr-namespace:MvvmLight2
MvvmLight2  5          MvvmLight2.Blinking   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MvvmLight2     5        � 	Resources  5	         Led � Color � Offset  Storyboard1 �� TargetProperty �� 
TargetName g� RepeatBehavior g� AutoReverse R� KeyTime  System.Windows.Visibility   Visible	 R� Value
   Hidden��%�  &	        &	 z     
� 5
   
   .��5      � $ 	#FFF9B0B0��6   $ 0Q�6-   � 5      $ 	#FFCD0202��6   $ 1Q�6-   5      �� 5   
   .��5      T� $ (UIElement.Visibility)�6,   $ ellipse��6_   $ Forever��6    . ..�5      i� $ 0��6)   #	 Z 65   i� 5      $ 0:0:0.2��6)   #	 Z
 6;   i� 5      $ 0:0:0.4��6)   #	 Z 6;   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[ 6   5      .��5      A� -   5         A�Name$ ellipse��5      $��0q�6    ��5   
   
� 5      .��5      � $ 	#FFF9B0B0��6   $ 0Q�61   � 5      $ 	#FFCD0202��6   $ 1Q�61   5       5"      5#      