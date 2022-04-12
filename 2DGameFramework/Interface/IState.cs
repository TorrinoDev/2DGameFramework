namespace _2DGameFramework.Interface
{
    public interface IState
    {
        Move NextMove(InputType input);
    }

    public enum CreatureHeadingStatesType
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public enum InputType
    {
        FORWARD,
        BACKWARD,
        LEFT,
        RIGHT
    }

    public record Move(int row, int col);
}
