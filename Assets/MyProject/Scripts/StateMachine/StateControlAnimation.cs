using UnityEngine;

public class StateControlAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private const string _idle = "isIdle";
    private const string _attack = "isAttack";
    private const string _dead = "isDead";
    private const string _jump = "isJump";
    private const string _run = "isRun";

    private void OnEnable()
    {
        EventBus.Instance.Value.OnIdle += ActiveIdleState;
        EventBus.Instance.Value.OnAttacked += ActiveAttackState;
        EventBus.Instance.Value.OnJumped += ActiveJumpState;
        EventBus.Instance.Value.OnRan += ActiveMoveState;
        EventBus.Instance.Value.OnDied += ActiveDeadState;
    }

    private void OnDisable()
    {
        EventBus.Instance.Value.OnIdle -= ActiveIdleState;
        EventBus.Instance.Value.OnAttacked -= ActiveAttackState;
        EventBus.Instance.Value.OnJumped -= ActiveJumpState;
        EventBus.Instance.Value.OnRan -= ActiveMoveState;
        EventBus.Instance.Value.OnDied -= ActiveDeadState;
    }

    public void ActiveIdleState()
    {
        _animator.SetBool(_idle, true);
        _animator.SetBool(_attack, false);
        _animator.SetBool(_dead, false);
        _animator.SetBool(_jump, false);
        _animator.SetBool(_run, false);
    }

    public void ActiveMoveState()
    {
        _animator.SetBool(_idle, false);
        _animator.SetBool(_attack, false);
        _animator.SetBool(_dead, false);
        _animator.SetBool(_jump, false);
        _animator.SetBool(_run, true);
    }

    public void ActiveJumpState()
    {
        _animator.SetBool(_idle, false);
        _animator.SetBool(_attack, false);
        _animator.SetBool(_dead, false);
        _animator.SetBool(_jump, true);
        _animator.SetBool(_run, false);
    }

    public void ActiveDeadState()
    {
        _animator.SetBool(_idle, false);
        _animator.SetBool(_attack, false);
        _animator.SetBool(_dead, true);
        _animator.SetBool(_jump, false);
        _animator.SetBool(_run, false);
    }

    public void ActiveAttackState()
    {
        _animator.SetBool(_idle, false);
        _animator.SetBool(_attack, true);
        _animator.SetBool(_dead, false);
        _animator.SetBool(_jump, false);
        _animator.SetBool(_run, false);
    }
}
