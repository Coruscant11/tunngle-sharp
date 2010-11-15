using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace tunngle_sharp
{
    public class Interop
    {
        public const string DllName = "Launcher.dll", CommunityName = "Tunngle Community Project";
        public const CallingConvention CallingConv = CallingConvention.StdCall;
        private const int IpLen = 16, UserLen = 33, NetworkLen = 65, ShortTime = 10 * 1000, LongTime = 120 * 1000;

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode Init(string company, string project);

        public static ErrorCode Init(string project)
        {
            return Init(CommunityName, project);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode ClientOpen(string parameters);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode IsClientOpen();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode WaitClose(int milliseconds);

        public static ErrorCode WaitClose()
        {
            return WaitClose(ShortTime);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode ClientClose();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode ClientCloseForce();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode IsReady();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode WaitReady(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode Login(string username, string password);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode WaitLogin(int milliseconds);

        public static ErrorCode WaitLogin()
        {
            return WaitLogin(LongTime);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode WaitLoginDialog(int milliseconds);

        public static ErrorCode WaitLoginDialog()
        {
            return WaitLoginDialog(LongTime);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode GetLoginStatus();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode IsConnected();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetUser(StringBuilder builder, int size);

        public static int GetUser(out StringBuilder builder)
        {
            builder = new StringBuilder(UserLen);
            builder.Length = UserLen;
            return GetUser(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetIP(StringBuilder builder, int size);

        public static int GetIP(out StringBuilder builder)
        {
            builder = new StringBuilder(IpLen);
            builder.Length = IpLen;
            return GetIP(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode JoinNetwork(string netname);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode JoinNetForce(string netname);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetwork(StringBuilder builder, int size);

        public static int GetNetwork(out StringBuilder builder)
        {
            builder = new StringBuilder(NetworkLen);
            builder.Length = NetworkLen;
            return GetNetwork(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode WaitNetwork(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern ErrorCode SetWindowState(WindowState state);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int LoadNetUser();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetUserName(int index, StringBuilder builder, int size);

        public static int GetNetUserName(int index, out StringBuilder builder)
        {
            builder = new StringBuilder(UserLen);
            builder.Length = UserLen;
            return GetNetUserName(index, builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetUserIP(int index, StringBuilder builder, int size);

        public static int GetNetUserIP(int index, out StringBuilder builder)
        {
            builder = new StringBuilder(IpLen);
            builder.Length = IpLen;
            return GetNetUserIP(index, builder, builder.Length);
        }
    }
}
