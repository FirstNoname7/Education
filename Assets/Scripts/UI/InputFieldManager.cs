using Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputFieldManager : MonoBehaviour
{
    private TMP_InputField _inputField;
    public TMP_InputField InputField => _inputField;
    private void Start()
    {
        if (FindObjectsOfType<TMP_InputField>().Length != 0) //если на сцене есть хотя бы одно поле для ввода, то:
        {
            //_inputField = GameObject.FindGameObjectWithTag("InputName").GetComponent<TMP_InputField>(); //инициализируем переменную
            _inputField = GetComponent<TMP_InputField>();
            _inputField.onEndEdit.AddListener(NameInputField);
        }
    }
    private void NameInputField(string currentInput)
    {
        foreach (var key in GameManager.instance.ProgressPupil.Keys)
        {
            if (currentInput == key)
            {
                Debug.Log("Да, такое имя есть, проходи");
                GameManager.instance.namePlayer = currentInput;
                SceneManager.LoadScene(1);
            }
            else
            {
                Debug.Log("Ты не пройдешь!");
            }

        }
    }

}
