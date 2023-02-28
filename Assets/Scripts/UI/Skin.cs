using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Core;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skin : MonoBehaviour, IPointerClickHandler
{
    private Image _spriteRenderer;
    public void OnPointerClick(PointerEventData eventData)
    {
        _spriteRenderer = GetComponent<Image>();
        GameManager.instance.currentSprite = _spriteRenderer.sprite;
        SceneManager.LoadScene(1);
    }
}
