using System;

namespace SYSEnemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy EnemyHealth = new Enemy();
            bool Alive = true;

            while (Alive)
                {
                    if (EnemyHealth.Health == 1)
                    {
                        Alive = false;
                    }
                    EnemyHealth.ChangeHp();
                    Console.WriteLine(EnemyHealth.Health);
                }

        }

    }

    class Enemy
    {
        public  int Health = 10;
        public  int DamageToEnemy(int EnemyHp, int Damage)
        {
            EnemyHp -= Damage;
            return EnemyHp;
        }
        public int ChangeHp() 
        {
            Health = DamageToEnemy(Health, 1);
            return Health;
        }
    }
}
