   M S B A M L   `   `   `  ����e  aTelerik.Windows.Controls, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7eHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.ControlsTelerik.Windows.Controls  5   	   {Sclr-namespace:Telerik.Windows.Controls.Primitives;assembly=Telerik.Windows.Controls#Telerik.Windows.Controls.Primitives  5   	   k gTelerik.Windows.Controls.Input, Version=2012.2.607.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7kNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.InputTelerik.Windows.Controls 5   	   yRclr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls"Telerik.Windows.Controls.Animation  5   	   uPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls Telerik.Windows.Controls.Chromes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ControlOuterBorder_Pressed  �� EndPoint �� 
StartPoint � Color � Offset  ControlBackground_Pressed  ControlInnerBorder_Pressed  ControlElement_Normal �� Color  ColorPicker_TitleBackground  ColorPicker_TitleBorder  ColorPicker_Background  ColorPicker_OuterBorder  ColorPicker_InnerBorder 	 ColorPicker_Foreground *
 &ColorPicker_ButtonBackground_MouseOver + 'ColorPicker_ButtonInnerBorder_MouseOver & "ColorPicker_ButtonBorder_MouseOver 2 .ColorPicker_ButtonOuterBorder_LeftCornerRadius 3 /ColorPicker_ButtonOuterBorder_RightCornerRadius  ColorPaletteViewItem_Border . *ColorPaletteViewItem_OuterBorder_MouseOver . *ColorPaletteViewItem_InnerBorder_MouseOver - )ColorPaletteViewItem_OuterBorder_Selected - )ColorPaletteViewItem_InnerBorder_Selected 4 0ColorPicker_HeaderButtonOuterBorder_CornerRadius 4 0ColorPicker_HeaderButtonInnerBorder_CornerRadius & "ColorPicker_HeaderButtonBackground " ColorPicker_HeaderButtonBorder 1 -ColorPicker_HeaderButtonOuterBorder_MouseOver 1 -ColorPicker_HeaderButtonInnerBorder_MouseOver 5 1ColorPicker_HeaderButtonInnerBackground_MouseOver , (ColorPicker_HeaderButtonOuterColorStroke % !ColorPicker_HeaderButtonColorFill , (ColorPicker_HeaderButtonInnerColorStroke  ToggleButtonIconStyle �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� CornerRadius F�Name �� Stretch �� Triggers P� Property P� Value �� 
TargetName6   0Telerik.Windows.Controls.RadColorPaletteViewItem �Name J� SnapsToDevicePixels ��Name ]� 
Conditions �� Property �� Value N� EnterActions �� TargetProperty �� 
TargetName R� KeyTime R� Value  System.Windows.Visibility N� ExitActions2  ,Telerik.Windows.Controls.RadColorPaletteView ��Name8   2Telerik.Windows.Controls.Primitives.RadUniformGrid  Name   ChildrenFlow    Columns/  )Telerik.Windows.Controls.RadColorSelector! � RowDefinitions" ��Name#   NoColorText$ ��Name%   MainPaletteHeaderText&  Name'   MainPaletteItemsStyle (   StandardPaletteHeaderText-  'Telerik.Windows.Controls.RadColorPicker) � ColumnDefinitions* J� Opacity+ d�Name,   ExpanderButtonStyle- � Cursor. d� 	IsChecked/ �� Path0 �� Mode1 �� RelativeSource2 �Name3 � AllowsTransparency4 � 	StaysOpen5  Name6   MainPaletteItemsStyle7   MainPaletteColumnsCount8   MainPaletteColumnsCount9   MainPaletteOrientation:   MainPaletteOrientation;   MainPaletteHeaderText<   MainPalette=   MainPalette>   HeaderPalette?   HeaderPalette@   HeaderPaletteVisibilityA   HeaderPaletteVisibilityB   StandardPaletteC   StandardPalette D   StandardPaletteVisibility E   StandardPaletteVisibility F   StandardPaletteHeaderTextG   NoColorTextH   NoColorVisibilityI   NoColorVisibilityJ   SelectedColorK   SelectedColorL P� 
SourceName�� 5   	   D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   TtelerikHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls  5   	   b
primitivesSclr-namespace:Telerik.Windows.Controls.Primitives;assembly=Telerik.Windows.Controls  5   	   _telerikInputNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Input  5   	   `	animationRclr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls  5   	   ctelerikChromesPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls  5   	   %�'  &	        &	 �     &	 �    &	 "    &	 E    &	 h    &	 �    &	 �    &	 �    &		 �    &	
     &	     &	 <    &	 _    &	 ~    &	 �    &	 �    &	 �    &	     &	 )    &	 �    &	 �    &	 �    &	     &	 4    &	 W    &	 z    &	 �    &	 �    &	 �    &	 �    7  7   7  7  7  '   �
    7  7  7  7  7  7  7  '  �    7  7  '  �    7  7  7 	 7  7  7  7  7  '      7 
 7  7  7  7  7  7 	 �� 5
      $  0.5,1&�6=   $ 0.5,0&�6N   .��5   
   � $ 	#FF282828��6   � 5   
   $ 	#FF5F5F5F��6   $ 1Q�6)   5      �� 5      $  0.5,1&�6<   $ 0.5,0&�6M   .��5   
   � $ 	#FFFFDCAB��6   $ 0Q�6)   � 5   
   $ 	#FFFFD18F��6   $	 0.5Q�6)   � 5   
   $ 	#FFFE9227��6   $	 0.5Q�6)   � 5   
   $ 	#FFFFBA74��6   $ 0Q�6)   5      �� 5      $  0.5,1&�6=   $ 0.5,0&�6N   .��5   
   � $ 	#FFB69A78��6   � 5   
   $ 	#FFFFE17A��6   $ 0.126Q�6)   5      �� 5      $ 	#FF000000��64   �� 5      $ 	#FFDEDEDE��6:   �� 5      $ 	#FF848484��66   �� 5      $ 	#FFFFFFFF��65   �� 5      $ 	#FF848484��66   �� 5      $ 	#FFF5F5F5��66   �� 5       $ 	#FF000000��65   �� 5!      $  0.5,1&�6I   $ 0.5,0&�6Z   .��5"   
   � $ 	#FFFFFBA3��6   $ 1Q�6)   � 5#   
   $ 	#FFFFFBDA��6   $ 0Q�6)   � 5$   
   $ 	#FFFFD25A��6   $
 0.43Q�6)   � 5%   
   $ 	#FFFEEBAE��6   $
 0.42Q�6)   5&      �� 5'      $ 	#FFFFFFFF��6F   �� 5(      $ 	#FFFFC92B��6A   ��5)      1,0,0,1��6S   ��5*      0,1,1,0��6T   �� 5,      $ 	#FFC9C9CB��6:   �� 5-      $ 	#FFFFC92B��6I   �� 5.      $ 	#FFFFFFFF��6I   �� 5/      $ 	#FF5D5D5D��6H   �� 50      $  0.5,1&�6L   $ 0.5,0&�6]   .��51   
   � $ 	#FFB69A78��6   � 52   
   $ 	#FFFFE17A��6   $ 0.126Q�6)   53      ��55      1��6O   ��56      0��6O   �� 57      $ 	#FFDEDEDE��6A   �� 58      $ 	#FF848484��6=   �� 59      $ 	#FFFFC92B��6L   �� 5:      $ 	#FFFFFFFF��6L   �� 5;      $  0.5,1&�6T   $ 0.5,0&�5<      .��5=   
   � $ 	#FFFFFBA3��6   $ 1Q�6)   � 5>   
   $ 	#FFFFFBDA��6   $ 0Q�6)   � 5?   
   $ 	#FFFFD25A��6   $
 0.43Q�6)   � 5@   
   $ 	#FFFEEBAE��6   $
 0.42Q�6)   5A      �� 5B      $ 	#FFFFC92B��6G   �� 5C      $ 	#FF000000��6@   �� 5D      $ 	#FFBFBFBF��6G   �� 5I      " d�6*   .�5J   
   ��  � �� 5K      �� 5L      " d�6"   .R�5M      � $��25��6   $��11��6'   .+�5P      �� $	 BackgroundChecked��6!   $��1q�6<   $��25��6P   $��11��5Q   !   $y�	Collapsed=�6,   8
   8�� 8�� ._�5U      �� $��1q�6%   8�� 5V   %   5W      F� 5Y      $ Arrow��6   8�� $
 Fill=�5Z   !   |����        �@KL     �@KL @B � 	= @B � 	= �� ���- �� ���- ��- р� ��- р� �� �@B �� �@B @B �    @B �        	$��5��5\   !   $��3��6+   5^       5_      P� 5a       �@d�	IsChecked$
 TrueY�67   . �5b      �� $ BackgroundChecked��6;    � y�$ Visible=�5c   %   5d      5f      5h      5i      �� 5l      "   6   .�5m   
   ��  � �� 5n      �� 5o      "   6"   .R�5p      � $ RootElement��6    . .+�5q      �� $ color��6$   $��11��63   $��11��6B   $
 Fill=�6P   $	��2 0q�5r   !   #��z��6.   �� 5s      $	 borderContent��5u   .   $��13��5s   !   $��13��60   8��  $	��2 0q�5u   !   $��Stretch=�6E   $��1q�5v   !   ._�5w      �� $	 InnerborderContent��69   $��1q�6%   69   5x      �� 5z      $	 border��5|   .   $��13��5z   !   $��13��60   8�� $	��2 0q�5|   !   $��Stretch=�6>   $��1q�5}   !   $y�	Collapsed=�65   ._�5~      �� $	 Innerborder��69   $��1q�6%   8�� 5   %   5�      5�       5�      ]� 5�       5�      �� 5�   "    �@��
