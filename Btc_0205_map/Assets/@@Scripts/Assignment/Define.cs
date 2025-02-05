public static class Define
{
    #region Text
    public static string RES_BAMSONGI = "Prefabs/Bamsongi";
    public static string RES_TARGET = "Prefabs/Target";
    public static string RES_CAM_DIRT = "Camera/dirts";
    public static string RES_SKY_DEFAULT = "Material/Skybox/CasualDay";
    public static string RES_SKY_CHILL = "Material/Skybox/AmbienceExposure";

    public static string UI_TITLE = "[밤송이 던져라]";
    public static string UI_INGAMETIME = "시간(인게임)";
    public static string UI_REALTIME = "시간(서버)";
    public static string UI_SCORE = "현재 점수";
    public static string UI_CHILLTEXT = "Chill...";
    #endregion
}

#region Enum
/// <summary>
/// 25.02.05. @TK : 시간 체크 타입 (인게임 시간, 실 서버 시간)
/// </summary>
public enum CheckTimeType
{
    INGAME,
    REALTIME,
}

#endregion
