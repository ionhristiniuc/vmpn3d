   M S B A M L   `   `   `  ����  	PNCreator9    3PNCreator.Modules.ServerConnection.ServerProperties   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ServerProperties��5   	    � WindowStartupLocation$ CenterScreen=�6"   $	��365��6G   $	��251��6T    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   
������  � Icon$3 -/Resources;component/Content/Images/cloud.png��6K   .��5      � .+�5   
   ��    SemiTransparentBorder#��[  6   � 5	   
   -   5        $��15q�5	       � RowDefinitions 5
      �� 5      $��60 �6    �� 5      �� 5      $��30 �6    .+�5      �� $��3��6     ShadowedBorder#��[ 6&   �� 5      $��0��6     HeaderBorder#��[ 6"   5      �� 5      $��1��6     ViewportBorder#��[ 6"   ._�5      � 
������ .+�5      �� $��	10,7,10,0q�6    $	��Top=�63   Server properties6^   �� 5      $��0��6!    �� Orientation$ 
Horizontal=�6.   $
��Left=�6G   $��
10,30,0,10q�6b   .+�5      �� .+�5      �� -   5        $��label2��5   :   $��0,20,0,0q�6(   
Hostname6S   �� 5      -   5        $��label3��5   :   $��0,20,0,0q�6(   Login6P   �� 5      -   5        $��label4��5   :   $��0,20,0,0q�6(   
Password6S   �� 5      -   5         ��Name$ isUseServer��5   '   $��	10,20,0,0q�6<   	 d� 	IsChecked$	 FalseY�6O   5       �� 5"      .+�5#      �� -   5        $��hostTB��5#   :   $��
10,17,15,0q�6&   $��
hpc.usm.md��6H   $	��100��6Z   �� 5$      -   5        $��userTB��5$   :   $��
10,15,15,0q�6&   $
��User��6H   $	��100��6T   G� 5%      -   5        $��
passwordTB��5%   >   $��
10,14,15,0q�6*   
 G� Password$

 User��6P   $	��100��6`   �� 5&      $��0,17,0,0q�6(   Simulate on the claster6T   5'      5(      5)      5*      �� 5,      -	   5         ��Name$ naBorder��5,      $��30��6'   $	��Top=�63   $��2��6K     FooterBorder#��[ 6X   ._�5-      �� $��3��6   $ 
Horizontal=�6*   $��0,0,7,2q�6C   $��Right=�6T   .+�5.      �� -
   5         ��Name$ okBtn��5.      $��2q�6,    � ToolTip 5/      _� 50      $��Accept��6&   .��52      �� $0��*/Resources;component/Content/Images/ok.png��6    53      �� 54      -   5        $ 	cancelBtn��54      $��2q�60    55      _� 56      $��Cancel��6&   .��58      �� $3��-/Resources;component/Content/Images/close.png��6    59      5:      5;      5=      5>      5?      