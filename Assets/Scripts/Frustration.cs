using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Frustration : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private TMP_Text score;

    [SerializeField] private float barSize;
    [SerializeField] private float attemptCount;

    void OnEnable()
    {
        AlienResponse.frustrationChange += UpdateFrustration; 
    }

    void OnDisable()
    {
        AlienResponse.frustrationChange -= UpdateFrustration;
    }

    private void Update()
    {
        bar.rectTransform.localScale = new Vector3(barSize, bar.rectTransform.localScale.y);

        if(barSize <= 0f)
        {
            barSize = 0f;
        }

        score.text = attemptCount + "/10";

        if(barSize >= 1f)
        {
            SceneManager.LoadScene(2);
        }

        if (attemptCount == 10f)
        {
            SceneManager.LoadScene(1);
        }
    }


    void UpdateFrustration(float value)
    {
        barSize += value;
        attemptCount++;
    }
}
