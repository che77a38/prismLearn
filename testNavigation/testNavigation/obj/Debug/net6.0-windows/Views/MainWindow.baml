   M S B A M L   `   `   `  ����  testNavigation%    testNavigation.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	   $	��350��5   !   $	��525��6.    � Title 6	   �� *Title+.��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��	上一步��6   $
��auto��6#   $
��auto��60   $��3q�6>   ��6I   �� *GoBackCommand+�� 5      $��	下一步��6   $
��auto��6#   $
��auto��60   $��3q�6>   ��6I   �� *GoForwordCommand+�� 5      $��打开A��6   $
��auto��6#   $
��auto��60   $��3q�6>   ��6I   �� *OpenACommand+�� 5      $��打开B��6   $
��auto��6#   $
��auto��60   $��3q�6>   ��6I   �� *OpenBCommand+5      �� 5   
   $��1��6   !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��6&   5      5      