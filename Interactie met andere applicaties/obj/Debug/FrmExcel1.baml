   M S B A M L   `   `   `  ����\  XInteractie met andere applicaties, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Interactie_met_andere_applicaties!Interactie_met_andere_applicaties  5   	   1    +Interactie_met_andere_applicaties.FrmExcel1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Interactie_met_andere_applicaties     5   	     � Title$  	FrmExcel1��5   	   $	��300��6   $	��300��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Bedrag��6   $��0��6"   $��0��6/   $��5q�6?   �� 5   
   -   5        $��	txtBedrag��5      $��0��6#   $��1��60   $��5q�6@   �� 5   
   $��Termijn��6   $��1��6#   $��0��60   $��5q�6@   �� 5   
   -   5        $��
txtTermijn��5      $��1��6$   $��1��61   $��5q�6A   �� 5   
   $��Rentepercentage��6   $��2��6+   $��0��68   $��5q�6H   �� 5   
   -   5        $��txtPercentage��5      $��2��6'   $��1��64   $��5q�6D   �� 5   
   $��
Te Betalen��6   $��3��6&   $��0��63   $��5q�6C   �� 5   
   -   5        $��txtTeBetalen��5      $��3��6(   $��1��65   $��5q�6E   �� 5   
   -   5        $��
btnBereken��5      $��Bereken��6#   $��4��65   $��0��6B   $��5q�6l   �� 5   
   -   5        $��
btnSluiten��5      $��Sluiten��6#   $��4��65   $��1��6B   $��5q�6l   5       5!      