using UnityEngine;

public class MoveGameObject : MonoBehaviour, IMovement
{
    [SerializeField]
    private RayCastCheckGround _rayCastCheckGround;

    private const string _horizontal = "Horizontal";
    [SerializeField]
    private bool _isGround;

    public void Move(float speed, Rigidbody2D _body)
    {
        var axisX = Vector2.right * speed;
        float horizontalMove = Input.GetAxis(_horizontal);

        _body.MovePosition(_body.position + (axisX * horizontalMove * Time.fixedDeltaTime));

        Debug.Log("Move");
    }

    public void Jump(float height, Rigidbody2D _body)
    {
        _isGround = _rayCastCheckGround.GroundCheck();

        if(Input.GetKey(KeyCode.Space) && _isGround == true)
        {
            _body.AddForce(new Vector2(_body.transform.position.x, 
                _body.transform.position.y + (height * height * Time.fixedDeltaTime)));
            Debug.Log("Jump");
        }
    }
}
