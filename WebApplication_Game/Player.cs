using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


namespace WebApplication_Game
{
    public class Player
    {
        #region
        public string Name { get; } = "";
        private double hp;
        public double HP
        {
            get { return hp; }
            set
            {
                if (value <= 0)
                {
                    hp = 0;
                    Dead();
                }
                else
                    hp = value;
            }
        }
        
        public int Attack_power { get; set; }
        public int Deffence_power { get; set; }
        public int Recover_power { get; set; }
        public string StatusMessage { get; set; } = "";
        public bool IsDead { get; private set; } = false;
        #endregion
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Player(string name,int hp, int ap, int dp,int rp)
        {
            this.Name = name;
            this.HP = hp;
            this.Attack_power = ap;
            this.Deffence_power = dp;
            this.Recover_power = rp;
        }
        #region メソッド
        public string Attack(Player aite)
        {
            StringBuilder sb = new StringBuilder();
            int damage = CalcDamage(aite);
            aite.Damage(damage);
            sb.AppendLine($"{this.Name}が{aite.Name}に攻撃した。");
            sb.AppendLine($"{aite.Name}は{damage}のダメージをくらった。");
            return sb.ToString();
        }
        public int CalcDamage(Player aite)
        {
            return this.Attack_power - aite.Deffence_power;
        }
        public void Damage(int damage) => this.HP -= damage;
        
        public string Recover()
        {
            StringBuilder sb = new StringBuilder();
            RecoverHP();
            sb.AppendLine($"{this.Name}は{this.Recover_power}回復した。");
            return sb.ToString();
        }
        public void RecoverHP() => this.HP += this.Recover_power;

        public void Dead()
        {
            this.IsDead = true;
            this.StatusMessage = $"{this.Name}は力尽きた。";
        }
        #endregion
    }
}