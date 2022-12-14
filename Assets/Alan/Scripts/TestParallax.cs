using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParallax : MonoBehaviour
{
    // Reference for camera in scene
    public Camera sceneCamera;

    // Reference for player (Subject)
    public Transform player;

    Vector2 startPosition;
    float startZ;

    // Distance that camera has moved from the original position of the sprite
    Vector2 travel => (Vector2)sceneCamera.transform.position - startPosition;

    float distanceFromSubject => transform.position.z - player.position.z;
    float clippingPlane => (sceneCamera.transform.position.z + (distanceFromSubject > 0 ? sceneCamera.farClipPlane : sceneCamera.nearClipPlane));

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
