using UnityEngine;

public class MenuEffectMove : MonoBehaviour
{
    [SerializeField]
    private Transform _menuScene;

    [Range(100f, 2000f)]
    [SerializeField]
    private float _menuPositionLeft;
    [Range(10f, 500f)]
    [SerializeField]
    private float _speed;

    private void Update()
    {
        MoveBackground();
        CheckPosition();
    }

    private void CheckPosition()
    {
        if (_menuScene.transform.position.x <= -_menuPositionLeft)
        {
            _menuScene.transform.position = PositionReturn(_menuPositionLeft, _menuScene.transform.position.y);
        }
    }

    private Vector2 PositionReturn(float startPositionAxisX, float startPositionAxisY)
    {
        return new Vector2(startPositionAxisX, startPositionAxisY);
    }

    private void MoveBackground()
    {
        _menuScene.transform.Translate(-transform.right * _speed * Time.deltaTime);
    }
}
