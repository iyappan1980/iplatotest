   M S B A M L   `   `   `  ����A  =iPlato, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:iPlatoiPlato  5   	       iPlato.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:iPlato     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5   
   $	��150 �6   �� 5   
   $	��250 �6   �� 5   
   $
��100* �6    � RowDefinitions 5      �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��10 �6   �� 5      $	��50* �6   �� 5   
   $��50 �6   .+�5   
   �� -   5        $��lblTitle��5      $��People Information��6$   $��Center=�6>   $��Center=�6[   $��0��6v   $��3��6�   $��Arial Black)�6�   $��20(�6�   �� 5   
   -   5        $��lblName��5      $��Name: ��6#   $��1��61   $��0��6>   $��Center=�6N   $��Center=�6k   $��Arial Narrow)�6�   $��18(�6�   $��Normal"�6�   �� 5   
   -   5        $��lbldob��5      $��Date of Birth: ��6"   $��2��69   $��0��6F   $��Center=�6V   $��Center=�6s   $��Arial Narrow)�6�   $��18(�6�   �� 5   
   -   5        $��lblProfession��5      $��Profession: ��6)   $��3��6=   $��0��6J   $��Center=�6Z   $��Center=�6w   $��Arial Narrow)�6�   $��18(�6�   �� 5   
   -   5        $��txtName��5       �� 	MaxLength$ 60��6!   $��1��60   $��1��6=   $��45��6o   $	��245��6{   $
��Left=�6�   $��Center=�6�   $��Center=�6�   ��6M   �� *Name+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $��txtDob��5      $ 10��6    $��2��6/   $��1��6<   $��45��6m   $	��245��6y   $
��Left=�6�   $��Center=�6�   $��Center=�6�   ��6L   �� *Dob+$ TwoWay=�6�   �� 5   
   -   5        $��txtProfession��5      $ 60��6'   $��3��66   $��1��6C   $��45��6|   $	��245��6�   $
��Left=�6�   $��Center=�6�   $��Center=�6�   ��6T   �� *
Profession+$ TwoWay=�6�   �� 5    
   $��5��6   $��3��6    ��65   ��  �� Path$ dtTable�$ TwoWay=� �� SelectedItem 6f   �� *SelectedRow+ �� View 5!      �� 5"      .P�5$      ��  �� Width$	 250��6&   $
��Name��62   	 �� DisplayMemberBinding	 6@   �� $
 Name�$ TwoWay=��� 5%      $	 250��6%   $��Date of Birth��62   	 6I   �� $	 Dob�$ TwoWay=�5'      5)      �� 5+   
   $��2��6   $��1��6!   $��30��6/   $	��100��6;   $	��Add��6k   $
��Left=�6y   ��6G   �� *AddClickCommand+6y   �� 5,   
   $��2��6   $��2��6!   $��30��6.   $	��100��6:   $
��Left=�6F   $
��Edit��6�   ��6a   �� *EditClickCommand+6�   �� 5-   
   $��2��6   $��3��6!   $��30��6.   $	��100��6:   $
��Left=�6F   $��Delete��6�   ��6a   �� *DeleteClickCommand+6�   5.      51      