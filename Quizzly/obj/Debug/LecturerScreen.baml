   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.LecturerScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Lecturer Main Screen��5   	   $	��600��6&   $
��1000��63    � 
ResizeMode$ CanMinimize=�6@   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   �� -   5        	 ��Name$	 	btnLogOut��5      $��Sign Out��6$   $��24(�5      $
��Auto��6   $��14,360,664,111q�6-   �� 5   
   -   5        $	 btnCreateTest��5      $��Create Test��6(   $��24(�5       $
��Auto��6   $��14,201,664,270q�6-   �� 5"   
   -   5        $	 
btnWebsite��5"      $��Go to website��6%   $��24(�5#      $
��Auto��6   $��14,41,664,430q�6-   6D   � 5%   
   -   5        
 �Name$
 mainArea��5%      $��	350,0,0,0q�6!   .+�5&      �� -   5         ��Name$ 
tbUsername��5&         MaterialDesignBody1TextBlock#��[ 5'      $��30(�5(       �� TextAlignment$ Center=�6   $��Center=�66   $��0,127,0,396q�6S   $	��644��6h   Welcome User6�   �� 5*      #��[ 5+      $��24(�5,      $ Center=�6   $��Center=�66   $��0,180,0,343q�6S   $	��644��6h   /-Click on a button on the left to create tests5.      5/      �� 51   
   $
��Left=�6   $��16��6/   $��
50,278,0,0q�6;   $	��Top=�6O   $	��572��6g    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�52      V� 53      .~�54      �� �� 55      �� 56       �� Angle$ 90Q�6&   T� 57      58      5:      5=      5>      