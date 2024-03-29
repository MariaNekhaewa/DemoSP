PGDMP         &                |         	   BD_Phones    14.6    14.6                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16742 	   BD_Phones    DATABASE     h   CREATE DATABASE "BD_Phones" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "BD_Phones";
                postgres    false            �            1259    17079    client_info    TABLE     �  CREATE TABLE public.client_info (
    client_info_id integer NOT NULL,
    client_fio character varying(150) NOT NULL,
    client_telephone_number character varying(11) NOT NULL,
    problem character varying(100) NOT NULL,
    date_of_the_end date NOT NULL,
    cost money NOT NULL,
    master_fio character varying(150) NOT NULL,
    status character varying(50),
    comments text,
    phone_name character varying(100) NOT NULL
);
    DROP TABLE public.client_info;
       public         heap    postgres    false            �            1259    16802    client_info_id_seq    SEQUENCE     {   CREATE SEQUENCE public.client_info_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.client_info_id_seq;
       public          postgres    false            �            1259    16987    clients    TABLE     �   CREATE TABLE public.clients (
    client_id integer NOT NULL,
    surname character varying(50) NOT NULL,
    name character varying(50) NOT NULL,
    patronymic character varying(50) NOT NULL,
    telephone_number integer NOT NULL
);
    DROP TABLE public.clients;
       public         heap    postgres    false            �            1259    16997    orders    TABLE     '  CREATE TABLE public.orders (
    order_id integer NOT NULL,
    client_id integer NOT NULL,
    master_id integer NOT NULL,
    service_id integer NOT NULL,
    phone_name character varying(100) NOT NULL,
    date_of_the_end date NOT NULL,
    status character varying(50),
    comments text
);
    DROP TABLE public.orders;
       public         heap    postgres    false            �            1259    16982    services    TABLE     �   CREATE TABLE public.services (
    service_id integer NOT NULL,
    name character varying(200) NOT NULL,
    cost money NOT NULL
);
    DROP TABLE public.services;
       public         heap    postgres    false            �            1259    16992    staff    TABLE       CREATE TABLE public.staff (
    staff_id integer NOT NULL,
    surname character varying(50) NOT NULL,
    name character varying(50) NOT NULL,
    patronymic character varying(50) NOT NULL,
    post character varying(100) NOT NULL,
    telephone_number integer NOT NULL
);
    DROP TABLE public.staff;
       public         heap    postgres    false            �            1259    16977    users    TABLE     �   CREATE TABLE public.users (
    user_id integer NOT NULL,
    staff_id integer,
    login character varying(50) NOT NULL,
    password character varying(50) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false                      0    17079    client_info 
   TABLE DATA           �   COPY public.client_info (client_info_id, client_fio, client_telephone_number, problem, date_of_the_end, cost, master_fio, status, comments, phone_name) FROM stdin;
    public          postgres    false    215   �!                 0    16987    clients 
   TABLE DATA           Y   COPY public.clients (client_id, surname, name, patronymic, telephone_number) FROM stdin;
    public          postgres    false    212   �"                 0    16997    orders 
   TABLE DATA           {   COPY public.orders (order_id, client_id, master_id, service_id, phone_name, date_of_the_end, status, comments) FROM stdin;
    public          postgres    false    214   �"                 0    16982    services 
   TABLE DATA           :   COPY public.services (service_id, name, cost) FROM stdin;
    public          postgres    false    211   �"                 0    16992    staff 
   TABLE DATA           \   COPY public.staff (staff_id, surname, name, patronymic, post, telephone_number) FROM stdin;
    public          postgres    false    213   �"                 0    16977    users 
   TABLE DATA           C   COPY public.users (user_id, staff_id, login, password) FROM stdin;
    public          postgres    false    210   #                  0    0    client_info_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.client_info_id_seq', 7, true);
          public          postgres    false    209            {           2606    17085    client_info client_info_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.client_info
    ADD CONSTRAINT client_info_pkey PRIMARY KEY (client_info_id);
 F   ALTER TABLE ONLY public.client_info DROP CONSTRAINT client_info_pkey;
       public            postgres    false    215            u           2606    16991    clients clients_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.clients
    ADD CONSTRAINT clients_pkey PRIMARY KEY (client_id);
 >   ALTER TABLE ONLY public.clients DROP CONSTRAINT clients_pkey;
       public            postgres    false    212            y           2606    17003    orders orders_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (order_id);
 <   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_pkey;
       public            postgres    false    214            s           2606    16986    services services_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.services
    ADD CONSTRAINT services_pkey PRIMARY KEY (service_id);
 @   ALTER TABLE ONLY public.services DROP CONSTRAINT services_pkey;
       public            postgres    false    211            w           2606    16996    staff staff_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staff_id);
 :   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_pkey;
       public            postgres    false    213            q           2606    16981    users users_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    210            }           2606    17004    orders orders_client_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_client_id_fkey FOREIGN KEY (client_id) REFERENCES public.clients(client_id);
 F   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_client_id_fkey;
       public          postgres    false    3189    212    214            ~           2606    17009    orders orders_master_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_master_id_fkey FOREIGN KEY (master_id) REFERENCES public.staff(staff_id);
 F   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_master_id_fkey;
       public          postgres    false    214    213    3191                       2606    17014    orders orders_service_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_service_id_fkey FOREIGN KEY (service_id) REFERENCES public.services(service_id);
 G   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_service_id_fkey;
       public          postgres    false    214    211    3187            |           2606    17019    users users_staff_id_fkey    FK CONSTRAINT        ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_staff_id_fkey FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id);
 C   ALTER TABLE ONLY public.users DROP CONSTRAINT users_staff_id_fkey;
       public          postgres    false    213    210    3191               �   x����`��O�? r��t��Z:Y�����0�AL�.�hR�V�	�}#��vs���9u�"�"B�O�32��Nc/�)/E����Hx�ڞ�f�eڞ�p+��5iފ?��2dUr�d���Q�Hw.(x-�6[�NB&
�����7V){pshk��X�\˼�h+�r;^���t6�?���u����Q��            x������ � �            x������ � �            x������ � �            x������ � �            x�3���LL��̃�\1z\\\ F��     