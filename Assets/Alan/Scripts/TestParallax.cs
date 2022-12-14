using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParallax : MonoBehaviour
{
    // Reference for camera in scene
    public Camera cam;

    // Reference for player (Subject)
    public Transform subject;

    Vector2 startPosition;
    float startZ;

    // Distance that camera has moved from the original position of the sprite
    Vector2 travel => (Vector2)cam.transform.position - startPosition;

    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));

    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;

    // Vector2 parallaxFactor;

    public void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    public void Update()
    {
        Vector2 newPos = startPosition + travel * parallaxFactor;
        transform.position = new Vector3(newPos.x, newPos.y, startZ);
    }
}
