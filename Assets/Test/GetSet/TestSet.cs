using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSet : MonoBehaviour
{
    private int pelmeni = 0; //��������� �������� ����������
    public int Pelmeni //���� ��� �������� ���������� � � ���������
    {
        get => pelmeni; //���������� �������� ���������� pelmeni
        set
        {
            pelmeni = value; //����������� �������� ���������� �� ��, ������� ������� � ���������� Pelmeni
            if(pelmeni == 0) //���� �������� � ���������� Pelmeni = 0, ��:
            {
                NoPelmeni(); //��� �� ����� "��� ���������"
            }
            else //� �������� ������
            {
                HasPelmeni(); //��� �� ����� "���� ��������"
            }
        }
    }

    private void Start()
    {
        Pelmeni = 5; //���� ������� ����� ����� ��� ������
    }

    private void NoPelmeni()
    {
        Debug.Log("���� ���������");
    }
    private void HasPelmeni()
    {
        Debug.Log("���� ��������");
    }


}
