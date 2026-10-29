using UnityEngine;

public class _0x0e064a10 : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x0e064a10>();
            DontDestroyOnLoad(this.gameObject);
            this._0x95c288a7();
        }
        else
        {
            this._0x2d8e5a2a();
            Destroy(this.gameObject);
        }
    }

    private void _0x95c288a7()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsLevelIncrementOnWin;
    public bool IsLevelSelectorEnabled;
    public bool IsTutorialEnabled;
    private void _0x2d8e5a2a()
    {
    }

    public bool IsSkipSplashEnabled;
    public static _0x0e064a10 Instance;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsBestScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsTimerEnabled;
    public bool IsCheckScoreEnabled;
}