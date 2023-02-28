using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttribute : MonoBehaviour
{
    [field: TextArea()] public string Name { get; set; }
}
