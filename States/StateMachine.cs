namespace Backend.States
{
    public class StateMachine
    {
        BaseState CurrentState;

        public void Initialize(BaseState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void ChangeState(BaseState newState)
        {
            CurrentState.Exit();

            CurrentState = newState;
            newState.Enter();
        }
    }
}