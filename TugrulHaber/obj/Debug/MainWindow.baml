   M S B A M L   `   `   `  ����F  BTugrulHaber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TugrulHaberTugrulHaber  5   	       TugrulHaber.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TugrulHaber     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Tuğrul Haber��5   	   $��400.351��6   $	��531��6/    � 
ResizeMode$ NoResize=�6;   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $
��335* �6   .+�5   
   �� -   5         ��Name$ lsbxHaberler��5      $
��Left=�6(   $	��215��6C   $��0,10,0,0q�6P   $��1��6b   $	��Top=�6o   $	��517��6�   �� 5   
   $
��Left=�6   $��42��60   $	��Top=�6<   $	��517��6T    �� Orientation$ 
Horizontal=�6`   .+�5      �� -   5         ��Name$ btnTurHepsi��5      $��Hepsi��6*   $
��Auto��6:   $	��130��6H   6T   �� 5      -   5        $ btnTurGundem��5      $��Gündem��6+   $��42��6<   $	��130��6H   $��Bottom=�6T   6o   �� 5      -   5        $ 
btnTurSpor��5      $
��Spor��6)   $
��Auto��68   $	��129��6F   6R   �� 5      -   5        $ btnTurDunya��5      $��Dünya��6*   $
��Auto��6:   $	��129��6H   6T   5      �� 5   
   -   5        $ btnHaberEkle��5      $��
Haber Ekle��6'   $
��Left=�6<   $	��Top=�6W   $	��517��6o   $��42��6{   $��	0,279,0,0q�6�   $��1��6�   �� 5   
   -   5        $ btnOku��5      $	��Oku��6!   $
��Left=�6/   $	��Top=�6J   $	��167��6b   $��42��6n   $��	0,230,0,0q�6�   $��1��6�   �� 5   
   -	   5        $ 
btnDuzenle��5      $��Düzenle��6%   $
��Left=�67   $	��Top=�6R   $	��167��6j   $��42��6v   $��175,230,0,0q�6�   $��1��6�   �� 5   
   -
   5        $ btnSil��5      $	��Sil��6!   $
��Left=�6/   $	��Top=�6J   $	��167��6b   $��42��6n   $��350,230,0,0q�6�   $��1��6�   5      5      