   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Login��5   	   $	��600��6   $	��600��6$    � 
ResizeMode$ CanMinimize=�60   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   �� 	 �� TextAlignment$	 Center=�5         MaterialDesignBody1TextBlock#��[ 5   	   $��28(�5    	   $��297,26,10,493q�5!   
   Login to your account5#      �� 5%   
   $��292,76,0,481q�6   �� 5'   
   -   5        
 ��Name$
 
tbUsername��5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5(       % !MaterialDesignFloatingHintTextBox#��[ 5)      $��320,102,32,405q�6N   $��20(�6f   G� 5+   
   -   5         G�Name$ 
tbPassword��5+      $ Password��5,       ) %MaterialDesignFloatingHintPasswordBox#��[ 5-      $��20(�5/      $��320,171,32,336q�6$   �� 51   
   #��[ 52   	   $��24(�53   	   $��320,269,32,265q�54   	   Who are you?56      �� 58   
   -   5         ��Name$ userType��59   	   #��[ 5:   	   $��20(�5;   	   $��320,322,184,213q�5<   	   	Student5>      d� 5@   
   -   5         d�Name$ 	LoginType��5A       ) %MaterialDesignSwitchLightToggleButton#��[ 5B       d� 	IsChecked$ FalseY�5C      $��408,322,131,213q�6   66   �� 5E   
   $
��Left=�6   $	��571��60   $	��Top=�6=   $	��292��6U   ��5F      �� 5G       �� ImageSource$ firewatch.jpg��6    j� Stretch$ UniformToFill=�69   5I      �� 5K   
   $
��Left=�6   $	��250��60   $	��Top=�6=   $	��292��6U   ��5L      �� 5M      $ logo.png��6   $
 None=�64   5O      )  #MaterialDesignThemes.Wpf.DialogHost  5Q   
   -   5        $��validateLogin��5Q   $     MaterialDesignDivider#���  69      DialogContent 5S      �� 5U      $��16q�5V   	   .+�5X      �� #��[ 5Y   	   $��20(�5Z   	   $��Center=�5[   
   $��16q�5\      Invalid Login5^      �� 5`        MaterialDesignFlatButton#��[ 5a       �� IsCancel .    CloseDialogCommand#��Z 5c      $��Center=�5d      .��6(   Ok5f      5h      5l        5n   
   -   5        $��validateUsername��5n   $   #���  6<    5p      �� 5r      $��16q�5s   	   .+�5u      �� #��[ 5v   	   $��20(�5w   	   $��Center=�5x   
   $��16q�5y      Username can't be empty5{      �� 5}      #��[ 5~       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�        5�   
   -   5        $��validatePassword��5�   $   #���  6<    5�      �� 5�      $��16q�5�   	   .+�5�      �� #��[ 5�   	   $��20(�5�   	   $��Center=�5�   
   $��16q�5�      Password can't be empty5�      �� 5�      #��[ 5�       . #��Z 5�      $��Center=�5�      .��6(   Ok5�      5�      5�      �� 5�   
   -   5         ��Name$ btnLogin��5�      $��Login��6#   $��24(�5�      $
��Left=�5�      $��339,388,0,0q�6,   $	��Top=�6A   $	��202��6Y   $��65��6e   �� 5�   
   -	   5        $ goToReg��5�   	   $	 Center=�5�      $��	underline{�5�      #��[ 5�   	   $��20(�5�   	   $��343,495,49,40q�5�   	   Register an account5�      5�      5�      