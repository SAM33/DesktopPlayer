   M S B A M L   `   `   `  ����R  NDesktopBackgroundPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DesktopBackgroundPlayerDesktopBackgroundPlayer  5   	   (    "DesktopBackgroundPlayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:DesktopBackgroundPlayer     5   	     � Title$<  6DesktopPlayer (https://github.com/SAM33/DesktopPlayer)��5   	   $	��150��6H   $	��430��6U    � Icon$ bg.PNG��6a    � WindowStyle$ 
ToolWindow=�6o   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF1DA5AC��6   $ 1Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��229* �6   �� 5      $	��14* �6   �� 5      $	��20* �6   �� 5      $	��72* �6   �� 5      $��4* �6   .+�5   
   �� -   5         ��Name$
 play��5      $
��Play��6   $
��Left=�6.   $��
123,50,0,0q�6I   $	��Top=�6]   $��75��6u   6�   �� 5   
   -   5        $
 open��5      $
��Open��6   $
��Left=�6.   $��	19,50,0,0q�6I   $	��Top=�6\   $��75��6t   6   �� 5   
   -   5        $ pause��5      $��Pause��6    $
��Left=�60   $��
227,50,0,0q�6K   $	��Top=�6_   $��75��6w   $��2��6�   �� 5   
   -   5        $
 stop��5      $
��Stop��6   $
��Left=�6.   $��5,50,0,0q�6I   $	��Top=�6[   $��75��6s   $��3��6�   �� 5   
   -   5        	 ��Name$	 slider��5      $
��Left=�6!   $��	19,16,0,0q�6<   $	��Top=�6O   
 J� RenderTransformOrigin$
 1.667,-1.167&�6g   $	��388��6�   $��4��6�    � Value$ 40Q�6�    � Maximum$	 100Q�6�   6�   �� 5   
   -   5         ��Name$ label��5      $��File :��6   $
��Left=�60   $��	19,74,0,0q�6K   $	��Top=�6^   5      5      