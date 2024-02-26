PGDMP     "    3                |            Food-deleivery    15.3    15.3 $    0           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            1           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            2           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            3           1262    16398    Food-deleivery    DATABASE     �   CREATE DATABASE "Food-deleivery" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
     DROP DATABASE "Food-deleivery";
                postgres    false            �            1259    16399    Заказы    TABLE       CREATE TABLE public."Заказы" (
    "ID_Заказа" integer NOT NULL,
    "ID_Курьера" integer,
    "ID_Клиента" integer,
    "ID_Ресторана" integer,
    "Адрес-доставки" character varying,
    "ID_Статуса" integer
);
 "   DROP TABLE public."Заказы";
       public         heap    postgres    false            �            1259    16406    Категории    TABLE     �   CREATE TABLE public."Категории" (
    "ID_Категории" integer NOT NULL,
    "Название" character varying
);
 (   DROP TABLE public."Категории";
       public         heap    postgres    false            �            1259    16413    Клиенты    TABLE     �   CREATE TABLE public."Клиенты" (
    "ID_Клиента" integer NOT NULL,
    "Имя" character varying(50),
    "Телефон" character varying(25)
);
 $   DROP TABLE public."Клиенты";
       public         heap    postgres    false            �            1259    16418    Корзина    TABLE     �   CREATE TABLE public."Корзина" (
    "ID_Корзины" integer NOT NULL,
    "ID_Заказа" integer,
    "ID_Блюда" integer,
    "Количество" character varying
);
 $   DROP TABLE public."Корзина";
       public         heap    postgres    false            �            1259    16425    Курьеры    TABLE     �   CREATE TABLE public."Курьеры" (
    "ID_Курьера" integer NOT NULL,
    "Имя" character varying,
    "Телефон" character varying
);
 $   DROP TABLE public."Курьеры";
       public         heap    postgres    false            �            1259    16493    Меню    TABLE     �   CREATE TABLE public."Меню" (
    "ID_Блюда" integer NOT NULL,
    "Название" character varying,
    "ID_Категории" integer,
    "Цена" money,
    "ID_Ресторана" integer
);
    DROP TABLE public."Меню";
       public         heap    postgres    false            �            1259    16432    Рестораны    TABLE     �   CREATE TABLE public."Рестораны" (
    "ID_Ресторана" integer NOT NULL,
    "Название" character varying,
    "Адрес" character varying,
    "Телефон" character varying
);
 (   DROP TABLE public."Рестораны";
       public         heap    postgres    false            �            1259    16439    Статусы-заказа    TABLE     �   CREATE TABLE public."Статусы-заказа" (
    "ID_Статуса" integer NOT NULL,
    "Название" character varying
);
 1   DROP TABLE public."Статусы-заказа";
       public         heap    postgres    false            &          0    16399    Заказы 
   TABLE DATA           �   COPY public."Заказы" ("ID_Заказа", "ID_Курьера", "ID_Клиента", "ID_Ресторана", "Адрес-доставки", "ID_Статуса") FROM stdin;
    public          postgres    false    214   �0       '          0    16406    Категории 
   TABLE DATA           [   COPY public."Категории" ("ID_Категории", "Название") FROM stdin;
    public          postgres    false    215   T1       (          0    16413    Клиенты 
   TABLE DATA           [   COPY public."Клиенты" ("ID_Клиента", "Имя", "Телефон") FROM stdin;
    public          postgres    false    216   �1       )          0    16418    Корзина 
   TABLE DATA           {   COPY public."Корзина" ("ID_Корзины", "ID_Заказа", "ID_Блюда", "Количество") FROM stdin;
    public          postgres    false    217   b2       *          0    16425    Курьеры 
   TABLE DATA           [   COPY public."Курьеры" ("ID_Курьера", "Имя", "Телефон") FROM stdin;
    public          postgres    false    218   2       -          0    16493    Меню 
   TABLE DATA           �   COPY public."Меню" ("ID_Блюда", "Название", "ID_Категории", "Цена", "ID_Ресторана") FROM stdin;
    public          postgres    false    221   �2       +          0    16432    Рестораны 
   TABLE DATA           {   COPY public."Рестораны" ("ID_Ресторана", "Название", "Адрес", "Телефон") FROM stdin;
    public          postgres    false    219   �3       ,          0    16439    Статусы-заказа 
   TABLE DATA           `   COPY public."Статусы-заказа" ("ID_Статуса", "Название") FROM stdin;
    public          postgres    false    220   �4       �           2606    16424    Корзина Basket_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."Корзина"
    ADD CONSTRAINT "Basket_pkey" PRIMARY KEY ("ID_Корзины");
 H   ALTER TABLE ONLY public."Корзина" DROP CONSTRAINT "Basket_pkey";
       public            postgres    false    217            �           2606    16412 "   Категории Categories_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public."Категории"
    ADD CONSTRAINT "Categories_pkey" PRIMARY KEY ("ID_Категории");
 P   ALTER TABLE ONLY public."Категории" DROP CONSTRAINT "Categories_pkey";
       public            postgres    false    215            �           2606    16431    Курьеры Couriers_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public."Курьеры"
    ADD CONSTRAINT "Couriers_pkey" PRIMARY KEY ("ID_Курьера");
 J   ALTER TABLE ONLY public."Курьеры" DROP CONSTRAINT "Couriers_pkey";
       public            postgres    false    218            �           2606    16417    Клиенты Customers_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."Клиенты"
    ADD CONSTRAINT "Customers_pkey" PRIMARY KEY ("ID_Клиента");
 K   ALTER TABLE ONLY public."Клиенты" DROP CONSTRAINT "Customers_pkey";
       public            postgres    false    216            �           2606    16445 /   Статусы-заказа Order-statuses_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."Статусы-заказа"
    ADD CONSTRAINT "Order-statuses_pkey" PRIMARY KEY ("ID_Статуса");
 ]   ALTER TABLE ONLY public."Статусы-заказа" DROP CONSTRAINT "Order-statuses_pkey";
       public            postgres    false    220            �           2606    16405    Заказы Orders_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public."Заказы"
    ADD CONSTRAINT "Orders_pkey" PRIMARY KEY ("ID_Заказа");
 F   ALTER TABLE ONLY public."Заказы" DROP CONSTRAINT "Orders_pkey";
       public            postgres    false    214            �           2606    16438 #   Рестораны Restaurants_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public."Рестораны"
    ADD CONSTRAINT "Restaurants_pkey" PRIMARY KEY ("ID_Ресторана");
 Q   ALTER TABLE ONLY public."Рестораны" DROP CONSTRAINT "Restaurants_pkey";
       public            postgres    false    219            �           2606    16499    Меню Меню_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."Меню"
    ADD CONSTRAINT "Меню_pkey" PRIMARY KEY ("ID_Блюда");
 D   ALTER TABLE ONLY public."Меню" DROP CONSTRAINT "Меню_pkey";
       public            postgres    false    221            �           2606    16473 (   Заказы Заказы-Клиенты    FK CONSTRAINT     �   ALTER TABLE ONLY public."Заказы"
    ADD CONSTRAINT "Заказы-Клиенты" FOREIGN KEY ("ID_Клиента") REFERENCES public."Клиенты"("ID_Клиента") NOT VALID;
 V   ALTER TABLE ONLY public."Заказы" DROP CONSTRAINT "Заказы-Клиенты";
       public          postgres    false    214    216    3205            �           2606    16468 (   Заказы Заказы-Курьеры    FK CONSTRAINT     �   ALTER TABLE ONLY public."Заказы"
    ADD CONSTRAINT "Заказы-Курьеры" FOREIGN KEY ("ID_Курьера") REFERENCES public."Курьеры"("ID_Курьера") NOT VALID;
 V   ALTER TABLE ONLY public."Заказы" DROP CONSTRAINT "Заказы-Курьеры";
       public          postgres    false    218    214    3209            �           2606    16478 ,   Заказы Заказы-Рестораны    FK CONSTRAINT     �   ALTER TABLE ONLY public."Заказы"
    ADD CONSTRAINT "Заказы-Рестораны" FOREIGN KEY ("ID_Ресторана") REFERENCES public."Рестораны"("ID_Ресторана") NOT VALID;
 Z   ALTER TABLE ONLY public."Заказы" DROP CONSTRAINT "Заказы-Рестораны";
       public          postgres    false    219    3211    214            �           2606    16483 3   Заказы Заказы-Статус-заказа    FK CONSTRAINT     �   ALTER TABLE ONLY public."Заказы"
    ADD CONSTRAINT "Заказы-Статус-заказа" FOREIGN KEY ("ID_Статуса") REFERENCES public."Статусы-заказа"("ID_Статуса") NOT VALID;
 a   ALTER TABLE ONLY public."Заказы" DROP CONSTRAINT "Заказы-Статус-заказа";
       public          postgres    false    3213    220    214            �           2606    16510 &   Корзина Конзина-Меню    FK CONSTRAINT     �   ALTER TABLE ONLY public."Корзина"
    ADD CONSTRAINT "Конзина-Меню" FOREIGN KEY ("ID_Блюда") REFERENCES public."Меню"("ID_Блюда") NOT VALID;
 T   ALTER TABLE ONLY public."Корзина" DROP CONSTRAINT "Конзина-Меню";
       public          postgres    false    217    221    3215            �           2606    16453 *   Корзина Корзина-Заказы    FK CONSTRAINT     �   ALTER TABLE ONLY public."Корзина"
    ADD CONSTRAINT "Корзина-Заказы" FOREIGN KEY ("ID_Заказа") REFERENCES public."Заказы"("ID_Заказа") NOT VALID;
 X   ALTER TABLE ONLY public."Корзина" DROP CONSTRAINT "Корзина-Заказы";
       public          postgres    false    3201    217    214            �           2606    16500 $   Меню Меню-Категории    FK CONSTRAINT     �   ALTER TABLE ONLY public."Меню"
    ADD CONSTRAINT "Меню-Категории" FOREIGN KEY ("ID_Категории") REFERENCES public."Категории"("ID_Категории") NOT VALID;
 R   ALTER TABLE ONLY public."Меню" DROP CONSTRAINT "Меню-Категории";
       public          postgres    false    221    215    3203            �           2606    16505 $   Меню Меню-Рестораны    FK CONSTRAINT     �   ALTER TABLE ONLY public."Меню"
    ADD CONSTRAINT "Меню-Рестораны" FOREIGN KEY ("ID_Ресторана") REFERENCES public."Рестораны"("ID_Ресторана") NOT VALID;
 R   ALTER TABLE ONLY public."Меню" DROP CONSTRAINT "Меню-Рестораны";
       public          postgres    false    219    3211    221            &   T   x�3�4��/��S�0��/l��paǅ�6�(�rrqB T����;.삩04�4�2�@����%a
8��b���� p�/      '   �   x�]�=
�P���Sx��������(�`%ba�>x$&^����J˙ogv@ek[Q�t!�ܨ	�[�s�N��Ac�GIm;�Ag�2�ۆ�˦����KM�x}F��T�u,\]ֶ���u$\|ȋ�-��P8}f��n۲��o�wF      (   ^   x���	� �g�������4L-��A������\W|uWc�X6:��'�p!�Ƌ��;ak4��dN���A��c��u[Z&"��g M      )      x������ � �      *   ]   x�ʻ�0E�ڞ��˰cDH���	�mε�;
�c�gU̘+aōJ��xgE��!,?^�\{�!�(�;�jO3�}""      -   �   x�eP;n1��O���6,,U.���D"ACҥ�D�z���c�0�FK��x��f<�&�O4��\k��K�Vk�Nht&S�8g�eh�X�Z}��8���.��7ZU�"��H�
�.���(�G��']cO��⊈��7���^J)o�`a�| �a�Ht�� �b�[]�%�]��=��݅�H����mĎs�B�8r�/2Ӱ@G8dM?������~>ջ�>F|�������޿3      +   �   x�5�;
�@E�y��^_��c�[!kpBMg��� F�pgGN��.�s���IbL>�7���w�t�s��҉Y��:���E�4i��xKe��tī���Ʋ�\ %֛�v�+�����x�[�9d��S[�
oOt      ,   E   x�3�0I�¾/6\�pa�}�.캰�˘�� ���paӅ��^��eV��b3PtW� �l$�     