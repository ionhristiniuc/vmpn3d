   M S B A M L   `   `   `  ����E  ANumericBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:NumericBox;assembly=NumericBox
NumericBox  5       	PNCreatorD   >PNCreator.Modules.Positioniser.PositioniserVisualPropertyPanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;nb,clr-namespace:NumericBox;assembly=NumericBox     5      e aTelerik.Windows.Controls, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k	 gTelerik.Windows.Controls.Input, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7NtelerikInput1http://schemas.telerik.com/2008/xaml/presentation    	 
  5      
������   � RowDefinitions  5      �� 5   
   �� 5	   
   .+�5      � $��0��6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��
Line color��6   $��10q�6&   - 	 'Telerik.Windows.Controls.RadColorPicker  5   
   $��1��6&   $��Right=�66      SelectedColor 5   &   ��  �� Path$ Color� �� Mode$ TwoWay=�5      � 5      $��1��6    5   
   �� 5      �� 5      .+�5   
   �� $��Line thickness��6   $��10q�6*      NumericBox.NumericBox  5   
   -   5          Name$ lineThicknessNB��5      $��1��61      	Increment$ 1Q�6A      Minimum$	 0.1Q�6O   $��Right=�5   F      Value 6   �� $ 	Thickness�$ TwoWay=�6F   5      5      