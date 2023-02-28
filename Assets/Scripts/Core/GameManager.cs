using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public string namePlayer;
        public Sprite currentSprite;

        private Dictionary<string, int> _progressPupil = new Dictionary<string, int>();
        private string[] _levelsNames = { "Trainee", "Junior", "Middle", "Senior" };
        private int[,] _levelsPoints = { { 4, 144 }, { 7, 432 }, { 10, 864 }, { 13, 1008 } };
        private string _currentLevelName;
        private int _currentSkins;
        private int _currentPoints;



        private int _level = 1;
        private int _maxCountCurrentLevel = 77;
        private TMP_InputField _inputField;

        public int Level => _level; //����� �� ���������� ��� ������, ���� �� ������� ������� ������ ���� ������
        public int MaxCountLevel => _maxCountCurrentLevel;
        public Dictionary<string, int> ProgressPupil => _progressPupil;
        public TMP_InputField InputField => _inputField;
        public string CurrentLevelName => _currentLevelName;
        public int CurrentSkins => _currentSkins;
        public int CurrentPoints => _currentPoints;
        public GameManager()
        {
            //_progressPupil.Add("����� ����������", 5);
            for (int i = 0; i <= 36; i++)
            {
                _progressPupil.Add($"{i}", 12*i);
            }

        }
        void Awake()
        {
            if(FindObjectsOfType<TMP_InputField>().Length != 0) //���� �� ����� ���� ���� �� ���� ���� ��� �����, ��:
            {
                _inputField = GameObject.FindGameObjectWithTag("InputName").GetComponent<TMP_InputField>(); //�������������� ����������
            }
            if (instance != null) //����, ���� ������ GameManager �� ��������� 100 ��� ��� ���������� ��������� �� ����� � �����
            {
                Destroy(gameObject); //������� ������ ���������
                return; //������������ � ������ ���, ��� �� ���������
            }
            instance = this; //���������, ��� ��� ���������� = ��������� ����� �������
            DontDestroyOnLoad(gameObject); //����������, ��� ���� ��������� ������� ������, � �������� ��������� ���� ������, ��� �������� �� ����� � �����
        }

        public void CurrentLevels(int levels)
        {
            _currentLevelName = _levelsNames[levels];
            //���������� ������ �������� ���������� ������� _levelsPoints, ����� � ��������� ���������� �������� ������� ������ ���������� + ������� �������, ����� ����� �� ���. ������� ���������
            for (int skins = 0; skins <= _levelsPoints.GetLength(0)+3*levels; skins++)
            {
                _currentSkins = skins;
                for (int points = 0; points <= _levelsPoints.GetLength(1); points++)
                {
                    _currentPoints = points;
                    //var val = _levelsPoints[skins, points];
                }
            }
        }

    }
}
