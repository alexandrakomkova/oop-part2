   M S B A M L   `   `   `  ����?  ;lab9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab9lab9  5   	   9!clr-namespace:lab9.CustomControlslab9.CustomControls  5   	       lab9.AddFly   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab9     5   	   1txt!clr-namespace:lab9.CustomControls     5   	   -   5        $��	AddWindow��5
   �    
  Cursor  � Cursor#  �   5	        	AddWindow � Title# �  5
   	     AddWindowGrid#���  6-   $	��300��6U   $	��405��6b    � WindowStartupLocation$ CenterScreen=�6n    � 
ResizeMode$ NoResize=�6�   .��5      � $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ FlyToTB��5        TextBox#���  6#   $
��Left=�6F   $��25��6a   $��
228,94,0,0q�6n    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��142��6�   �� 5   
   -   5         ��Name$ 
FlyToBlock��5        FlyToTB#���  6(    J� IsHitTestVisible .    
FlyToBlock#���  6d   $��
228,91,0,0q�6�   $	��Top=�6�   $
��Left=�6�   �� 5   
   -   5        $ 	FlyFromTB��5      #���  6%   $
��Left=�6H   $��25��6c   $��
228,63,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��142��6�   �� 5   
   -   5        $ FlyFromBlock��5        	FlyFromTB#���  6*    .    FlyFromBlock#���  6g   $��
228,63,0,0q�6�   $	��Top=�6�   $
��Left=�6�   � 5   
   -   5        $��Image��5      
�������$��0��60   $
��Left=�6>   $	��150��6Y   $	��150��6f   $��	36,34,0,0q�6r   $	��Top=�6�   .+�5      �� -   5         ��Name$ ImageCompany��5      $
��Left=�6*   $	��150��6E   $	��150��6R   $��2,0,-2,0q�6^   $	��Top=�6p   	 J� OpacityMask
	 �   �6�   �� 5      -   5        
 ��Name$
 
LoadButton��5        
LoadButton#���  6)   $
��Left=�6P   $��26��6k   $��2,159,0,-35q�6w   $	��Top=�6�   $��70��6�   6�   5       �� 5!   
   -	   5        $
 	Serialize��5!       	 	Serialize#��� 	 6$   $
��Left=�6J   $��29��6e   $��246,207,0,0q�6q   $	��Top=�6�   $	��114��6�   6�   (   "lab9.CustomControls.LimitedTextBox  5"   
   -
   5          Name$ 
txtCompany��5"         Title$ Copmany name:��61      	MaxLength$ 10��6G   $��228,0,28.4,207.4q�6V     5#   
   -   5        $ txtPrice��5#      (   "lab9.CustomControls.LimitedTextBox   KeyDown$ txtPrice_KeyDown��6g   $ Price:��6/   $ 4��6>   $��228,114,28.4,86.4q�6L   6g   5$      5&      