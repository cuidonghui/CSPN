﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPN.common
{
    /// <summary>
    /// 读写配置文件
    /// </summary>
    public class ReadWriteConfig
    {
        public static string ReadConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static void WriteConfig(string key, string value)
        {
            //获取Configuration对象
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //写入<add>元素的Value
            config.AppSettings.Settings[key].Value = value;
            //保存
            config.Save();
            //刷新
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
