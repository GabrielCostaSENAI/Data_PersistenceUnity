using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class DataPersistenceManager : MonoBehaviour
{

    public GameData data;

    public Text textBestScore;

    public string pName;
    public int pPoint;

    public bool loadGame = true;

    public static DataPersistenceManager Instance;
    //public InputField nameInput;

    private void Awake()
    {
        data = new GameData(pName, pPoint);

        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadGame();



    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }


    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SaveGame()
    {

        data.data_Name = pName;
        data.data_Point = pPoint;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(json);

            pName = data.data_Name;
            pPoint = data.data_Point;

            loadGame = true;

            textBestScore.text = $"Best Score:  {data.data_Name} - {data.data_Point}";
            ///Debug.Log($"Nome:{data.data_Name} ,Point: {data.data_Point}");
        }
        else
        {
            textBestScore.text = $"Best Score:  {pName} - {pPoint}";
        }


    }


    public void Exit()
    {

        SaveGame();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
     Application.Quit(); // original code to quit Unity player
#endif
        // DataPersistenceManager.instance.SaveGame();
    }
}

//Tentativa de DataPersistence, Misturei muita coisa vou recomeçar do 0. Fica de Referencia.
/* private GameData gameData;
    private List<IDataPersistence> dataPersistencesObjects;

    public static DataPersistenceManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Found more data persistence");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataPersistencesObjects = FindeAllDataPersistenceObjects();
    }


    public void NewGame()
    {
        this.gameData = new GameData();

    }

    public void LoadGame()
    {
        //Load any saved data from a file using the data handler
        //if no data can be load, initialize to a new game 
        if (this.gameData == null)
        {
            Debug.Log("No data was found. Initializing data to defaults.");
            NewGame();
        }
        //push the loaded data to all other scripts tha neew it 
        foreach (IDataPersistence dataPersistenceObj in dataPersistencesObjects)
        {
            dataPersistenceObj.LoadData(gameData);
        }

       

    }

    public void SaveGame()
    {
        //pass the data to other scripts so they can update it 
        foreach (IDataPersistence dataPersistenceObj in dataPersistencesObjects)
        {
            dataPersistenceObj.SaveData(gameData);
        }
        //save that data to a fille using the data handler

        
    }

    private List<IDataPersistence> FindeAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistencesObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistencesObjects);
    }


    public void StartGame()
    {
        if (DataPersistenceManager.instance != null)
        {
            SceneManager.LoadScene(1);
            DataPersistenceManager.instance.LoadGame();
        }

        Debug.Log(" Loaded score point = " + gameData.p_Score);
    }


    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
     Application.Quit(); // original code to quit Unity player
#endif
        DataPersistenceManager.instance.SaveGame();
    }*/