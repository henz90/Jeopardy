   M S B A M L   `   `   `  ����  JeopardyGame    JeopardyGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5        $��Jeopardy��5   	     � Title$  	Jeopardy!��5   	   $	��500��6   $	��800��6(   
����  � � WindowState$ 	Maximized=�6J    � Icon$ /Resources/icon.png��6b    � WindowStartupLocation$ CenterScreen=�6}   .��5
      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��	_New Game��5      6.   m� 5      -   5        $��Double Jeopardy��5      64   m� 5      -   5        $��_Final Jeopardy��5      64   �� 5      m� 5      -   5        $��btnMusic��5   2   $��🔇_Stop Music��6   6B   m� 5      -   5        $��_Exit��5      6*   5      5      � 5   
   $	��Top=�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5       $��* �6    �� 5!      $��* �6    �� 5"      $��* �6    �� 5#      $��* �6    �� 5$      $��* �6    �� 5%      $��* �6    .+�5(      �� -   5        $
��clue��5(   �   $��6��6   $��6��6&    K� ZIndex$ 1��6:   $��10q�6K   
��� ���
����  �$��Korinna)�6�   
���   �$	��2.5q�6�   $y�	Collapsed=�6�   $
��Bold"�6�   ��5)      �� 5*       �� 
TargetType" ��6   .�5+      ��  �� Property � ��	 �� Value
	 ��  �67   �� 5,       � ��	 5-      �� 5.   "   
 �� 
TargetType"
 ��62   .R�5/   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�50   *   �� $��Center=�6;   $��Center=�6X   51   '   52   #   54       �� Triggers 55      P� 56       P� Property �@J�IsMouseOver P� Value . . �57   "   ��  � ��
	 ��  �6?   58      5:      ��5<      �� 5=      -   5        $��tbClue��5=       $
��Wrap=�6.   $��Center=�6B   $	��100(�6]   $��Center=�6l    �� TextAlignment$ Center=�6�   5?      �� 5B      $��0��6   $��0��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5C      �� 5D      " ��6   .�5E      ��  � ��
	 ��  �67   �� 5F       � ��	 5G      �� 5H   "   "
 ��62   .R�5I   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5J   *   �� $��Center=�6;   $��Center=�6X   5K   '   5L   #   5N       5O      P� 5P       �@J�IsMouseOver . . �5Q   "   ��  � ��
	 ��  �6?   5R      5T      ��5V      (� 5W      .��5X      �� -	   5        $��tbCat1��5X   �    �� Padding$ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5Y      5[      �� 5\      $��0��6   $��1��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5]      �� 5^      " ��6   .�5_      ��  � ��
	 ��  �67   �� 5`       � ��	 5a      �� 5b   "   "
 ��62   .R�5c   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5d   *   �� $��Center=�6;   $��Center=�6X   5e   '   5f   #   5h       5i      P� 5j       �@J�IsMouseOver . . �5k   "   ��  � ��
	 ��  �6?   5l      5n      ��5p      (� 5q      .��5r      �� -
   5        $��tbCat2��5r   �   $ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5s      5u      �� 5v      $��0��6   $��2��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5w      �� 5x      " ��6   .�5y      ��  � ��
	 ��  �67   �� 5z       � ��	 5{      �� 5|   "   "
 ��62   .R�5}   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5~   *   �� $��Center=�6;   $��Center=�6X   5   '   5�   #   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   ��  � ��
	 ��  �6?   5�      5�      ��5�      (� 5�      .��5�      �� -   5        $��tbCat3��5�   �   $ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5�      5�      �� 5�      $��0��6   $��3��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5�      �� 5�      " ��6   .�5�      ��  � ��
	 ��  �67   �� 5�       � ��	 5�      �� 5�   "   "
 ��62   .R�5�   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '   5�   #   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   ��  � ��
	 ��  �6?   5�      5�      ��5�      (� 5�      .��5�      �� -   5        $��tbCat4��5�   �   $ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5�      5�      �� 5�      $��0��6   $��4��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5�      �� 5�      " ��6   .�5�      ��  � ��
	 ��  �67   �� 5�       � ��	 5�      �� 5�   "   "
 ��62   .R�5�   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '   5�   #   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   ��  � ��
	 ��  �6?   5�      5�      ��5�      (� 5�      .��5�      �� -   5        $��tbCat5��5�   �   $ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5�      5�      �� 5�      $��0��6   $��5��6"   $��10q�62   $��Korinna)�6?   $
��Bold"�6T   ��5�      �� 5�      " ��6   .�5�      ��  � ��
	 ��  �67   �� 5�       � ��	 5�      �� 5�   "   "
 ��62   .R�5�   &   �� #��z��6-   
���   �$	��2.5q�6k   ._�5�   *   �� $��Center=�6;   $��Center=�6X   5�   '   5�   #   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   ��  � ��
	 ��  �6?   5�      5�      ��5�      (� 5�      .��5�      �� -   5        $��tbCat6��5�   �   $ 10q�6$   $��10q�61   
�������$��Center=�6P   $��Center=�6m   $��Korinna)�6�   $
��Bold"�6�   $
��Wrap=�6�   $ Center=�6�   5�      5�      �� 5�      -   5        $��btnCat1Clue1��5�   �   $��1��6   $��0��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�      (� 5�      .��5�      �� -   5        $��tbCat1Clue1��5�   $   $2006=   5�      5�      �� 5�      -   5        $��btnCat1Clue2��5�   �   $��2��6   $��0��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�      (� 5�      .��5�      �� -   5        $��tbCat1Clue2��5�   $   $4006=   5�      5�      �� 5�      -   5        $��btnCat1Clue3��5�   �   $��3��6   $��0��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�      (� 5�      .��5�      �� -   5        $��tbCat1Clue3��5�   $   $6006=   5�      5�      �� 5�      -   5        $��btnCat1Clue4��5�   �   $��4��6   $��0��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�      (� 5�      .��5�      �� -   5        $��tbCat1Clue4��5�   $   $8006=   5�      5�      �� 5�      -   5        $��btnCat1Clue5��5�   �   $��5��6   $��0��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�      (� 5�      .��5�      �� -   5        $��tbCat1Clue5��5�   $   $10006>   5      5     �� 5     -   5        $��btnCat2Clue1��5  �   $��1��6   $��1��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5     (� 5     .��5     �� -   5        $��tbCat2Clue1��5  $   $2006=   5	     5     �� 5     -   5        $��btnCat2Clue2��5  �   $��2��6   $��1��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5     (� 5     .��5     �� -   5        $��tbCat2Clue2��5  $   $4006=   5     5     �� 5     -   5        $��btnCat2Clue3��5  �   $��3��6   $��1��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5     (� 5     .��5     �� -   5        $��tbCat2Clue3��5  $   $6006=   5     5     �� 5     -   5        $��btnCat2Clue4��5  �   $��4��6   $��1��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5     (� 5     .��5     �� -    5        $��tbCat2Clue4��5  $   $8006=   5     5      �� 5!     -!   5        $��btnCat2Clue5��5!  �   $��5��6   $��1��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5"     (� 5#     .��5$     �� -"   5        $��tbCat2Clue5��5$  $   $10006>   5%     5'     �� 5*     -#   5        $��btnCat3Clue1��5*  �   $��1��6   $��2��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5+     (� 5,     .��5-     �� -$   5        $��tbCat3Clue1��5-  $   $2006=   5.     50     �� 51     -%   5        $��btnCat3Clue2��51  �   $��2��6   $��2��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��52     (� 53     .��54     �� -&   5        $��tbCat3Clue2��54  $   $4006=   55     57     �� 58     -'   5        $��btnCat3Clue3��58  �   $��3��6   $��2��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��59     (� 5:     .��5;     �� -(   5        $��tbCat3Clue3��5;  $   $6006=   5<     5>     �� 5?     -)   5        $��btnCat3Clue4��5?  �   $��4��6   $��2��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5@     (� 5A     .��5B     �� -*   5        $��tbCat3Clue4��5B  $   $8006=   5C     5E     �� 5F     -+   5        $��btnCat3Clue5��5F  �   $��5��6   $��2��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5G     (� 5H     .��5I     �� -,   5        $��tbCat3Clue5��5I  $   $10006>   5J     5L     �� 5O     --   5        $��btnCat4Clue1��5O  �   $��1��6   $��3��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5P     (� 5Q     .��5R     �� -.   5        $��tbCat4Clue1��5R  $   $2006=   5S     5U     �� 5V     -/   5        $��btnCat4Clue2��5V  �   $��2��6   $��3��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5W     (� 5X     .��5Y     �� -0   5        $��tbCat4Clue2��5Y  $   $4006=   5Z     5\     �� 5]     -1   5        $��btnCat4Clue3��5]  �   $��3��6   $��3��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5^     (� 5_     .��5`     �� -2   5        $��tbCat4Clue3��5`  $   $6006=   5a     5c     �� 5d     -3   5        $��btnCat4Clue4��5d  �   $��4��6   $��3��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5e     (� 5f     .��5g     �� -4   5        $��tbCat4Clue4��5g  $   $8006=   5h     5j     �� 5k     -5   5        $��btnCat4Clue5��5k  �   $��5��6   $��3��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5l     (� 5m     .��5n     �� -6   5        $��tbCat4Clue5��5n  $   $10006>   5o     5q     �� 5t     -7   5        $��btnCat5Clue1��5t  �   $��1��6   $��4��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5u     (� 5v     .��5w     �� -8   5        $��tbCat5Clue1��5w  $   $2006=   5x     5z     �� 5{     -9   5        $��btnCat5Clue2��5{  �   $��2��6   $��4��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5|     (� 5}     .��5~     �� -:   5        $��tbCat5Clue2��5~  $   $4006=   5     5�     �� 5�     -;   5        $��btnCat5Clue3��5�  �   $��3��6   $��4��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -<   5        $��tbCat5Clue3��5�  $   $6006=   5�     5�     �� 5�     -=   5        $��btnCat5Clue4��5�  �   $��4��6   $��4��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� ->   5        $��tbCat5Clue4��5�  $   $8006=   5�     5�     �� 5�     -?   5        $��btnCat5Clue5��5�  �   $��5��6   $��4��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -@   5        $��tbCat5Clue5��5�  $   $10006>   5�     5�     �� 5�     -A   5        $��btnCat6Clue1��5�  �   $��1��6   $��5��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -B   5        $��tbCat6Clue1��5�  $   $2006=   5�     5�     �� 5�     -C   5        $��btnCat6Clue2��5�  �   $��2��6   $��5��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -D   5        $��tbCat6Clue2��5�  $   $4006=   5�     5�     �� 5�     -E   5        $��btnCat6Clue3��5�  �   $��3��6   $��5��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -F   5        $��tbCat6Clue3��5�  $   $6006=   5�     5�     �� 5�     -G   5        $��btnCat6Clue4��5�  �   $��4��6   $��5��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -H   5        $��tbCat6Clue4��5�  $   $8006=   5�     5�     �� 5�     -I   5        $��btnCat6Clue5��5�  �   $��5��6   $��5��6"   $��10q�62   
��� ���
����  �$��Korinna)�6l   
���   �$	��2.5q�6�   $
��Bold"�6�   ��5�     (� 5�     .��5�     �� -J   5        $��tbCat6Clue5��5�  $   $10006>   5�     5�     5�     5�     5�     