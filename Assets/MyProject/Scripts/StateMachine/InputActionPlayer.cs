using UnityEngine;

public class InputActionPlayer : MonoBehaviour, IInputAction
{
    [SerializeField]
    private StateBehaviorPlayer _stateBehaviorPlayer;

    public void DesktopInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _stateBehaviorPlayer.Movement();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _stateBehaviorPlayer.Jump();
        }
        else if (Input.GetMouseButton(0))
        {
            _stateBehaviorPlayer.Attack();
        }
        else
        {
            _stateBehaviorPlayer.Idle();
        }

        Debug.Log("DesktopInput");
    }

    public void MobileInput()
    {
        Debug.Log("MobileInput");
    }
}
