using _2DGameFramework.Interface;

namespace _2DGameFramework.State
{
    public static class MoveCreature
    {
        public static Move GoNorth = new Move(-1, 0);
        public static Move GoSouth = new Move(+1, 0);
        public static Move GoEast = new Move(0, +1);
        public static Move GoWest = new Move(0, -1);
    }
}
