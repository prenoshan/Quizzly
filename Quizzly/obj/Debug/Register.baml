   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.Register   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Register��5   	   $	��600��6   $	��600��6'    � 
ResizeMode$ CanMinimize=�63   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   ��    MaterialDesignBody1TextBlock#��[ 5   	   $��24(�5   	   $��320,364,32,170q�5    	   Who are you?5"      �� 5$   
   -   5        	 ��Name$	 
tbUsername��5$      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Username��5%       % !MaterialDesignFloatingHintTextBox#��[ 5&      $��320,92,32,415q�6N   $��20(�6e   �� 5(   
   -   5        $	 tbFirstname��5(      $
 
First Name��5)      #��[ 5*      $��320,157,32,350q�6N   $��20(�6f   �� 5,   
   -   5        $	 	tbSurname��5,      $
 Surname��5-      #��[ 5.      $��320,221,32,286q�6N   $��20(�6f   G� 50   
   -   5         G�Name$ 
tbPassword��50      $
 Password��51       ) %MaterialDesignFloatingHintPasswordBox#��[ 52      $��20(�54      $��320,284,32,223q�6$   �� 56   
    �� TextAlignment$ Center=�57      #��[ 58   	   $��28(�59   	   $��297,26,10,493q�5:   	   Register an account5<      �� 5>   
   $��292,76,0,481q�6   �� 5@   
   -   5         ��Name$ userType��5A   	   #��[ 5B   	   $��20(�5C   	   $��320,403,184,132q�5D   	   	Student5F      d� 5H   
   -   5         d�Name$ RegType��5I       ) %MaterialDesignSwitchLightToggleButton#��[ 5J       d� 	IsChecked$ FalseY�5K      $��408,403,131,132q�6   66   �� 5M   
   $
��Left=�6   $	��571��60   $	��Top=�6=   $	��292��6U   ��5N      �� 5O       �� ImageSource$ firewatch.jpg��6    j� Stretch$ UniformToFill=�69   5Q      �� 5S   
   $
��Left=�6   $	��250��60   $	��Top=�6=   $	��292��6U   ��5T      �� 5U      $ logo.png��6   $
 None=�64   5W      )  #MaterialDesignThemes.Wpf.DialogHost  5Y   
   -   5        $��validateUsername��5Y   $     MaterialDesignDivider#���  6<      DialogContent 5[      �� 5]      $��16q�5^   	   .+�5`      �� #��[ 5a   	   $��20(�5b   	   $��Center=�5c   
   $��16q�5d      Username can't be empty5f      �� 5h        MaterialDesignFlatButton#��[ 5i       �� IsCancel .    CloseDialogCommand#��Z 5k      $��Center=�5l      .��6(   Ok5n      5p      5t        5v   
   -   5        $��checkUsername��5v   $   #���  69    5x      �� 5z      $��16q�5{   	   .+�5}      �� #��[ 5~   	   $��20(�5   	   $��Center=�5�   
   $��16q�5�      %#Username exists, Please try another5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -	   5        $��validatePassword��5�   $   #���  6<    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      Password can't be empty5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -
   5        $��
regSuccess��5�   $   #���  66    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      Registration successful5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -   5        $��regError��5�   $   #���  64    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      Registration error5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -   5        $��validateName��5�   $   #���  68    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      First Name can't be empty5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5     5       5  
   -   5        $��validateSurname��5  $   #���  6;    5	     �� 5     $��16q�5  	   .+�5     �� #��[ 5  	   $��20(�5  	   $��Center=�5  
   $��16q�5     Surname can't be empty5     �� 5     #��[ 5      . #��Z 5     $��Center=�5     .��6(   Ok5     5     5"     �� 5$  
   -   5         ��Name$ btnReg��5$     $��Register��6!   $��24(�5&     $
��Left=�5'     $��339,445,0,0q�6,   $	��Top=�6A   $	��202��6Y   $��65��6e   �� 5)  
   -   5        $ 	goToLogin��5-  	   $ Center=�5*     $��	underline{�5,     #��[ 5.  	   $��20(�5/  	   $��343,524,49,11q�50  	   Login to your account52     54     55     