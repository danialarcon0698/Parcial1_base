using System;

namespace Parcial1_logic.OOP
{
    public class Hero : Actor, ICharacter
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor {
            get;
            protected set;            
        }


        Gear armor1;

        float modWep;
        float modArmor;
        
        public float GetCurrentAtk {
            get {
                float modWepF;
                modWepF = BaseAtk * modWep;
                return modWepF;
            }
        }

        public float GetCurrentDef {
            get {
                float modArmorF;
                modArmorF = BaseDef * modArmor;
                return modArmorF;
            }
        }
        public Hero(float _atkHero, float _defHero)
        {
            BaseAtk = _atkHero;
            BaseDef = _defHero;

            armor1 = new Armor(modArmor);

            if (modArmor > 1)
            {
                modArmor = 1;
            }
            if (modArmor < 0) {
                modArmor = 0;
            }
        }

        public void Equip(Gear _equip) {
            if (_equip is Weapon)
            {
                _equip = CurrentWeapon;
            }
            else {
                _equip = CurrentArmor;
            }
        }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public MovementType Move(MovementType _movType)
        {
            _movType = MovementType.Input;
            Console.Write("Me muevo a través de "+ _movType.ToString());
            return _movType;
        }
    }
}