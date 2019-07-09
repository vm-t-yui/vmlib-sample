/******************************************************************************/
/*!    \brief  自社製品をオススメするウインドウのボタン.
*******************************************************************************/

using UnityEngine;
using System.Collections.Generic;
using VMUnityLib;

public sealed class SelfRecommendContent : MonoBehaviour 
{
    [SerializeField]
    string androidURL;

    [SerializeField]
    string iosURL;

    public void OpenUrl()
    {
#if UNITY_IOS
        Application.OpenURL(iosURL);
#else
        Application.OpenURL(androidURL);
#endif
    }
}
