using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Core;

public class TextController : MonoBehaviour
{
    private TMP_Text _text;
    void Start()
    {
        _text = GetComponent<TMP_Text>();
        string currentKey = GameManager.instance.namePlayer;
        _text.text = currentKey;
        GameObject character = GameObject.Find("Character");
        gameObject.transform.SetParent(character.transform);
    }
}
