   M S B A M L   `   `   `  ����  	PNCreator&     PNCreator.Modules.TempHelpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$
  Help��5   	    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6)   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . $	��419��6H   $	��442��6U   .��5      � .+�5   
   ��    SemiTransparentBorder#��[  6   � 5   
   $��15q�6    � RowDefinitions 5	      �� 5
      $��60 �6    �� 5      �� 5      $��30 �6    .+�5      �� $��3��6     ShadowedBorder#��[ 6&   �� 5      $��0��6     HeaderBorder#��[ 6"   5      �� 5      $��1��6     ViewportBorder#��[ 6"   ._�5      � .+�5      -� 
������ .��5      /� .T�5      J�  �� TextAlignment$
 Left=�6(   .*�6=   .*�5   "   �� Zoom In/Out -5   #    �� 5   "   $��50,0,0,0q�6,   $��Mouse wheel or +\- key��5   *   5    #   5!      J� 5#      $
 Left=�6(   .*�6=   .*�5$   "   �� Rotate camera -5&   #    �� 5'   "   $��50,0,0,0q�6,   $ ��Hold Right Button and move��5*   *   5+   #   5,      J� 5.      $
 Left=�6(   .*�6=   .*�5/   "   �� Switch to perspective view -51   #    �� 52   "   $��50,0,0,0q�6,   $��Ctrl+P��55   *   56   #   57      J� 59      $
 Left=�6(   .*�6=   .*�5:   "   �� Switch to edit view -5<   #    �� 5=   "   $��50,0,0,0q�6,   $��Ctrl+E��5@   *   5A   #   5B      J� 5D      $
 Left=�6(   .*�6=   .*�5E   "   �� Zoom to Object -5G   #    �� 5H   "   $��50,0,0,0q�6,   $��Z��5K   *   5L   #   5M      J� 5O      $
 Left=�6(   .*�6=   .*�5P   "   �� Find object -5R   #    �� 5S   "   $��50,0,0,0q�6,   $��Ctrl + F��5V   *   5W   #   5X      5Z      5[      5\      5]      �� 5_      -   5         ��Name$ naBorder��5_      $	��Top=�6'   $��2��6?     FooterBorder#��[ 6L   ._�5`      ��  �� Orientation$ 
Horizontal=�6   $��0,0,7,2q�66   $��Right=�6G   .+�5a      �� -   5        	 ��Name$	 	searchBtn��5a      $��2q�60   
 � ToolTip
 5b      _� 5c      $��Ok��6&   .��5e      �� $0��*/Resources;component/Content/Images/ok.png��6    5f      �� 5g      -   5        $	 closeBtn��5g      $��2q�6/   
 5h      _� 5i      $��Close��6&   .��5k      �� $3��-/Resources;component/Content/Images/close.png��6    5l      5m      5n      5o      5p      5r      