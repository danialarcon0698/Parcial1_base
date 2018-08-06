namespace Parcial1_logic.OOP
{
    public class Weapon : Gear
    {
        private float weaponPercent;

        public Weapon(float _porcent)
        {
            weaponPercent = _porcent;
            ParamMod();
        }

        private float ParamMod()
        {
            BaseDef = BaseDef * weaponPercent;
            return BaseDef;
        }
    }

}
}