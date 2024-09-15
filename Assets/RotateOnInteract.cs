using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEditor;

public class RotateOnInteract : MonoBehaviour
{
    public GameObject button;
    public GameObject anchorObject;
    public float speed;

    private bool isClockwise = true;
    private bool shouldRotate = false;  

    private void Update()
    {
        if (shouldRotate)
        {
            RotateAround();
        }
    }

    public void RotateAround()
    {
        float rotationDirection = isClockwise ? 1f : -1f;
        button.transform.RotateAround(anchorObject.transform.position, Vector3.forward, rotationDirection * speed * Time.deltaTime);
    }

    public void OnClick()
    {
        shouldRotate = true;
        isClockwise = !isClockwise;
    }
}
