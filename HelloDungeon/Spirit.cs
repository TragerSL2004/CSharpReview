using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Spirit
    {
        private float _health;
        private string _name;
        private float _damage;
        private float _ectoplasmBarrier;

        public Spirit(float health, string name, float damage, float ectoplasm)
        {
            _health = health;
            _name = name;
            _damage = damage;
            _ectoplasmBarrier = ectoplasm;
        }
        public Spirit()
        {

        }
        public void Haunt()
        {
            //Haunt things
        }
        public void Reincarnate()
        {
            //Reset health
        }
        public virtual void Cry()
        {
            //Cry about dying
            Console.WriteLine("You cry uncontrollably over your own death, how narcissitic");
        }
        public string GetName()
        {
            return _name;
        }
    }
}
