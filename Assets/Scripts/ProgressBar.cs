using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public Image mask;
    public GameObject LevelCompleted;

    void Start() 
    {
        maximum = 1;
    }

    void Update()
    {
        getCurrentFill();
    }

    void getCurrentFill() 
    {
        float fillAmount = Time.timeSinceLevelLoad/40;
        mask.fillAmount = fillAmount;
        if (fillAmount >= maximum) 
        {
            Debug.Log("levelcompleted");
            FindObjectOfType<LevelDone>().CompleteLevel();
            
        }
    }
}
