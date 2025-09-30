using UnityEngine;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private BootsStrap _bootsStrap;

    private void OnEnable()
    {
        EventBus.Instance.Value.OnTouchDeadZona += FellDeadZona;
    }

    private void OnDisable()
    {
        EventBus.Instance.Value.OnTouchDeadZona -= FellDeadZona;
    }

    public void FellDeadZona()
    {
        _bootsStrap.Spawn();
        Debug.Log("ActiveDeadZona");
    }
}
