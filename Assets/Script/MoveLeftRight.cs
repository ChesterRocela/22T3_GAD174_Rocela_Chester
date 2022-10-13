using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ChesterRocela
{
    public class MoveLeftRight : MonoBehaviour
    {
        Rigidbody rb;
        public float moveSpeed;
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            moveSpeed = 5f;
        }
        public void moveLeft()
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
        public void MoveRight()
        {
            rb.velocity = Vector2.right * --moveSpeed;
        }
        public void stopMoving()
        {
            rb.velocity = Vector2.zero;
        }
    }
}