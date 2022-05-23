using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {


        public int bitisSatir=3;
        public int bitisSutun=0;
        public int baslangicSatir;
        public int baslangicSutun;
        static int satir = 12;
        static int sutun = 12;
        string yon;

        public char[,] labirentAlan = new char[,]

                                                                  { {'#','#','#','#','#','#','#','#','#','#','#','#',
                                                                     '#','.','.','.','#','.','.','.','.','.','.','#',
                                                                     '#','.','#','.','#','.','#','#','#','#','.','#',
                                                                     '#','#','#','.','#','.','.','.','.','#','.','#',
                                                                     '#','.','.','.','.','#','#','#','.','#','.','#',
                                                                     '#','#','#','#','.','#','.','#','.','#','.','#',
                                                                     '#','.','.','#','.','.','.','#','.','#','.','#',
                                                                     '#','#','.','#','.','#','.','#','.','#','.','#',
                                                                     '#','.','.','.','.','#','.','.','.','#','.','#',
                                                                     '#','#','#','#','#','#','.','#','#','#','.','#',
                                                                     '#','.','.','.','.','.','.','.','.','.','.','#',
                                                                     '#','#','#','#','#','#','#','#','#','#','#','#',} };

        
      };

        //public int[,]labirentAlan={

        //    {0,0,0,0,0,0,0,0,1,0,0,0},
        //    {0,1,1,1,0,1,1,1,1,1,1,0},
        //    {1,1,0,1,0,1,0,0,0,0,1,0},
        //    {0,0,0,1,0,1,1,1,1,0,1,0},
        //    {0,1,1,1,1,0,0,0,1,0,1,0},
        //    {0,0,0,0,1,0,1,0,1,0,1,0},
        //    {0,1,1,0,1,1,1,0,1,0,1,0},
        //    {0,0,1,0,1,0,1,0,1,0,1,0},
        //    {0,1,1,1,1,0,1,1,1,0,1,0},
        //    {0,0,0,0,0,0,1,0,0,0,1,0},
        //    {1,1,1,1,1,1,1,1,1,1,1,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0},
        //    };
        //public int[,] labirentAlan ={

        //    {0,0,0,0,0,0,0,0,1,0,0,0},
        //    {0,1,0,1,0,1,1,1,1,1,1,0},
        //    {1,1,0,1,0,1,0,0,0,0,1,0},
        //    {0,0,0,1,0,1,1,1,1,0,1,0},
        //    {0,1,1,1,1,0,0,0,1,0,1,0},
        //    {0,0,0,0,1,0,1,0,1,0,1,0},
        //    {0,1,1,0,1,1,1,0,1,0,1,0},
        //    {0,0,1,0,1,0,1,0,1,0,1,0},
        //    {0,1,1,1,1,0,1,1,1,0,1,0},
        //    {0,0,0,0,0,0,1,0,0,0,1,0},
        //    {1,1,1,1,1,1,1,1,1,1,1,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0},
        //    };




        public Class1(int _bsa,int _bsu)
        {
            baslangicSatir =_bsa;
            baslangicSutun =_bsu;
            printLabirent();
            yolbul();
            
        }

        public int _bsa
        {
            get
            {
                return baslangicSatir;
            }
        }
        public int _bsu
        {
            get
            {
                return baslangicSutun;
            }
        }

        public void printLabirent()
        {
            
            int satir = 0;
            foreach (char labo in labirentAlan)
            {
                satir++;
                if (satir % 12 != 0)
                {
                    Console.Write(labo);
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }

        public string yolbul()
        {

            if (baslangicSatir == 0 && baslangicSutun != 0 && baslangicSutun != 11) yon = "guney";
            else if (baslangicSatir == 11 && baslangicSutun != 0 && baslangicSutun != 11) yon = "kuzey";
            else if (baslangicSutun == 0 && baslangicSatir != 0 && baslangicSatir != 11) yon = "dogu";
            else yon = "bati";
            return yon;
        }

        public void cikisBul(int satir, int sutun)
        {
            if (yon == "dogu") {
		if (labirentAlan[satir + 1,sutun] != '#' && labirentAlan[satir + 1,sutun] != 'x' && labirentAlan[satir + 1,sutun] != 'O') {
			satir += 1;  // Saga don
			yon = "guney";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun + 1] != '#' && labirentAlan[satir,sutun + 1] != 'x' && labirentAlan[satir,sutun + 1 ] != 'O') {
			sutun += 1;	// Ileri 
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir - 1,sutun] != '#' && labirentAlan[satir - 1,sutun] != 'x' && labirentAlan[satir - 1,sutun] != 'O') {
			satir -= 1;	// Sola don
			yon = "kuzey";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun - 1] != '#' && labirentAlan[satir,sutun - 1] != 'O') {
			labirentAlan[satir,sutun] = 'O';
			sutun -= 1;	// Geri don
			yon = "bati";
		}
		else  {
			labirentAlan[satir,sutun] = 'O';
			yon = "guney";			
		}
	}

	if (yon == "bati") {
		if (labirentAlan[satir - 1,sutun] != '#' && labirentAlan[satir - 1,sutun] != 'x' && labirentAlan[satir - 1,sutun] != 'O') {
			satir -= 1; // Saga don
			yon = "kuzey";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun - 1] != '#' && labirentAlan[satir,sutun - 1] != 'x' && labirentAlan[satir,sutun - 1] != 'O') {
			sutun -= 1; // �leri 
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir + 1,sutun] != '#' && labirentAlan[satir + 1,sutun] != 'x' && labirentAlan[satir + 1,sutun] != 'O') {
			satir += 1;	// Sola don
			yon = "guney";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun + 1] != '#' && labirentAlan[satir,sutun + 1] != 'O') {			
			labirentAlan[satir,sutun] = 'O';
			sutun += 1;	// Geri don
			yon = "dogu";	
		}
		else {			
			labirentAlan[satir,sutun] = 'O';
			yon = "kuzey";
			
		}
	}

	if (yon == "kuzey") {
		if (labirentAlan[satir,sutun + 1] != '#' && labirentAlan[satir,sutun + 1] != 'x' && labirentAlan[satir,sutun + 1] != 'O') {
			sutun += 1; // Saga don
			yon = "dogu";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir - 1,sutun] != '#' && labirentAlan[satir - 1,sutun] != 'x' && labirentAlan[satir - 1,sutun] != 'O') {
			satir -= 1; // �leri
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun - 1] != '#' && labirentAlan[satir,sutun - 1] != 'x' && labirentAlan[satir,sutun - 1] != 'O') {
			sutun -= 1; // Sola don
			yon = "bati";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir + 1,sutun] != '#' && labirentAlan[satir + 1,sutun] != 'O') {
			labirentAlan[satir,sutun] = 'O';
			satir += 1; // Geri don
			yon = "guney";
		}
		else {
			labirentAlan[satir,sutun] = 'O';
			yon = "dogu";			
		}
	}

	if (yon == "guney") {
		if (labirentAlan[satir,sutun-1] != '#' && labirentAlan[satir,sutun-1] != 'x' && labirentAlan[satir,sutun - 1] != 'O') {
			sutun -= 1;	// Saga d�n
			yon = "bati";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir+1,sutun] != '#' && labirentAlan[satir + 1,sutun] != 'x' && labirentAlan[satir + 1,sutun] != 'O') {
			satir += 1; // �leri
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir,sutun + 1] != '#' && labirentAlan[satir,sutun + 1] != 'x' && labirentAlan[satir,sutun + 1] != 'O') {
			sutun += 1; // Sola don
			yon = "dogu";
			labirentAlan[satir,sutun] = 'x';
		}
		else if (labirentAlan[satir - 1,sutun] != '#' && labirentAlan[satir - 1,sutun] != 'O') {
			labirentAlan[satir,sutun] = 'O';
			satir -= 1; // Geri 
			yon = "kuzey";
		}
		else {
			labirentAlan[satir,sutun] = 'O';
			yon = "bati";		
		}
	}
                }
            }
        }
        
