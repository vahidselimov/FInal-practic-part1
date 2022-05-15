
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Wor
{
    internal class Weapon
    {
        private int _bulletcapacity;
        public  int Bulletcapacity
        {
            get
            {
                return _bulletcapacity;
            }
            set
            {
                if (value > 0 && value <= 50)
                {
                    _bulletcapacity = value;
                }

            }

        }
        
        public int CountBullets
        {
            get
            {
                return _countbullets;
            }
            set
            {
                if (value>0 &&value<=49 &&value<Bulletcapacity)
                {
                    _countbullets = value;
                }
            }
        }

        private int _countbullets;
        public bool mood;
      
        public Weapon(int bulletcapacity, int countbullets,bool Mood)
        {
            Bulletcapacity = bulletcapacity;
            CountBullets = countbullets;
            mood = Mood;

        }
        public void shoot()
        {
            if (Bulletcapacity>0)
            {
                Console.WriteLine(--Bulletcapacity);
                
            }
            
            

        }
       
        public void Fire()
        {
            if (mood==true)
            {
                Console.WriteLine(--CountBullets);

               
            }
            else
            {
                Console.WriteLine(CountBullets = 0);
            }
                   
        }
        public int GetRemainBulletCount()
        {
            if (Bulletcapacity!=CountBullets)
            {

                return Bulletcapacity - CountBullets;
            }
            else
            {
                Console.WriteLine("Capacity full!");
            }
            return -1;
        }
        public void Reload() {
            if (Bulletcapacity!=CountBullets)
            {
                int remain = GetRemainBulletCount();
                CountBullets += GetRemainBulletCount();
                Console.WriteLine($"Added:{remain} bullets,ammo :{CountBullets}");
                
            }

        }
        public void ChangeFireMode()
        {
            if (mood==true)
            {
                Console.WriteLine("Static");
            }
            else
            {
                Console.WriteLine("Automatic");
            }
        }
    }

    
      
  
}
