   M S B A M L   `   `   `  ����?  ;lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab3lab3  5   	       lab3.AddTimer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab3     5   	     � Title$  AddTimer��5   	   $��384.083��6   $��242.251��6+   .��5	      � $��	0,0,-8,-5q�6   ���	#FFFFCFEE � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.Calendar  -   5          Name$	 cal��5      $
��Left=�6    $��
28,116,0,0q�6;   $	��Top=�6O   ���	#FFBBFFF6��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFBBFFFF��6#    � Offset$ 0.159Q�65   � 5      $ White��6#   $
 0.16Q�61   � 5      $ 	#FFFFFFF6��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$
 name��5      $
��Left=�6    $��22��6;   $��	28,33,0,0q�6G   	 �� TextWrapping$
	 Wrap=�6Z   $��Введите имя��6n   $	��Top=�6�   $	��179��6�   �� 5   
   -   5        $ hours��5      $
��Left=�6!   $��32��6<   $��	28,66,0,0q�6H   $
	 Wrap=�6[   $��часы��6o   $	��Top=�6{   $��49��6�   �� 5   
   -   5        $	 min��5      $
��Left=�6   $��32��6:   $��	82,66,0,0q�6F   $
	 Wrap=�6Y   $��минуты��6m   $	��Top=�6{   $��64��6�   �� 5   
   -   5        $	 sec��5      $
��Left=�6   $��32��6:   $��
151,66,0,0q�6F   $
	 Wrap=�6Z   $��секунды��6n   $	��Top=�6}   $��56��6�   �� 5   
   -   5        
 ��Name$	
 add��5      $��Добавить��6   $
��Left=�61   $��30��6L   $��
28,300,0,0q�6X   $	��Top=�6l   $��73��6�   ���	#FFBBFFF6���	#FFBBFFF66�   �� 5   
   -   5        $	
 can��5      $��Отмена��6   $
��Left=�6/   $��30��6J   $��134,300,0,0q�6V   $	��Top=�6k   $��73��6�   ���	#FFBBFFF6���	#FFBBFFF66�   5       5!      