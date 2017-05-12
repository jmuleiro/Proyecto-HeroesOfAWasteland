using UnityEngine;
using System.Collections;

// Para que se muestre en el inspector
public class IntRange : MonoBehaviour {
    public int m_Min;
    public int m_Max;

    public IntRange(int min, int max)
    {
        m_Min = min;
        m_Max = max;
    }
    public int Random
    {
        get { return UnityEngine.Random.Range(m_Min, m_Max); }
    }
}
