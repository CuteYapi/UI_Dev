#if LOG

using UnityEngine;

public class Log
{
    public static void Message(string message, LogCategory logCategory)
    {
        if(Manager.Log.IsLogOn == false)
        {
            return;
        }

        if (Manager.Log.IsLogCategoryOn[(int)logCategory] == false)
        {
            return;
        }

        Debug.Log(message);
    }

    public static void Error(string message)
    {
        Debug.LogError(message);
    }

    public static void Warning()
    {

    }
}

#endif