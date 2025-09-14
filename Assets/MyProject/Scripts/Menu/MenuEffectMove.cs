using UnityEngine;

public class MenuEffectMove : MonoBehaviour
{
    [SerializeField]
    private Transform _menuScene;
    [SerializeField]
    private float _menuPositionLeft;

    [SerializeField]
    private float _speed;

    private void Update()
    {
        MoveBackground();
        CheckPositionBackground();
    }

    private void CheckPositionBackground()
    {
        if (_menuScene.transform.position.x <= -_menuPositionLeft)
        {
            _menuScene.transform.position = new Vector2(0, _menuScene.transform.position.y);
        }
    }

    private void MoveBackground()
    {
        _menuScene.transform.Translate(-transform.right * _speed * Time.deltaTime);
    }
}
