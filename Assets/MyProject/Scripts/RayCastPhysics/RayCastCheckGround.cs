using UnityEngine;

public class RayCastCheckGround : MonoBehaviour
{
    public LayerMask LayerMask;

    [SerializeField]
    private float _durationLong;
    private const string _isGround = "Ground";

    public bool GroundCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, _durationLong, LayerMask);
        DrawRayCast();
        Debug.Log($"Ray hit: {hit.collider.gameObject.name}!!");

        if (hit.collider.gameObject.layer != LayerMask)
        {
            Debug.Log($"Return result: {_isGround}!!");
            return true;
        }
        Debug.Log($"Return result: {_isGround}!!");
        return false;
    }

    public void DrawRayCast()
    {
        Debug.DrawRay(transform.position, -transform.up, Color.red, _durationLong);
    }
}
