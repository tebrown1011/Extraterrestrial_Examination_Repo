using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class AlienResponse : MonoBehaviour
{
    public AlienDialogue dialogue;
    public GameObject responseHolder;
    public GameObject feedbackHolder;
    public GameObject optionsHolder;
    public GameObject DialogueManager;

    public static event Action<float> frustrationChange;

    void Start()
    {
        responseHolder = GameObject.FindGameObjectWithTag("Response");
        feedbackHolder = GameObject.FindGameObjectWithTag("Feedback");
        optionsHolder = GameObject.FindGameObjectWithTag("Options");
        DialogueManager = GameObject.FindGameObjectWithTag("Manager");


    }


    void Update()
    {

    }

    public void OptionPressed()
    {
        StartCoroutine(AlienRespond());
    }


    IEnumerator AlienRespond()
    {
        DialogueManager.GetComponent<Talking>().selectedOptions.Clear();



        optionsHolder.GetComponent<CanvasGroup>().alpha = 0;
        optionsHolder.GetComponent<CanvasGroup>().interactable = false;
        optionsHolder.GetComponent<CanvasGroup>().blocksRaycasts = false;


        responseHolder.GetComponentInChildren<TMP_Text>().text = dialogue.Response;
        responseHolder.GetComponent<CanvasGroup>().alpha = 1f;

        yield return new WaitForSeconds(2f);

        responseHolder.GetComponent<CanvasGroup>().alpha = 0f;

        frustrationChange.Invoke(dialogue.Frustration);

        feedbackHolder.GetComponent<CanvasGroup>().alpha = 1f;
        feedbackHolder.GetComponentInChildren<TMP_Text>().text = dialogue.Feedback;

    }
}
