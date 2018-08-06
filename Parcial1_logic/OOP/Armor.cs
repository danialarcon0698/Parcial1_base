namespace Parcial1_logic.OOP
{
    public class Armor : Gear
    {
        private float armorPercent;

        public Armor(float _porcent) {
            armorPercent = _porcent;
            ParamMod();
        }

        private float ParamMod() {
            BaseDef = BaseDef * armorPercent ;
            return BaseDef;
        }
    }
}