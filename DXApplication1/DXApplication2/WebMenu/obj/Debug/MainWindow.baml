   M S B A M L   `   `   `  ����  WebMenu    WebMenu.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5	      $��1* �6   �� 5
      $��1* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ button��5      $��Путь��6!   $
��Left=�60   $	��Top=�6L   $��0��6q   �� 5   
   -   5        $ button1��5      $��Выгрузить��6"   $
��Left=�66   $
��Auto��6S   $��28��6`   $��0��6y   �� 5   
   -   5         ��Name$ Count��5      $)��#Количество колонок��6   $
��Left=�6<   $	��Top=�6W   $
��auto��6o   $��28��6|   $��1��6�   �� 5   
   -   5        $ button2��5      $'��!Создать страничку��6"   $
��Left=�6>   $
��Auto��6[   $��28��6h   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dataGrid1��5   M      AutoGenerateColumns .  $��Stretch=�6/   $��Stretch=�6^   $��2��6z      
IsReadOnly .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Foto��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 67   	   CellTemplate	 5      �� 5      .R�5      �� $��image1��6Z   $��Stretch=�6$   $
��auto��6h   $	��200��6u   $
��Fill=�6�   $��Stretch=�6�   ��6B   �� *Foto+6�   5      5        5      $ Описание��6)   	 5      �� 5      .R�5       �� ��6(   �� *
FotoName+5!      5#      5%      5'      5(      