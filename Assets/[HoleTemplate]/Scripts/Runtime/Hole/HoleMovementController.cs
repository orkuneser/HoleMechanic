using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMovementController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Vector3 _moveVector;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Move();
        }
    }

    private void Move()
    {
        _moveVector = Vector3.zero;
        _moveVector.x = InputManager.Instance.InputDirection.x;
        _moveVector.z = InputManager.Instance.InputDirection.y;

        transform.position = transform.position + _moveVector * _movementSpeed * Time.deltaTime;
    }
}
