   M S B A M L   `   `   `  ����D  @TrackThat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TrackThat	TrackThat  5   	       TrackThat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TrackThat     5   	     � Title$  	TrackThat��5   	   $	��450��6   $	��800��6(   .��5	      � $��Stretch=�6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��.3* �6   .+�5   
   �� $��1��6    �� Orientation$ Vertical=�6%   $��Stretch=�6<   $��10q�6X   .+�5      �� $	��Top=�6   .��6-   	Refresh66   	� 5      -   5        $��
uxUpsRadio��5   U   $��0��6    	� 	GroupName$ Couriers��6'   $	��UPS��6<   $��5q�6J   6U   	� 5      -   5        $��uxUspsRadio��5   V   $��0��6   $ Couriers��6'   $
��USPS��6<   $��5q�6K   6V   	� 5      -   5        $��uxFedExRadio��5   W   $��0��6   $ Couriers��6'   $��FedEx��6<   $��5q�6L   6W   �� 5      $��Tracking number:��6   �� 5      -   5         ��Name$ uxTrackingTxt��5      $
��20pt��6-   $��100pt��6>   $��5q�6O   �� 5      -   5         ��Name$ 	uxGetInfo��5      $��
Get Status��6(   
�������$��5q�6P   6[   �� 5      -   5        $ uxAddPackage��5      $��Add To My Packages��6+   
�������$��5q�6[   6f   5      � 5   
   $��0��6    � RowDefinitions 5      �� 5      �� 5      .+�5      � $��0��6   $��0��6    $��10q�60    5      �� 5       $��75 �6'   �� 5!      $	��.5* �6'   �� 5"       5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      .+�5,      �� $��5q�6   $��0��6'   $��Center=�64   $��Right=�6O   
Ship Date:6x   �� 5-      $��5q�6   $��1��6'   $��Center=�64   $��Right=�6O   
Carrier:6v   �� 5.      $��5q�6   $��2��6'   $��Center=�64   $��Right=�6O   	Tracking:6w   �� 5/      $��5q�6   $��3��6'   $��Center=�64   $��Right=�6O   	Status:6u   �� 50      $��5q�6   $��4��6'   $��Center=�64   $��Right=�6O   ETD:6q   �� 52      $��5q�6   $��0��6'   $��1��64   $��Center=�6D   $
��Left=�6_   ��6z   ��  �� ElementName$ uxShipmentList�� �� Path$ SelectedItem.ship_date��� 53      $��5q�6   $��1��6'   $��1��64   $��Center=�6D   $
��Left=�6_   ��6z   �� $ uxShipmentList��$ SelectedItem.carrier��� 54      $��5q�6   $��2��6'   $��1��64   $��Center=�6D   $
��Left=�6_   ��6z   �� $ uxShipmentList��$" SelectedItem.tracking_number��� 55      $��5q�6   $��3��6'   $��1��64   $��Center=�6D   $
��Left=�6_   ��6z   �� $ uxShipmentList��$% SelectedItem.status_description��� 56      $��5q�6   $��4��6'   $��1��64   $��Center=�6D   $
��Left=�6_   ��6z   �� $ uxShipmentList��$* $SelectedItem.estimated_delivery_date��� 58      -   5        $��uxEventList��58   I   $��0��6   $��6��6(   $��2��69   ��6\   �� $ uxShipmentList��$ SelectedItem.events�	 �� View	 59      �� 5:      .P�5;      �� $
��Time��6-   
 �� Width$

 Auto��6h    �� DisplayMemberBinding 6;   �� *occurred_at+6h   �� 5<      $
��City��6-   $

 Auto��6j    6;   �� *city_locality+6j   �� 5=      $��State��6-   $

 Auto��6l    6<   �� *state_province+6l   �� 5>      $��Description��6-   $

 Auto��6o    6B   �� *description+6o   5?      5A      5C      �� 5E      -   5        $��uxShipmentList��5E   $   $��1��6   $��10q�6:   ��6F   �� $ ShipInfoList�	 5F      �� 5G      -	   5        
uxGridView��.P�5H      �� $��	Ship Date��6-   $

 Auto��6k    6@   �� *	ship_date+6k   �� 5I      $��
TrackingNo��6-   $

 Auto��6r    6A   �� *tracking_number+6r   �� 5J      $��Carrier��6-   $

 Auto��6g    6>   �� *	carrier+6g   �� 5K      $��Status��6-   $

 Auto��6q    6=   �� *status_description+6q   �� 5L      $	��ETD��6-   $

 Auto��6s    6:   �� *estimated_delivery_date+6s   5M      5O      5P      5Q      5R      