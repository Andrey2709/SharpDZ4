// Задание 25
Console.WriteLine("Задание 25");
int exponentiation( int a, int b)
{
    int c =(int) Math.Pow(a,b);
    Console.Write(c+ " ");
    return c;
}
exponentiation(3, 5);
exponentiation(2, 4);
Console.WriteLine(" ");
Console.WriteLine("Задание 27");
// Задание 27


int sumAll(int x){
      int sum =0;
for(int n = x; n > 0; n /= 10){
    sum += n % 10;
}
Console.Write(sum+ " ");
return sum;

}

sumAll(452);
sumAll(82);
sumAll(9012);

// Задание 29
Console.WriteLine(" ");
Console.WriteLine("Задание 29");
void arr(int [] ar){
    for(int i = 0;i<ar.Length;i++){
        int x = ar[i];
        Console.Write(x+" ");
    }
}
int[] a = {1,2,4,6,7,8};
arr(a);


