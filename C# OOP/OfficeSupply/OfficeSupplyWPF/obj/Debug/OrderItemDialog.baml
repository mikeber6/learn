   M S B A M L   `   `   `  ����J  FOfficeSupplyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OfficeSupplyWPFOfficeSupplyWPF  5   	   %    OfficeSupplyWPF.OrderItemDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OfficeSupplyWPF     5   	     � Title$  
Order Item��5   	   $	��169��6   $	��300��6)    � WindowStartupLocation$ CenterOwner=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6    $��2q�6-   .��68   Product ID:6E   �� 5   
   -   5        $��productIdTextBox��5      $��1��6*   $��0��6:   $��2q�6G   $��2��6R   {�.  6f   �� 5   
   $��0��6   $��1��6    $��2q�6-   .��68   Unit Price:6E   �� 5   
   -   5        $��unitPriceTextBox��5      $��1��6*   $��1��6:   $��2q�6G   $��2��6R   {�.  6f   �� 5   
   $��0��6   $��2��6    $��2q�6-   .��68   	Quantity:6C   �� 5   
   -   5        $��quantityTextBox��5      $��1��6)   $��2��69   $��2q�6F   $��1��6Q   {�.  $��80��6w   $��1��6�   �� 5!   
   $��0��6   $��3��6%   $��3��69    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5"      �� -   5        $��okButton��5"       �� 	IsDefault . $��80��6M   $��5q�6[   .��6f   OK6j   �� 5#      -   5        $��cancelButton��5#       �� IsCancel . $��80��6T   $��5q�6b   .��6m   Cancel6u   5$      5&      5'      