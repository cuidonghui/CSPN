﻿namespace CSPN.common
{
    public enum CSPNType
    {
        /// <summary>
        /// 人井信息
        /// </summary>
        WellInfo,
        /// <summary>
        /// 系统日志
        /// </summary>
        SysLogInfo,
        /// <summary>
        /// 用户日志_人井日志
        /// </summary>
        UserLogInfo_WellInfo,
        /// <summary>
        /// 用户日志_一般
        /// </summary>
        UserLogInfo_GeneralInfo,
        /// <summary>
        /// 预约维护
        /// </summary>
        MaintainInfo,
        /// <summary>
        /// 报警信息
        /// </summary>
        AlarmInfo,
        /// <summary>
        /// 已处理信息
        /// </summary>
        DisposeInfo,
        /// <summary>
        /// 未上报信息
        /// </summary>
        NotReportInfo,
        /// <summary>
        /// 值班人员信息
        /// </summary>
        OperatorInfo,
        /// <summary>
        /// 用户信息
        /// </summary>
        UserInfo
    }
}
