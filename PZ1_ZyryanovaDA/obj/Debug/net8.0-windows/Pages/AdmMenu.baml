   M S B A M L   `   `   `  ����J  FPZ1_ZyryanovaDA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PZ1_ZyryanovaDA.PagesPZ1_ZyryanovaDA.Pages  5      #    PZ1_ZyryanovaDA.Pages.AdmMenu   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PZ1_ZyryanovaDA.Pages     5        N� Title$  AdmMenu��5	      .��5      �  � 	Resources 5   
    	  MyCol �� Padding �� CornerRadius �� Orientation��%�  &	        �� 5      .R�5      �� $��1q�6   
���   �$��5,5,5,5q�6A   $ 5q�6R   $ 5��6^   ._�5      �� $
��auto��6!   $
��auto��6.   $ 
Horizontal=�6<   .+�5      �� $ Vertical=�6%   $
��auto��6<   .+�5      �� $
��auto��6<   $
��Left=�6I   ��6(   �� *Id+6I   �� 5      $
��auto��6?   $
��Left=�6L   ��6(   �� *Email+6L   �� 5      $
��auto��6B   $
��Left=�6O   ��6(   �� *
Password+6O   5      5      5      5      5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ userGrid��5   /      AutoGenerateColumns$ False��6      
IsReadOnly$
 True��6A      GridLinesVisibility$
 None=�6S   	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate#
 [  6+   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   5      5$      5%      5&      