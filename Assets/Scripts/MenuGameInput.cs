//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGameInput : MonoBehaviour
{
    
    //[SerializeField] Text textBestScoreMenu;
    [SerializeField] InputField inputName;


    private void Awake()
    {
        // gameData = new GameData(nameInput.text, gameData.p_Score);

       // if (DataPersistenceManager.Instance.loadGame == true)
       // {
       //     textBestScoreMenu.text = $"Best Score:  {DataPersistenceManager.Instance.data.data_Name} - {DataPersistenceManager.Instance.data.data_Point}";
       // }

    }

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        DataPersistenceManager.Instance.pName = inputName.text;
    }
}
