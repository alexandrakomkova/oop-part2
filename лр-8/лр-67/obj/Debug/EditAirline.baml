   M S B A M L   `   `   `  ����B  >лр-67, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:лр_67лр_67  5   	       лр_67.EditAirline   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:лр_67     5   	   -   5        $��
EditWindow��5   o    
  Cursor  � Cursor#  �   5        
EditWindow � Title# �  5   	     AddWindowGrid#���  6.   $	��300��6V   $	��405��6c    � 
ResizeMode$ NoResize=�6�   .��5      � $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ 	CompanyTB��5        TextBox#���  6%   $
��Left=�6G   $��25��6b   $��
228,32,0,0q�6o    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��142��6�   �� 5   
   -   5         ��Name$ CompanyBlock��5        	CompanyTB#���  6*    J� IsHitTestVisible .    CompanyBlock#���  6g   $��
227,29,0,0q�6�   $	��Top=�6�   $
��Left=�6�   �� 5   
   -   5        $ FlyToTB��5      $
��Left=�6#   $��25��6>   #���  6J   $��
228,94,0,0q�6l   $
 Wrap=�6�   $	��Top=�6�   $	��142��6�   �� 5   
   -   5        $ 
FlyToBlock��5        FlyToTB#���  6(    .    
FlyToBlock#���  6c   $��
228,91,0,0q�6�   $	��Top=�6�   $
��Left=�6�   �� 5   
   -   5        $ 	FlyFromTB��5      $
��Left=�6%   $��25��6@   #���  6L   $��
228,63,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��142��6�   �� 5   
   -   5        $ FlyFromBlock��5        	FlyFromTB#���  6*    .   	 FlyFromBlock#��� 	 6g   $��
228,63,0,0q�6�   $	��Top=�6�   $
��Left=�6�   �� 5   
   -   5        $ PriceTB��5      $
��Left=�6#   $��25��6>   #���  6J   $��228,125,0,0q�6l   $
 Wrap=�6�   $	��Top=�6�   $	��142��6�   6�   �� 5   
   -	   5        $ 
PriceBlock��5       .   
 PriceTB#��� 
 6A     
PriceBlock#���  6c   $��228,125,0,0q�6�   
�������$	��Top=�6�   $
��Left=�6�   � 5   
   -
   5        $��Image��5        	ImageGrid#���  6   $��0��6A   $
��Left=�6O   $	��150��6j   $	��150��6w   $��	36,34,0,0q�6�   $	��Top=�6�   .+�5      �� -   5         ��Name$ ImageCompany��5      $
��Left=�6*   $	��150��6E   $	��150��6R   $��2,0,-2,0q�6^   $	��Top=�6p   �� 5      -   5         ��Name$ 
LoadButton��5        
LoadButton#���  6)   $
��Left=�6P   $��26��6k   $��2,159,0,-35q�6w   $	��Top=�6�   $��70��6�   6�   5      �� 5   
   -   5        $ SaveChanges��5        SaveChanges#���  6&   $
��Left=�6N   $��29��6i   $��246,207,0,0q�6u   $	��Top=�6�   $	��114��6�   6�   5       5!      