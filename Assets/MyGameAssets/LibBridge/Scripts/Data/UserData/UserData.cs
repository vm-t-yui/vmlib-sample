/******************************************************************************/
/*!    \brief  ユーザーデータ.
*******************************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserData
{
    public UserPublicData   UserPublicData  { get; private set; }    // ユーザー公開情報.

    public UserData(
            UserPublicData userPublicData
        )
    {
        UserPublicData = userPublicData;
    }
}
