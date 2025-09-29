using System;
using UnityEngine;

public class ClientMove : MonoBehaviour
{
    [Range(1, 100)]
    [SerializeField]
    private float _speedMove;
    [SerializeField]
    private AnimationCurve _heightJumpAnimation;
    [SerializeField]
    private AnimationCurve _timeJumpAnimation;

    [SerializeField]
    private Transform _jump;
    [SerializeField]
    private float _duration;
    [SerializeField]
    private float _height;
    [SerializeField]
    private float _expriedTime;

    [SerializeField]
    private Rigidbody2D _body;

    private IMovement _iMove;

    [SerializeField]
    private GameObject _playerObject;

    private void OnEnable()
    {
        EventBus.Instance.Value.OnMethodMovePlayer += MethodMovePlayer;
        EventBus.Instance.Value.OnMethodJumpPlayer += MethodJumpPlayer;
    }

    private void OnDisable()
    {
        EventBus.Instance.Value.OnMethodMovePlayer -= MethodMovePlayer;
        EventBus.Instance.Value.OnMethodJumpPlayer -= MethodJumpPlayer;
    }

    private void Start()
    {
        _iMove = _playerObject.GetComponent<IMovement>();
    }

    public void MethodMovePlayer()
    {
        _iMove.Move(_speedMove, _body);
    }

    public void MethodJumpPlayer()
    {
        _iMove.Jump(_heightJumpAnimation, _timeJumpAnimation, _jump,
            _duration, _expriedTime, _height);
    }
}
