   M S B A M L   `   `   `  ����J  FOfficeSupplyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OfficeSupplyWPFOfficeSupplyWPF  5   	        OfficeSupplyWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OfficeSupplyWPF     5   	   -   5          � Title$  Office Supply Ordering��5   	   $	��484��6(   $	��550��65   .��5
      � .+�5   
   �� -   5        $��
LayoutRoot��5       �� Orientation$ Vertical=�6?   $
��Left=�6V   $
��auto��6q   $
��auto��6    � DataContext 6'   �� .+�5      �� $ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Categories:��6   $��	20,10,0,0q�6.   �� 5      -   5        $��categoriesComboBox��5   3   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6M    �� DisplayMemberPath$
 Name��6r   $��23��6�   $��12q�6�   $	��200��6�   ��6   �� ��5      �� 5      .R�5      $� 5      5      �� 5      -   5        $��loginButton��5   5   $��Login��6   $��30��6)   $��75��6H   $��20,5,0,0q�6S   6e   �� 5      -   5        $��
exitButton��5   4   $
��Exit��6   $��30��6(   $��75��6F   $��20,5,0,0q�6Q   6c   5      &   System.Windows.Controls.DataGrid  5      -   5        $��ProductsDataGrid��5   �      AutoGenerateColumns .  $	��165��63      RowDetailsVisibilityMode$ VisibleWhenSelected=�6l   $	��490��6�   $
��Left=�5      $��
20,0,20,10q�62      SelectionMode$ Single=�6F   ��5   @   �� *drCategoryToProduct+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        productIDColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 
Product ID��5   e   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 40* 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ��  �� Path$ 	ProductId�6y     5      -   5        
nameColumn��$
	 Name��5   [   $	
 40* 6i    6=   �� $
 Name�6i     5       -	   5        descriptionColumn��$	 Description��5    i   $	
 80* 6~    6D   �� $ Description�6~     5!      -
   5        unitCostColumn��$	 	Unit Cost��5!   c   $	
 30* 6v    6A   �� $ UnitCost�6v   5#      �� 5%      $ Vertical=�6   .+�5&      �� -   5        $��orderListView��5&      $	��150��60   $	��490��6@    �� SelectionMode$ Single=�6d   ��6L   ��  �� View 5'      �� 5(      .P�5)      ��  �� Width$	 140��6-   $��
Product ID��69    �� DisplayMemberBinding 6M   �� *ProdID+�� 5*      $	 140��6-   $��
Unit Price��69    6M   �� *	UnitPrice+�� 5+      $	 140��6-   $��Quantity��69    6K   �� *
Quantity+5,      5.      5/      �� 51      $ 
Horizontal=�6   $��Center=�62   .+�52      �� -   5        $��	addButton��52      $��25��6*   $��80��69   $��Add Item��6G   6Z   �� 53      -   5        $��removeButton��53      $��25��6-   $��80��6<   $��Remove Item��6J   6`   �� 54      -   5        $��placeOrderButton��54      $��25��61   $��80��6@   $��Place Order��6N   6d   55      56      �� 57   
   $��Bottom=�6   $��Stretch=�6/   .@�58      �� -   5        $��statusTextBlock��58      $"You must log in to place an order.6S   59      5:      5;      