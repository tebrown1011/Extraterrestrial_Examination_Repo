using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartDialogue : MonoBehaviour
{
    public bool startExamination;
    [SerializeField] private GameObject pressSpace;

    private void Start()
    {
        startExamination = false;
        pressSpace.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            pressSpace.SetActive(true);
            startExamination = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pressSpace.SetActive(false);
            startExamination = false;
        }
    }
}
