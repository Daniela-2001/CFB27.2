namespace aula27._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            n3 = Convert.ToInt32(Console.ReadLine());

            soma(n1, n2, n3);
        }

        static void soma(params int[]n) 
        {
            int res = 0;

            if(n.Length < 1) {
                Console.WriteLine("Não existem valores a serem somados");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
            }else{
                for(int i=0; i < n.Length; i++){
                    res+=n[i];
                }
                Console.WriteLine("A soma dos valores é: {0}", res);
            }

        }
    }
}