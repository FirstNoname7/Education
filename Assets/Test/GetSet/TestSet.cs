using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSet : MonoBehaviour
{
    private int pelmeni = 0; //дефолтное значение переменной
    public int Pelmeni //поле дл€ возврата переменной и еЄ настройки
    {
        get => pelmeni; //возвращаем значение переменной pelmeni
        set
        {
            pelmeni = value; //настраиваем значение переменной на то, которое укажешь в переменной Pelmeni
            if(pelmeni == 0) //если значение в переменной Pelmeni = 0, то:
            {
                NoPelmeni(); //идЄм на дебаг "нет пельменей"
            }
            else //в обратном случае
            {
                HasPelmeni(); //идЄм на дебаг "есть пельмени"
            }
        }
    }

    private void Start()
    {
        Pelmeni = 5; //сюда ставишь любое число дл€ дебага
    }

    private void NoPelmeni()
    {
        Debug.Log("Ќету пельменей");
    }
    private void HasPelmeni()
    {
        Debug.Log("≈сть пельмени");
    }


}