IsSelected .  6B   �� 5�   "    �@J�IsMouseOver . 6C   ./�5�      �� $ border��6;    � y�$ Visible=�6O   �� 5�      $ border��6<   8   � ��5�   %   �� 5�      $ Innerborder��6<   8   � ��5�   %   5�      P� 5�       �@��
IsSelected .  5�      �� 5�   "   .��5�   &   �� .��5�   *   T� $ 
Visibility�5�   1   $ border��5�   1   ..�5�   .   i� $ 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #    5�      �� 5�   "   .��5�   &   �� .��5�   *   T� $ 
Visibility�5�   1   $ border��5�   1   ..�5�   .   i� $ 0��6E    5�   2    5�   6   	Collapsed=�6L   5�   /   5�   +   5�   '   5�   #   . �5�      �� $ border��6<   8   � ��5�   %   �� 5�      $ Innerborder��6<   8   � ��5�   %   5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ border��6;    � y� 5�   "    5�   &   Visible=�6:   5�      5�      P� 5�       �@J�IsMouseOver .  . �5�      �� $ border��6;    � y� 5�   "    5�   &   	Collapsed=�6<   5�      5�      5�      5�      �� 5�   
    � ��$ Color��6$   �� 5�   
    �@  Color$ Green��6"   5�      �� 5�      "  6   .�5�   
   ��  � ��8   6'   �� 5�   
    � ��8  6(   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   #��z��5�      #��z��5�      ._�5�      �� $ ItemsPresenter��6)   $��0,2,0,2q�6A   5�      5�      5�      �� 5�   
    � �� 5�      �� 5�      .R�5�        $ uniformGrid��60   $��Stretch=�6E   $ Vertical=�5�      $��Stretch=�65   $  10��6Q   5�      5�      5�      �� 5�   
    � ��$ 0q�6#   5�      �� 5�      "  6   .�5�   
   ��  � ��8   6'   �� 5�   
    � ��8  6(   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � ��8  6'   �� 5�   
    � ��$
 Bold"�6'   �� 5�   
    � ��$ Normal$�6&   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   $
 2��6I   #��z��5�      ._�5�      �� 8�� $��1q�5�   !   $
 1��65   ._�5�      � $ RootElement��6#   $��0q�68   #��z��5�   %   ! 5�   "   �� 5�   &   $
��Auto �64   �� 5�   &   $
��Auto �64   �� 5�   &   $
��Auto �64   �� 5�   &   $��* �64   �� 5�   &   $
��Auto �64   �� 5�   &   $
��Auto �64   .+�5�   "   �� $" PaletteHeader��5�   )   #��z# 5�   )   $��0��5�   @   #��z��5�   )   �� 5  "   $��0 0 0 3q�6)   $��1��6:   8�� 8�� $��0 0 0 1q�5  )   ._�5  &   �� $$ mainPaletteHeader��6B   $��10,2,2,2q�60   #��z��5  -   #��z��5  -   #��z��5  -   #��z% 5	  -   5
  #     5  "   $& HeaderPalette��5  )   #��z��5  )   $��2��6S   $��0,0,0,-3q�5  )   $��Center=�6;   
������ $��0q�5  )   ��5  &   �� 5  *   .R�5  .     
������ $  10��5  5   5  /   5  +   5  #     5  "   $& MainPalette��5  )   $��3��5  C   $��0 5 0 2q�6P   #��z' 5  )   
������ $��0q�5  C   #��z��5  )   �� 5  "   $	 StandardPaletteBorder��6:   $��0 2 0 3q�6)   $��4��6Y   8�� 8�� $��0 0 0 1q�5   )   ._�5!  &   �� $$ standardPaletteHeader��6B   $��10,2,2,2q�60   #��z��5"  -   #��z��5#  -   #��z( 5$  -   5%  #     5&  "   $& StandartPalette��6C   $��0 0 0 1q�5'  )   $��Center=�6:   $��5��6U   
������ $��0q�5(  C   #��z��5)  )   ��5*  &   �� 5+  *   .R�5,  .     
������ $  10��5-  5   5.  /   5/  +   51  #   52     53     54     55     57     58     �� 5:     "  6   �5;  
   �� 5<      � �� 5=     �� 5>     "  6&   .R�5?     � $
 Root��6   #��z��5@  !   #��z��5A  !   .+�5B     � $ 	Placement��6#   $��34��66   ) 5C  "   �� 5D  &   $��23 �67   �� 5E  &   $
��Auto �67   .+�5H  "   �� $	 	Over_back��6)   $* 0Q�6<   $��25��6H   $
 1��6T   8��  8�� $��1q�5K  )   $��34��6=   $��2��6H   ._�5L  &   �� $
 0��6-   $��1q�6>   8�� 5M  -   5N  #   �� 5P  "   $" 
