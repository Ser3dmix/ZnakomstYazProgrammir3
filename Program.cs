// Знакомство с яз.программирования. Семинар-3.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-1. Написать программу,кот.принимает на вход координаты точки(не нулевые) и выдает номер четверти плоскости оси координат
/*
int KoordCh(double x, double y)
{

     if(x > 0 && y > 0) return 1;
     if(x > 0 && y < 0) return 2;
     if(x < 0 && y < 0) return 3;
     if(x < 0 && y > 0) return 4;
    return 0;
}

Console.Write("введите координаты X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Y: ");
double yA = Convert.ToDouble(Console.ReadLine());

double itog = KoordCh(xA, yA);

Console.WriteLine($"точка с координатами x = {xA}, y = {yA} принадлежит {itog} четверти");
*/




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-2.(самост)  Программа,по заданному номеру четверти, показывает диапазон возможных координат в этой четверти
/*
void DiapCh(int chetv)
{
    if(chetv == 1)Console.WriteLine("X - все положительные , Y - все положительные");
    if(chetv == 2)Console.WriteLine("X - все положительные , Y - все отрицательные");
    if(chetv == 3)Console.WriteLine("X - все отрицательные , Y - все отрицательные");
    if(chetv == 4)Console.WriteLine("X - все отрицательные , Y - все положительные");
    if(chetv > 4 || chetv < 1 )Console.WriteLine("не хулигань! четвертей всего четыре! На то они и четверти. ");
    
}

Console.Write("введите номер четверти осей координат XY : ");
int nCh = Convert.ToInt32(Console.ReadLine());
DiapCh(nCh);                                                                                    // решено
*/




 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                          
//ЗАДАЧА-3.(самост) Программа принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве
/*
double LengDot(double xA, double yA, double xB, double yB)
{
    double dist = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    dist = Math.Round(dist, 3);
    return dist;
}

Console.Write("введите координаты X точки A: ");
double xtA = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Y точки A: ");
double ytA = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты X точки B: ");
double xtB = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Y точки B: ");
double ytB = Convert.ToDouble(Console.ReadLine());

double dlina = LengDot(xtA, ytA, xtB, ytB);

Console.WriteLine($"расстояние между данными точками {dlina}");                                // решено
*/



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-4.(самост) Программа принимает на вход число N и выдает ряд квадратов чисел от 1 до N
/*
void QuatroN(int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.Write(Math.Pow(current, 2) + "  ");
        current++;
    }
}

Console.Write("введите число : ");
int NN = Convert.ToInt32(Console.ReadLine());

QuatroN(NN);                                                                                 // решено
*/



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//Homework
//Homework
//Homework
//Homework

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА 19: Напишите программу, которая принимает на вход @@@пятизначное@@@ число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void NPal(int number)
{
    int pal = 0;
    int num = number;

    while(number > 0)
    {
        pal = pal * 10 + number % 10;
        number = number / 10;
    }

    if(num == pal)
    {
       Console.WriteLine("палиндром"); 
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}

Console.Write("введите число : ");
int NN = Convert.ToInt32(Console.ReadLine());

NPal(NN);                                                                                                           // решено
*/

        

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53       3d расстояние м/у точками A и B = корень из(xB - xA)в квадр.  + (yB - yA)в квадр.  + (zB - zA)в квадр


/*
double LengDot(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double dist = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    dist = Math.Round(dist, 2);
    return dist;
}

Console.Write("введите координаты X точки A: ");
double xtA = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Y точки A: ");
double ytA = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Z точки A: ");
double ztA = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координаты X точки B: ");
double xtB = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Y точки B: ");
double ytB = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты Z точки B: ");
double ztB = Convert.ToDouble(Console.ReadLine());

double dlina = LengDot(xtA, ytA, ztA, xtB, ytB, ztB);

Console.WriteLine($"расстояние между данными точками {dlina}");                                                     // решено
*/



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void CubeN(int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.Write(Math.Pow(current, 3) + "  ");
        current++;
    }
}

Console.Write("введите число : ");
int NN = Convert.ToInt32(Console.ReadLine());

CubeN(NN);                                                                                                            //решено
*/












