   M S B A M L   `   `   `  ����?  ;ryle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ryle.Pages
ryle.Pages  5   	       ryle.Pages.merches   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ryle.Pages     5   	     � Title$  merches��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   �� -   5        $��22(�5      $��Center=�6   $��Right=�6:   
����� �$
��Bold"�6h   $��1��6z   .��6�   
Выйти6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��lv��5         AutoGenerateColumns .     GridLinesVisibility$
 None=�69      RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5       �� Binding 6&   �� *	TextColor+ �� Value True6D   .a�5      �� 	 �� Property	 � ��
 �� Value

 �����6;   5      5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6)      CellTemplate 5      �� 5      .R�5      �� .+�5   "   �� $	��150��6(   ��5    &   �� 5!   *    �� Path$ photo�62    �� TargetNullValue 5"   .   ��5#   2   /photo/t4.jpg��6M   5%   +   5'   #   5(      5)      5,        5-      $ 1* 6)    5.      �� 5/      .R�50      �� $��Center=�6)   .+�51   "   �� $��30(�6C   
����� ���6,   �� *title+6g   �� 52   "   $��15(�6J   
����  ���6,   �� *descreption+6r   �� 53   "   $��15(�6I   
����  ���6,   �� *detailproiz+6q   �� 54   "   ��6,   �� *cost+��6B   �� *Arrow+6f   �� 55   "   ��6,   �� *	newcost+6H   56      58      5:        5<      $ 1* 6)    5=      �� 5>      .R�5?      �� $��Center=�6(   $��Right=�6C   ��6_   �� *
discount+ �� StringFormat$ скидка: {0:0.##}%��6�   5@      5B      5D      5F      5G      