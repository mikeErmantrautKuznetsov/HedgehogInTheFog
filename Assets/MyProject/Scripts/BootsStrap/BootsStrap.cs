using UnityEngine;

public class BootsStrap : MonoBehaviour
{
    [SerializeField]
    private Transform[] _transform;

    private AbstractionFactory _factory;
    [SerializeField]
    private InputActionPlayer _inputActionPlayer;

    private void OnEnable()
    {
        EventBus.Instance.Value.OnDesktop += OnMoveDesktopPlayer;
        EventBus.Instance.Value.OnMobile += OnMoveMobilePlayer;
    }

    private void OnDisable()
    {
        EventBus.Instance.Value.OnDesktop -= OnMoveDesktopPlayer;
        EventBus.Instance.Value.OnMobile -= OnMoveMobilePlayer;
    }

    private void Start()
    {
        Spawn();
    }

    private void FixedUpdate()
    {
        OnMoveDesktopPlayer();
        OnMoveMobilePlayer();
    }

    private void Spawn()
    {
        foreach (var item in _transform)
        {
            _factory = new Factory(item);
            _factory.CreateGameObjects(item.position);
        }
    }

    public void OnMoveDesktopPlayer()
    {
        _inputActionPlayer.DesktopInput();
    }

    public void OnMoveMobilePlayer()
    {
        _inputActionPlayer.MobileInput();
    }
}
