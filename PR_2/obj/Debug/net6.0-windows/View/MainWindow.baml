   M S B A M L   `   `   `  ����?  ;PR_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PR_2PR_2  5   	       PR_2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   localclr-namespace:PR_2  5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��600��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��305* �6   �� 5      $	��49* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  $��30��6   $��Center=�6!   $��2��6Z      SelectedDate 6<   �� *Date+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ CalendarClosed��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *
SelectDate+5      5      �� 5   
   $	��300��6   $	��300��6   $��Center=�6+   $��Center=�6F   $��1��6�   ��6c   �� *	ListBox+ �� SelectedItem 6�   �� *Select+ 5        5      $ SelectionChanged��6!   . 5         6,   �� *
SelectItem+5      5!      �� 5"   
   $��3��6   $��2��6"   $��2��66   	 �� Orientation$	 
Horizontal=�6G   .+�5#      �� $	��150��6   $��50��6!   $
��25,0q�6-   $��Удалить��6;    5$        5%      $ Click��6%   . 5&         60   �� *Delete+5'      5)      �� 5*      $	��150��6   $��50��6!   $
��25,0q�6-   $��Изменить��6;    5+        5,      $ Click��6%   . 5-         60   �� *Update+5.      50      �� 51      $	��150��6   $��50��6!   $
��25,0q�6-   $��Добавить��6;    52        53      $ Click��6%   . 54         60   �� *Add+55      57      58      �� 59   
   $��1��6   $��1��6%   .+�5:      �� $��Название��6   
 �� TextAlignment$
 Center=�6(   $
��Jura)�6?   $��16(�6Q   $��15q�6_   �� 5;       �� TextAlignment$ Center=�6   $
��Jura)�6-   $��16(�6?   ��6M   �� *Name+�� 5<      $��Описание��6   $
 Center=�6(   $
��Jura)�6?   $��16(�6Q   $��15q�6_   �� 5=      $ Center=�6   $
��Jura)�6-   $��16(�6?   ��6M   �� *Description+5>      5@      5A      