   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.TestArea   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   �� -   5         ��Name$
 qNum��5         MaterialDesignBody1TextBlock#��[ 5   	   $��24(�5   	   $��10,39,10,493q�5   	    �� TextAlignment$ Center=�6   $��Center=�66   $	��624��6S   Question 1 of 15      )  #MaterialDesignThemes.Wpf.DialogHost  5!   
   -   5        $��validateAnswer��5!   $     MaterialDesignDivider#���  6:      DialogContent 5#      �� 5%      $��16q�5&   	   .+�5(      �� #��[ 5)   	   $��20(�5*   	   $��Center=�5+   
   $��16q�5,      Please select an answer5.      �� 50        MaterialDesignFlatButton#��[ 51      	 �� IsCancel	 . 
   CloseDialogCommand#��Z
 53      $��Center=�54      .��6(   Ok56      58      5<      �� 5>   
   -   5        $ questionText��5@      $
��Wrap=�5?      #��[ 5A   	   $��24(�5B   	   $��10,116,10,376q�5C   	   $ Center=�6    $��Center=�67   $	��624��6T   Question Text5E      �� 5G   
   -   5        $ ansOne��5G      $
��Wrap=�5H      #��[ 5I   	   $��24(�5J   	   $��10,193,10,320q�5K   	   $ Center=�6    $��Center=�67   $	��624��6T   
Answer One5M      �� 5O   
   -   5        $ ansTwo��5O      $
��Wrap=�5P      #��[ 5Q   	   $��24(�5R   	   $��10,256,10,258q�5S   	   $ Center=�6    $��Center=�67   $	��624��6T   
Answer Two5U      �� 5W   
   -   5        $ ansThree��5W      $
��Wrap=�5X      #��[ 5Y   	   $��24(�5Z   	   $��10,326,10,195q�5[   	   $ Center=�6    $��Center=�67   $	��624��6T   Answer Three5]      �� 5_   
   -   5        $ ansFour��5_      $
��Wrap=�5`      #��[ 5a   	   $��24(�5b   	   $��10,394,10,119q�5c   	   $ Center=�6    $��Center=�67   $	��624��6T   Answer four5e      	� 5g   
   -   5         	�Name$ selectAnswerOne��5g      $
��Left=�6/     MaterialDesignRadioButton#��[ 6J   $��136,198,0,0q�6}   $	��Top=�6�   $��18(�6�   	� 5h   
   -	   5        $ selectAnswerTwo��5h      $
��Left=�6/   #��[ 6J   $��136,263,0,0q�6}   $	��Top=�6�   $��18(�6�   	� 5i   
   -
   5        $ selectAnswerThree��5i      $
��Left=�61   #��[ 6L   $��136,330,0,0q�6   $	��Top=�6�   $��18(�6�   	� 5j   
   -   5        $ selectAnswerFour��5j      $
��Left=�60   #��[ 6K   $��136,399,0,0q�6~   $	��Top=�6�   $��18(�6�   �� 5k   
   -   5         ��Name$ btnNextQuestion��5k      $
��Next��6*   $��24(�5l      $
��Left=�5m      $��211,475,0,0q�6(   $	��Top=�6=   $	��202��6U   $��65��6a   5p      5q      