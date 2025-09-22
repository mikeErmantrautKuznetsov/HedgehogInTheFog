using UnityEngine;

public interface IMovement 
{
    public void Move(float speed, Rigidbody2D _body);

    public void Jump(float height, Rigidbody2D _body);
}
