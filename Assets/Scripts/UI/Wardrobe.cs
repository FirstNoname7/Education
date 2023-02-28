using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class Wardrobe : MonoBehaviour
{
    private Transform[] allSkines;
    private TMP_Text title;
    private Transform parentForSkins;
    private List<GameObject> currentSkins = new List<GameObject>();
    private void Awake()
    {
        allSkines = GetComponentsInChildren<Transform>();
        title = GameObject.FindGameObjectWithTag("Title").GetComponent<TMP_Text>();
        parentForSkins = GameObject.FindGameObjectWithTag("ParentSkins").GetComponent<Transform>();
        foreach (var skin in allSkines)
        {
            allSkines.Append(skin);
        }
        CurrentTitle();
    }

    void CurrentTitle()
    {
        title.text = "����� ��� ������ " + GameManager.instance.CurrentLevelName;

        //��������� ����� ������ �� �������� ������
        for (int i = 0; i < GameManager.instance.CurrentSkins; i++)
        {
            currentSkins.Add(allSkines[i].gameObject);
        }

        //������� ����� �� �����
        for (int i = 0; i < currentSkins.Count; i++)
        {
            currentSkins[i].transform.SetParent(parentForSkins);
        }
    }
}
