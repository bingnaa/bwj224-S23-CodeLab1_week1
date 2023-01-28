using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoreB;
    void Start()
    {
        scoreB.GetComponent<UnityEngine.UI.Text>().text = WASDController.score.ToString();
    }

    // Update is called once per frame
}
