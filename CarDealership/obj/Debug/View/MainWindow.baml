   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CarDealership.ViewCarDealership.View  5   	   #    CarDealership.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CarDealership.View     5   	   $	��400��5   	   $	��500��5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$2 ,Окно вывода данных из бд��5   	   $	��450��6*   $	��800��67   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ textBlockAccount��5      $
��5,10q�5      $��20(�5      $
��Left=�5      �� 5      $��1��6   .+�5      �� -   5        $��
btnAddToDb��5      $'��!Добавить/Изменить��5!      $	��240��5"      $��10q�5#      $��Right=�5$      �� 5&      -   5        $��btnDeleteToDb��5'      $��Удалить��5)      $	��240��5*      $��10q�5+      $��Right=�5,      5-      5/      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ dataGridView��51      $��1��52         
IsReadOnly .    AutoGenerateColumns .  ��55      �� *	Manager+ �� SelectedItem 56      �� *SelectedManager+	   Columns	 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фамилия��59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5:      �� *	Surname+  5<      $
 Имя��5=       5>      �� *	FirstName+  5A      $
 Отчество��5B       5C      �� *
MiddleName+5F      5G      5H      