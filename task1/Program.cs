// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да


Console.Clear();
Console.WriteLine("Введите номер задачи");
Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Задача 1(задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.");
Console.WriteLine("Задача 2(задача со звёздочкой): Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, и вывести на экран те (тот), где чаще всего встречается введённая буква.");
Console.Write("Введите номер задачи, которую хотите проверить: ");
int task = Convert.ToInt32(Console.ReadLine());
switch(task){
    case 19 : {
    Console.WriteLine("Выберите какое решение хотите проверить:");
    Console.Write("1 - для общего решения с помощью массива для чисел любой длины или 2-для решения без массива для пятизначных чисел: ");
    int choise = Convert.ToInt32(Console.ReadLine());
    switch(choise){
        case 1: CheckPalindrom1();
            break;
        case 2: CheckPalindrom2();
            break;
        default : Console.WriteLine("Неправильный ввод");
            break;
        }
        break;
    }
    case 21: {
        Console.Clear();
        FindDistance();
        break;
    }
    case 23:{
        Console.Clear();
        NCubeList();
        break;
    }
    case 1: {
        Console.Clear();
        CircleSqr();
        break;
    }
    case 2:{
        Console.Clear();
        FindChar();
        break;
    }
    
    default : Console.WriteLine("Неправильный ввод");
        break;
}





void CheckPalindrom1(){ //общее решение с целочисленным массивом для чисел любой длины
    Console.Write("Введите число: ");
    string num = Console.ReadLine(); 
    int n = num.Length; 
    int[] numArray = new int[n]; 
    int number = Convert.ToInt32(num); 
    int index = n-1;
    for(int i = 0; i < n; i ++){
        numArray[index] = number % 10;
        number = number / 10;
        index --;
    }
    index = n-1;
    for(int i=0; i <= n/2 ; i++){
       if(numArray[i] == numArray[index]){
        index --;
       } else{
        Console.WriteLine("Не Палиндром");
        break;
       }
       if (i == n/2){
        Console.WriteLine("Палиндром");
       }
    }
}

void CheckPalindrom2(){ //решение без массива для пятизначных чисел
Console.Write("Введите пятизначное число: ");
    string num = Console.ReadLine(); 
    int n = num.Length; 
    if (n == 5){
       int number = Convert.ToInt32(num);
       if(number/10000 == number%10 && (number%10000)/1000 == (number%100)/10){
        Console.WriteLine("Палиндром");
       } else{
        Console.WriteLine("Не палиндром");
       }
    
    } else {
        Console.WriteLine("Неправильный ввод");
    }

}

void FindDistance(){
Console.Write("Введите координату х первой точки: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y первой точки: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату z первой точки: ");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату х второй точки: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y второй точки: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату z второй точки: ");
        int z2 = Convert.ToInt32(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
        Console.WriteLine(Math.Round(d, 2));
}

void NCubeList(){
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    if (n >= 0){
         for (int i = 1; i < n+1; i++){
        Console.Write(Math.Pow(i, 3) + "; ");
        }
    } else if (n <= 0){
         for (int i = 1; i > n-1; i--){
        Console.Write(Math.Pow(i, 3) + "; ");
        }
    } else {
        Console.WriteLine("Неправильный ввод");
    }
   
}
void CircleSqr(){
    Console.Write("Введите радиус: ");
    int r = Convert.ToInt32(Console.ReadLine());
    if (r > 0){
    double sqr = Math.PI*Math.Pow(r,2);
    string num = Convert.ToString(Math.Round(sqr)); 
    int n = num.Length; 
    int[] numArray = new int[n]; 
    int number = Convert.ToInt32(num); 
    int index = n-1;
    for(int i = 0; i < n; i ++){
        numArray[index] = number % 10;
        number = number / 10;
        index --;
    }
    int max = numArray[0];
    for(int j = 1; j < n; j++){
        if(numArray[j] > numArray[j-1]){
            max = numArray[j];
        }
    }
    Console.WriteLine($"Площадь круга с радиусом {r} равна {num}");
    Console.WriteLine($"Максимальная цифра в числе {num} - {max}");
    } else {
        Console.WriteLine("Неправильный ввод");
    }
    
}
void FindChar(){
    string[] cities = {"Москва", "Новосибирск", "Казань", "Тюмень", "Екатеринбург"};
    int[] count = {0,0,0,0,0};
    int max = count[0];
    int maxIndex = 0;
    Console.Write("Введите букву: ");
    string temp = Console.ReadLine();
    char[] find = temp.ToCharArray();
    if (find.Length == 1){
        
        for(int i = 0; i < cities.Length; i++){
            foreach(char c in cities[i]){
                if(c == find[0]){
                    count[i]= count[i] + 1;
                }
            }
        }
        for(int j = 1; j < count.Length; j++){
            if(count[j] > max){
                max = count[j];
                maxIndex = j;
            }
        }
        Console.WriteLine(cities[maxIndex]);
    } else {
        Console.WriteLine("Неправильный ввод");
    }

}
