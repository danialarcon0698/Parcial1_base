using System;

namespace Parcial1_logic.OOP
{
    public class NPC : ICharacter
    {
        public MovementType Move(MovementType _movType)
        {
            _movType = MovementType.Waypoint;
            Console.Write("Me muevo a través de "+ _movType.ToString());
            return _movType;
        }
    }
}