using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;


#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{

   

    public void StartGameOnclick()
    {
        DataPersistenceManager.Instance.StartGame();
    }

    public void BackToMenuOnclick()
    {
        DataPersistenceManager.Instance.BackMenu();
    }

    public void ExitOnclick()
    {
        DataPersistenceManager.Instance.Exit();

    }


}

//First Code, 
/*public class MenuUIHandler : MonoBehaviour
{
   
    public GameObject g_textDisplayBestScore;

    //TMP_InputField p_name;

    private void Start()
    {
        
    }

    public void NewNamePlayer(TMP_InputField name)
    {
             
        DataManager.Instance.p_Name =  name; 
    }

 public int BestScorePoint(int score)
 {
     if (DataManager.Instance != null)
     {
         //Load Higth score player
     }

     return DataManager.Instance.p_BestScore = score;

 }


public void TextDisplayBestScore(GameObject textDisplayBestScore)
{

    if (DataManager.Instance != null)
    {
        g_textDisplayBestScore = textDisplayBestScore;

        textDisplayBestScore.GetComponent<TMP_Text>().text = "Best Score " + DataManager.Instance.p_Name + " : " + DataManager.Instance.p_BestScore;


        //Load Text if name Save Player and Score
        //DataManager.Instance.textDisplayBestScore = bestScoreText;
        //bestScoreText.text = $"Best Score { DataManager.Instance.p_Name} : {BestScorePoint(DataManager.Instance.p_BestScore)} ";

    }

    //bestScoreText.text = $"Best Score {DataManager.Instance.p_Name} : {DataManager.Instance.p_BestScore}";
}

public void StartGame()
{
    if (DataManager.Instance != null)
    {
        SceneManager.LoadScene(1);
        DataManager.Instance.LoadGameData();
    }

    // DataManager.Instance.SaveGamaData();
}


public void Exit()
{

#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
     Application.Quit(); // original code to quit Unity player
#endif
    DataManager.Instance.SaveGamaData();
}
*/