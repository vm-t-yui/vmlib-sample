/******************************************************************************/
/*!    \brief  ボイスデータ.
*******************************************************************************/

using UnityEngine;
using VMUnityLib;

[CreateAssetMenu(menuName = "Data/VoiceData")]
public sealed class VoiceData : BaseData
{
    public string    TermName { get { return termName; } private set { termName = value; } }
    public float     Time  { get { return time; } private set { time = value; } }
    
    [SerializeField] private string    termName;
    [SerializeField] private float     time;
}
