﻿
namespace variables
{
    class Program{
        static void Main(string []args){
            //Console.WriteLine();
            /*byte b = 5;     //1byte
            sbyte c = 5;    //1byte

            short s = 5;    //2byte
            ushort us = 5;   //2byte

            Int16 i16 = 2;  //2byte
            int i = 2;      //4byte
            Int32 i32 = 2;  //4byte
            Int64 i64 = 2;  //8byte

            uint ui = 2;    //4byte
            long l = 4;     //8byte
            ulong ul = 4;   //8byte

            //Real sayılar
            float f = 5;    //4byte
            double d = 5;   //8byte
            decimal de = 5; //16byte

            char ch = '2';  //2byte
            string sr = "HsO";  //Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Hüseyin Özkan";
            string ad = "Hüseyin";
            string soyad = "Özkan";
            string tamIsim = ad + " " + soyad;
            
            //Integer

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean
            
            bool bool1 = 10>2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);   //2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);   //çıktısı 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);*/

            int x = 3;
			int y = 3;
			y = y + 2;
			Console.WriteLine(y);
			y += 2;
			Console.WriteLine(y);
			y /= 1;
			Console.WriteLine(y);
			x *= 2;
			Console.WriteLine(x);

			// MANTIKSAL OPERETÖRLER
			// && , || !

			bool isSucces = true;
			bool isCompleted = false;

			if (isSucces && isCompleted)
				Console.WriteLine("Perfesct!");

			if (isSucces || isCompleted)
				Console.WriteLine("Great!");

			if (isSucces && isCompleted)
				Console.WriteLine("Fine!");


			//İLİŞKİSEL OPERATÖRLER
			// <, >, <=, >=, ==, !=

			int a = 3;
			int b = 4;
			bool sonuc = a < b;

			Console.WriteLine(sonuc);
			sonuc = a > b;
			Console.WriteLine(sonuc);
			sonuc = a >= b;
			Console.WriteLine(sonuc);
			sonuc = a <= b;
			Console.WriteLine(sonuc);
			sonuc = a == b;
			Console.WriteLine(sonuc);
			sonuc = a != b;
			Console.WriteLine(sonuc);

			Console.WriteLine("***Aritmetik Operatorler***");

			int sayi1 = 10;
			int sayi2 = 5;
			int sonuc1 = sayi1 / sayi2;
			Console.WriteLine(sonuc1);
			sonuc1 = sayi1 + sayi2;
			Console.WriteLine(sonuc1);
			sonuc1 = sayi1 + sayi2;
			Console.WriteLine(sayi1);
			sonuc1 = sayi1++;

			// % mod alır
			int sonuc2 = 20 % 3;
			Console.WriteLine(sonuc2);



        }
    }    
}