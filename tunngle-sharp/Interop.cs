using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace tunngle_sharp
{
    public class Interop
    {
        public const string DllName = "Launcher.dll";
        public const CallingConvention CallingConv = CallingConvention.StdCall;

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int Init(string company, string project);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int ClientOpen(string parameters);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int IsClientOpen();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int WaitClose(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int ClientClose();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int ClientCloseForce();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int IsReady();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int WaitReady(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int Login(string username, string password);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int WaitLogin(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int WaitLoginDialog(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetLoginStatus();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int IsConnected();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetUser(StringBuilder builder, int size);

        public static int GetUser(out StringBuilder builder)
        {
            builder = new StringBuilder(33);
            builder.Length = 33;
            return GetUser(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetIP(StringBuilder builder, int size);

        public static int GetIP(out StringBuilder builder)
        {
            builder = new StringBuilder(16);
            builder.Length = 16;
            return GetIP(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int JoinNetwork(string netname);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int JoinNetForce(string netname);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetwork(StringBuilder builder, int size);

        public static int GetNetwork(out StringBuilder builder)
        {
            builder = new StringBuilder(65);
            builder.Length = 65;
            return GetNetwork(builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int WaitNetwork(int milliseconds);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int SetWindowState(int state);

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int LoadNetUser();

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetUserName(int index, StringBuilder builder, int size);

        public static int GetNetUserName(int index, out StringBuilder builder)
        {
            builder = new StringBuilder(33);
            builder.Length = 33;
            return GetNetUserName(index, builder, builder.Length);
        }

        [DllImport(DllName, CallingConvention = CallingConv)]
        public static extern int GetNetUserIP(int index, StringBuilder builder, int size);

        public static int GetNetUserIP(int index, out StringBuilder builder)
        {
            builder = new StringBuilder(16);
            builder.Length = 16;
            return GetNetUserIP(index, builder, builder.Length);
        }
    }
}
