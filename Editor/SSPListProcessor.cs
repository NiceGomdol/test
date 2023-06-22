#if UNITY_EDITOR && UNITY_IOS


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;


namespace SmartStudy.PID
{
    public class SSPListProcessor
    {
        [PostProcessBuild]
        public static void OnPostPListProcessBuild(BuildTarget buildTarget, string path)
        {
            string plistPath = Path.Combine(path, "Info.plist");
            PlistDocument plist = new PlistDocument();
            plist.ReadFromFile(plistPath);
            AddITSAppUsesNonExemptEncryption(plist);
            File.WriteAllText(plistPath, plist.WriteToString());
        }
        
        public static void AddITSAppUsesNonExemptEncryption(PlistDocument plist)
        {
            plist.root.SetBoolean("ITSAppUsesNonExemptEncryption", false);
        }

    }
}

#endif
