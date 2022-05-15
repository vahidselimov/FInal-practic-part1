
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
                if (value<0 &&value<=49)
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
                Console.WriteLine(--Bulletcapacity);

               
            }
            else
            {
                Console.WriteLine(Bulletcapacity = 0);
            }
                   
        }
        public int GetRemainBulletCount()
        {
            return Bulletcapacity - CountBullets;
        }
        public int Reload() {
            return Bulletcapacity += GetRemainBulletCount();
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
