/******************************************************************************/
/*!    \brief  指定SEを再生する.
*******************************************************************************/

using UnityEngine;
using PathologicalGames;
using System.Collections.Generic;

public sealed class SePlayer : MonoBehaviour
{
    [SerializeField]
    SpawnPool sePool;

    [SerializeField]
    GameObject sePrefab;

    List<CriAtomSource> endWatchSeList = new List<CriAtomSource>();

    /// <summary>
    /// 再生.
    /// </summary>
    public void PlaySe(string cueName, float volume = 1, float pitch = 0)
    {
        GameObject prefab = sePrefab;

        Transform spawnedSeTrans;
        spawnedSeTrans = sePool.Spawn(prefab);
        CriAtomSource spawnedSe = spawnedSeTrans.GetComponent<CriAtomSource>();

        // 一つ目、二つ目のfloatパラメータをそれぞれボリュームとピッチに設定.
        spawnedSe.volume = volume;
        spawnedSe.pitch = pitch;
        spawnedSe.cueName = cueName;
        spawnedSe.Play();

        endWatchSeList.Add(spawnedSe);
    }
    

    /// <summary>
    /// 再生終了したものをすべて削除する.
    /// </summary>
    void LateUpdate()
    {
        List<CriAtomSource> removeSeList = endWatchSeList.FindAll(se => (se.status == CriAtomSource.Status.PlayEnd));
        foreach (var item in removeSeList)
        {
            sePool.Despawn(item.transform);
            endWatchSeList.Remove(item);
        }
    }
    /// <summary>
    /// 全ての音を停止させる.
    /// </summary>
    public void StopSeAll()
    {
        List<CriAtomSource> removeSeList = endWatchSeList.FindAll(se => (se.status == CriAtomSource.Status.Playing));
        foreach (var item in removeSeList)
        {
            item.Stop();
        }
    }
}
