using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void PlayGame () {
        SceneManager.LoadScene("Game");
    }
    
}
