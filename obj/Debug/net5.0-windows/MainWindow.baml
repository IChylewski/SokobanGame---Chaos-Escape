   M S B A M L   `   `   `  ����S  OSokoban Game - Assesment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Sokoban_Game_AssesmentSokoban_Game_Assesment  5   	   '    !Sokoban_Game_Assesment.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Sokoban_Game_Assesment     5   	     � Title$  Chaos Escape��5   	   $	��450��6   $	��800��6+   $��Center=�67   $��Center=�6[    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 MenuButtonStyle �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 0q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      ��5B      �� 5C   
    �� ImageSource$+ %/Assets/Background/MenuBackground.jpg��6   6K   .��5E      �  � RowDefinitions 5F   
   �� 5G      $	��180 �6   6+   �� 5H      6   .+�5J   
   �� $	��500��6   $��0��6   $��/Assets/Logo/Logo.png��6)   6J   � 5K   
   $��1��6    5L      �� 5M      6"   �� 5N      6"   �� 5O      6"   .+�5Q      �� -   5        $��StartGameBtn��5Q   /   #��� 
 6C   $
��Bold"�6m   $��22(�6   $��Arial Rounded MT Bold)�6�   $��0��6�   $��50��6�   $	��140��6�   
����������#ff4500$��
Start Game��6�   6  �� 5R      #��� 
 6   $
��Bold"�6?   $��22(�6Q   $��Arial Rounded MT Bold)�6_   $��1��6�   $��50��6�   $	��160��6�   
����������#ff4500$��Choose Level��6�   6�   �� 5S      #��� 
 6   $
��Bold"�6?   $��22(�6Q   $��Arial Rounded MT Bold)�6_   $��2��6�   $��50��6�   $	��140��6�   
����������#ff4500$��	Exit Game��6�   6�   5T      5U      5V      