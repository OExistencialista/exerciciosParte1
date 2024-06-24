class Program
{
    public static void Main(){
        Console.Clear();
        int a = 2;
        int[] v = new int[6];

        while(a<6){
            v[a] = 10*a;
            Console.WriteLine($"a:{a}, v[{a}]:{v[a]}");
            a++;
        }
    }
}