using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class sceneStart : MonoBehaviour
{
    public void ButtClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
