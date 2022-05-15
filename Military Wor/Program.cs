using System;

namespace Military_Wor
{
    internal class Program
    {




        static void Main(string[] args)
        {
            int bulletCapacity;
            int countBullets;
            Console.WriteLine("Please enter Check");
            bool check;
            do
            {
                check = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Please Enter BulletCapacity");
                bulletCapacity = Convert.ToInt32(Console.ReadLine());
            } while (bulletCapacity < 0 || bulletCapacity == 0||bulletCapacity>=51);
            Console.WriteLine("\n ***********\n");
            do
            {
                Console.WriteLine("Please enter CountCapacity...Warning The number of bullets in a weapon must be less than the number of bullets in unit!!");
                countBullets = Convert.ToInt32(Console.ReadLine());
                 
                
            } while (countBullets < 0 || countBullets >= bulletCapacity || countBullets == 0||countBullets>=50);
            Weapon weapon = new Weapon(bulletCapacity, countBullets, check);
            weapon.Bulletcapacity = bulletCapacity;
            weapon.Bulletcapacity = countBullets;


            do
            {
                Console.WriteLine("0: İnformasiya almaq üçün");
                Console.WriteLine("1: Shoot metodu üçün");
                Console.WriteLine("2: Fire metodu üçün");
                Console.WriteLine("3: GetRemainBulletCount metodu üçün");
                Console.WriteLine("4: Reload metodu üçün");
                Console.WriteLine("5: ChangeFireMode metodu üçün");
                Console.WriteLine("6: Proqramdan dayandırmaq üçün");

                switch (Console.ReadLine())
                {
                    case "0":
                        break;
                    case "1":
                        weapon.shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);


        }
    }
}
