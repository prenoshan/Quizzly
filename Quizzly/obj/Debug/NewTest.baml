   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.NewTest   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   �� -   5         ��Name$
 qNum��5         MaterialDesignBody1TextBlock#��[ 5   	   $��24(�5   	   $��10,39,10,493q�5   	    �� TextAlignment$ Center=�6   $��Center=�66   $	��624��6S   Question 1 of 15       �� 5"   
   -   5         ��Name$ 
rbQuestion��5"   q   $��18(�6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Enter a question��6$   
 � ToolTip$
 Enter a question��6V   $
��Left=�6�   $��	10,75,0,0q�6�   $	��Top=�6�   $	��624��6�   $��86��6�    �� 
LineHeight$ 6��6�   . �5#      /� .T�5$      J� .*�6   5&      5'      5(      �� 5*   
   -   5         ��Name$ tbAnswerOne��5*      $	 Enter the first answer��5+      $��186,174,166,333q�6J   $��20(�6c   �� 5-   
   -   5        $ tbAnswerTwo��5-      $	 Enter the second answer��5.      $��186,238,166,269q�6K   $��20(�6d   �� 50   
   -   5        $ tbAnswerThree��50      $	 Enter the third answer��51      $��186,306,166,201q�6J   $��20(�6c   �� 53   
   -   5        $ tbAnswerFour��53      $	 Enter the fourth answer��54      $��186,375,166,132q�6K   $��20(�6d   	� 56   
   -   5         	�Name$ checkAnswerOne��56      $
��Left=�6.     MaterialDesignRadioButton#��[ 6I   $��136,198,0,0q�6|   $	��Top=�6�   $��18(�6�   	� 57   
   -   5        $ checkAnswerTwo��57      $
��Left=�6.   #��[ 6I   $��136,263,0,0q�6|   $	��Top=�6�   $��18(�6�   	� 58   
   -	   5        $ checkAnswerThree��58      $
��Left=�60   #��[ 6K   $��136,330,0,0q�6~   $	��Top=�6�   $��18(�6�   	� 59   
   -
   5        $ checkAnswerFour��59      $
��Left=�6/   #��[ 6J   $��136,399,0,0q�6}   $	��Top=�6�   $��18(�6�   �� 5;   
   -   5         ��Name$ btnSaveQuestion��5;      $
��Save��6*   $��24(�5<      $
��Left=�5=      $��211,475,0,0q�6(   $	��Top=�6=   $	��202��6U   $��65��6a   )  #MaterialDesignThemes.Wpf.DialogHost  5?   
   -   5        $��validateQuestion��5?   $     MaterialDesignDivider#���  6<      DialogContent 5A      �� 5C      $��16q�5D   	   .+�5F      �� #��[ 5G   	   $��20(�5H   	   $��Center=�5I   
   $��16q�5J      Question can't be empty5L      �� 5N        MaterialDesignFlatButton#��[ 5O       �� IsCancel .    CloseDialogCommand#��Z 5Q      $��Center=�5R      .��6(   Ok5T      5V      5Z        5\   
   -   5        $��validateAnswers��5\   $   #���  6;    5^      �� 5`      $��16q�5a   	   .+�5c      �� #��[ 5d   	   $��20(�5e   	   $��Center=�5f   
   $��16q�5g      +)You haven't filled out one of the answers5i      �� 5k      #��[ 5l       . #��Z 5n      $��Center=�5o      .��6(   Ok5q      5s      5w        5y   
   -   5        $��validateCorrect��5y   $   #���  6;    5{      �� 5}      $��16q�5~   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�       Please choose a correct answer5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�      5�      5�      