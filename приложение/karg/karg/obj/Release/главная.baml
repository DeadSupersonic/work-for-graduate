   M S B A M L   `   `   `  ���� ?  ;karg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kargkarg      karg.главная   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:karg       � Title$  Главная��$	��670��$
��1000�� � Icon$( "/photos/58af8-removebg-preview.png��.��� -    �Name$
 grid�����	#FF9ECDF9 � RowDefinitions �� $��60 ���  � ColumnDefinitions �� $	��190 ��� .+��� -    ��Name$ 	backPhoto��$-��'/photos/news_file_937_5f6f460bdbc22.jpg��$
��Fill=�$��2��$��2�� J� Effect -  'System.Windows.Media.Effects.BlurEffect  �� -    ��Name$
 name��$��0��$��1�� �� TextAlignment$ Center=�$��40(�$	��300��	Santorini � -   	  �Name$	 frame��$��1��$��1��$�� ��
  � NavigationUIVisibility$
 Hidden=��� -    ��Name$ cb��$��0��$��1��$��Right=�$��40��$��20��$��	0 0 110 0q��� -   $ changecolor��$��Цвет��$��0��$��1��$��Right=�$��40��$	��100��$��	0 0 130 0q��� -    ��Name$
 exit��$��0��$��1��$��Right=�$��40��$	��100��
������ .��
Выйти�� -    ��Name$ panel��$��1��$��0��.+��� -	   $ personal��.��Сотрудники�� -
   $
 cafe��.��
Кафе�� -   $ product��.��Продукты�� -   $ adress��.��
Адрес�� -   $
 work��.��Должность�� -   $ 	telephone��.��Телефон�� -   $ postavka��.��Поставщики�� -   $ 	statistic��.��Статистика�� -   $ photo��$(��"/photos/58af8-removebg-preview.png��$	��250��$��0 10 0 0q� � Triggers :�  :� RoutedEvent$ Loaded��[��� -    ��Name$ elasticAnimation��.���� -    ��Name$ elastic��.��W�  �� TargetProperty$ Height�	 W� To$	 200X� g� Duration$ 0:0:4D� g� RepeatBehavior$ Forever�� g� AutoReverse .  W� EasingFunction 0  *System.Windows.Media.Animation.ElasticEase  7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseOut=�   Oscillations$ 5��   Springiness$ 5Q