using _2DGameFramework.Enum;
using _2DGameFramework.State;

namespace _2DGameFramework.Interface
{
    public interface IState
    {
        Move NextMove(InputType input);
    }
    
}
