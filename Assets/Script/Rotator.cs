using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ChesterRocela
{
    public class Rotator : MonoBehaviour
    {
        public float rotateSpeed = 25f;
        bool isPressed;

        public void TogglePressed(bool value)
        {
            isPressed = value;
        }
        public void onClickLeft()
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        private void Update()
        {
            if (isPressed)
            {
                onClickLeft();
            }
        }
    }
}

