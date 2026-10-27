using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace пр8_Данилова.Classes
{
    public class Voin
    {
        public int Health { get; set; }

        public Voin(int health) {
            Health = health;
        }
        public virtual void TakeDamage(int damage) 
        { 
            Health -= damage;
            if(Health < 0) Health = 0;
        }
    }
    public class LVoin : Voin 
    {
        public LVoin() : base(100) { }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }
    }
    public class TVoin : Voin
    {
        public TVoin() : base(150) { }
        public override void TakeDamage(int damage)
        {
            int reducedDamage = (int)(damage * 0.5);
            base.TakeDamage(reducedDamage);
        }
    }
}
