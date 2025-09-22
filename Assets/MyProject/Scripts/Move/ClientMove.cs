using System;
using UnityEngine;

public class ClientMove : MonoBehaviour
{
    [Range(1, 100)]
    [SerializeField]
    private float _speedMove;
    [Range(1, 5000)]
    [SerializeField]
    private float _heightJump;

    [SerializeField]
    private Rigidbody2D _body;

    private IMovement _iMove;

    [SerializeField]
    private GameObject _gameObject;

    private void Start()
    {
        _iMove = _gameObject.GetComponent<IMovement>();
    }

    private void FixedUpdate()
    {
        _iMove.Move(_speedMove, _body);
        _iMove.Jump(_heightJump, _body);
    }
}
