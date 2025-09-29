public interface IStateMachine 
{
    public void Idle();

    public void Attack();

    public void Movement();

    public void Jump();

    public void Dead();
}
