using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunngleSharp
{
    public enum ErrorCode : int
    {
        Success = 0x00000000,
        NoData = 0x00000000,
        General = 0x00010000,
        NotInstalled = 0x00010001,
        NotReachable = 0x00010002,
        InitFail = 0x00010003,
        RegisterFail = 0x00010004,
        ProcessNotFound = 0x00010005,
        ProcessFound = 0x00010006,
        Execution = 0x00010007,
        Response = 0x00010008,
        TimeOut = 0x00010009,
        NotConnected = 0x0001000A,
        LoggedIn = 0x0001000B,
        InNetwork = 0x0001000C,

        Load = 0x00020001,
        Connect = 0x00020002,
        Version = 0x00020003,
        Auth = 0x00020004,
        Login = 0x00020005,
        Abort = 0x00020006,
        Close = 0x00020007,

        LoginBusy = 0x00100001,
        LoginOK = 0x00100002,
        LoginNA = 0x00100003
    }
}