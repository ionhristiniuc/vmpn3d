   M S B A M L   `   `   `  ����D  @PNCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PNCreator.Modules.SimulationPNCreator.Modules.Simulation  5   	   b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35bFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.ShellMicrosoft.Windows.Shell 5   	   E ANumericBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:NumericBox;assembly=NumericBox
NumericBox 5   	   3    -PNCreator.Modules.Simulation.SimulationWindow   5   "   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   A
simulation*clr-namespace:PNCreator.Modules.Simulation     5   	   XshellFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.Shell     5   	   C
numericBox,clr-namespace:NumericBox;assembly=NumericBox     5   	     � AllowsTransparency  . 
������  � Title$ 
Simulation��5   	   $	��150��6   $	��503��6)    � WindowStyle$
 None=�65    � 
ResizeMode$ NoResize=�6H    � WindowStartupLocation$ CenterOwner=�6^   .��5	      � -   5        .+�5
   
   �� $��0��6      SemiTransparentBorder#��[  6   � 5   
   $��15q�6    � RowDefinitions 5      �� 5      $��60 �6    �� 5      �� 5      $��30 �6    .+�5      �� $��3��6     ShadowedBorder#��[ 6&   �� 5        HeaderBorder#��[ 6   ._�5      :   4PNCreator.Modules.Simulation.SimulationPlayerToolbar     StartSimulation StartSimulation65      StopSimulation StopSimulation6W   5      �� 5      $��1��6     ViewportBorder#��[ 6"   ._�5      � -   5         �Name$ simulationProgressBar��5      	 � Minimum$	 0Q�6=   5      �� 5      $	��Top=�6   $��2��6-   $��30��6:     FooterBorder#��[ 6F   ._�5      �� 
 �� Orientation$
 
Horizontal=�6   $��Right=�66   .+�5      � -   5         �Name$ sectorOptionPanel��5       � AllowsTransparency . $��
MousePoint=�6Q   ��5      �� *	IsChecked+ �� ElementName$ 
endTimeBtn��.��5       ��   LightContentBorder#��[ 6!   $��1��6M   $��0��6]   $��Bottom=�5!      $
��Left=�68   $��5q�6S   ._�5"      �� $
 
Horizontal=�6)   $��5,2,5,2q�6B   .+�5#   "   �� $��End time��6,   $��2q�6<     NumericBox.NumericBox  5$   "   -   5          Name$ endTimeNumericBox��5$   8      Value$ 0Q�6S      Minimum$ 0Q�6]   $	��100��6i    � ToolTip 5%   &   �� 5&   *   $��End simulation time��64   5(   #   5)      5*      5+      d� 5-      -   5         d�Name$ 
endTimeBtn��5-   #   $��5,2,5,2q�67     OtherButtonStyle#��[ 6H    5.      _� 5/      $��Set animation speed��6&   .��51      �� $4��./Resources;component/Content/Images/pencil.png��6    52      �� 53      -   5         ��Name$ minimizeBtn��53      $��5,2,5,2q�62   $0��*shell:SystemCommands.MinimizeWindowCommand��6C    54      _� 55      $
��Hide��6&   .��57      �� $3��-/Resources;component/Content/Images/minus.png��6    58      59      5:      5;      5<      5=      