using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Exorcist : Spirit
    {
        private bool _isAngry;
        private float _attackDelay;

        public Exorcist(bool isAngry, float attackDelay, float health, string name, float damage, float ectoplasm) : base(health, name, damage, ectoplasm)
        {
            _isAngry = isAngry;
            _attackDelay = attackDelay;
        }

        public override void Cry()
        {

        }
    }
}
