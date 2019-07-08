/******************************************************************************/
/*!    \brief  ローディング画面のUIのマネージャー HACK:ライブラリか？.
*******************************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using VMUnityLib;

public sealed class LoadingUIManager : SingletonMonoBehaviour<LoadingUIManager> 
{
    [System.Serializable]
    struct UiTypeSet
    {
        public LibBridgeInfo.LoadingType type;
        public uTweenAlpha               tweenAlpha;
    }
    // ロード画面マップ.
    [SerializeField]
    List<UiTypeSet> loadingUiList;
    
    Dictionary<LibBridgeInfo.LoadingType, uTweenAlpha> loadingUiDict;

    void Start()
    {
        loadingUiDict = new Dictionary<LibBridgeInfo.LoadingType, uTweenAlpha>();
        foreach (UiTypeSet item in loadingUiList)
        {
            loadingUiDict.Add(item.type, item.tweenAlpha);
        }
    }

    /// <summary>
    /// ロード画面を表示する.
    /// </summary>
    public void ShowLoadingUI(LibBridgeInfo.LoadingType type)
    {
        loadingUiDict[type].gameObject.SetActive(true);
        loadingUiDict[type].Play(PlayDirection.Forward);
    }

    /// <summary>
    /// ロード画面を終了する.
    /// </summary>
    public void HideLoadingUI(LibBridgeInfo.LoadingType type)
    {
        loadingUiDict[type].Play(PlayDirection.Reverse);
    }
}
