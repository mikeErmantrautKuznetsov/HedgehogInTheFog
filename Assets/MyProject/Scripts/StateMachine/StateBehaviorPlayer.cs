using UnityEngine;

public class StateBehaviorPlayer : MonoBehaviour, IStateMachine
{
    [SerializeField]
    private StateControlAnimation _stateControlAnimation;
    [SerializeField]
    private ClientMove _clientMove;

    public void Attack()
    {
        EventBus.Instance.Value.OnAttacked?.Invoke();
        _stateControlAnimation.ActiveAttackState();
    }

    public void Dead()
    {
        EventBus.Instance.Value.OnDied?.Invoke();
        _stateControlAnimation.ActiveDeadState();
    }

    public void Idle()
    {
        EventBus.Instance.Value.OnIdle?.Invoke();
        _stateControlAnimation.ActiveIdleState();
    }

    public void Jump()
    {
        EventBus.Instance.Value.OnJumped?.Invoke();
        EventBus.Instance.Value.OnMethodJumpPlayer?.Invoke();
        _clientMove.MethodJumpPlayer();
        _stateControlAnimation.ActiveJumpState();
    }

    public void Movement()
    {
        EventBus.Instance.Value.OnRan?.Invoke();
        EventBus.Instance.Value.OnMethodMovePlayer?.Invoke();
        _clientMove.MethodMovePlayer();
        _stateControlAnimation.ActiveMoveState();
    }
}
