using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _camera;
    void Start()
    {
        _camera = GetComponent<Transform>();
        GameObject character = GameObject.Find("Character");
        _camera.position = character.transform.position;
    }
}
