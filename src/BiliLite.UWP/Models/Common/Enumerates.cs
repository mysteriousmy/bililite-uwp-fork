﻿namespace BiliLite.Models.Common
{
    public enum LogType
    {
        Trace,
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
        Necessary,
    }

    public enum LoginStatus
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        Success,
        /// <summary>
        /// 登录失败
        /// </summary>
        Fail,
        /// <summary>
        /// 登录错误
        /// </summary>
        Error,
        /// <summary>
        /// 登录需要验证码
        /// </summary>
        NeedCaptcha,
        /// <summary>
        /// 需要安全认证
        /// </summary>
        NeedValidate
    }

    public enum LoginQRStatusCode
    {
        /// <summary>
        /// 扫码成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 二维码失效
        /// </summary>
        Fail = 86038,

        /// <summary>
        /// 二维码已扫码未确认
        /// </summary>
        Unconfirmed = 86090,

        /// <summary>
        /// 未扫码
        /// </summary>
        NotScanned = 86101,
    }

    public enum MouseMiddleActions
    {
        /// <summary>
        /// 返回或关闭页面
        /// </summary>
        Back=0,

        /// <summary>
        /// 打开新标签页但不跳转 
        /// </summary>
        NewTap=1,

        /// <summary>
        /// 无操作
        /// </summary>
        None=2,
    }

    public enum DownloadType
    {
        /// <summary>
        /// 视频
        /// </summary>
        Video = 0,
        /// <summary>
        /// 番剧、电影、电视剧等
        /// </summary>
        Season = 1,
        /// <summary>
        /// 音乐，暂不支持
        /// </summary>
        Music = 2,
        /// <summary>
        /// 课程，暂不支持
        /// </summary>
        Cheese = 3
    }

    public enum PlayerKeyRightAction
    {
        /// <summary>
        /// 操作进度条
        /// </summary>
        ControlProgress,

        /// <summary>
        /// 倍速播放
        /// </summary>
        AcceleratePlay
    }

    public enum PlayerHoldingAction
    {
        /// <summary>
        /// 无
        /// </summary>
        None,

        /// <summary>
        /// 倍速播放
        /// </summary>
        AcceleratePlay
    }

    public enum BiliPlayUrlType
    {
        /// <summary>
        /// 单段FLV
        /// </summary>
        SingleFLV,

        /// <summary>
        /// 多段FLV
        /// </summary>
        MultiFLV,

        /// <summary>
        /// 音视频分离DASH流
        /// </summary>
        DASH
    }

    public enum BiliPlayUrlVideoCodec
    {
        AVC = 7,
        HEVC = 12,
        AV1 = 13,
    }

    public enum PlayState
    {
        Loading,
        Playing,
        Pause,
        End,
        Error
    }

    public enum PlayEngine
    {
        Native = 1,
        FFmpegInteropMSS = 2,
        SYEngine = 3,
        FFmpegInteropMSSH265 = 4,
        VLC = 5
    }

    public enum PlayMediaType
    {
        Single,
        MultiFlv,
        Dash
    }

    public enum DynamicType
    {
        /// <summary>
        /// 用户关注动态
        /// </summary>
        UserDynamic,
        /// <summary>
        /// 话题动态
        /// </summary>
        Topic,
        /// <summary>
        /// 个人空间动态
        /// </summary>
        Space
    }

    public enum AnimeType
    {
        /// <summary>
        /// 番剧
        /// </summary>
        Bangumi = 1,

        /// <summary>
        /// 国创
        /// </summary>
        GuoChuang = 4
    }
}