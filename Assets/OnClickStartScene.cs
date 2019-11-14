using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClickStartScene : MonoBehaviour
{
    public Button thisButton;
 
    // Start is called before the first frame update
    void Start()
    {
        thisButton.onClick.AddListener(LoadScene);   
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
