using System.Linq.Expressions;
using System.Diagnostics; //biblioteka do liczenia czasu (czas działania alg)
using System.Runtime.ExceptionServices;
using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //wyszukiwanie liniowe

            //int[] array = new int[10000];

            //Random randNum = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = randNum.Next(0, 100000000);
            //}

            //int value = 8203955;

            //int s = 0;
            //int n = 10000;
            //while (s < n && array[s] != value) s++;
            //if (s == n) Console.WriteLine("BRAK");
            //else Console.WriteLine("Jest na pozycji" + s);

            //wyszukiwanie binarne

            //int[] t = new int[10000];
            //Random R = new Random();
            //t[0] = R.Next(1, 100);

            //for (int i = 1; i < t.Length; i++)
            //{
            //    t[i] = t[i - 1] + R.Next(1, 10);
            //}

            //int value = 8000;
            //int p = 0, k = 9999, s = (p + k) / 2;

            //while ((p + 1) != k && t[s] != value)
            //{
            //    s = (p + k) / 2;
            //    if (t[s] > value) k = s;
            //    else if (t[s] < value) p = s;
            //}
            //if (t[s] == value) Console.WriteLine("JEST");
            //else Console.WriteLine("BRAK");

            //wyszukiwanie liniowe

            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for(int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[]t, int n)
            //{
            //    foreach (var item in t)
            //    {
            //        if(item == n) return true;
            //    }
            //    return false;
            //}

            //int a = t[10000000 - 3];
            //if (Line(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");

            //dodanie instrumentacji X (ilość powtórzeń pętli)


            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for (int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[] t, int n)
            //{
            //    int X = 0;
            //    foreach (var item in t)
            //    {
            //        X++;
            //        if (item == n) { Console.WriteLine("X {0} ", X); return true; }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return false;
            //}

            //int a = t[10000000 - 3];
            //if (Line(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");


            //dodanie mierzenia czasu
            //using System.Diagnostics; //biblioteka do liczenia czasu (czas działania alg) (na górze)
            //wczytanie czasu przed, wykonac alg, zmierzyc czas po


            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for (int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[] t, int n)
            //{
            //    int X = 0;
            //    foreach (var item in t)
            //    {
            //        X++;
            //        if (item == n) { Console.WriteLine("X {0} ", X); return true; }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return false;
            //}

            //int a = t[10000000 - 3];


            //bool LineTime(int[] t, int n)
            //{
            //    bool jest = false; //czy wartosc jest czy nie ma 
            //    long START = Stopwatch.GetTimestamp(); //zmierzenie przed
            //    foreach(var item in t)
            //    {
            //        if(item ==n) {  jest = true; break; } // wartosc była
            //    }
            //    long STOP = Stopwatch.GetTimestamp(); //zmierzenie po
            //    long R = STOP - START; //różnica 
            //    double czas = R * (1.0 / Stopwatch.Frequency); // przeliczeni na czas sekundowy // Stopwatch.Frequency -> ilosc cykli na min https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.frequency?view=net-8.0
            //    Console.WriteLine("Czas {0} ", czas);
            //    return jest;   
            //}
            //if (LineTime(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");


            //wyszukiwanie binarne 

            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for (int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[] t, int n)
            //{
            //    int X = 0;
            //    foreach (var item in t)
            //    {
            //        X++;
            //        if (item == n) { Console.WriteLine("X {0} ", X); return true; }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return false;
            //}

            //int a = t[10000000 - 3];


            //bool LineTime(int[] t, int n)
            //{
            //    bool jest = false; //czy wartosc jest czy nie ma 
            //    long START = Stopwatch.GetTimestamp(); //zmierzenie przed
            //    foreach(var item in t)
            //    {
            //        if(item ==n) {  jest = true; break; } // wartosc była
            //    }
            //    long STOP = Stopwatch.GetTimestamp(); //zmierzenie po
            //    long R = STOP - START; //różnica 
            //    double czas = R * (1.0 / Stopwatch.Frequency); // przeliczeni na czas sekundowy // Stopwatch.Frequency -> ilosc cykli na min https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.frequency?view=net-8.0
            //    Console.WriteLine("Czas {0} ", czas);
            //    return jest;   
            //}

            //bool Binary(int[] t, int n)
            //{
            //    int p = 0, k = t.Length - 1, s;
            //    while(p <= k)
            //    {
            //        s = (p + k) / 2; //liczenie srodka 
            //        if (t[s] == n) return true; //porównanie czy to jest szukana wartosc 
            //        else
            //        {
            //            if (t[s] > n) k = s - 1; //przestawianie startu do tylu
            //            else p = s + 1; //przestawianie startu do przody
            //        }
            //    }
            //    return false;
            //}
            //if (Binary(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");

            //dodanie instrumentacji (liczenie ilosci powtorzen);

            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for (int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[] t, int n)
            //{
            //    int X = 0;
            //    foreach (var item in t)
            //    {
            //        X++;
            //        if (item == n) { Console.WriteLine("X {0} ", X); return true; }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return false;
            //}

            //int a = t[10000000 - 3];


            //bool LineTime(int[] t, int n)
            //{
            //    bool jest = false; //czy wartosc jest czy nie ma 
            //    long START = Stopwatch.GetTimestamp(); //zmierzenie przed
            //    foreach (var item in t)
            //    {
            //        if (item == n) { jest = true; break; } // wartosc była
            //    }
            //    long STOP = Stopwatch.GetTimestamp(); //zmierzenie po
            //    long R = STOP - START; //różnica 
            //    double czas = R * (1.0 / Stopwatch.Frequency); // przeliczeni na czas sekundowy // Stopwatch.Frequency -> ilosc cykli na min https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.frequency?view=net-8.0
            //    Console.WriteLine("Czas {0} ", czas);
            //    return jest;
            //}

            //bool BinaryInst(int[] t, int n)
            //{
            //    bool jest = false;
            //    int X = 0;
            //    int p = 0, k = t.Length - 1, s;
            //    while (p <= k)
            //    {
            //        s = (p + k) / 2; //liczenie srodka 
            //        if (t[s] == n) { X++; jest = true; break; } //porównanie czy to jest szukana wartosc 
            //        else
            //        {
            //            if (t[s] > n) k = s - 1; //przestawianie startu do tylu
            //            else p = s + 1; //przestawianie startu do przody
            //            X++;
            //        }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return jest;
            //}
            //if (BinaryInst(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");

            //dodanie liczenia czasu

            //int[] t = new int[10000000];
            //Random r = new Random();
            //t[0] = r.Next(1, 100);
            //for (int i = 1; i < t.Length; i++) t[i] = t[i - 1] + r.Next(1, 10);

            //bool Line(int[] t, int n)
            //{
            //    int X = 0;
            //    foreach (var item in t)
            //    {
            //        X++;
            //        if (item == n) { Console.WriteLine("X {0} ", X); return true; }
            //    }
            //    Console.WriteLine("X {0} ", X);
            //    return false;
            //}

            //int a = t[10000000 - 3];


            //bool LineTime(int[] t, int n)
            //{
            //    bool jest = false; //czy wartosc jest czy nie ma 
            //    long START = Stopwatch.GetTimestamp(); //zmierzenie przed
            //    foreach (var item in t)
            //    {
            //        if (item == n) { jest = true; break; } // wartosc była
            //    }
            //    long STOP = Stopwatch.GetTimestamp(); //zmierzenie po
            //    long R = STOP - START; //różnica 
            //    double czas = R * (1.0 / Stopwatch.Frequency); // przeliczeni na czas sekundowy // Stopwatch.Frequency -> ilosc cykli na min https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.frequency?view=net-8.0
            //    Console.WriteLine("Czas {0} ", czas);
            //    return jest;
            //}

            //bool BinaryTime(int[] t, int n)
            //{
            //    bool jest = false;
            //    int p = 0, k = t.Length - 1, s;
            //    long START = Stopwatch.GetTimestamp(); //zmierzenie przed
            //    while (p <= k)
            //    {
            //        s = (p + k) / 2; //liczenie srodka 
            //        if (t[s] == n) {jest = true; break; } //porównanie czy to jest szukana wartosc 
            //        else
            //        {
            //            if (t[s] > n) k = s - 1; //przestawianie startu do tylu
            //            else p = s + 1; //przestawianie startu do przody
            //        }
            //    }
            //    long STOP = Stopwatch.GetTimestamp(); //zmierzenie po
            //    long R = STOP - START; //różnica 
            //    double czas = R * (1.0 / Stopwatch.Frequency);
            //    Console.WriteLine("Czas {0} ", czas);
            //    return jest;
            //}
            //if (BinaryTime(t, a)) Console.WriteLine("JEST"); else Console.WriteLine("BRAK");

            //alg na liczenie silni (metoda iteracyjna)

            //long SilI(int n)
            //{
            //    long w = 1;
            //    for(int i = 1; i <= n; i++)
            //    {
            //        w = w * i;
            //    }
            //    return w;
            //}
            //Console.WriteLine(SilI(4));

            //alg na liczenie silni (metoda rekurencyjna)


            //long SilR(int n)
            //{
            //    if (n < 2) return 1;
            //    else return SilR(n - 1) * n;
            //}
            //Console.WriteLine(SilR(4));

            // alg na ciag fibonacciego rekurencyjny

            //long FibR(int n)
            //{
            //    if (n < 2) return n;
            //    else return FibR(n - 1) + FibR(n - 2);
            //}
            //Console.WriteLine(FibR(4));

            // alg na ciag fib iteracyjny

            //long FibI(int n)
            //{
            //    int a = 0, b = 1, c = 1;
            //    if (n < 2) return n;
            //    for (int i = 0; i <= n; i++)
            //    {
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //    return c;
            //}
            //Console.WriteLine(FibI(12));\\

            //long FibI(int n) // iteracyjny
            //{
            //    int a = 0, b = 1, c = 1;
            //    if (n < 2) return n;
            //    for (int i = 0; i <= n; i++)
            //    {
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //    return c;
            //}
            //Console.WriteLine(FibI(12));


            //alg na ciag fibonacciego rekurencyjny

            //long FibR(int n)
            //{
            //    if (n < 2) return n;
            //    else return FibR(n - 1) + FibR(n - 2);
            //}
            //Console.WriteLine(FibR(1));


            // algorytm na n-ty wyraz ciągu Fibonnaciego
            //long FR(int n)
            //{
            //    if (n <= 1) return n;
            //    else return FR(n - 1) + FR(n - 2);
            //}
            //long FI(int n)
            //{
            //    if (n <= 1) return n;
            //    long a = 0, b = 1, c = 1;
            //    for (int i = 2; i <= n; i++ )
            //    {
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //    return c;
            //}
            //Console.WriteLine(FR(7));
            //Console.WriteLine(FI(7));




            // dynamiczne wydawanie reszty moje wersja

            //using System;
            //using System.Collections.Generic;
            //using System.Linq;
            //using System.Text;
            //using System.Threading.Tasks;

            //namespace Reszta1
            //{
            //    class Program
            //    {
            //        static int[] Nom = {50000, 20000, 10000, 5000, 2000, 1000,
            //                            500, 200, 100, 50, 20, 10, 5, 2, 1, };

            //        static void Main(string[] args)
            //        {
            //            Console.Write("Reszta do wydania: ");
            //            double Reszta = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("----------------------------");
            //            int Kwota = Convert.ToInt32(100 * Reszta);
            //            for (int k = 0; Kwota > 0; k++)
            //            {
            //                int n = Kwota / Nom[k];
            //                if (n > 0)
            //                {
            //                    if (Nom[k] >= 100)
            //                        Console.Write("{0,3} zł: ", Nom[k] / 100);
            //                    else
            //                        Console.Write("{0,3} gr: ", Nom[k]);
            //                    Console.WriteLine(n);
            //                    Kwota %= Nom[k];
            //                }
            //            }
            //            Console.WriteLine("----------------------------");
            //        }
            //    }
            //}

            //long FibI(int n) // iteracyjny
