   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.ViewMemo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   ��    MaterialDesignBody1TextBlock#��[ 5   	   $��24(�5   	   $��10,32,10,475q�5   	    �� TextAlignment$ Center=�6   $��Center=�66   $	��624��6S   $��64��6_   31Select a test you've taken below to view its memo5      �� 5!   
   -   5         ��Name$ allTests��5!   !   $��18(�6   $��176,88,176,0q�63    �� SelectedIndex$ 0��6I   $	��Top=�6[   $��37��6s   �� 5"   
   -   5        	 ��Name$	 btnViewMemo��5"      $
��View��6&   $��24(�5#      $��221,486,221,0q�6   $	��Top=�62   $��65��6J   &   System.Windows.Controls.DataGrid  5$   
   -   5        
  Name$
 dgMemo��5$   %      
IsReadOnly . $
��Left=�65   $	��322��6P   $��
10,148,0,0q�6]   $	��Top=�6q   $	��624��6�   5&      5'      