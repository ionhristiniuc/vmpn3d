   M S B A M L   `   `   `  ����D  @PNCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PNCreator.Modules.ODLEditorPNCreator.Modules.ODLEditor  5   	   7 clr-namespace:PNCreator.ControlsPNCreator.Controls  5   	   D @ODLEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullF1clr-namespace:ODLEditorControl;assembly=ODLEditorODLEditorControl 5   	   1    +PNCreator.Modules.ODLEditor.ODLEditorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;local)clr-namespace:PNCreator.Modules.ODLEditor     5   	   5controls clr-namespace:PNCreator.Controls     5   	   Deditor1clr-namespace:ODLEditorControl;assembly=ODLEditor     5   	   -   5          � Icon$4  ./Resources;component/Content/Images/pencil.png��5   J    � Title$ ODLEditorWindow��5   	   $	��600��6!   $	��900��6.   $��65��6:    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ 	CanResize=�6   
������  J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5        1   +PNCreator.Modules.ODLEditor.ODLEditorWindow   FormatCommand   Command# Z 5
      6R   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��30 �6   .+�5   
   �� $��3��6      ShadowedBorder#��[  6"   �� 5   
   -   5        $��0��5        HeaderBorder#��[ 6   ._�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        
 ��Name$
 	formatBtn��5      #��Z 6,     DefaultButtonStyle#��[ 6e    � ToolTip 5      _� 5      $��Format document��6"   .��5      �� $4��./Resources;component/Content/Images/pencil.png��6   5      �� 5      -   5        $
 cutBtn��5      #��[ 6)    5      _� 5      $��Cut selected text��6"   .��5       �� $1��+/Resources;component/Content/Images/cut.png��6   5!      �� 5"      -   5        $
 copyBtn��5"      #��[ 6*    5#      _� 5$      $��Copy selected text��6"   .��5&      �� $2��,/Resources;component/Content/Images/copy.png��6   5'      �� 5(      -   5        $
 pasteBtn��5(      #��[ 6+    5)      _� 5*      $��Paste��6"   .��5,      �� $3��-/Resources;component/Content/Images/paste.png��6   5-      �� 5.      -   5        $
 undoBtn��5.      #��[ 6*    5/      _� 50      $
��Undo��6"   .��52      �� $2��,/Resources;component/Content/Images/undo.png��6   53      �� 54      -	   5        $
 redoBtn��54      #��[ 6*    55      _� 56      $
��Redo��6"   .��58      �� $2��,/Resources;component/Content/Images/redo.png��6   59      �� 5:      -
   5        $
 	zoomInBtn��5:      #��[ 6I    5;      _� 5<      $��Close��6"   .��5>      �� $5��//Resources;component/Content/Images/zoom_in.png��6   5?      �� 5@      -   5        $
 
zoomOutBtn��5@      #��[ 6J    5A      _� 5B      $��Close��6"   .��5D      �� $6��0/Resources;component/Content/Images/zoom_out.png��6   5E      5G      5H      �� 5J   
   $��1��6     ViewportBorder#��[ 6   ._�5K      � $��10q�6   
������  J� IsHitTestVisible . .+�5S         ODLEditorControl.ODLEditor  -   5        $��
textEditor��5S   #   $��Consolas)�5T      $
��12pt(�5U      ` \ICSharpCode.AvalonEdit, Version=4.0.0.5950, Culture=neutral, PublicKeyToken=9cc39be672370310'  !ICSharpCode.AvalonEdit.TextEditor   SyntaxHighlightingM  GICSharpCode.AvalonEdit.Highlighting.HighlightingDefinitionTypeConverter$	 XML 5V         ShowLineNumbers .    Text. 5Y   $   z�5Z      �� 5[      -   5        
editorSize��5[   )   . 5\   8   5^      5`      5a      �� 5c   
   -   5         ��Name$ naBorder��5c      $��30��6#   $	��Top=�6/   $��2��6G     FooterBorder#��[ 6T   ._�5d      �� $	 
Horizontal=�6   $��0,5,0,0q�62   $��Right=�6C   .+�5e      �� -   5        $
 closeBtn��5e      $��2q�6+    5f      _� 5g      $��Cancel��6"   .��5i      �� $3��-/Resources;component/Content/Images/close.png��6   5j      5k      5l      5n      5o      