//{
//    int a = 0, b = 1, c = 1;
//    if (n < 2) return n;
//    for (int i = 0; i <= n; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;
//    }
//    return c;
//}
//Console.WriteLine(FibI(12));


//alg na ciag fibonacciego rekurencyjny

//long FibR(int n)
//{
//    if (n < 2) return n;
//    else return FibR(n - 1) + FibR(n - 2);
//}
//Console.WriteLine(FibR(1));


// algorytm na n-ty wyraz ciągu Fibonnaciego
//long FR(int n)
//{
//    if (n <= 1) return n;
//    else return FR(n - 1) + FR(n - 2);
//}
//long FI(int n)
//{
//    if (n <= 1) return n;
//    long a = 0, b = 1, c = 1;
//    for (int i = 2; i <= n; i++ )
//    {
//        c = a + b;
//        a = b;
//        b = c;
//    }
//    return c;
//}
//Console.WriteLine(FR(7));
//Console.WriteLine(FI(7));




// dynamiczne wydawanie reszty moje wersja

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Reszta1
//{
//    class Program
//    {
//        static int[] Nom = {50000, 20000, 10000, 5000, 2000, 1000,
//                            500, 200, 100, 50, 20, 10, 5, 2, 1, };

//        static void Main(string[] args)
//        {
//            Console.Write("Reszta do wydania: ");
//            double Reszta = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("----------------------------");
//            int Kwota = Convert.ToInt32(100 * Reszta);
//            for (int k = 0; Kwota > 0; k++)
//            {
//                int n = Kwota / Nom[k];
//                if (n > 0)
//                {
//                    if (Nom[k] >= 100)
//                        Console.Write("{0,3} zł: ", Nom[k] / 100);
//                    else
//                        Console.Write("{0,3} gr: ", Nom[k]);
//                    Console.WriteLine(n);
//                    Kwota %= Nom[k];
//                }
//            }
//            Console.WriteLine("----------------------------");
//        }
//    }
//}

            //sprawdzenie czy liczba jest liczbą pierwszą

            //bool isNumberPrime(int a)
            //{
            //    for(int i = 2; i < a; i++)
            //    {
            //        if(a % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            //Console.WriteLine(isNumberPrime(1));

            //bool prime2(long a)
            //{
            //    if (a < 2) return false;
            //    if (a == 2) return true;
            //    if (a % 2 == 0) return false;
            //    for(int i = 3; i*i <= a; i+= 2)  //pierwiastek zeby nie sprawdzac siebie
            //    {
            //        if (a % 1 == 0) return false;
            //    }
            //    return true;
            //}

            //long t1 = Stopwatch.GetTimestamp();
            //Console.WriteLine(isNumberPrime(23232132));
            //long t2 = Stopwatch.GetTimestamp();
            //double w = (t2-t1)*(1.0/Stopwatch.Frequency);
            //Console.WriteLine(w);

            //long t3 = Stopwatch.GetTimestamp();
            //Console.WriteLine(prime2(23232132));
            //long t4 = Stopwatch.GetTimestamp();
            //double q = (t4 - t3) * (1.0 / Stopwatch.Frequency);
            //Console.WriteLine(q);

            //Console.WriteLine(prime2(23232132));

            //---------------------

            //int zakres = 100000;
            //int howMuch = 0;

            //long t5 = Stopwatch.GetTimestamp();
            //for (int i = 2; i <= zakres; i++)
            //{
            //    if (isNumberPrime(23232132)) howMuch++;
            //}
            //long t6 = Stopwatch.GetTimestamp();
            //double l = (t6 - t5) * (1.0 / Stopwatch.Frequency);
            //Console.WriteLine(l);


            //long t7 = Stopwatch.GetTimestamp();
            //for (int i = 2; i <= zakres; i++)
            //{
            //    if (prime2(23232132)) howMuch++;
            //}
            //long t8 = Stopwatch.GetTimestamp();
            //double y = (t8 - t7) * (1.0 / Stopwatch.Frequency);
            //Console.WriteLine(y);


            //bool prime3(long a)
            //{
            //    if (a < 2) return false;
            //    if (a == 2 || a == 3) return true;
            //    if (a % 2 == 0 || a % 3 == 0) return false;
                
            //    for (int i = 5; i * i <= a; i += 6)  //pierwiastek zeby nie sprawdzac siebie //elementy dzielone przez 6 maja czesto pierwsze iczy obok siebie
            //    {
            //        if (a % 1 == 0 || a % (i + 2) == 0) return false;
            //    }
            //    return true;
            //}

            //long t9 = Stopwatch.GetTimestamp();
            //for (int i = 2; i <= zakres; i++)
            //{
            //    if (prime3(23232132)) howMuch++;
            //}
            //long t10 = Stopwatch.GetTimestamp();
            //double e = (t10 - t9) * (1.0 / Stopwatch.Frequency);
            //Console.WriteLine(y);

            //--------------------------------
            //sito eratostenesa

            //int[] t = new int[zakres + 1];

            //howMuch = 0;

            //t[0] = t[1] = 1;

            //for(int i = 2; i * i <= zakres; i++)
            //{
            //    if (t[i] == 0)
            //    {
            //        for(int j = i * 2; j <= zakres; j += 1) t[j] = 1;
            //    }
            //}

            //int[] t = new int[zakres + 1];

            //howMuch = 0;

            //t[0] = t[1] = 1;

            //for (int i = 2; i * i <= zakres; i++)
            //{
            //    if (t[i] == 0)
            //    {
            //        for (int j = i * 2; j <= zakres; j += 1) t[j] = 1;
            //    }
            //}
            //for(int i = 3; i * i <= zakres; i += 2) if(t[i] == 0)

            //wieze hanoi

            //string s1 = "AC", s2 = "AC", t;

            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    t = s1;
            //    t = t.Replace('C', 'D'); t = t.Replace('B', 'C');
            //    t = t.Replace('D', 'B');
            //    s2 = t + "AC";
            //    t = s1;
            //    t = t.Replace('A', 'D'); t = t.Replace('B', 'A');
            //    t = t.Replace('D', 'B');
            //    s2 = s2 + t;
            //    s1 = s2;
            //}

            //void Hanoi(char a, char b, char c, int n)
            //{
            //    if(n > 0)
            //    {
            //        Hanoi(a,c,b,n - 1);
            //        Console.WriteLine("{0}{1}", a, c);
            //        Hanoi(b, a, c, n - 1);
            //    }
            //}
            //Hanoi('A', )

            //STOS LastInFirstOut

            //int[] stack = new int[1000];

            //int marker = 0;

            //void addToStack(int value)
            //{
            //    if (marker == 999) throw new Exception("Stos zapełniony!");
            //    stack[marker++] = value;
            //};

            //int deleteFromStack()
            //{
            //    if (marker == 0) throw new Exception("Stos pusty!");
            //    marker--;
            //    return stack[marker];
            //};

            //void readLatestElement()
            //{
            //    Console.WriteLine(stack[marker]);
                
            //};

            //int readStackLength()
            //{
            //    return marker; 
            //}

            //int a;

            //do { a = int.Parse(Console.ReadLine()); addToStack(a); } while (a != 0);
            //while ( readStackLength() > 0 ) Console.WriteLine(deleteFromStack());

            //KOLEJKA FirstInFirstOut

            //int[] queue = new int[1000];

            //int p = 0;
            
            //int k = 1;

            //void addToQueue(int value)
            //{
            //    if (k == 999) throw new Exception("Kolejka zapełniona!");
            //    queue[k++] = value;
            //};

            //int deleteFromQueue()
            //{
            //    if (p == k) throw new Exception("Kolejka nie ma danych!");
            //    p++;
            //    return queue[p - 1];
            //};

            //int readQueueLength()
            //{
            //    return k - p;
            //}

            //int a;

            //do { a = int.Parse(Console.ReadLine()); addToQueue(a); } while (a != 0);
            //while (readQueueLength() > 0) Console.WriteLine(deleteFromQueue());

            //LISTA w C#

            //List <int> L = new List<int>(); //inicjacja listy

            //L.Add(1); //dodanie do listy elementu

            //L.Count(); //długość listy

            //L.RemoveAt(index); //usunięie elementu

            //STOS LISTA

            //void addToStack(int value)
            //{
            //    L.Add(value);
            //};

            //int deleteFromStack()
            //{
            //    int x = L[L.Count() - 1];
            //    L.RemoveAt(L.Count() - 1);
            //    return L[L.Count() - 1];
            //};

            //int readStackLength()
            //{
            //    return L.Count();
            //}

            //int a;

            //do { a = int.Parse(Console.ReadLine()); addToStack(a); } while (a != 0);
            //while (readStackLength() > 0) Console.WriteLine(deleteFromStack());

            //KOLEJKA LISTA

            //void addToQueue(int value)
            //{
            //    L.Add(value);
            //};

            //int deleteFromQueue()
            //{
            //    int x = L[0];
            //    L.RemoveAt(0);
            //    return x;
            //};

            //int readQueueLength()
            //{
            //    return L.Count();
            //}

            //int a;

            //do { a = int.Parse(Console.ReadLine()); addToQueue(a); addToStack(a); } while (a != 0);
            //while (readQueueLength() > 0) Console.WriteLine(deleteFromQueue());
            //while (readStackLength() > 0) Console.WriteLine(deleteFromStack());

            //Bufor cykliczny - usunięie pierwszego el i dodanie go na koniec listy

            //void addElementsToList()
            //{
            //    int x = 0;
            //    for(int i = 0; i <= 5; i++)
            //    {
            //        L.Add(x++);
            //    }
            //};

            //int doBufor()
            //{
            //    int x = L[0];
            //    L.RemoveAt(0);
            //    L.Add(x);
            //    return x;
            //};

            //int a;

            //do { a = int.Parse(Console.ReadLine()); addToQueue(a); addToStack(a); } while (a != 0);
            //while (readQueueLength() > 0) Console.WriteLine(deleteFromQueue());
            //while (readStackLength() > 0) Console.WriteLine(deleteFromStack());

        }
    }
}