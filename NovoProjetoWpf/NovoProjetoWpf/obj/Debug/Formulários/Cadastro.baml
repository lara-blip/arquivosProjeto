   M S B A M L   `   `   `  ����I  ENovoProjetoWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NovoProjetoWpf.FormuláriosNovoProjetoWpf.Formulários  5   	   *    $NovoProjetoWpf.Formulários.Cadastro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:NovoProjetoWpf.Formulários     5   	     � Title$  Cadastro��5   	   $	��448��6   $	��523��6'   .��5	      � $��0,0,0,-6q�6   ��5
   
   �� 5       �� ImageSource$ /Formulários/papel.png��6   .+�5   
   �� -   5         ��Name$ tbEmail��5      $
��Left=�6#   $��
10,124,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��261��6~   $��28��6�   $��14(�6�   $��Arial)�6�   �� 5   
   -   5        $ 
tbTelefone��5      $
��Left=�6&   $��
10,247,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��261��6�   $��28��6�   $��14(�6�   $��Arial)�6�   �� 5   
   -   5        $ tbNome��5      $
��Left=�6"   $��	10,60,0,0q�6=   $
 Wrap=�6P   $	��Top=�6d   $	��261��6|   $��28��6�   $��14(�6�   $ �� HorizontalScrollBarVisibility$
 Auto=�6�    � UseLayoutRounding .  $��Arial)�6�   �� 5   
   $��Nome:
��6   $
��Left=�6*   $��	10,32,0,0q�6E   $	��Top=�6X   $��28��6p   $��80��6|   $��Arial)�6�   $��14(�6�   $��Center=�6�   
�������6�   �� 5   
   $��Sexo:��6   $
��Left=�6    $��
10,157,0,0q�6;   $	��Top=�6O   $��14(�6g   $��Arial)�6u   
�������6�   �� 5   
   $��Email:��6   $
��Left=�6!   $��	10,93,0,0q�6<   $	��Top=�6O   $��14(�6g   $��Arial)�6u   
�������6�   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��
10,221,0,0q�6?   $	��Top=�6S   $��14(�6k   $��Arial)�6y    J� RenderTransformOrigin$ 0.479,-0.19&�6�   
�������6�   �� 5   
   -   5         ��Name$ cbSexo��5      $
��Left=�6#   $��
10,183,0,0q�6>   $	��Top=�6R   $	��261��6j   $��28��6v   
�������$��14(�6�   $��Arial)�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      � 	 � Color$	 	#FFF0F0F0��6#   � 5      $	 White��6#   
 � Offset$
 1Q�61   5      .@�5      �� $��Feminino��6   �� 5      $��	Masculino��6   5      �� 5   
   $��Data de Nascimento:��6   $
��Left=�6.   $��
10,343,0,0q�6I   $	��Top=�6]   $��14(�6u   $��Arial)�6�   $ 0.348,0.116&�6�   
�������6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtpNascimento��5      $
��Left=�6,   $��
10,374,0,0q�6G   $	��Top=�6[   $��Arial)�6s   $��14(�6�   $��27��6�   $	��262��6�      SelectedDateFormat$ Short=�6�   ��5       �� 5!      $ 0.5,0&�6&    �� 
StartPoint$ 0.5,1&�67   .��5"      � $	 	#FFA3AEB9��6#   � 5#      $	 	#FF8399A9��6#   $
 0.375Q�65   � 5$      $	 	#FF718597��6#   $
 0.375Q�65   � 5%      $	 	#FF587A94��6#   $
 1Q�65   5&      5(      �� 5)   
   $�� ��6   $
��Left=�6   $��323,291,0,0q�66   $	��Top=�6K   �� 5*   
   -   5         ��Name$ 
btCancelar��5*      $��Cancelar��6%   $
��Left=�68   $��438,304,0,0q�6S   $	��Top=�6h   
����������	#002F2C2C$��40��6�   $��75��6�   $��Arial)�6�   $��14(�6�   6�   �� 5+   
   -   5        $ btSalvar��5+      $��Salvar��6#   $
��Left=�64   $��438,374,0,0q�6O   $	��Top=�6d   ���	#00000000
�������$��39��6�   $��Arial)�6�   $��14(�6�    .  $��75��6�   6�   5-      5.      