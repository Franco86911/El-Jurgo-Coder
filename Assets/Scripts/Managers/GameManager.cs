using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager m_scoreManager;
    [SerializeField] private LevelSceneManager m_levelManager;
    [SerializeField] private InventoryManager m_inventoryManager;
    public static GameManager Instance;
    

    private void Awake()
    {
        //var l_gameManager = FindObjectOfType<GameManager>();
        if(Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore(int p_score)
    {
        m_scoreManager.Add(p_score);
        //var l_haveKey = m_scoreManager.GetCurrentScore();
        //if (l_haveKey)
        //{
        //    LoadLevel("Nombre del nivel")
        //}
    }
   
    public void LoadLevel(string m_levelToLoad)
    {
        m_levelManager.LoadLevel(m_levelToLoad);
    }

    public void AddItem(Items itemID)
    {
        m_inventoryManager.Add(itemID.type);
    }

    public void ShowItems()
    {
        m_inventoryManager.ShowThis();
    }
}
