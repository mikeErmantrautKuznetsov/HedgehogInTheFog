using UnityEngine;

[ExecuteInEditMode]
public class DrawPointGizmos : MonoBehaviour
{
    [SerializeField]
    private float _radius;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
