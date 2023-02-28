using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class Character : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image _image;
    public Sprite _sprite;
    [SerializeField] private GameObject[] currentGamepad;
    int[,] limits = { {0, 12}, {12, 24}, { 24, 36 }, { 36, 48}, { 48, 60}, { 60, 72}, { 72, 84},
        { 84, 96}, { 96, 108}, { 108, 120}, { 120, 132}, { 132, 144}, { 144, 156}, { 156, 168}, { 168, 180}, { 180, 192}, { 192, 204},
    { 204, 216}, { 216, 228}, { 228, 240}, { 240, 252}, { 252, 264}, { 264, 276}, { 276, 288}, { 288, 300},
    { 300, 312} };
    //https://www.pngmart.com/image/509039
    public void GetSpriteOfWardrobe()
    {
        _sprite = GameManager.instance.currentSprite;
    }

    private void Awake()
    {
        _image = GetComponent<Image>();
        GetSpriteOfWardrobe();
        if (_sprite != null)
        {
            _image.sprite = _sprite; //тут надо заменять спрайт исходя из того, что игрок выбрал в гардеробе (сравнение с CharacterType над сделать)
        }
    }
    
    private void Start()
    {
        SetSkin();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log(GameManager.instance.ProgressPupil[GameManager.instance.namePlayer]);
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log(" Выход курсора ");
    }
    void SetSkin()
    {
        Dictionary<string, int> currentDictionary = GameManager.instance.ProgressPupil; //ссылка на словарь
        string currentKey = GameManager.instance.namePlayer; //то, что ввел игрок (текущий ключ словаря)
        if (currentDictionary.ContainsKey(currentKey)) //если в словаре есть ключ currentKey, то:
        {
            //тут надо найти значение введенного ключа и исходя из него двигать перса на нужный геймпад
            //Debug.Log(currentKey);
            int currentValue = currentDictionary[currentKey]; //нахожу значение текущего ключа, т.е. кол-во баллов
            //Debug.Log(currentValue);

            for (int i = 0; i < limits.GetLength(0); i++)
            {
                if (currentValue >= (int)limits.GetValue(i, 0) && currentValue <= (int)limits.GetValue(i, 1)) //GetValue(индекс вложенного массива, индекс элемента во вложенном массиве)
                {
                    transform.SetParent(currentGamepad[i].transform);
                    break;
                }
            }

            if (currentValue <= 144)
            {
                GameManager.instance.CurrentLevels(0);
            }
            if (currentValue >= 144 && currentValue <= 432)
            {
                GameManager.instance.CurrentLevels(1);
            }

            //if(Mathf.Clamp(currentValue, currentValue - 10, currentValue))
        }

    }
}
