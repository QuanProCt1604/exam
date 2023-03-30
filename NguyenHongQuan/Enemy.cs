using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NguyenHongQuan.IEnemy;

namespace NguyenHongQuan
{
    internal class Enemy : IEnemy
    {
        IEnemy Id { get; set; }
    }
}
