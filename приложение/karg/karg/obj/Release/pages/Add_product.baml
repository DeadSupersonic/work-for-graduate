   M S B A M L   `   `   `  ���� ?  ;karg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:karg.pages
karg.pages      karg.pages.Add_product   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:karg.pages       N� Title$  Add_product��.���    gb#���    � ColumnDefinitions �� ��  � RowDefinitions �� �� $��60 �.+���  �� Orientation$ Vertical=�$��0��.+��� $��Right=�$��0 5 0 5q�$	��350��$��Right=�.��+)наименование продукта�� $��Right=�$��0 0 0 5q�$	��200��$��Right=�.��дата привоза�� $��Right=�$��0 0 0 5q�$	��250��$��Right=�.��годен до�� $��Right=�$��0 0 0 5q�$	��250��$��Right=�.��
цена�� $��Right=�$��0 0 0 5q�$	��250��$��Right=�.��качество�� $��Right=�$��0 0 0 5q�$	��300��$��Right=�.��" сколько в наличии�� $��Right=�$��0 0 0 5q�$	��250��$��Right=�.��поставщик�� $��Right=�$	��250��$��Right=�.��название кафе�� $��1��$ Vertical=�.+��� -    ��Name$
 name��$��0 15 0 0q�$��Center=�$��30��$	��200��$��Center=����� *name+(  "System.Windows.Controls.DatePicker  -     Name$ enter��$��0 15 0 0q�$��Center=�$��35��$	��200��$��Center=�   Text �� *
date_get+  -   $
 srok��$��0 20 0 0q�$��Center=�$��35��$	��200��$��Center=� �� *before_date+�� -   $ pr��$��0 20 0 0q�$��Center=�$��30��$	��200��$��Center=����� *price+�� -    ��Name$	 qua��$��0 25 0 0q�$��Center=�$��35��$	��200��$��Center=� �� SelectedValue �� *	quality+�� -   $	 how��$��0 20 0 0q�$��Center=�$��30��$	��200��$��Center=����� *
how_much+�� -   $
 idsp��	 �� DisplayMemberPath$
	 name��
 �� SelectedValuePath$

 idsp��$��0 17 0 0q�$��Center=�$��35��$	��200��$��Center=� �� *supply.name+�� -   $	 idc��$
	 name��$	
 idc��$��0 17 0 0q�$��Center=�$��35��$	��200��$��Center=� �� *	cafe.name+�� -	    ��Name$ 
ButtonSave��$��1��$��2��$��Center=�$��40��$	��170��.��Сохранить�� -
   $ 
ButtonBack��$��1��$��1��$��Right=�$��40��$	��150��.��
Назад