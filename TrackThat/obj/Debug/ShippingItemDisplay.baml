   M S B A M L   `   `   `  ����D  @TrackThat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TrackThat	TrackThat  5          TrackThat.UserControl1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:TrackThat     5      .��5	      � $��0��6   $��0��6   $��10q�6(     � ColumnDefinitions  5
   
   �� 5      $��75 �6   �� 5      $	��.5* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��5q�6   $��0��6   $��Center=�6,   $��Right=�6G   
Ship Date:6o   �� 5   
   $��5q�6   $��1��6   $��Center=�6,   $��Right=�6G   
Carrier:6m   �� 5   
   $��5q�6   $��2��6   $��Center=�6,   $��Right=�6G   	Tracking:6n   �� 5   
   $��5q�6   $��3��6   $��Center=�6,   $��Right=�6G   	Status:6l   �� 5   
   $��5q�6   $��4��6   $��Center=�6,   $��Right=�6G   ETD:6i   �� 5   
   $��5q�6   $��0��6   $��1��6,   $��Center=�6<   $
��Left=�6W   ��6r   �� *	ship_date+�� 5   
   $��5q�6   $��1��6   $��1��6,   $��Center=�6<   $
��Left=�6W   ��6r   �� *	carrier+�� 5   
   $��5q�6   $��2��6   $��1��6,   $��Center=�6<   $
��Left=�6W   ��6r   �� *tracking_number+�� 5    
   $��5q�6   $��3��6   $��1��6,   $��Center=�6<   $
��Left=�6W   ��6r   �� *status_description+�� 5!   
   $��5q�6   $��4��6   $��1��6,   $��Center=�6<   $
��Left=�6W   ��6r   �� *estimated_delivery_date+�� 5#   
   -   5        $��uxEventList��5#   A   $��0��6   $��6��6    $��2��61   ��6T   �� *events+ �� View 5$      �� 5%      .P�5&      �� $
��Time��6%    �� Width$
 Auto��6`    �� DisplayMemberBinding 63   �� *occurred_at+6`   �� 5'      $
��City��6%   $
 Auto��6b    63   �� *city_locality+6b   �� 5(      $��State��6%   $
 Auto��6d    64   �� *state_province+6d   �� 5)      $��Description��6%   $
 Auto��6g    6:   �� *description+6g   5*      5,      5.      5/      