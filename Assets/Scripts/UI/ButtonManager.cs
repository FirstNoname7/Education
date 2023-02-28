using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Core;

public class ButtonManager : MonoBehaviour
{
    public int index; //на какую сцену переходим, её индекс
    private Button button;

    void Start()
    {
        if (FindObjectsOfType<Button>().Length != 0)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(ChangeScene);
        }
    }


    public void ChangeScene() //ставится на кнопки для перехода от сцены к сцене
    {
        SceneManager.LoadScene(index);
    }

}
