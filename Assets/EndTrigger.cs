using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
