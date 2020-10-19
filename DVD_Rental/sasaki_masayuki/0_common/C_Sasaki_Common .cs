using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVD_Rental.sasaki_masayuki._0_common
{
    public class C_Sasaki_Common 
    {
        //例外をデバッグ出力します。
        public static void Catch_An_Exception(Exception e)
        {
            System.Diagnostics.Debug.WriteLine("例外をキャッチ");
            System.Diagnostics.Debug.Write(e.Message);
            System.Diagnostics.Debug.WriteLine("\n");
        }


    }
}