using UnityEngine;

public class DeadZona : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EventBus.Instance.Value.OnTouchDeadZona?.Invoke();
        Destroy(collision.gameObject);
    }
}
