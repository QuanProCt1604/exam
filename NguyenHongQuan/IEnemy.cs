using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NguyenHongQuan

{
     public interface IEnemy
    {
        public enum ENEMY_TYPE
        {
            GOBLIN, BOSS, ORC
        }
        public enum ATTACK_TYPE
        {
            RANGE, MELEE
        }
            public long Id { get; set; }
            public string Name { get; set; }
            public ENEMY_TYPE Type { get; set; }

            public int Health { get; set; }

            public ATTACK_TYPE ATTACK { get; set; }
            public float Damage { get; set; }
        
         void ShowInfo()
        {
            Console.WriteLine("Show Information: ");
        }
         
    }
    



}
