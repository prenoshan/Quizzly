   M S B A M L   `   `   `  ���� B  >Quizzly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzlyQuizzly      Quizzly.TestArea   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  !localclr-namespace:Quizzly     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .��� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF2C3B50�� � Offset$ 1Q�� $ 	#FF232526��.+��� -    ��Name$
 qNum��   MaterialDesignBody1TextBlock#��[ $��24(�$��10,39,10,493q� �� TextAlignment$ Center=�$��Center=�$	��624��Question 1 of 1)  #MaterialDesignThemes.Wpf.DialogHost  -   $��validateAnswer��  MaterialDesignDivider#���     DialogContent �� $��16q�.+��� #��[ $��20(�$��Center=�$��16q�Please select an answer��   MaterialDesignFlatButton#��[ 	 �� IsCancel	 . 
   CloseDialogCommand#��Z
 $��Center=�.��Ok�� -   $ questionText��$
��Wrap=�#��[ $��24(�$��10,116,10,376q�$ Center=�$��Center=�$	��624��Question Text�� -   $ ansOne��$
��Wrap=�#��[ $��24(�$��10,193,10,320q�$ Center=�$��Center=�$	��624��
Answer One�� -   $ ansTwo��$
��Wrap=�#��[ $��24(�$��10,256,10,258q�$ Center=�$��Center=�$	��624��
Answer Two�� -   $ ansThree��$
��Wrap=�#��[ $��24(�$��10,326,10,195q�$ Center=�$��Center=�$	��624��Answer Three�� -   $ ansFour��$
��Wrap=�#��[ $��24(�$��10,394,10,119q�$ Center=�$��Center=�$	��624��Answer four	� -    	�Name$ selectAnswerOne��$
��Left=�  MaterialDesignRadioButton#��[ $��136,198,0,0q�$	��Top=�$��18(�	� -	   $ selectAnswerTwo��$
��Left=�#��[ $��136,263,0,0q�$	��Top=�$��18(�	� -
   $ selectAnswerThree��$
��Left=�#��[ $��136,330,0,0q�$	��Top=�$��18(�	� -   $ selectAnswerFour��$
��Left=�#��[ $��136,399,0,0q�$	��Top=�$��18(��� -    ��Name$ btnNextQuestion��$
��Next��$��24(�$
��Left=�$��211,475,0,0q�$	��Top=�$	��202��$��65��