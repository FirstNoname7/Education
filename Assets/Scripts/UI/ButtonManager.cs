using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Core;

public class ButtonManager : MonoBehaviour
{
    public int index; //�� ����� ����� ���������, � ������
    private Button button;

    void Start()
    {
        if (FindObjectsOfType<Button>().Length != 0)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(ChangeScene);
        }
    }


    public void ChangeScene() //�������� �� ������ ��� �������� �� ����� � �����
    {
        SceneManager.LoadScene(index);
    }

}
