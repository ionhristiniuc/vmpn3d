   M S B A M L   `   `   `  ����b  ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35bFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.ShellMicrosoft.Windows.Shell  5       	PNCreator:   4PNCreator.Modules.Simulation.SimulationPlayerToolbar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      XshellFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.Shell     5      -   5        
������   �� Orientation$  
Horizontal=�5      $��Center=�6&   .+�5      �� -   5         ��Name$ playBtn��5      $��5,0,0,0q�6      DefaultButtonStyle#��[  5      {�5   /   �� *	IsChecked+ �� ElementName$ 
endTimeBtn�� � ToolTip 5	   
   _� 5
      $
��Play��6   .��5   
   �� $2��,/Resources;component/Content/Images/play.png��6   5      �� 5      -   5        $ stopBtn��5      $��5,0,0,0q�6   #��[  6/    5   
   _� 5      $
��Stop��6   .��5   
   �� $2��,/Resources;component/Content/Images/stop.png��6   5      �� 5      -   5        $ closeBtn��5      $��5,0,0,0q�6   #��[  60   $-��'shell:SystemCommands.CloseWindowCommand��5       5   
   _� 5      $
��Exit��6   .��5   
   �� $3��-/Resources;component/Content/Images/close.png��6   5      5      