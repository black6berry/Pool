   M S B A M L   `   `   `  ����?  ;Pool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PoolPool  5   	       Pool.WindowAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Pool     5   	     � Title$!  Общие сведения��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��197* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   �� 5      $
��671* �6   .+�5   
   �� $��0��5      $��2��5       �� Orientation$ 
Horizontal=�5      $��	10 0 0 0 q�5      .+�5      �� -   5        $��AddNote��5      $��30��5      $��80��5      $��Добавить��5       5!      �� 5#      -   5        $��
DeleteNote��5&      $��30��5$      $��80��5%      $��Удалить��5'      $��	10 0 0 0 q�5)      5+      ]� 5,   
   $��0��5-      $��2��5.      $��Right=�5/      
�������$��Center=�51      .+�54      �� $��Поиск:��55      �� 56      -   5        $��	TxbSearch��57      $	��220��5:      $��20��5;      $��0 0 10 0q�5<      $ �� HorizontalScrollBarVisibility$
 Auto=�5=      .��66   5?      5@      �� 5C   
   $��1��5D      $��2��5E      .+�5F      �� -   5        $
��User��5G      $��Посетители��5I      $	��100��5J      $��25��5K      $��0 10 0 0q�5L      �� 5N      -   5        $
��Pool��5O      $��Басейны��5Q      $	��100��5R      $��25��5S      $��0 10 0 0q�5T      �� 5V      -   5        $��Trener��5W      $��Тренера��5Y      $	��100��5Z      $��25��5[      $��0 10 0 0q�5\      �� 5^      -   5        $��Group��5_      $��Группы��5a      $	��100��5b      $��25��5c      $��0 10 0 0q�5d      �� 5f      -   5        $��	Abonement��5g      $��Абонементы��5i      $	��100��5j      $��25��5k      $��0 10 0 0q�5l      5n      &   System.Windows.Controls.DataGrid  5q   
   -	   5        $��GridUserList��5t      $��1��5r      $��2��5s         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����	   AlternatingRowBackground
	 �����
   GridLinesVisibility$	
 All=�5y      $��2��5z         Columns 5{      0  *System.Windows.Controls.DataGridTextColumn  5|      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��5}         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1 5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5~      �� *Id+5        5�      $
 Name��5�      $ * 5�       5�      �� *Name+5�        5�      $ Surname��5�      $ * 5�       5�      �� *	Surname+5�        5�      $ 
Patronomic��5�      $ * 5�       5�      �� *
Patronomic+5�        5�      $ Phone��5�      $ * 5�       5�      �� *Phone+5�        5�      $ AbonementNum��5�      $ * 5�       5�      �� *Abonement.Number+5�        5�      $ Category��5�      $ * 5�       5�      �� *Abonement.Category.Name+5�        5�      $ Visit��5�      $ * 5�       5�      �� * Abonement.NumberVisit.Quantity+5�      5�       � 5�   
   -
   5        $��FrmGrid��5�      $��2��5�      $��2��5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      