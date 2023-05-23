using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject restartButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        //Time.timeScale = 1;
        restartButton.SetActive(false);
    }
}
