using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public static StartGame Instance;
    private Text text;
    public TMP_InputField playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        } 
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
       
    }

    public void LoadName()
    {
        text = GameObject.Find("ScoreText").GetComponent<Text>();
        if(playerName.text != null){
            text.text  =  playerName.text +" " + text.text;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartNew(){
        SceneManager.LoadScene(0);
       
    }
}
