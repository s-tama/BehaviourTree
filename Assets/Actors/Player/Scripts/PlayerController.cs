//
// PlayerController.cs
//

using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float _moveSpeed;
    public float _rotateSpeed;

    private Rigidbody _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 position = _rigidbody.position;
        Vector3 angle = _rigidbody.angularVelocity;

        float movememt = Input.GetAxis("Vertical") * _moveSpeed;
        position += transform.forward * movememt * Time.deltaTime;

        angle.y = Input.GetAxis("Horizontal") * _rotateSpeed;

        _rigidbody.angularVelocity = angle;
        _rigidbody.MovePosition(position);
    }
}
