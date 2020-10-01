using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Text scoreText;
    
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");//Showing numbers in whole number.
    }
}
