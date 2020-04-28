using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed;
    private Animator _animator;
    private Vector2 _movement;
    private Vector2 _destination;
    private bool _isMoving;
    private float _cellSize;
    private static float _idleStateX;
    private static float _idleStateY;
    void Start() 
    {
       _speed = 5f;
       _animator = GetComponent<Animator>();
       _destination = transform.position;
       _isMoving = false;
       _cellSize = 1f;
    }
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");


        AnimateMovement();
    }
    private void FixedUpdate() 
    {
        if(_isMoving == true)
        {
            float step = _speed * Time.fixedDeltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _destination, step);
            if(transform.position == (Vector3)_destination)
            {
                _isMoving = false;
            }
        }
        else
        {
            if(_movement.y > 0)
            {
                _destination = transform.position + Vector3.up * _cellSize;
                _idleStateY = _movement.y;
                _idleStateX = 0;
                _isMoving = true;
            }
            else if(_movement.y < 0)
            {
                _destination = transform.position + Vector3.down * _cellSize;
                _idleStateY = _movement.y;
                _idleStateX = 0;
                _isMoving = true;
            }
            else if(_movement.x > 0)
            {
                _destination = transform.position + Vector3.right * _cellSize;
                _idleStateX = _movement.x;
                _idleStateY = 0;
                _isMoving = true;
            }
            else if(_movement.x < 0)
            {
                _destination = transform.position + Vector3.left * _cellSize;
                _idleStateX = _movement.x;
                _idleStateY = 0;
                _isMoving = true;
            }
        }     
    }
    public void AnimateMovement()
    {
        _animator.SetFloat("x", _movement.x);
        _animator.SetFloat("y", _movement.y);
        _animator.SetFloat("Speed", _movement.sqrMagnitude);

        _animator.SetFloat("idleStateX", _idleStateX);
        _animator.SetFloat("idleStateY", _idleStateY);
    }
}
