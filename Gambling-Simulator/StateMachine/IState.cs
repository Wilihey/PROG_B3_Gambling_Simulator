namespace Gambling_Simulator
{
    public interface IState
    {

        void Enter();

        void Update();

        void Exit();
    }
}
