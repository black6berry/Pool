   M S B A M L   `   `   `  ����?  ;Pool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pool.Pages
Pool.Pages  5          Pool.Pages.PageUsers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Pool.Pages     5        N� Title$  	PageUsers��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��197* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   �� 5      $
��671* �6   .+�5   
   �� $��0��5      $��2��5       �� Orientation$ 
Horizontal=�5      $��	10 0 0 0 q�5      .+�5      �� -   5        $��AddNote��5      $��30��5      $��80��5      $��Добавить��5      5      �� 5!      -   5        $��
DeleteNote��5$      $��30��5"      $��80��5#      $��Удалить��5%      $��	10 0 0 0 q�5'      5)      &   System.Windows.Controls.DataGrid  5,   
   -   5        $��GridUserList��5/      $��2��5-      $��2��5.         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   AlternatingRowBackground
 �����   GridLinesVisibility$	 All=�54      	   Columns	 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��57         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1 59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 58      �� *Id+59        5;      $

 Name��5<      $ * 5>       5=      �� *Name+5>        5@      $
 Surname��5A      $ * 5C       5B      �� *	Surname+5C        5E      $
 
Patronomic��5F      $ * 5H       5G      �� *
Patronomic+5H        5J      $
 Phone��5K      $ * 5M       5L      �� *Phone+5M        5O      $
 AbonementNum��5P      $ * 5R       5Q      �� *Abonement.Number+5R        5T      $
 Category��5U      $ * 5W       5V      �� *Abonement.Category.Name+5W        5Y      $
 Visit��5Z      $ * 5\       5[      �� * Abonement.NumberVisit.Quantity+5\      5_      5`      5a      