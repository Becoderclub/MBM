using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float _speed;
    private Animator _animator;
    private Vector2 _movement;
    private Rigidbody2D _rigidbody;
    void Start() 
    {
       _speed = 5f;
       _animator = GetComponent<Animator>();
       _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        AnimateMovement();
    }
    private void FixedUpdate() 
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * _speed * Time.fixedDeltaTime);    
    }
    public void AnimateMovement()
    {
         _animator.SetFloat("x", _movement.x);
         _animator.SetFloat("y", _movement.y);
         _animator.SetFloat("Speed", _movement.sqrMagnitude);
    }
}
