using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiePlayerFind : MonoBehaviour
{
    [SerializeField] private Transform player;
    private bool isPlayerClose;
    private Transform selfTransform;
    private void Start()
    {
        selfTransform = transform;
    }
    private void Update()
    {
        if(Mathf.Abs(selfTransform.position.x - player.transform.position.x) + Mathf.Abs(selfTransform.position.y - player.transform.position.y) < 10)
        {
            isPlayerClose = true;
        }
        else
        {
            isPlayerClose = false;
        }
        if (isPlayerClose)
        {

        }
    }
}
