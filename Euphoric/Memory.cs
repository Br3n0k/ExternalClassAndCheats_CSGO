﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Barbudon.Euphoric
{
    //TODO Get rid of Marshalling

    internal static class Memory
    {
        public static IntPtr pHandle;
        public static Process process;

        public static Int32 client = 0;
        public static Int32 client_size = 0;

        public static Int32 engine = 0;
        public static Int32 engine_size = 0;

        const UInt32 INFINITE = 0xFFFFFFFF;
        const UInt32 WAIT_ABANDONED = 0x00000080;
        const UInt32 WAIT_OBJECT_0 = 0x00000000;
        const UInt32 WAIT_TIMEOUT = 0x00000102;

        public static bool OpenProcess(string name)
        {
            Process[] _process = Process.GetProcessesByName(name);
            if (_process.Length > 0)
            {
                process = _process[0];
                OpenProcess(process.Id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void OpenProcess(int pId, Enums.ProcessAccessFlags processAccess = Enums.ProcessAccessFlags.All)
        {
            pHandle = WinAPI.OpenProcess(processAccess, false, pId);
        }

        public static void CloseProcess(IntPtr phandle)
        {
            bool result = WinAPI.CloseHandle(phandle);
        }
        public static T GetStructure<T>(byte[] bytes)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var structure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }
         
        public static byte[] GetStructBytes<T>(T str)
        {
            int size = Marshal.SizeOf(typeof(T));

            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        public static T Read<T>(Int32 address)
        {
            int length = Marshal.SizeOf(typeof(T));

            if (typeof(T) == typeof(bool))
                length = 1;

            byte[] buffer = new byte[length];
            UInt32 nBytesRead = UInt32.MinValue;
            bool success = WinAPI.ReadProcessMemory(pHandle, (IntPtr)address, buffer, (UInt32)length, ref nBytesRead);
            return GetStructure<T>(buffer);
        }

        public static void Write<T>(Int32 address, T value)
        {
            int length = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[length];

            IntPtr ptr = Marshal.AllocHGlobal(length);
            Marshal.StructureToPtr(value, ptr, true);
            Marshal.Copy(ptr, buffer, 0, length);
            Marshal.FreeHGlobal(ptr);

            UInt32 nBytesRead = UInt32.MinValue;
            WinAPI.WriteProcessMemory(pHandle, (IntPtr)address, buffer, (IntPtr)length, ref nBytesRead);
        }

        public static byte[] ReadBytes(Int32 address, int length)
        {
            byte[] buffer = new byte[length];
            UInt32 nBytesRead = UInt32.MinValue;
            bool success = WinAPI.ReadProcessMemory(pHandle, (IntPtr)address, buffer, (UInt32)length, ref nBytesRead);
            return buffer;
        }

        public static void WriteBytes(Int32 address, byte[] value)
        {
            UInt32 nBytesRead = UInt32.MinValue;
            WinAPI.WriteProcessMemory(pHandle, (IntPtr)address, value, (IntPtr)value.Length, ref nBytesRead);
        }

        public static string ReadString(Int32 address, int bufferSize, Encoding enc)
        {
            byte[] buffer = new byte[bufferSize];
            UInt32 nBytesRead = 0;
            bool success = WinAPI.ReadProcessMemory(pHandle, (IntPtr)address, buffer, (UInt32)bufferSize, ref nBytesRead);
            string text = enc.GetString(buffer);
            if (text.Contains('\0'))
                text = text.Substring(0, text.IndexOf('\0'));
            return text;
        }

    }
}
