   M S B A M L   `   `   `  ����  WindowsControl    WindowsControl.Error   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Error��5   	    � WindowStyle$
 None=�6    � WindowState$ 	Maximized=�6*   
������  � AllowsTransparency .  � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $E ?pack://application:,,,/Resources;component/UIStyles/Border.xaml?�6%   �� 5	      $H Bpack://application:,,,/Resources;component/UIStyles/TextBlock.xaml?�6%   �� 5
      $E ?pack://application:,,,/Resources;component/UIStyles/Button.xaml?�6%   %    5      .��5      � -   5         � RowDefinitions 5   
   �� 5      �� 5      $	��300 �6   �� 5      .+�5   
   ��     BackgroundDialogWindowBorder#��[  6   $��3��6G   �� 5   
     ShadowedBorder#��[ 6   $	��580��69   $	��180��6E   $��5q�6R   $��1��6]   ._�5      � $��5q�6    5      �� 5      �� 5      $��35 �6$   .+�5      �� $��0��6   $��Center=�6*    �� Orientation$ 
Horizontal=�6E   .+�5      �� $I��Cpack://application:,,,/Resources;component/Content/Images/error.png��6   $��60��6i   $��60��6u   �� 5      -   5        	 ��Name$	 message��5       $��Message��61   $
��Wrap=�6@   $��Center=�6T     ColoredTextStyle#��[ 6o   5      �� 5!      -   5        
 ��Name$
 obBtn��5!      $��1��6(   $��65��65   $��0,5,0,0q�6@   $��Right=�6R   .��6�   OK5#      5$      5%      5'      5(      