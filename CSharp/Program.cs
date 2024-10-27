using System.ComponentModel;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
         {
            int hp = 100;
            int maxHp = 100;

            string message = string.Format("당신의 HP는 {0} {1} 입니다", hp, maxHp);

            string mms = $"당신의 체력은 {hp}/{maxHp} 입니다";
            Console.WriteLine(message);
            Console.WriteLine(mms);

            bool isAlive = (hp > 0);

            int level = 10;

            bool isTall = true;
            bool isSmart = false;

            bool result = (isTall || isSmart);
            Console.WriteLine(result);

            bool result1 = (isTall && isSmart);
            Console.WriteLine(result1);
            
        }
    }
}