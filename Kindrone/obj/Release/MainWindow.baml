   M S B A M L   `   `   `  ����   Kindrone    Kindrone.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Kindrone��$	��830��$	��770�� � 	Resources    MediumGreyBrush �� Color  KinectPurpleBrush  KinectBlueBrush �� 
TargetType �� Property �� Value  SquareCheckBox �� 
TargetType �� Orientation �Name	 ��Name
 ��Name �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	      &	 *     '�� ?     &	 t     7  7  �� $ 	#ff6e6e6e���� $ 	#ff52318f���� $ 	#ff00BCF2���� " ��.���  �@J�SnapsToDevicePixels . �� " ��.���  � �� �� " ��.R�� .+��� $ 
Horizontal=�
������ .+�� $ SquareCheckBoxChecked��.+��� $	 CheckedNormal��$��Images\CheckedNormal.png��$
��None=�$��Center=��� $	 CheckedHover��$��Images\CheckedHover.png��$
��None=�$��Center=�$y�	Collapsed=�� $ SquareCheckBoxUnchecked��$y�	Collapsed=�.+��� $	 UncheckedNormal��$ ��Images\UncheckedNormal.png��$
��None=�$��Center=��� $	 UncheckedHover��$��Images\UncheckedHover.png��$
��None=�$��Center=�$y�	Collapsed=��� $
 SquareCheckBoxText��#��z��$
 Left=�$��Center=�8��  $��15(�$��9,0,0,0q� P�  �@d�	IsChecked$ falseY�. ��� $ SquareCheckBoxChecked�� � y�$ 	Collapsed=��� $ SquareCheckBoxUnchecked�� � y�$ Visible=�P�  �@J�IsMouseOver . . ��� $ CheckedNormal�� � y�$ 	Collapsed=��� $ UncheckedNormal�� � y�$ 	Collapsed=��� $ CheckedHover�� � y�$ Visible=��� $ UncheckedHover�� � y�$ Visible=��� 8  $ SquareCheckBoxText�� � ��.��� -   $��
layoutGrid��$��	10 0 10 0q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$ 
Horizontal=�$��Center=�.+��� -    ��Name$ LeftUpButton��#���  #���   
�������$��Up��$	��100��{�.  �� -   $ LeftCenter1Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $ LeftDownButton��#���  #���   
�������$
��Down��$	��100��{�.  $��0,0,40,0q��� -   $ RightUpButton��#���  #���   
�������$��Up��$	��100��{�.  �� -   $ RightCenter1Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $ RightDownButton��#���  #���   
�������$
��Down��$	��100��{�.  �� $��1��$ 
Horizontal=�$��Center=�.+��� -	   $ LeftLeftButton��#���  #���   
�������$
��Left��$	��100��{�.  �� -
   $ LeftCenter2Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $ LeftRightButton��#���  #���   
�������$��Right��$	��100��{�.  $��0,0,40,0q��� -   $ RightLeftButton��#���  #���   
�������$
��Left��$	��100��{�.  �� -   $ RightCenter2Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $ RightRightButton��#���  #���   
�������$��Right��$	��100��{�.  �� $��2��$ 
Horizontal=�$��Center=�.+��� -   $��LeftFordwardsButton��#���  #���   
�������$��Forwards��$	��100��{�.  �� -   $��LeftCenter3Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $��LeftBackwardsButton��#���  #���   
�������$��	Backwards��$	��100��{�.  $��0,0,40,0q��� -   $��RightFordwardsButton��#���  #���   
�������$��Forwards��$	��100��{�.  �� -   $��RightCenter3Button��#���  #���   
�������$��Center��$	��100��{�.  �� -   $��RightBackwardsButton��#���  #���   
�������$��	Backwards��$	��100��{�.  (� $��3�� (� Stretch$ Uniform=�$��Center=�.���� -   $��Image��$	��630��$	��457��� $��4��$��Center=�$
��0 10q�.+��� $��Center=�.+��� ���	#FF09B433$
��Bold"�$��16(�$��Center=��� $�Last Command Sent ���� $	�to ���� $�Drone:���� -   $
 CommandTextBlock��$��Press Start to begin�����	#FF35A2CA$
��Bold"�$��24(�$��Center=�� $��5��.+��� $ 
Horizontal=�$��Center=�.+��� -   $ StartButton��$��Start��$
��30 5q�$��0 0 40 0q����	#FFE5E53D�� -   $ 
StopButton��$
��Stop��$
��30 5q�$��0 0 40 0q�{�.  ���	#FFB442AD�� -   $ HoverButton��$��Hover��$
��30 5q�$��0 0 40 0q�{�.  ���	#FF44CAC6�� -   $ EmergencyButton��$��	Emergency��$
��30 5q�$��0 0 40 0q����	#FFDA6C6C�� -   $ ResetEmergencyButton��$��Reset Emergency��$
��30 5q�$��28��$��Bottom=����	#FFDC9C2A� $��6��.+��� -   $��checkBoxSeatedMode��#��[ $��(Seating Mode)��$
��Auto��$
��Left=�$��Center=�$��
0 10 10 10q��� $%��Kindrone FLY DRONE USING KINECT��$��183,10.667,0.333,13.333q�$��4�����	#FF35A2CA$
��Bold"�$��18(�$��Right=�� $��7��.+��  � ColumnDefinitions �� $��* ��� $
��Auto �.+��� -   $��	statusBar��$��0��$��Stretch=�$��Bottom=�
�������#��[  .@��� $��0 0 0 10q��� -   $
 statusBarText��$J��DClick Seating Mode to change the skeletal appearance to being seated��$	��377��