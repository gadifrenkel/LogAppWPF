   M S B A M L   `   `   `  ����G  CLogExtractor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LogExtractorLogExtractor  5   	       LogExtractor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:LogExtractor     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ button��5      $��0��6   $��	Load Logs��6.   $
��Left=�6B   $��	45,42,0,0q�6]   $	��Top=�6p   $��75��6�   6�   � 5   
   $��1��6    5      �� 5      6%   �� 5      6%   .+�5      �� $��0��6   $��5,20,0,0q�6)   .+�5      �� -   5         ��Name$ label��5      $��RegEx��6*   $
��Left=�6:   $	��Top=�6V   �� 5      -   5         ��Name$ rexExpTextBox��5      $
��Left=�62   $��23��6M    �� TextWrapping$
 Wrap=�6Z   $��TC[0-9]+��6n   $	��Top=�6~   $	��120��6�   6�   5      �� 5      $��1��6   $��5,20,0,0q�6)   .+�5      	� -   5         	�Name$  radiobutton_extract_before��5   2   	 	� 	GroupName$	 extract��6   $��Extract Before��6V   $
��Left=�6o   $	��Top=�6�   $	��101��6�   	� 5       -   5        $ radiobutton_extract_after��5    2   $	 extract��6   $��Extract After��6U   $
��Left=�6m   $	��Top=�6�   $	��101��6�   	� 5!      -   5        $ radiobutton_extract_this��5!   2   $	 extract��6   $��Extract This��6T   $
��Left=�6k   $	��Top=�6�   $	��101��6�   	� 5"      -   5        $+ %radiobutton_extract_remove_duplicates��5"   2   $	 extract��6   $��Remove Duplicates��6a   $
��Left=�6}   $	��Top=�6�   $	��138��6�   5#      5%      �� 5(   
   -   5        $ btn_Run��5(      $��2��6   $��	Extract
��60   $��Center=�6M   $��75��6h   
 J� RenderTransformOrigin$
 0.448,2.269&�6s   $��293,76,149,11q�6�   6�   �� 5*   
   $��2��6   $��50,70,149,11q�6"    �� Orientation$ 
Horizontal=�68   .+�5+   
   �� -	   5        $ label1��5+      $��Count��6    $
��Left=�60   $	��Top=�6L   �� 5,   
   -
   5        $ label2��5,      $	��n/a��6    $
��Left=�6.   $	��Top=�6J   $��32��6b   5-      �� 5/   
   -   5        $ 
btn_SaveAs��5/      $��2��6   $��Save As��62   $��Center=�6E   $��75��6`   $��395,76,47,11q�6k   6�   51      52      