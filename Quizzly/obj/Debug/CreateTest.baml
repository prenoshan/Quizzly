   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.CreateTest   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5        $��
nameExists��5   $     MaterialDesignDivider#���  66      DialogContent 5      �� 5      $��16q�5   	   .+�5!      ��    MaterialDesignBody1TextBlock#��[ 5"   	   $��20(�5#   	   $��Center=�5$   
   $��16q�5%      64Name for the test already exists, Please try another5'      �� 5)        MaterialDesignFlatButton#��[ 5*       �� IsCancel .    CloseDialogCommand#��Z 5,      $��Center=�5-      .��6(   Ok5/      51      55        57   
   -   5        $��validateName��57   $   #���  68    59      �� 5;      $��16q�5<   	   .+�5>      �� #��[ 5?   	   $��20(�5@   	   $��Center=�5A   
   $��16q�5B      Test name can't be empty5D      �� 5F      #��[ 5G       . #��Z 5I      $��Center=�5J      .��6(   Ok5L      5N      5R        5T   
   -   5        $��validateQuestionNumber��5T   $   #���  6B    5V      �� 5X      $��16q�5Y   	   .+�5[      �� #��[ 5\   	   $��20(�5]   	   $��Center=�5^   
   $��16q�5_      $"Number of questions can't be empty5a      �� 5c      #��[ 5d       . #��Z 5f      $��Center=�5g      .��6(   Ok5i      5k      5o        5q   
   -   5        $��validateQnumber��5q   $   #���  6;    5s      �� 5u      $��16q�5v   	   .+�5x      �� #��[ 5y   	   $��20(�5z   	   $��Center=�5{   
   $��16q�5|      97Please enter a valid number for the number of questions5~      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -   5        $��testCreated��5�   <   	   
Identifier$	 
RootDialog��6$   #���  6O    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      Test created successfully5�      �� 5�      -   5        
 ��Name$
 btnCreateSuccess��5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�      �� 5�   
   #��[ 5�   	   $��24(�5�   	   $��10,32,10,499q�5�   	    �� TextAlignment$ Center=�6   $��Center=�66   $	��624��6S   $��64��6_   Enter the test name5�      �� 5�   
   #��[ 5�   	   $��24(�5�   	   $��10,170,10,329q�5�   	   $ Center=�6    $��Center=�67   $	��624��6T   $��64��6`   " Select the category for the test5�      �� 5�   
   #��[ 5�   	   $��24(�5�   	   $��-10,321,-10,194q�5�   	   $ Center=�6"   $��Center=�69   $	��664��6V   $��64��6b   ,*Enter the number of questions for the test5�      �� 5�   
   -   5         ��Name$ 
tbTestName��5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Test Name��5�       % !MaterialDesignFloatingHintTextBox#��[ 5�      $��185,75,167,432q�6N   $��20(�6f   �� 5�   
   -   5         ��Name$ testCategories��5�   !   $��18(�6   $��176,237,176,0q�69    �� SelectedIndex$ 0��6P   $	��Top=�6b   $��37��6z   �� 5�   
   -	   5        $ tbTestQs��5�      $ 	No. of Qs��5�      #��[ 5�      $��176,377,176,130q�6N   $��20(�6g   �� 5�   
   -
   5        $
 btnCreateTest��5�      $��Create��6(   $��24(�5�      $��221,474,221,0q�6   $	��Top=�62   $��65��6J   5�      5�      