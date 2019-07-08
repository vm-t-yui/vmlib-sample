Viking Maxx Unity Library - VMUnityLib2 (ver 2.0.0)

■フォルダ構成
○MyGameAsset
　・Lib
　　VMUnityLib2のフォルダです。
　・LibBridge
　　ライブラリから参照されるが、プロジェクトごとに異なるようなアセットはここに格納します。
　・それ以外
　　フォルダ名を参考に察してください。

○それ以外
アセットストアで購入したアセット等が置かれます。

■サンプルプロジェクト使用方法
MyGameAssetsにVMUnityLib2をクローンし、フォルダ名をLibにリネーム。
Lib/Scene/root.unityを実行すれば各シーンに遷移します。

■依存しているアセット群
・TextMeshPro
・PoolManager
・I2Localization
・Adx2 LE
・Nend Unity Plugin
・Google Play Service for Unity
・AdMob

■ザックリTips
・シーン移動は独自のSceneManagerで行われています。各SceneのSceneRootオブジェクトがコントロール
・CommonProgramObjとCommonUiRootが自動生成されて色々コントロールしてます
・基本的にはrootシーンからスタートします。どこからでも起動できるようにするにはCommonProgramObjになんやかや入れましょう
・DebugMenuを活用しよう
・GameDataとUserDataわけてます