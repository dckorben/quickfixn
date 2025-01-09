﻿using System;

namespace QuickFix.Logger;

/// <summary>
/// FIXME - needs to log sessionIDs, timestamps, etc.
/// </summary>
[Obsolete("Use Microsoft.Extensions.Logging instead.")]
public class ScreenLog : ILog
{
    private readonly object _sync = new ();
    private readonly bool _logIncoming;
    private readonly bool _logOutgoing;
    private readonly bool _logEvent;

    public ScreenLog(bool logIncoming, bool logOutgoing, bool logEvent)
    {
        _logIncoming = logIncoming;
        _logOutgoing = logOutgoing;
        _logEvent    = logEvent;
    }

    #region ILog Members

    public void Clear()
    { }

    public void OnIncoming(string msg)
    {
        if (!_logIncoming)
            return;

        lock (_sync)
        {
            System.Console.WriteLine("<incoming> " + msg.Replace(Message.SOH, '|'));
        }
    }

    public void OnOutgoing(string msg)
    {
        if (!_logOutgoing)
            return;

        lock (_sync)
        {
            System.Console.WriteLine("<outgoing> " + msg.Replace(Message.SOH, '|'));
        }
    }

    public void OnEvent(string s)
    {
        if (!_logEvent)
            return;

        lock (_sync)
        {
            System.Console.WriteLine("<event> " + s);
        }
    }
    #endregion

    public void Dispose(){}
}
