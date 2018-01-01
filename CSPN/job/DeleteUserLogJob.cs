﻿using CSPN.BLL;
using CSPN.common;
using CSPN.helper;
using CSPN.IBLL;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPN.job
{
    public class DeleteUserLogJob : IJob
    {
        ILogService logService = new LogService();
        public void Execute(IJobExecutionContext context)
        {
            int save_Day = int.Parse(ReadWriteConfig.ReadConfig("UserLogTime"));
            logService.DeleteUserLogInfo(DateTime.Now.ToString("yyyy/MM/dd"), save_Day);
            LogHelper.WriteQuartzLog(string.Format("删除超过{0}天的用户日志", save_Day));
        }
    }
}
