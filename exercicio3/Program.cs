class Program{
    public static void Main(){
        int[] v = new int[6];
        int a = 7;
        int b = a - 6;
        while(b<a){
            v[b] = b+a;
            Console.WriteLine($"v[{b}]:{v[b]}, b:{b}, a:{a}");
            b+=2;
        }
    }
}