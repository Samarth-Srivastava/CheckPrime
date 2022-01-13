using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        string number_str = Console.ReadLine();
        int number = Convert.ToInt32(number_str);

        MAIN m = new MAIN();

        if(m.getNumberOfFactors(number) == 2){
            Console.WriteLine("YES");
        }
        else{
            Console.WriteLine("NO");
        }
    }

    public int getNumberOfFactors(int N){
        int f =  2;
        for(int i = 2; i*i <= N; i++){
            if(N%i == 0){
                if(i == (N/i)){
                    f = f+1;
                }
                else{
                    f = f+2;
                }
            }
        }
        return f;
    }
}
