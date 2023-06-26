using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Document
{
    public int d_number;
    public string d_info;
}



public class Collectibles : MonoBehaviour
{
    private static int m_count;

    private Dictionary<int, Document> m_documentDictionary = new Dictionary<int, Document>();

    private void Awake()
    {
        Document note01 = new Document()
        {
            d_number = 1,
            d_info = "Nose que carajos esta pasando ahí afuera, saldre a investigar, te dejo una de las linternas que tenemos. Espera a que regrese y no salgas afuera"
        };
        m_documentDictionary.Add(1,note01);

        Document note02 = new Document()
        {
            d_number = 2,
            d_info = "Las personas estan desapareciendo y se escuchan ruidos extarños durante las noche, esta noche saldre a investigar de donde provienen los ruidos"
        };
        m_documentDictionary.Add(2, note02);

        Document note03 = new Document()
        {
            d_number = 3,
            d_info = ""
        };
        m_documentDictionary.Add(3, note03);

        Document note04 = new Document()
        {
            d_number = 4,
            d_info = ""
        };
        m_documentDictionary.Add(4, note04);

        Document note05 = new Document()
        {
            d_number = 5,
            d_info = "Lo que se encuentra ahi dentro no deberia salir nunca, asi que cerre con llave y la tire detras de una farola"
        };
        m_documentDictionary.Add(5, note05);
    }

    private void ShowInfoNote()
    {
        m_count += 1;
        if (m_documentDictionary.TryGetValue(m_count, out Document i_note))
        {
            Debug.Log(i_note.d_info);
        }
    }

    public void Collected()
    {
        ShowInfoNote();
        Destroy(gameObject);
    }
}
