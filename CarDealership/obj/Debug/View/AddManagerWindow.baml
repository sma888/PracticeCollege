   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CarDealership.ViewCarDealership.View  5   	   )    #CarDealership.View.AddManagerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CarDealership.View     5   	   $	��550��5   	   $	��300��5	   	     � Title$6  0Окно добавления менеджера��5
   	   $	��450��6+   $	��400��68   .��5      � $��Center=�5   	    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      .+�5   
   �� $��10q�5      .+�5       �� $��Имя��5!      �� 5"      -   5         ��Name$ boxName��5#      ��5$      �� *	FirstName+5%      �� 5(   
   $��1��5)      $��10q�5*      .+�5+      �� $��Фамилия��5,      �� 5-      -   5        $ 
boxSurname��5.      ��5/      �� *	Surname+50      �� 52   
   $��2��53      $��10q�54      .+�55      �� $��Отчество��56      �� 57      -   5        $ boxMiddleName��58      ��59      �� *
MiddleName+5:      �� 5<   
   $��3��5=      $��10q�5>      .+�5?      �� $��Возраст��5@      �� 5A      -   5        $ boxAge��5B      ��5C      �� *Age+5D      �� 5F   
   $��4��6   $��10q�5G      .+�5H      �� $��
Логин��5I      �� 5J      -   5        $ boxLogin��5K      ��5L      �� *Login+5M      �� 5O   
   $��5��6   $��10q�5P      .+�5Q      �� $��Пароль��5R      �� 5S      -   5        $ boxPassword��5T      ��5U      �� *
Password+5V      �� 5X   
   -   5        $��btnSave��5]      $��10q�5Z      $��6��5[      $��Сохранить��5\      5]      5^      5_      