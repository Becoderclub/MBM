using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float _speed;
    private Animator _animator;
    private Vector2 _movement;
    private Vector2 _destination;
    void Start() 
    {
       _speed = 5f;
       _animator = GetComponent<Animator>();
       _destination = transform.position;
    }
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        _destination = transform.position + (Vector3)_movement;

        AnimateMovement();
    }
    private void FixedUpdate() 
    {
        transform.position = Vector3.MoveTowards(transform.position, _destination, _speed * Time.fixedDeltaTime);    
    }
    public void AnimateMovement()
    {
        _animator.SetFloat("x", _movement.x);
        _animator.SetFloat("y", _movement.y);
        _animator.SetFloat("Speed", _movement.sqrMagnitude);
    }
}
