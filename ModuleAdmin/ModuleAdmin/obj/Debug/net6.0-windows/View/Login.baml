   M S B A M L   `   `   `  ����F  BModuleAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ModuleAdmin.ViewModuleAdmin.View  5   	       ModuleAdmin.View.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   *localclr-namespace:ModuleAdmin.View  5   	     � Title$  Login��5	   	   $	��450��6   $	��800��6$    J� InputBindings 5
      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *LoginCommand+.��5      � $��Center=�6   $��Center=�6(   $	��190��6C   $	��450��6P    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6    5      �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5       �� $��0��6   $��0��6$   $%��Nom d'utilisateur (courriel) : ��61      MaterialDesignLabel#��[  6[   $��16(�6�   $��Right=�6�   $��Center=�6�   �� 5!      $��0��6   $��1��6$   $��Mot de passe : ��61   #��[  6K   $��16(�6x   $��Right=�6�   $��Center=�6�   �� 5"      $��1��6   $
��Auto��6&   $��Center=�63   $��Stretch=�6N    ! MaterialDesignOutlinedTextBox#��[ 5#   3   ��6   �� *
Courriel+63   �� 5&      -   5         ��Name$ PasswordTextBox��5&      $��1��5'      $��1��6"   $
��Auto��5(      $��Center=�5)      $��Stretch=�5*      #��[ 5,      ��5+      �� *Mdp+ �� UpdateSourceTrigger$ PropertyChanged=�.��5-   <   5.      5/      �� 51   
   -   5         ��Name$ ErrorMessageLabel��51   1   $��1��6L   
���  ��$��Center=�6j   ��6   �� *ErrorMessage+6j   � 53   
   $��2��6    54      �� 55      $��* �6#   �� 56      $��* �6#   �� 57      $��* �6#   .+�59      �� -   5        $��1��59      	 � Cursor$
	 Hand��6%   
 �� 	IsDefault$

 True��6K   .��6\   	Connexion6g   5:      � 5;   
   $��3��6    5<      �� 5=      $��* �6#   �� 5>      $��* �6#   �� 5?      $��* �6#   5A      5B      5C      