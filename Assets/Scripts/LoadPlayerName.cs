using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        if(DataManager.Instance.playerName!=null){
            GetComponent<TMP_Text>().text = DataManager.Instance.playerName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
