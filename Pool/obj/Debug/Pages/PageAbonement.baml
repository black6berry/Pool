   M S B A M L   `   `   `  ����?  ;Pool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pool.Pages
Pool.Pages  5          Pool.Pages.PageAbonement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Pool.Pages     5        N� Title$  PageAbonement��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��197* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   �� 5      $
��671* �6   .+�5   
   �� $��0��5      $��2��5       �� Orientation$ 
Horizontal=�5      $��	10 0 0 0 q�5      .+�5      �� -   5        $��AddNote��5      $��30��5      $��80��5      $��Добавить��5      5      �� 5!      -   5        $��
DeleteNote��5$      $��30��5"      $��80��5#      $��Удалить��5%      $��	10 0 0 0 q�5'      5)      &   System.Windows.Controls.DataGrid  5*   
   -   5        $��GridAbonementList��5-      $��2��5+      $��2��5,         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   AlternatingRowBackground
 �����   GridLinesVisibility$	 All=�52      	   Columns	 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��55         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1 57      1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      �� *Id+57        59      $
 Number��5:      $ * 5<       5;      �� *Number+5<        5>      $
 Category��5?      $ * 5A       5@      �� *Category.Name+5A        5C      $
 NumberVisit��5D      $ * 5F       5E      �� *NumberVisit.Quantity+5F        5H      $
 Price��5I      $ * 5K       5J      �� *Price+5K      5N      5O      5P      