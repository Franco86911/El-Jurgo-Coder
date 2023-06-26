using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   

    [SerializeField] private CounterNotes m_counterNotes;
    
    
    
    private int m_currentScore;
  
    //public int GetCurrentScore() => m_currentScore;
    public int GetCurrentScore()
    {
        return m_currentScore;
    }

    public void Add(int p_score)
    {
        
        Debug.Log("Entre");
            
        m_counterNotes.CounterN();
        
        Debug.Log("Sali");
        m_currentScore += p_score;
        Debug.Log($"Notas Recogidas {m_currentScore} de 5");
        if(m_currentScore == 5)
        {
            Debug.Log("La llave de la Iglesia se encuentra detras de una de las farolas");
        }
    }
}
