   M S B A M L   `   `   `  ����F  BWpfMVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WpfMVVMDemo.UserControlsWpfMVVMDemo.UserControls  5   	   =#clr-namespace:WpfMVVMDemo.ViewModelWpfMVVMDemo.ViewModel  5   	       WpfMVVMDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WpfMVVMDemo.UserControls     5   	   2vm#clr-namespace:WpfMVVMDemo.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��600��6)    � 	Resources 5
      +   %WpfMVVMDemo.ViewModel.PersonViewModel   PersonViewModel��%   &	          5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6   .+�5%   
   �� $��0��6   $��0��6!   $��	FirstName��61   $��Center=�6B   �� 5&   
   $��0��6   $��1��6   $	��300��6/   $
��Left=�6;   ��6V   �� *Person.FirstName+ �� Mode$ TwoWay=��� 5'   
   $��1��6   $��0��6!   $��LastName��61   $��Center=�6A   �� 5(   
   $��1��6   $��1��6   $	��300��6/   $
��Left=�6;   ��6V   �� *Person.LastName+$ TwoWay=��� 5)   
   $��2��6   $��1��6   $��Submit��6.   $
��Left=�6a   ��6?   �� *SubmitCommand+6a   '   !WpfMVVMDemo.UserControls.ListView  5+   
   $��1��6   $��3��6)   58      59      