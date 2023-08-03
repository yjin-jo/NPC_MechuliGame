using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class HomesDatabase : ScriptableObject
{
    public Homes[] home;
    public int HomesCount
    {
        get
        {
            return home.Length;
        }
    }
    public Homes GetHomes(int index)
    {
        return home[index];
    }
}
