   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��600��6)    � AllowsTransparency .  � WindowStyle$
 None=�6P   
������ $��Georgia)�6|   ��5	      �� 5
   
    �� 
TargetType" �6   .R�5      �� $��	newBorder��6    �� CornerRadius$	 300��6&   
���   �._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      �� 5      $
��Auto �6(   .+�5      �� $��1��6   ._�5      �� .u�5      �� 5      5      5      5      5      .��5      � .+�5   
   A� $	��400��6   $	��400��6   $��24,50,176,150q�6+   ��5      
� 5       
� GradientOrigin$ 	0.25,0.25&�6&   .��5      �  � Color$ Azure��6#    � Offset$ 0Q�61   6>   � 5       $
 Gray��6#   $	 0.3Q�60   6?   � 5!      $ Black��6#   $ 1Q�61   6>   5"      5$      A� 5%   
   $	��300��6   $	��300��6   
�������6+   �� 5&   
   $��8��6   $��Center=�6   $��Center=�69   $	��280(�6T   �� 5'   
   -   5        	 ��Name$	 closeButton��5'      $��30��5(      $��30��6   $��473,80,97,472.4q�6(   ��5)      �� 5*      
 j� TileMode$

 Tile=�6    �� ImageSource$' !remove_delete_exit_close_1545.png��6-   5,      �� 5-   
   $��Question��6   $��15q�6#   $��Center=�6/   $	��Top=�6L   $��25(�6d   
�������6r   �� 5.   
   -   5        $��question��5.      $
��Bold"�6"   $��Center=�64   $	��Top=�6Q   $	��300��6i   $��60q�6u   $��20(�6�   
�������
�������6�   �� 5/   
    �� Orientation$ 
Horizontal=�6   .+�50      �� $��Answer��6   $��100,90,0,85q�6%   $
��Left=�6:   $��Bottom=�6U   $��25(�6p   
�������6~   �� 51      -   5         ��Name$ answer��51      $	��245��6(   $��20(�64   $��
10,90,0,90q�6B   $
��Left=�6V   $��Bottom=�6q   
�������
�������6�   52      �� 53   
   -   5        $	��Ask��53      $��Center=�6   $��Bottom=�6<   $��250,0,250,27q�6W   $	��100��6m   $��43��6y   $��25(�6�   $
��Bold"�6�   6�   54      55      