LeftButton��6)   $��Center=�5R  )   d� 5T  "   $+ ToggleButtonElement��6?   $��1��6/   #��z, 5V  %   $
- Hand��6S   . 5U  %   �� $/ IsDropDownOpen�$0 TwoWay=�1 �� *TemplatedParent+5V  S   5W     � 5Y     $2 
PART_Popup��6$   3 . 4 .  #��� .�5\  !   ��5[  !   �� $/ IsDropDownOpen�1 �� *TemplatedParent+.��5]  "   � .+�5^  &   �� $	 DropDownBorder��6-   ._�5_  *     $5 ColorSelector��6H   #' z6 5`  1   #8 z7 5a  1   #: z9 5b  1   #% z; 5c  1   #= z< 5d  1   #? z> 5e  1   #A z@ 5f  1   #C zB 5g  1   #E zD 5h  1   #( zF 5i  1   ## zG 5j  1   #��z��5k  1   #��z��5l  1   #I zH 5m  1   #K zJ 5n  1   #��z��5o  1   #��z��5p  1   #��z��5q  1   #��z��5r  1   5t  '   5u  #   5v     5x      5y     P� 5z      �@J�IsMouseOver . . �5{  "   �� $ 	Over_back��6<    �@J�Opacity$ 1Q�6S   5|     P� 5}     $L ToggleButtonElement��5~  %    �@d�	IsChecked$
 TrueY�5}  ;   . �5  "   �� $ 	Over_back��6<    �@J�Opacity$ 1Q�6S   5�     P� 5�      �@J�	IsFocused . 6;   5�     5�     �� 5�      �@ MainPaletteColumnsCount$ 10��68   �� 5�      �@ MainPaletteOrientation$ Vertical=�67   �� 5�      �@ MainPalette$ Office=�6,   �� 5�      �@ HeaderPaletteVisibility$ Visible=�68   �� 5�     ! �@ StandardPaletteVisibility$ Visible=�6:   �� 5�      �@ NoColorVisibility$ Visible=�62   �� 5�      �@ SelectedColor$ Black��6.   �� 5�      �@ StandardPalette$ Standard=�60   �� 5�      �@ HeaderPalette$ Office=�6.   �� 5�      �@ ExpanderButtonStyle8  64   �� 5�      � ��$
 Left=�64   �� 5�      � ��$	 Top=�62   �� 5�      � ��8  6+   �� 5�      � ��8  6,   �� 5�      � ��$ 1q�60   �� 5�      � ��$ Normal$�6*   �� 5�      � ��$
 Bold"�6+   �� 5�      � ��8  6+   5�     5�     