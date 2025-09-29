using UnityEngine;

public class MoveGameObject : MonoBehaviour, IMovement
{
    [SerializeField]
    private RayCastCheckGround _rayCastCheckGround;

    private const string _horizontal = "Horizontal";
    [SerializeField]
    private bool _isGround;
    [SerializeField]
    private bool _facingRight = true;

    public void Move(float speed, Rigidbody2D body)
    {
        var axisX = Vector2.right * speed;
        float horizontalMove = Input.GetAxis(_horizontal);

        if (_facingRight == false && horizontalMove > 0)
        {
            Flip();
        }
        else if (_facingRight == true && horizontalMove < 0)
        {
            Flip();
        }

        body.MovePosition(body.position + (axisX * horizontalMove * Time.fixedDeltaTime));

        Debug.Log("Move");
    }

    public void Jump(AnimationCurve height, AnimationCurve time, Transform jump,
        float duration, float expriedTime, float heightFloat)
    {
        _isGround = _rayCastCheckGround.GroundCheck();

        if (_isGround == true)
        {
            expriedTime += Time.deltaTime;

            if (expriedTime > duration)
            {
                expriedTime = 0;
            }
            float progress = expriedTime / duration;
            transform.position = new Vector2(transform.position.x, transform.position.y + height.Evaluate(progress) * heightFloat);

            Debug.Log("Jump");
        }
    }

    public void Flip()
    {
        _facingRight = !_facingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
