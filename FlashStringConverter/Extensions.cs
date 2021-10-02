using System;

namespace FlashStringConverter
{
    public static class Extensions
    {
        public static int? ToInt32(this string o)
        {
            int? result = null;
            try { result = Convert.ToInt32(o); }
            catch (Exception) { }
            return result;
        }
        public static double? ToDouble(this string o)
        {
            double? result = null;
            try { result = Convert.ToDouble(o); }
            catch (Exception) { }
            return result;
        }
        public static long? ToInt64(this string o)
        {
            long? result = null;
            try { result = Convert.ToInt32(o); }
            catch (Exception) { }
            return result;
        }
        public static DateTime? ToDateTime(this string o)
        {
            DateTime? result = null;
            try { result = Convert.ToDateTime(o); }
            catch (Exception) { }
            return result;
        }
        public static bool? ToBoolean(this string o)
        {
            bool? result = null;
            try { result = Convert.ToBoolean(o); }
            catch (Exception) { }
            return result;
        }
    }
}
