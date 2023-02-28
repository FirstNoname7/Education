using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepads : MonoBehaviour
{
    [SerializeField] private GameObject gamepad;
    [SerializeField] private GameObject content;
    void Start()
    {
        SpawnerGamepads(GameManager.instance.MaxCountLevel);
        content = GameObject.Find("Content");
    }

    private void SpawnerGamepads(int countGamepads)
    {
        for (int i = 0; i < countGamepads; i++)
        {
            //gamepad.SetParent(content);
            Instantiate(gamepad, content.transform.position + new Vector3(i * 2.2f, i * 1.2f, 0), transform.rotation);
        }
    }
}
