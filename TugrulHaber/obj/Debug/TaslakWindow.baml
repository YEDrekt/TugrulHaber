   M S B A M L   `   `   `  ����F  BTugrulHaber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TugrulHaberTugrulHaber  5   	       TugrulHaber.TaslakWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TugrulHaber     5   	   -   5          �Name$  windowTaslak��5   	    � Title$ Taslak��5   	   $	��514��6   $	��591��6%    � 
ResizeMode$ NoResize=�6N   .��5	      � $	��468��6   $	��Top=�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��Yazar İsmi:��6   $
��Left=�65   $��	15,17,0,0q�6P   $	��Top=�6c   $
��Bold"�6{   �� 5   
   -   5         ��Name$ tbxYazarIsim��5      $
��Left=�6(   $��26��6C   $��	83,17,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��256��6�   �� 5   
   -   5        $ label1��5      $��Haber Türü:��6    $
��Left=�66   $��
371,17,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ 0.471,0.167&�6}   $
��Bold"�6�   �� 5   
   -   5         ��Name$ cmbxHaberTur��5      $
��Left=�6)   $��
445,15,0,0q�6D   $	��Top=�6X   $	��100��6p   �� 5   
   -   5        $ label2��5      $��Haber Başlığı��6    $
��Left=�68   $��
247,66,0,0q�6S   $	��Top=�6g   $��85��6   $
��Bold"�6�   �� 5   
   -   5        $ tbxHaberBaslik��5      $
��Left=�6*   $��26��6E   $��
35,104,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��500��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��241��6T   $��
12,185,0,0q�6a   $	��Top=�6u   $	��548��6�   ._�5      �� -   5        $ tbxHaberIcerik��5      $
��Left=�6.   $	��231��6I   $��9,7,0,0q�6V   $
 Wrap=�6g   $	��Top=�6{   $	��528��6�    �� AcceptsReturn . 6�   5      �� 5   
   -	   5        	 ��Name$	 
btnYayinla��5      $��Yayınla��6%   $
��Left=�67   $��
12,431,0,0q�6R   $	��Top=�6f   $	��548��6~   $��2��6�   �� 5   
   -
   5        $ label3��5      $��Haber İçeriği��6    $
��Left=�68   $��247,156,0,0q�6S   $	��Top=�6h   $
��Bold"�6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��45��6T   $	��Top=�6`   $	��550��6x   $��10,9,0,0q�6�   $y�Visible=�6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��44��6T   $��	10,95,0,0q�6`   $	��Top=�6s   $	��550��6�   $y�Visible=�6�   5      5      