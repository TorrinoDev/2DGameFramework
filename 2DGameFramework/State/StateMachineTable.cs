using _2DGameFramework.Enum;
using _2DGameFramework.Interface;

namespace _2DGameFramework.State
{
    class StateAction
    {
        public CreatureHeadingStatesType HeadingState { get; set; } //Next state
        public CreatureHeadingStatesType Action { get; set; } // Direction the creature should move
    }

    public class StateMachineTable : IState
    {
        private StateAction[,] stateMachine;
        private CreatureHeadingStatesType currentHeadingState;

        public StateMachineTable()
        {
            currentHeadingState = CreatureHeadingStatesType.NORTH;

            //Initialize table
            stateMachine = new StateAction[4, 3];
            stateMachine[(int)CreatureHeadingStatesType.NORTH, (int)InputType.FORWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.NORTH, Action = CreatureHeadingStatesType.NORTH };
            stateMachine[(int)CreatureHeadingStatesType.NORTH, (int)InputType.BACKWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.SOUTH, Action = CreatureHeadingStatesType.SOUTH };
            stateMachine[(int)CreatureHeadingStatesType.NORTH, (int)InputType.LEFT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.WEST, Action = CreatureHeadingStatesType.WEST };
            stateMachine[(int)CreatureHeadingStatesType.NORTH, (int)InputType.RIGHT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.EAST, Action = CreatureHeadingStatesType.EAST };

            stateMachine[(int)CreatureHeadingStatesType.SOUTH, (int)InputType.FORWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.SOUTH, Action = CreatureHeadingStatesType.SOUTH };
            stateMachine[(int)CreatureHeadingStatesType.SOUTH, (int)InputType.BACKWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.NORTH, Action = CreatureHeadingStatesType.NORTH };
            stateMachine[(int)CreatureHeadingStatesType.SOUTH, (int)InputType.LEFT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.EAST, Action = CreatureHeadingStatesType.EAST };
            stateMachine[(int)CreatureHeadingStatesType.SOUTH, (int)InputType.RIGHT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.WEST, Action = CreatureHeadingStatesType.WEST };

            stateMachine[(int)CreatureHeadingStatesType.EAST, (int)InputType.FORWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.EAST, Action = CreatureHeadingStatesType.EAST };
            stateMachine[(int)CreatureHeadingStatesType.EAST, (int)InputType.BACKWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.WEST, Action = CreatureHeadingStatesType.WEST };
            stateMachine[(int)CreatureHeadingStatesType.EAST, (int)InputType.LEFT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.NORTH, Action = CreatureHeadingStatesType.NORTH };
            stateMachine[(int)CreatureHeadingStatesType.EAST, (int)InputType.RIGHT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.SOUTH, Action = CreatureHeadingStatesType.SOUTH };

            stateMachine[(int)CreatureHeadingStatesType.WEST, (int)InputType.FORWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.WEST, Action = CreatureHeadingStatesType.WEST };
            stateMachine[(int)CreatureHeadingStatesType.WEST, (int)InputType.BACKWARD] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.EAST, Action = CreatureHeadingStatesType.EAST };
            stateMachine[(int)CreatureHeadingStatesType.WEST, (int)InputType.LEFT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.SOUTH, Action = CreatureHeadingStatesType.SOUTH };
            stateMachine[(int)CreatureHeadingStatesType.WEST, (int)InputType.RIGHT] = new StateAction()
                { HeadingState = CreatureHeadingStatesType.NORTH, Action = CreatureHeadingStatesType.NORTH };
        }

        public Move NextMove(InputType input)
        {
            //Find next move from current state and input
            CreatureHeadingStatesType nextMove = stateMachine[(int)currentHeadingState, (int)input].Action;

            //Find next state from current state and input
            currentHeadingState = stateMachine[(int)currentHeadingState, (int)input].HeadingState;
            return ConvertDirection2Move(nextMove);
        }

        private Move ConvertDirection2Move(CreatureHeadingStatesType nextMove)
        {
            switch (nextMove)
            {
                case CreatureHeadingStatesType.NORTH: return MoveCreature.GoNorth;
                case CreatureHeadingStatesType.SOUTH: return MoveCreature.GoSouth;
                case CreatureHeadingStatesType.EAST: return MoveCreature.GoEast;

                default: return MoveCreature.GoWest;
            }
        }
    }
}
