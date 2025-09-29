using UnityEngine;

public interface IMovement 
{
    public void Move(float speed, Rigidbody2D _body);

    public void Jump(AnimationCurve height, AnimationCurve time, Transform jump, 
        float duration, float expriedTime, float heightFloat);

    public void Flip();
}
