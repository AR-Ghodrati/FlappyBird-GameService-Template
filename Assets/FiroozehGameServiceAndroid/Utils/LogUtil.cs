// <copyright file="LogUtil.cs" company="Firoozeh Technology LTD">
// Copyright (C) 2019 Firoozeh Technology LTD. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>


using UnityEngine;

/**
* @author Alireza Ghodrati
*/


namespace FiroozehGameServiceAndroid.Utils
{
    public static class LogUtil
    {

 
        public static void LogDebug(string where,string debug)
        {
           Debug.Log("LogHappenedIn : "+where +" ,With Text :"+debug);
        }
        
        public static void LogWarning(string where,string warning)
        {
            Debug.LogWarning("WarningHappenedIn : "+where +" ,With Text :"+warning);
        }

        public static void LogError(string where,string error)
        {
            Debug.LogError("ErrorHappenedIn : "+where +" ,With Text :"+error);
        }
    }
}