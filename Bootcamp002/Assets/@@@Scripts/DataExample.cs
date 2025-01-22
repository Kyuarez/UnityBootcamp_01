using System;
using UnityEngine;

[Flags] //그냥 야매 개념 : 배열들 다수 선택 가능하게 해줌.  
public enum DAY
{
    None = 0,
    SUNDAY = 1,
    MONDAY = 1 << 1,
    TUESDAY = 1 << 2,
    WEDNESDAY = 1 << 3,
    THURSDAY = 1 << 4,
    FRIDAY = 1 << 5,
    SATURDAY = 1 << 6,
}

public enum MONTH
{
    JANUARY,
    FEBUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER,
}

public class DataExample : MonoBehaviour
{
    public string[] schedules;
    public DAY day;
    public MONTH month;

    private void Start()
    {
        foreach (var schedule in schedules)
        {
            Debug.Log(schedule);
        }

        Debug.Log(day);
        Debug.Log(month);
    }
}
