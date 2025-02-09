using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int SkillCount = 0;

    public GameObject MainPanel;
    public GameObject StrenghtPanel;

    private void Start()
    {
        SkillCount = 1;
    }
    public void OnPointerClick()
    {
        if(SkillCount != 0)
        {
            Debug.Log("Strenght Increased");
            SkillCount--;
        }
        else
        {
            Debug.Log("No skill Point");
        }
    }
    public void StrenghtAccessMenu()
    {
        StrenghtPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void BackToMainPanel()
    {
        StrenghtPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
}
