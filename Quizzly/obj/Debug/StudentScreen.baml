   M S B A M L   `   `   `  ����B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly  5   	       Quizzly.StudentScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:Quizzly  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Student Main Screen��5   	   $	��600��6%   $
��1000��62    � 
ResizeMode$ CanMinimize=�6?   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2C3B50��6    � Offset$ 1Q�61   � 5      $ 	#FF232526��6   5      .+�5   
   �� -   5        	 ��Name$	 	btnLogOut��5      $��Sign Out��6$   $��24(�5      $
��Auto��6   $��14,350,664,121q�6-   �� 5   
   -   5        $	 btnTakeTest��5      $��	Take Test��6&   $��24(�5      $
��Auto��6   $��14,7,664,464q�6-   � 5    
   -   5        
 �Name$
 mainArea��5       $��	350,0,0,0q�6!   .+�5!      �� -   5         ��Name$ userName��5"         MaterialDesignBody1TextBlock#��[ 5#      $��30(�5$       �� TextAlignment$ Center=�6   $��Center=�66   $��0,127,0,396q�6S   $	��644��6h   Welcome User6�   �� 5&      $
��Wrap=�5'      #��[ 5(      $��24(�5)      $ Center=�6   $��Center=�66   $��0,180,0,314q�6S   $	��644��6h   HFClick on a button on the left to take a test, view marks or view memos5+      5,      �� 5.   
   $
��Left=�6   $��16��6/   $��
50,278,0,0q�6;   $	��Top=�6O   $	��572��6g    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5/      V� 50      .~�51      �� �� 52      �� 53       �� Angle$ 90Q�6&   T� 54      55      57      �� 58   
   -   5        $	 btnViewMarks��58      $��
View Marks��6'   $��24(�59      $
��Auto��6   $��14,121,664,350q�6)   �� 5:   
   -   5        $	 btnViewMemos��5:      $��
View Memos��6'   $��24(�5;      $
��Auto��6   $��14,236,664,235q�6)   �� 5<   
   -   5        $	 
btnWebsite��5<      $��Go To Website��6%   $��24(�5=      $
��Auto��6   $��14,461,664,10q�6-   6D   5>      5?      