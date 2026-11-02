using UnityEngine;

public class _0x4e0bbe1d : MonoBehaviour
{
    private void _0xa62cd5d3()
    {
    }

    public bool IsStoryEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsBestScoreEnabled;
    public static _0x4e0bbe1d Instance;
    public bool IsLevelIncrementOnWin;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x4e0bbe1d>();
            DontDestroyOnLoad(this.gameObject);
            this._0x814c896e();
        }
        else
        {
            this._0xa62cd5d3();
            Destroy(this.gameObject);
        }
    }

    public bool IsTimerEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelSelectorEnabled;
    private void _0x814c896e()
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
}