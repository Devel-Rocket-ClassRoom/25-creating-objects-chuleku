using System;
using System.Collections.Generic;
using System.Text;
namespace GameCharacher
{
    public class GameCharacter
    {
        public string Name;
        public string Job;
        public int Level = 1;
        public int Exp;

        public void GainExp(int amount)
        {
            Exp += amount;
            if( Exp>=100)
            {
                Level++;
                Exp -= 100;
                Console.WriteLine($"레벨 업! {Name} Lv.{Level}(EXP: {Exp}/100)");
            }
            else
            {
                Console.WriteLine($"경험치 획득! 현재 EXP: ({Exp}/100)");
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"[{Job}] {Name} - Lv.{Level} (EXP: {Exp}/100)");
        }
    }
}
