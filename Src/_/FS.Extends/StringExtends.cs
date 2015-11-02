using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable once CheckNamespace
namespace FS.Extends
{
    public static class StringExtends
    {
        /// <summary>
        /// 字符串转为字节
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte[] ToUtf8Bytes(this string val)
        {
            return Encoding.UTF8.GetBytes(val);
        }
        /// <summary>
        /// 字符串转为字节
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte[][] ToUtf8Bytes(this string[] val)
        {
            return val.Select(ToUtf8Bytes).ToArray();
        }
        /// <summary>
        /// long转为字节
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte[] ToUtf8Bytes(this long val)
        {
            return BitConverter.GetBytes(val);
        }
        /// <summary>
        /// double转为字节
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte[] ToUtf8Bytes(this double val)
        {
            return BitConverter.GetBytes(val);
        }
        /// <summary>
        /// 字符串转为字节
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte[] ToUtf8Bytes(this int val)
        {
            return BitConverter.GetBytes(val);
        }

        /// <summary>
        /// byte二维数组转List
        /// </summary>
        /// <param name="multiDataList"></param>
        /// <returns></returns>
        public static List<TReturn> ToListByUtf8<TReturn>(this byte[][] multiDataList)
        {
            return multiDataList?.Select(multiData => multiData.ToStringByUtf8().ConvertType<TReturn>()).ToList() ?? new List<TReturn>();
        }

        /// <summary>
        /// byte维数组转字符串
        /// </summary>
        /// <param name="arrByte"></param>
        /// <returns></returns>
        public static string ToStringByUtf8(this byte[] arrByte)
        {
            return Encoding.UTF8.GetString(arrByte ?? new byte[] { });
        }
    }
}
