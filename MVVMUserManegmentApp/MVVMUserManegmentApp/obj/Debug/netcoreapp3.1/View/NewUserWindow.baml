   M S B A M L   `   `   `  ����O  KMVVMUserManegmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MVVMUserManegmentApp.ViewMVVMUserManegmentApp.View  5   	   O,clr-namespace:MVVMUserManegmentApp.ViewModelMVVMUserManegmentApp.ViewModel  5   	   O,clr-namespace:MVVMUserManegmentApp.ConverterMVVMUserManegmentApp.Converter  5   	   Q-clr-namespace:MVVMUserManegmentApp.ComponentsMVVMUserManegmentApp.Components  5	   	   -    'MVVMUserManegmentApp.View.NewUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:MVVMUserManegmentApp.View     5   	   ;vm,clr-namespace:MVVMUserManegmentApp.ViewModel     5   	   :c,clr-namespace:MVVMUserManegmentApp.Converter     5   	   D
components-clr-namespace:MVVMUserManegmentApp.Components     5	   	     � Title$  NewUserWindow��5   	   $	��400��6   $	��600��6,    � 	Resources 5      3   -MVVMUserManegmentApp.Converter.GenderCoverter   GenderCoverter2   ,MVVMUserManegmentApp.Converter.DateConverter  DateConverter  errorTemplate �� CornerRadius �� 
TargetType  txtBoxBorder �� Property �� Value �� Triggers P� Property P� Value��%=  &	        &	      &	 &     &	 �     '�� �    7  '��     '	� <    '�� �      5   
   6     5   
   6   �� 5   
   .R�5      �� 
������ $ 5��6/   $��2q�6@   ._�5      � .+�5      �� 5      5      5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 2q�60   �� 5       � ��
 �����6,   �� 5       �@��CornerRadius$ 5��6-   �� 5       � ��
 �����6+   �� 5       �@��Padding$ 1q�6(    5      P� 5        �@J�IsMouseOver$
 True��61   . �5!      ��  � ��
 ��·�64   5"      P� 5#       �@J�IsKeyboardFocusWithin$
 True��6;   . �5$      ��  � ��
 ��·�64   5%      5'      �� 5(   
   " ��6   .�5)      ��  � ��$ 20��6'   �� 5*       � ��$ 0q�60   �� 5+       � ��
 ���� 6+   �� 5,       � ��$ 2,1,0,0q�6(   �� 5-       �@=�ErrorTemplate8   69   5.      �� 5/   
   " ��6   .�50      ��  � ��$ Center=�62   �� 51       � ��$ Right=�64   �� 52       � ��$ 13(�6)   �� 53       � ��
 �����6+   54      �� 55   
   " 	�6   .�56      ��  � ��
 �����6+   57      �� 58   
   " ��6   .�59      ��  � ��
 �����6+   �� 5:       � ��$ Medium"�6+   �� 5;       � ��$ 15(�6)   �� 5<       � �� �#fe659e6+   �� 5=       �@J�Opacity$	 0.5Q�6(    5>      P� 5?       � {�$
 True��66   . �5@      ��  � �� �#FE658463   �� 5A       � ��
 �����63   �� 5B       �@J�Opacity$ 1Q�60   5C      P� 5D       �@J�IsMouseOver$
 True��61   . �5E      ��  � ��
 �����63   5F      P� 5G       � ��$
 True��6/   . �5H      ��  � ��
 �OO/�63   5I      5K      5L      .��5N      � ���#344955	 � ColumnDefinitions	 5P   
   �� 5Q      $��* �6   �� 5R      $
��auto �6   �� 5S      $
��auto �6   �� 5T      $��* �6   
 � RowDefinitions
 5V   
   �� 5W      $
��auto �6   �� 5X      $
��auto �6   �� 5Y      $
��auto �6   �� 5Z      $
��auto �6   �� 5[      $
��auto �6   �� 5\      $
��auto �6   �� 5]      $
��auto �6   �� 5^      $
��auto �6   �� 5_      $
��auto �6   .+�5b   
   �� $��
First name��6   $��1��6%   $��0��65   �� 5c   
   $��0��6   $��2��6   #��[ 6.   ._�5d      �� ��6   �� *User.FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� � ToolTip 6�   �� *!User.ErrorCollection[FirstName]+5e      �� 5f   
   $��	Last name��6   $��1��6$   $��1��61   �� 5g   
   $��1��6   $��2��6   #��[ 6.   ._�5h      �� ��6   �� *User.LastName+$ TwoWay=�$ PropertyChanged=�$
 True�� 6�   �� * User.ErrorCollection[LastName]+5i      �� 5j   
   $��Email��6   $��2��6    $��1��6-   �� 5k   
   $��2��6   $��2��6   #��[ 6/   ._�5l      �� ��6   �� *
User.Email+$ TwoWay=�$ PropertyChanged=�$
 True�� 6}   �� *User.ErrorCollection[Email]+5m      �� 5o   
   $��Password��6   $��3��6#   $��1��60   �� 5p   
   $��3��6   $��2��6   #��[ 6.   ._�5q      D   >MVVMUserManegmentApp.Components.BindablePasswordBoxUserControl   =� ErrorTemplate# [ 68      Password 6r   �� *User.Password+$ TwoWay=�$ PropertyChanged=�$
 True�� 6�   �� * User.ErrorCollection[Password]+5r      �� 5t   
   $��
Birth date��6   $��4��6%   $��1��62   �� 5u   
   #��[ 6   $��5q�68   $	��250��6C   $��4��6O   $��2��6\   ._�5v      (  "System.Windows.Controls.DatePicker  -   5          Name$ dateOfBirth��5v      $��0q�6.      SelectedDate 6B   �� *
User.DOB+$ TwoWay=�$ PropertyChanged=�5w      �� 5x   
   $��Gender��6   $��5��6!   $��1��6.   	� 5y   
   $��5��6   $��2��6#    	� 	GroupName$ gender��63   $
��Male��6F   $��0,5,0,0q�6U    d� 	IsChecked 6f   �� *User.Gender+ �� 	Converter# [   �� ConverterParameter$
 Male��$ TwoWay=�$ PropertyChanged=�	� 5z   
   $��6��6   $��2��6#   $ gender��63   $��Female��6F   $��0,5,0,5q�6W    6h   �� *User.Gender+# [  $ Female��$ TwoWay=�$ PropertyChanged=��� 5{   
   $��Add User��6   $��7��6$   $��2��61   ��6A   �� *AddNewUserCommand+$ TwoWay=�$ PropertyChanged=���5|      �� 5}       �� 
TargetType" ��6"   .R�5~      �� $��25��6   $ 10��6)   #��z��6;   ._�5      �� $��Center=�6+   $��Center=�6H   5�      5�      5�      5�      5�      