using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ButtonEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("ClickPress!");
    }

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("NewScale");
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("NewExit");
    }
}
